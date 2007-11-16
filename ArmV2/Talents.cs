using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arm
{
    class Talents
    {
        public int Tree1 = 0;
        public int Tree2 = 0;
        public int Tree3 = 0;

     


        private string myclass;
        /// <summary>
        /// The Talent tree selected from The constants
        /// </summary>
        private Tree_Names T_myclass;

        private  Tree_Names T_NAME_DRUID   = new Tree_Names("Balance", "Feral", "Restoration");
        private  Tree_Names T_NAME_HUNTER  = new Tree_Names("Beast Mastery", "Marksmanship", "Survival");
        private  Tree_Names T_NAME_MAGE    = new Tree_Names("Arcane", "Fire", "Frost");
        private  Tree_Names T_NAME_PALADIN = new Tree_Names("Holy", "Protection", "Retribution");
        private  Tree_Names T_NAME_PRIEST  = new Tree_Names("Discipline", "Holy", "Shadow");
        private  Tree_Names T_NAME_ROGUE   = new Tree_Names("Assassination", "Combat", "Subtlety");
        private  Tree_Names T_NAME_SHAMAN  = new Tree_Names("Elemental", "Enhancement", "Restoration");
        private  Tree_Names T_NAME_WARLOCK = new Tree_Names("Affliction", "Demonology", "Destruction");
        private  Tree_Names T_NAME_WARRIOR = new Tree_Names("Arms", "Fury", "Protection");

        public Talents(string set_class,int t1,int t2,int t3)
        {
            myclass = set_class;
            Tree1 = t1;
            Tree2 = t2;
            Tree3 = t3;

            switch (myclass.ToLower()) {

                case "druid": T_myclass = T_NAME_DRUID; break;
                case "hunter": T_myclass = T_NAME_HUNTER; break;
                case "mage": T_myclass = T_NAME_MAGE; break;
                case "paladin": T_myclass = T_NAME_PALADIN; break;
                case "priest": T_myclass = T_NAME_PRIEST; break;
                case "rogue": T_myclass = T_NAME_ROGUE; break;
                case "shaman": T_myclass = T_NAME_SHAMAN; break;
                case "warlock": T_myclass = T_NAME_WARLOCK; break;
                case "warrior": T_myclass = T_NAME_WARRIOR; break;
            }

        }

        public override string ToString()
        {
            return Tree1.ToString() + "/" + Tree2.ToString() + "/" + Tree3.ToString() + " (" + Talent_Logic()+")";
        }

        public string Talent_Logic() {

            if (Tree1 > Tree2)
            {
                if (Tree1 > Tree3)
                {
                    return T_myclass.tree1_name;
                }
                else
                {
                    return T_myclass.tree3_name;
                }



            }
            else {
                if (Tree2 > Tree3)
                {
                    return T_myclass.tree2_name;
                }
                else
                {
                    return T_myclass.tree3_name;
                }
          
            
            }
        
        
        }


    }


    class Tree_Names {
        public string tree1_name;
        public string tree2_name;
        public string tree3_name;

        public Tree_Names(string t1, string t2, string t3)
        {

            tree1_name = t1;
            tree2_name = t2;
            tree3_name=t3;
        }
    
    }


}
