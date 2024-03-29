﻿/* Copyright Nameless Gnome
 * This file is part of WoW Armory Search.

    WoW Armory Search is free software: you can redistribute it and/or modify
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

        // Draging Variables
        private bool dragging;
        private Point offset;

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Program.BUILD_NONET_UIDBG)
            {
                Character chr = new Character("", "");

                lbl_name.Text = chr.name;
                lbl_hp.Text = chr.Hp.ToString();
                lbl_class.Text = chr.Class;
                lbl_etype.Text = chr.ManaType();
                lbl_mana.Text = chr.Mana.ToString();
                img_class.BackgroundImage = chr.Class_Icon();
                lbl_spec.Text = chr.Talents.ToString();
                lbl_race.Text = chr.Race;
                lbl_etype.Text = chr.ManaType();

                //Arena Teams
                try
                {
                    team1.SetToTeam(chr.ArenaTeams[0]);
                    team2.SetToTeam(chr.ArenaTeams[1]);
                    team3.SetToTeam(chr.ArenaTeams[2]);
                }
                catch
                {

                }
            }


        }
/*
        private void Old_Load()
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
            img_class.BackgroundImage = Class_Icon(reader.GetAttribute("class"));

            reader.ReadToFollowing("health");
            lbl_hp.Text = reader.GetAttribute("effective");

            reader.ReadToFollowing("secondBar");
            string ene_type = reader.GetAttribute("type");
            string ene_mana = reader.GetAttribute("effective");
            //Display Mana
            Mana_Display(ene_type, ene_mana);

            reader = XmlReader.Create("armory.xml", settings);
            try
            {
                reader.ReadToFollowing("arenaTeams");
                // Arena Teams to be Phrased 3 times at max
                team1.SetToTeam(ArenaTeam_ext(reader)); // 2v2
                team2.SetToTeam(ArenaTeam_ext(reader)); // 3v3
                team3.SetToTeam(ArenaTeam_ext(reader)); // 3v3

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("end of file"))
                {

                    team1.Hide();
                    team2.Hide();
                    team3.Hide();
                }
            }


            disp_talents(settings);
            // Rescillance Stat
            Resc(settings);


        }

        private void Mana_Display(string ene_type, string ene_mana)
        {
            if (ene_type == "m")
            {
                lbl_mana.Text = ene_mana;
            }
            else if (ene_type == "r")
            {
                lbl_etype.Text = "Rage";
                lbl_mana.Text = "100";
            }

            else if (ene_type == "e")
            {
                lbl_etype.Text = "Energy";
                lbl_mana.Text = "100";
            }
        }

        private  void disp_talents(XmlReaderSettings settings)
        {

            XmlReader reader = XmlReader.Create("armory.xml", settings);
            reader.ReadToFollowing("talentSpec");
            // I use the formate that blizzard uses in the game guideS
       int t1  = Convert.ToInt32((reader.GetAttribute("treeOne")));
       int t2 = Convert.ToInt32((reader.GetAttribute("treeTwo")));
       int t3 = Convert.ToInt32((reader.GetAttribute("treeThree")));

           Talents plr_talents = new Talents(lbl_class.Text,t1,t2,t3);

           lbl_spec.Text = plr_talents.ToString();

      
        }

 */



   


       
      
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - offset.X,
                     currentScreenPos.Y - offset.Y);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
                    

        }



    }

