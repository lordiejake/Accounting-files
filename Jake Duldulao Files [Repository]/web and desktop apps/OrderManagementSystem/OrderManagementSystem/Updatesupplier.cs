using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;   
using System.Windows.Forms;
using System.Data; 

namespace OrderManagementSystem
{
    class Updatesupplier
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        private string search;
        public string SEARCH
        {
            get { return search; }
            set { search = value; }
        }

        public SqlDataReader SearchSupplier(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier WHERE SupLN LIKE'" + search + "%'ORDER BY SupLN,SupID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

         public SqlDataReader SearchSupplierinfo(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

         private string date1;
         private string date2;

         public string DATE1
         {
             get { return date1; }
             set { date1 = value; }
         }

         public string DATE2
         {
             get { return date2; }
             set { date2 = value; }
         }

         private string date11;
         private string date22;

         public string DATE11
         {
             get { return date11; }
             set { date11 = value; }
         }

         public string DATE22
         {
             get { return date22; }
             set { date22 = value; }
         }
         public SqlDataReader PopulateSalesBYProduct(SqlConnection conn)
         {
             string sqlSelect = "SELECT        SUM(SalesData.NewSalesQty) AS Expr1, SalesData.ProdDesc, SalesData.ProductRetailPrice, SUM(SalesData.NewSalesQty) * SalesData.ProductRetailPrice AS k FROM            Sales INNER JOIN Customer ON Sales.CustID = Customer.CustID INNER JOIN SalesData ON Sales.SalesNO = SalesData.SalesNO AND Customer.CustID = SalesData.CustID INNER JOIN  Products ON SalesData.ProdID = Products.ProdID WHERE        Sales.Date BETWEEN'" + date1 + "'AND'" + date2 + "'GROUP BY SalesData.ProdDesc, SalesData.ProductRetailPrice";
             SqlCommand cmd = new SqlCommand(sqlSelect, conn);
             //cmd.Parameters.Add(new SqlParameter("@startDate", startDate));
             //cmd.Parameters.Add(new SqlParameter("@endDate", endDate));
             cmd.CommandType = CommandType.Text;
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;
         }

         public SqlDataReader PopulateIncome(SqlConnection conn)
         {
             string sqlSelect = "SELECT        SUM(SalesData.SalesQty) AS Expr1, SalesData.ProdDesc, SalesData.ProductRetailPrice, SUM(SalesData.SalesQty) * SalesData.ProductRetailPrice AS k FROM            Sales INNER JOIN Customer ON Sales.CustID = Customer.CustID INNER JOIN SalesData ON Sales.SalesNO = SalesData.SalesNO AND Customer.CustID = SalesData.CustID INNER JOIN  Products ON SalesData.ProdID = Products.ProdID WHERE  Sales.Date BETWEEN'" + date1 + "'AND'" + date2 + "'GROUP BY SalesData.ProdDesc, SalesData.ProductRetailPrice";
             SqlCommand cmd = new SqlCommand(sqlSelect, conn);
             //cmd.Parameters.Add(new SqlParameter("@startDate", startDate));
             //cmd.Parameters.Add(new SqlParameter("@endDate", endDate));
             cmd.CommandType = CommandType.Text;
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;
         }

         public SqlDataReader PopulateIncome2(SqlConnection conn)
         {
             string sqlSelect = "SELECT        SUM(TotalAmountRec) AS Expr1, Date FROM PaymentsReceipt WHERE PaymentsReceipt.Date BETWEEN '" + date11 + "'AND'" + date22 + "'GROUP BY PaymentsReceipt.Date";
             SqlCommand cmd = new SqlCommand(sqlSelect, conn);
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;
         }

         private string nn;
         public string NAMESz
         {
             get { return nn; }
             set { nn = value; }
         }

         public SqlDataReader PopulateCUSTOMERSearch(SqlConnection conn)
         {
             string sqlSelect = "SELECT * FROM Customer WHERE CustLN LIKE '" + nn + "%'";
             SqlCommand cmd = new SqlCommand(sqlSelect, conn);
             //cmd.Parameters.Add(new SqlParameter("@startDate", startDate));
             //cmd.Parameters.Add(new SqlParameter("@endDate", endDate));
             cmd.CommandType = CommandType.Text;
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;
         }

         public void updateSupplier(DataGridView datagrid)
         {
             try
             {
                 conn.Open();
                 if (conn.State == ConnectionState.Open)
                 {
                     for (int i = 0; i < datagrid.Rows.Count; i++)
                     {
                         string SqlSelect = "UPDATE Supplier SET SupLN = '" + datagrid.Rows[i].Cells[0].Value + "',SupFN = '" + datagrid.Rows[i].Cells[1].Value + "',SupCompany = '" +datagrid.Rows[i].Cells[2].Value + "',SupContactnum = '" +datagrid.Rows[i].Cells[3].Value + "'WHERE SupID='" + datagrid.Rows[i].Cells[4].Value + "'";
                         SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                         cmd.CommandType = CommandType.Text;
                         cmd.ExecuteNonQuery();
                     }
                 }
             }
             catch (Exception)
             {

                 DialogResult okay = new DialogResult();
                 okay = MessageBox.Show("check the values you entered.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 if (okay == DialogResult.OK)
                 {
                     Application.DoEvents();
                 }
             }
             finally { conn.Close(); }
         }
    }
}
