using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.IO;

namespace Arm
{
    class Downloader
    {
        // Connection Constants
   const   string CON_DEF_HEADERS_USER_AGENT = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2) Gecko/20070219 Firefox/2.0.0.2";
    const   string CON_DEF_ADR_BASE           = "http://wowarmory.com/character-sheet.xml";



       static public string Download_Char(string name, string server)
        {
            return Arm_dl(CON_DEF_ADR_BASE + "?r=" + server + "&n=" + name);
        }


       static private void Status_Check( HttpStatusCode Code) {
            switch (Code) {
                case HttpStatusCode.OK: break;
                case HttpStatusCode.NotFound: break;

            
            }
        
        }


       static public string Arm_dl(string adr)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(adr);
   
            req.UserAgent = CON_DEF_HEADERS_USER_AGENT;
     
            HttpWebResponse response = null;
           
            try
            {
                response = (HttpWebResponse)req.GetResponse();
               
            }
            catch (Exception ex)
            {
                

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


        // Workaround for Armory XML Error
    int del_pointer  =    result.IndexOf("</page>");
    result=  result.Remove(del_pointer);
    result=  result.Insert(del_pointer, "</page>");

            return result;

        }



    }
}
