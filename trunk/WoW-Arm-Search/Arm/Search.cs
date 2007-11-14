using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;

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
            Download_Char("", "");
viewer View_frm = new viewer();

        View_frm.Show();

        
        }


        public string Download_Char(string name,string server){
        string result = "";
try
{


WebRequest request = WebRequest.Create("http://www.google.com");
//request.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.9) Gecko/20071025 Firefox/2.0.0.9";
// Send the 'HttpWebRequest' and wait for response.
HttpWebResponse response = (HttpWebResponse)request.GetResponse(); System.IO.Stream stream = response.GetResponseStream();
System.Text.Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
System.IO.StreamReader reader = new System.IO.StreamReader(stream, ec);
char [] chars = new Char[256];
int count = reader.Read(chars, 0, 256);
while(count > 0)
{
string str = new String(chars, 0, 256);
result = result + str;
count = reader.Read(chars, 0, 256);
}
response.Close();
stream.Close();
reader.Close();

}
catch(Exception exp)
{
string str = exp.Message;

}
return result;

        }

    }
}
