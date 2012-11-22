using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;   

namespace Reservations
{
   
    class Connection
    {
        public static SqlConnection ConnectToServer()
        {
            string command = @"Server=duldulaokzes-pc\sqlexpress;Database=ReservationSystemz;Trusted_Connection=Yes";
            SqlConnection conn = new SqlConnection(command);
            conn.Open();
            return conn;
        }
    }
}
