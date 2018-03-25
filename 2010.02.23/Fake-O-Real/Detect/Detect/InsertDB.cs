using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FakeOReal.ServiceModule.Interface;

namespace FakeOReal.Detect
{
    public partial class InsertDB : Form
    {       
        private ModuleController mc;
        public InsertDB(ModuleController mc)
        {
            this.mc = mc;
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void DBSelect()
        {
            string signature = this.textBox3.Text;
            string source = this.textBox1.Text;
            string make = this.textBox4.Text;
            string model = this.textBox5.Text;
            string quality = this.textBox2.Text;
            if(source.Equals("")){
                MessageBox.Show("Please specify the source.");
            }
            else if (quality.Equals(""))
            {
                MessageBox.Show("Please specify the image quality.");
            }
            else
            {                
                try
                {                   
                    IDBService MessageService = mc.WorkItem.Services.Get<IDBService>();
                    MySqlConnection mysqlCon = MessageService.getDB();
                    mysqlCon.Open();
                    string strSQL = "INSERT INTO image_hash (image_hash_value,Software,Make,Model,Quality) VALUES ('" + signature + "','" + source + "','" + make + "','" + model + "','" + quality + "')";
                    MySqlCommand mysqlCmd = new MySqlCommand();
                    mysqlCmd.Connection = mysqlCon;
                    mysqlCmd.CommandText = strSQL;
                    mysqlCmd.ExecuteNonQuery();
                    label7.Text = "Image Source Data(Signature) Successfully Written To Database.";
                    button1.Hide();
                    button2.Hide();
                    button3.Show();                    
                }
                catch (MySqlException)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBSelect();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }        
    }
}
