using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml.XPath;
using Microsoft.Practices.CompositeUI.EventBroker;
using FakeOReal.Infrastructure.Interface;
using FakeOReal.UpdateModule.Interface.Constants;

namespace FakeOReal.UpdateModule
{
    public partial class Updates : Form
    {
        FTPFactory ftp;
        ModuleController mc;
        List<String> selectedList= new List<string>();
        public Updates(FTPFactory ftp,ModuleController mc)
        {
            this.mc = mc;
            this.ftp = ftp;
            InitializeComponent();
        }

        private void Updates_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {           
            for (int i = 0; i < checkedListBox1.Items.Count;i++)
            {
                this.checkedListBox1.SetItemChecked(i, true);
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedList.Count > 0)
            {
                try
                {
                    IEnumerator num = selectedList.GetEnumerator();                   
                    int i = 1;
                    while (num.MoveNext())
                    {
                        this.ftp.download(num.Current.ToString(), "halo" + i.ToString() + ".dll", false);
                        i++;
                    }
                    MessageBox.Show("All files were successfully downloaded.");
                    updateCatalog();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Module Files download failed!");
                }
            }
            else {
                MessageBox.Show("Please select the files to be downloaded!");
            }          
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                selectedList.Add(checkedListBox1.SelectedItem.ToString());
            }
            else
            {
                selectedList.Remove(checkedListBox1.SelectedItem.ToString());
            } 
        }

        public void updateCatalog()
        {

            string fileName = "ProfileCatalog.xml";
            XPathDocument doc = new XPathDocument(fileName);
            XPathNavigator nav = doc.CreateNavigator();

            // Compile a standard XPath expression

            XPathExpression expr;
            expr = nav.Compile("/SolutionProfile/Section[@Name='Services']");
            XPathNodeIterator iterator = nav.Select(expr);
            MessageBox.Show(iterator.Count.ToString());

            // Iterate on the node set

            try
            {
                while (iterator.MoveNext())
                {
                    XPathNavigator nav2 = iterator.Current.Clone();
                    MessageBox.Show(nav2.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
       
    }
}
