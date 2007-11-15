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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arm
{
    public partial class Team_Disp : UserControl
    {
        public Team_Disp()
        {
            InitializeComponent();
        }


        public void SetToTeam(ArenaTeam team){
            if (team != null)
            {
                SetTeamSize(team);
                lbl_teamname.Text = team.Name;
                lbl_rating.Text = team.Rating.ToString();
                lbl_winloss.Text = team.Win.ToString()+"-"+team.Lose.ToString();

                lst_plrs.Items.AddRange(team.members.ToArray());


            }
            else { Hide(); }
     
        }

        private void SetTeamSize(ArenaTeam team)
        {
            switch (team.Size)
            {
                case 2:
                    lbl_size.Text = "2v2";
                    break;

                case 3:
                    lbl_size.Text = "3v3";
                    break;

                case 5:
                    lbl_size.Text = "5v5";
                    break;
            }
        }

        private void Team_Disp_Load(object sender, EventArgs e)
        {

        }
    }
}
