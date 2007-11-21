using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace Arm
{
    class Character
    {
        public string name="";

        public int Hp = 0;
        public int Mana=0;

        public string Class = "";
        public string Race = "";
        private string Etype = "m";
        public string ManaType() {
            switch (Etype.ToLower()) {
                case "m": return "Mana"; break;
                case "e": return "Energy"; break;
                case "r": return "Rage"; break;
            
            }

            /* DND              For Debuging          DND*
             * When WOLK comes this will have to change but
             * The DK type is for bug reporting/ Debuging 
             * when WOLK Comes.
             */
            return "DK";
        }

        public Talents Talents;

        //ArenaTeams
        public List<ArenaTeam> ArenaTeams = new List<ArenaTeam>();
        //TODO: Uncomment below line when S3 Starts
        //int PersonalRating = 0;


        // DEFENSE
        /*This Application is made for preformance,
         * because of that I will not have parry and
         * dodge since they are class specific (sort of)
         * and are not as important as Dodge Armor and Resc
         */

        //Resilience crit chance reducement and Crit Damage reducement
        // The stats it gives are using diffrent formulas
        // Due to that I use the Resilience value 
        public int Resilience  = 0;
        //Precent Value for Melee Damage Reduction
        public int Armor  = 0;
        //Dodge precent chance to dodge
        public int Dodge = 0;


        // Spell Damage
        public Spell_Dmg SpellDamage = null;

        // XML Reading
        // For the reader settings we Use
        // Program.DEF_XML_SEETINGS()

        private XmlReader reader; 

        public Character(string name,string realm)
        {
            reader =XmlReader.Create("armory.xml", Program.DEF_XML_SEETINGS());

           
          //CHECK: Following Line Needed?
            reader.Read();


            reader.ReadToFollowing("character");

            name  = reader.GetAttribute("name");
            Class = reader.GetAttribute("class");
            Race  = reader.GetAttribute("race");


            reader.ReadToFollowing("health");
            Hp = Convert.ToInt32( reader.GetAttribute("effective"));

            reader.ReadToFollowing("secondBar");
           Etype = reader.GetAttribute("type");
            Mana =Convert.ToInt32( reader.GetAttribute("effective"));


            // Extract Three Arena Teams CATCH statement 
            //for Character with less than 3 teams
           
            try 
            {
                reader.ReadToFollowing("arenaTeams");
                ArenaTeams.Add(ArenaTeam_ext());
                ArenaTeams.Add(ArenaTeam_ext());
                ArenaTeams.Add(ArenaTeam_ext());
  
            }catch (Exception ex) {
                if (!ex.Message.Contains("end of file")) ;
              // Rethrow if strange error
                 
                
            }

            disp_talents();

            get_Defenses();
          


        } 


             private ArenaTeam ArenaTeam_ext()
        {
            
            try
            {
                reader.ReadToFollowing("arenaTeam");
                if (!(reader.GetAttribute("name") == null))
                {
                    ArenaTeam te=new ArenaTeam();
                   
                    te.Name = reader.GetAttribute("name");
                    te.Rating = Convert.ToInt32( reader.GetAttribute("rating"));
                    te.Win = Convert.ToInt32(reader.GetAttribute("gamesWon"));
                    te.Lose = (Convert.ToInt32(reader.GetAttribute("gamesPlayed")) - te.Win);
                    te.Size = Convert.ToInt32(reader.GetAttribute("size"));
                    reader.ReadToFollowing("members");
                    te.members= Get_ArenaTeam_Members(reader.ReadSubtree());
                    return te;
                }
            }
            catch(Exception ex) {
                System.Windows.Forms.MessageBox.Show("ERROR:" + ex.Message);
           
            }
            return null;
        }
             public List<BasicPlayerInfo> Get_ArenaTeam_Members (XmlReader SubTr){
            List<BasicPlayerInfo> ret= new List<BasicPlayerInfo>();
            bool stop=false;
            while (!stop)
            {
               try
               {
                   SubTr.ReadToFollowing("character");
                string mem_class =    reader.GetAttribute("class");
                string plr_name = reader.GetAttribute("name");

                if (mem_class==null)
                {
                stop=true;
                }else
                {
                    ret.Add(new BasicPlayerInfo(plr_name, mem_class));
                }

               } catch 
               {
                   stop = true;
               }
               
                } // End of loop
               

               

            return ret;
            }

             private void disp_talents()
             {
              //   XmlReader reader = XmlReader.Create(path, Program.DEF_XML_SEETINGS());
                 reader.ReadToFollowing("talentSpec");
         
                 // I use the format that blizzard uses in the game guide
                 int t1 = Convert.ToInt32((reader.GetAttribute("treeOne")));
                 int t2 = Convert.ToInt32((reader.GetAttribute("treeTwo")));
                 int t3 = Convert.ToInt32((reader.GetAttribute("treeThree")));


                Talents = new Talents(Class, t1, t2, t3);
             }


             private void get_Defenses()
             {
                 reader.ReadToFollowing("defenses");
                
                 //Armor
                 reader.ReadToFollowing("armor");
                 Armor=  Convert.ToInt32(reader.GetAttribute("precent"));
           
                 //Dodge
                 reader.ReadToFollowing("dodge");
                 Dodge = Convert.ToInt32(reader.GetAttribute("precent"));
                 
                 //Resilience
                 reader.ReadToFollowing("resilience");
                 try
                 {
                     Resilience = Convert.ToInt32(reader.GetAttribute("value").Replace(".00", ""));
                 }
                 catch {
                     Resilience = Convert.ToInt16( Convert.ToDouble(reader.GetAttribute("value")));

                 }
             }

          

        //DISPLAY
        /*This is the function for displaying the class icons.
         * It is in the Character class for code reuse and unity
         * when displaying data
         * 
         * This is a copy of the function with same name in Viewer
         * but its using the member instead of the param
         * 
         * If no class matched it will return the Warrior Class Icon
         */
        public System.Drawing.Image Class_Icon()
        {

            switch (Class.ToLower())
            {

                case "druid": return Arm.ICON.Druid; break;

                case "hunter": return Arm.ICON.Hunter; break;

                case "mage": return Arm.ICON.Mage; break;

                case "paladin": return Arm.ICON.Paladin; break;

                case "priest": return Arm.ICON.Priest; break;

                case "rogue": return Arm.ICON.Rogue; break;

                case "shaman": return Arm.ICON.Shaman; break;

                case "warlock": return Arm.ICON.Warlock; break;

                case "warrior": return Arm.ICON.Warrior; break;
            }

            return Arm.ICON.Warrior;
        }
            

        
    }

    class Spell_Dmg {
        
       public int Holy    = 0;
       public int Arcane = 0;
       public int Fire = 0;
       public int Nature = 0;
       public int Frost = 0;
       public int Shadow = 0;


        /* PLEASE NOTE:
         * Bonus Healing is included  in the Spell_Dmg Class 
         * Because its one of the Spell Stats
         */
       public int Healing = 0;


        public int MainSPL_DMG() {
            int ret = Holy;

            if (ret > Arcane)
                ret = Arcane;
            if (ret > Fire)
                ret = Fire;
            if (ret > Nature)
                ret = Nature;
            if (ret > Frost)
                ret = Frost;
            if (ret > Shadow)
                ret = Shadow;

            return ret;
        
        }


        // Thank you blizzard for this one :)
        public Spell_Dmg(int pHoly,int pArcane, int pFire, int pNature,int pFrost, int pShadow, int pHealing)
        {
            Holy = pHoly;
            Arcane = pArcane;
            Fire = pFire;
            Nature = pNature;
            Frost = pFrost;
            Shadow = pShadow;
            Healing = pHealing;
           

        }
    }
}
