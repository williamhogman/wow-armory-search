/* Copyright Nameless Gnome
 * This file is part of WoW Armory Search.

    Foobar is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    WoW Armory Search is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with WoW Armory Search.  If not, see <http://www.gnu.org/licenses/>.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace Arm
{
    public partial class viewer : Form
    {
        public viewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader reader = XmlReader.Create("armory.xml", settings);
            reader.Read();

            reader.ReadToFollowing("character");
           lbl_name.Text = reader.GetAttribute("name");
           lbl_class.Text = reader.GetAttribute("class");
           lbl_race.Text = reader.GetAttribute("race");

             reader.ReadToFollowing("health");
             lbl_hp.Text = reader.GetAttribute("effective");

           reader.ReadToFollowing("secondBar");
       lbl_mana.Text =    reader.GetAttribute("effective");

       reader = XmlReader.Create("armory.xml", settings);
       try
       {
           reader.ReadToFollowing("arenaTeams");
           // Arena Teams to be Phrased 3 times at max
           team1.SetToTeam(ArenaTeam_ext(reader)); // 2v2
           team2.SetToTeam(ArenaTeam_ext(reader)); // 3v3
           team3.SetToTeam(ArenaTeam_ext(reader)); // 3v3
        
       } catch (Exception ex) {
           if (ex.Message.Contains("end of file"))
           {
               MessageBox.Show("No Arena Teams");
               team1.Hide();
               team2.Hide();
               team3.Hide();
           }
       }
     Talents(settings);


            // Rescillance Stat
            Resc(settings);



        }

        private  void Talents(XmlReaderSettings settings)
        {

            XmlReader reader = XmlReader.Create("armory.xml", settings);
            reader.ReadToFollowing("talentSpec");
       string t1  = (reader.GetAttribute("treeOne"));
       string t2  = (reader.GetAttribute("treeThree"));
       string t3  = (reader.GetAttribute("treeTwo"));

            lbl_spec.Text=t1+"/"+t2+"/"+t3;


      
        }

        private  void Resc(XmlReaderSettings settings)
        {
            XmlReader reader = XmlReader.Create("armory.xml", settings);

            reader.ReadToFollowing("defenses");
            reader.ReadToFollowing("resilience");

            lbl_resc.Text = reader.GetAttribute("value").Replace(".00","");
          
            string resc_negdmg = reader.GetAttribute("damagePercent");

            string resc_negcrit = reader.GetAttribute("hitPercent");

          
        }

        private ArenaTeam ArenaTeam_ext( XmlReader reader)
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
                    te.members = Get_ArenaTeam_Members(reader.ReadSubtree());
                    return te;
                }
            }
            catch {
             
           
            }
            return null;
        }


        public List<BasicPlayerInfo> Get_ArenaTeam_Members (XmlReader reader){
            List<BasicPlayerInfo> ret= new List<BasicPlayerInfo>();
            bool stop=false;
            while (!stop)
            {
                reader.ReadToFollowing("character");
            string mem_class =    reader.GetAttribute("class");
            string plr_name = reader.GetAttribute("name");
                if (mem_class==null){
                stop=true;
                }else{
                    ret.Add(new BasicPlayerInfo(plr_name, mem_class));



                }
               

                }

            return ret;
            }

       
                    

        }



    }

