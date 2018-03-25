using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Microsoft.Practices.CompositeUI;
using FakeOReal.ServiceModule.Interface;


namespace FakeOReal.Detect
{
    class MySQLConnectionTest
    {        
        public void DBSelect(ModuleController mc, String hash, String software,String make,String model,String quality)
        {
            IDBService MessageService = mc.WorkItem.Services.Get<IDBService>();
            MySqlConnection mysqlCon = MessageService.getDB();
            try{
                mysqlCon.Open();
                string strSQL = "SELECT * FROM image_hash WHERE image_hash_value='"+ hash +"'";
                MySqlCommand mysqlCmd = new MySqlCommand(strSQL, mysqlCon);
                MySqlDataReader mysqlReader = mysqlCmd.ExecuteReader();
                    if (mysqlReader.Read())
                        {
                            SoureMatchFoundForm f = new SoureMatchFoundForm();
                            f.textBox1.Text = mysqlReader.GetString(1);                            
                        string dmake,dmodel;
                        try
                        {
                            if ((dmake = mysqlReader.GetString(2)) != null)
                            {
                                f.textBox5.Text = dmake;
                            }
                             if ((dmodel = mysqlReader.GetString(3)) != null)
                              {
                                  f.textBox4.Text = dmodel;
                              }
                        }catch(Exception){
                        
                        }
                            f.textBox3.Text = mysqlReader.GetString(0);
                            f.textBox2.Text = mysqlReader.GetString(4);                            
                            f.Show();
                         }
                    else {        
                        InsertDB ins = new InsertDB(mc);
                        ins.textBox4.Text = make;
                        ins.textBox5.Text = model;                        
                        ins.textBox1.Text= software;                        
                        ins.textBox2.Text = quality;
                        ins.textBox3.Text = hash;
                        ins.button3.Hide();
                        ins.Show();
                     }
            }catch(MySqlException){
                        
            }
        }
    }
}
