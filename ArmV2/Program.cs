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
using System.Linq;
using System.Windows.Forms;

namespace Arm
{
    static class Program
    {
        public const bool BUILD_NONET_UIDBG = false;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       Application.Run(new Search());
          
        }


        static public System.Xml.XmlReaderSettings DEF_XML_SEETINGS() {
            System.Xml.XmlReaderSettings settings = new System.Xml.XmlReaderSettings();
            settings.ConformanceLevel = System.Xml.ConformanceLevel.Fragment;

            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
           

            return settings;
        
        }

    }
}
