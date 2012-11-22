using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;  

namespace OrderManagementSystem
{
    class CustomerOrders
    {
        private ArrayList Prodid = new ArrayList();
        public ArrayList PRODID
        {
            get { return Prodid; }
            set { Prodid = value; }
        }
        private string like;
        public string LIKEE
        {
            get { return like; }
            set { like = value; }
        }
        private double CusID;
        public double CUSID
        {
            get { return CusID; }
            set { CusID = value; }
        }

        private string CustNUM;
        public string CustNUMBER
        {
            get { return CustNUM; }
            set { CustNUM = value; }
        }

        public SqlDataReader Search(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Products WHERE ProdDesc LIKE'" + like + "%'ORDER BY ProdDesc,ProdID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader Searchcustomer(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer WHERE CustNumber = '" + CustNUM + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double runningID;

        public double RUNNINGID
        {
            get { return runningID; }
            set { runningID = value; }
        }

        public SqlDataReader Running(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM SalesData WHERE ProdID = '" + runningID + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
