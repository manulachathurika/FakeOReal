using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace FakeOReal.ServiceModule.Interface
{
    public interface IDBService
    {
        MySqlConnection getDB();
    }
}
