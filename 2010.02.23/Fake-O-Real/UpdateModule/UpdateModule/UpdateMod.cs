using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using Microsoft.Practices.CompositeUI;
using FakeOReal.UpdateModule.Interface.Constants;
using FakeOReal.Infrastructure.Interface;
using Microsoft.Practices.CompositeUI.EventBroker;

namespace FakeOReal.UpdateModule
{
    public class UpdateMod
    {
        public static void Update(ModuleController mc)
        {
            try
            {
                FTPFactory ff = new FTPFactory();              
              //  ff.setDebug(true);
               ff.setRemoteHost("ucscresource.comoj.com");
                ff.setRemoteUser("a6578526");
               ff.setRemotePass("VIKZTS");                        
                ff.login();
                ff.chdir("public_html/Modules");
                string filename = null;
                string[] fileNames = ff.getFileList("*.*");
                Updates up = new Updates(ff,mc);
                for (int i = 0; i < fileNames.Length - 1; i++)
                {
                    filename = fileNames[i].Substring(0, fileNames[i].Length - 1);
                    up.checkedListBox1.Items.Add(filename);
                    if (!File.Exists(filename))
                    {
                        up.checkedListBox1.Items.Add(filename);
                        ff.download(filename, "halo" + i.ToString() + ".dll", true);
                    }
                }
                up.label1.Text = "Following updates were found on the server :";               
                up.Show();
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
