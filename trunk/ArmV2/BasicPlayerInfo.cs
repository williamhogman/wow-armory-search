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
using System.Text;

namespace Arm
{
    public class BasicPlayerInfo
    {
        public string Name;
        public string plr_Class;

        public BasicPlayerInfo(string p_name,string p_Class)
        {

            Name = p_name;
                plr_Class=p_Class;

        }


    override    public string  ToString() {
            return Name + " (" + plr_Class + ")";
        
        }
    }
}
