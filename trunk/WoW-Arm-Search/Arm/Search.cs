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
    Save(  Download_Char("Tarendor", "Aggramar"));
      viewer View_frm = new viewer();     

        View_frm.Show();

        
        }


        private void Save(string data) {
            MessageBox.Show(data);
            
            StreamWriter stream = new StreamWriter("armory.xml",false);
       
            stream.Write(data);

            stream.Close();
        


        }

        public string Download_Char(string name,string server){
         //   return Arm_dl("http://wowarmory.com/character-sheet.xml?r="+server+"&n="+name);
            return Arm_dl("http://wowarmory.com/character-sheet.xml?r=Tichondrius&n=Hammura");
        }




        public string Arm_dl(string adr) { 
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(adr);
        req.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2) Gecko/20070219 Firefox/2.0.0.2";
        HttpWebResponse response = (HttpWebResponse)req.GetResponse();
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
