using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Test
{
    class Connection
    {
        public static SqlConnection ConnectToServer()
        {
            string command = @"Server=duldulaokzes-pc\sqlexpress;Database=Testings;Trusted_Connection=Yes";
            SqlConnection conn = new SqlConnection(command);
            conn.Open();
            return conn;
        }
    }
}
