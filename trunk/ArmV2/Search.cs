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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
namespace Arm
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
   Download_Char(tbx_name.Text, tbx_rel.Text);
      viewer View_frm = new viewer();     

        View_frm.Show();

        
        }


        private void Save(string data,string name,string rel) {
            
            StreamWriter stream = new StreamWriter("DB/"+tbx_rel.Text+"/"+tbx_name.Text+".xml",false);
       
            stream.Write(data);

            stream.Close();
        


        }

        public string Download_Char(string name,string server){
            FileInfo fi = new FileInfo(server+"/"+name+".xml");
       if    (!fi.Exists){
            Save(Arm_dl("http://eu.wowarmory.com/character-sheet.xml?r="+server+"&n="+name),name,server);
      
       }
        }




        public string Arm_dl(string adr) { 
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(adr);
        req.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2) Gecko/20070219 Firefox/2.0.0.2";
        HttpWebResponse response=null; 
            try
        {
            response = (HttpWebResponse)req.GetResponse();
        }
        catch (Exception ex) {
            if (ex.Message.Contains("503"))
                MessageBox.Show("Error 503 Service Unavailable");
            if (ex.Message.Contains("400"))
                MessageBox.Show("Error 400 Bad Request");
           
        }

        string result = "";
        System.Text.Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
        System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream(), ec);
        char[] chars = new Char[256];
        int count = reader.Read(chars, 0, 256);
 
        while (count > 0)
        {
            string str = new String(chars, 0, 256);
            result = result + str;
            count = reader.Read(chars, 0, 256);
        }
        response.Close();
     
        reader.Close();

        return result;
        
        }

    }
}
