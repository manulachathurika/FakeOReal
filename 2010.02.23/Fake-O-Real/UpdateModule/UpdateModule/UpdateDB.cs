using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FakeOReal.UpdateModule
{
    public class UpdateDB
    {
        public static void Updatedbase() {
            try
            {
                FTPFactory ff = new FTPFactory();                                                
                ff.login();
                ff.chdir("public_html/Signatures");
                ff.download("temp.frm",true);                
              //  File.Copy("temp.frm","C:/Program Files/temp.frm",true);            
                ff.setBinaryMode(true);
                ff.close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Caught Error : " + e.Message);
            }
        
        }
    }
}
