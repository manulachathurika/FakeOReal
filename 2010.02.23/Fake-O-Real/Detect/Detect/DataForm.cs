using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;
using System.IO;

namespace FakeOReal.Detect
{
    public partial class DataForm : Form
    {
        string host = null;
        string user = null;
        string pwd = null;


        public DataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            host = hostBox.Text;
            if (!hostBox.Text.Equals(""))
            {
                 user = NameBox.Text;
                if (!NameBox.Text.Equals(""))
                {
                    try
                    {
                         pwd = passwordBox.Text;
                        MySqlConnection conDatabase = new MySqlConnection("Data Source=" + host + ";" +
                                         "Persist Security Info=yes;" +
                                         "UserId=" + user + "; PWD=" + pwd + ";");
                        MySqlCommand cmdDatabase = new MySqlCommand("CREATE DATABASE IF NOT EXISTS image_information;", conDatabase);
                        conDatabase.Open();
                        cmdDatabase.ExecuteNonQuery();
                        conDatabase.Close();
                        string strProvider = "Data Source=" + host + ";Database=image_information;User ID=" + user + ";Password=" + pwd + ";";
                        MySqlConnection mysqlCon = new MySqlConnection(strProvider);
                        string strCreate = "CREATE TABLE IF NOT EXISTS `image_hash` (" +
                            "`Id` int(11) NOT NULL AUTO_INCREMENT," +
      "`image_hash_value` varchar(100) NOT NULL," +
      "`Software` varchar(100) NOT NULL," +
      "`Make` varchar(100) DEFAULT NULL," +
      "`Model` varchar(100) DEFAULT NULL," +
      "`Quality` varchar(10) NOT NULL," +
      "PRIMARY KEY (`Id`)" +
      ") ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;";
                        cmdDatabase = new MySqlCommand(strCreate, mysqlCon);
                        mysqlCon.Open();
                        cmdDatabase.ExecuteNonQuery();
                        
                        mysqlCon.Close();
                        this.Close();
                    }catch(Exception){
                        MessageBox.Show("Please check database settings again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the username.");
                }
            }
            else {
                MessageBox.Show("Please enter the host name.");
            }

            this.createDBXML();
        }

        private void createDBXML() {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement newcatalogentry = xmldoc.CreateElement("DBConnection"); 
            XmlElement firstelement = xmldoc.CreateElement("Host");   
            firstelement.InnerText = "Peter";
            newcatalogentry.AppendChild(firstelement);
            XmlElement secondelement = xmldoc.CreateElement("User");
            secondelement.InnerText = "Que Publishing";
            newcatalogentry.AppendChild(secondelement);
            XmlElement thirdelement = xmldoc.CreateElement("Password");
            thirdelement.InnerText = "Que Publishing";
            newcatalogentry.AppendChild(thirdelement);
            xmldoc.DocumentElement.InsertAfter(newcatalogentry,
                                               xmldoc.DocumentElement.LastChild);
            try
            {
                MessageBox.Show("DB XML successfully written ");
                FileStream fsxml = new FileStream("DBSetting.xml", FileMode.Truncate,
                                                  FileAccess.Write,
                                                  FileShare.ReadWrite);
                xmldoc.Save(fsxml);
            }
            catch (Exception) {

                MessageBox.Show("Error in configuring XML of DB Setting ");
            
            }
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
