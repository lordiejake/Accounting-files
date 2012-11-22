using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data; 

namespace OrderManagementSystem
{

    class Returnz
    {
        SqlTransaction tran = null;
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        private double cid;
        private string cLN;
        private string cFN;
        private double Ttall;
        private double emid;
        private int RetailsalesNumber;

        public double CID
        {
            get { return cid; }
            set { cid = value; }
        }
        public string CLN
        {
            get { return cLN; }
            set { cLN = value; }
        }
        public string CFN
        {
            get { return cFN; }
            set { cFN = value; }
        }
        public double TTALL
        {
            get { return Ttall; }
            set { Ttall = value; }
        }
        public double EMID
        {
            get { return emid; }
            set { emid = value; }
        } 

        public void CreateReturnscustomer(DataGridView griddd)
        {

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO RetSales(CustID,CustLN,CustFN,Total,EmpID,Date)VALUES('" + cid + "','" + cLN + "','" + cFN + "','" + Ttall + "','" + emid + "','" + DateTime.Now.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) RetSalesNO FROM RetSales ORDER BY RetSalesNO DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            RetailsalesNumber = Convert.ToInt32(dr[0]);
                            dr.Close();

                        }
                    }

                    for (int i = 0; i < griddd.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO RetSalesData(RetSalesNO,SalesNO,ProdID,ProdDesc,Qty,RPrice,Amount,Date)VALUES(@retsalesno,@salesno,@prodid,@Proddesc,@Qty,@rprice,@amm,'" + DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@retsalesno", RetailsalesNumber));
                        cmdInsert.Parameters.Add(new SqlParameter("@salesno", Convert.ToDouble(griddd.Rows[i].Cells[6].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@prodid", Convert.ToDouble(griddd.Rows[i].Cells[1].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@Proddesc", griddd.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Qty", Convert.ToDouble(griddd.Rows[i].Cells[10].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@rprice", Convert.ToDouble(griddd.Rows[i].Cells[2].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@amm", Convert.ToDouble(griddd.Rows[i].Cells[9].Value.ToString())));
                        cmdInsert.ExecuteNonQuery();

                    }



                }
                tran.Commit();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("New Order Taken!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    
                }

            }
            catch (Exception)
            {

                tran.Rollback();

            }
            finally
            {
                conn.Close();
            }
        }
       


        
    }
}
