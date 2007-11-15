/* Copyright Nameless Gnome
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
using System.Text;

namespace Arm
{
    public class ArenaTeam
    {
        public int Size;
        public string Name;
        public int Win;
        public int Lose;
        public int Rating;

        public List<BasicPlayerInfo> members;

    }
}
