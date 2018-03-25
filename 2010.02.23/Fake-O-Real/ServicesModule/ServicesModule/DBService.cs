using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeOReal.ServicesModule.Interface;
using MySql.Data.MySqlClient;
using Microsoft.Practices.CompositeUI;

namespace FakeOReal.ServicesModule
{
    [Service(typeof(IDBService))]
    public class DBService : IDBService
    {

        #region IDBService Members

        public MySqlConnection getDB()
        {
            String host = "localhost";
            String database = "Image_information";
            String user = "root2";
            String password = "123";
            string strProvider = "Data Source=" + host + ";Database=" + database + ";User ID=" + user + ";Password=" + password;
            MySqlConnection mysqlCon = new MySqlConnection(strProvider);
            return mysqlCon;
        }

        #endregion
    }
}
