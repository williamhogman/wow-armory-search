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
            WebClient Client = new WebClient();
       Client.Headers["User-agent"]="Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9a7) Gecko/2007080210 GranParadiso/3.0a7";
            //Client.DownloadFile("http://eu.wowarmory.com/character-sheet.xml?r="+tbx_rel.Text+"&n="+tbx_name.Text, "armory.xml");
            MessageBox.Show(Client.DownloadString("http://eu.wowarmory.com/character-sheet.xml?r=" + tbx_rel.Text + "&n=" + tbx_name.Text));
            viewer View_frm= new viewer();
        View_frm.Show();

        
        }
    }
}
