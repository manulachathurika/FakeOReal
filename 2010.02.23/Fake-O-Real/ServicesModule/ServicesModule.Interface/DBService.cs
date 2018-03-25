using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace FakeOReal.ServicesModule.Interface
{
    public interface IDBService
    {
        MySqlConnection getDB();
    }
}
