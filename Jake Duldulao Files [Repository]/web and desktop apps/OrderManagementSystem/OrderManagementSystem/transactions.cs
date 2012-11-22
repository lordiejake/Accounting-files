using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.Data; 
using System.Windows.Forms;  

namespace OrderManagementSystem
{
    class transactions
    {
        private double IDSupp;
        private ArrayList Supplierid = new ArrayList(); 
        private string like;
        private string COMPANY;
        private string totall;
        SqlTransaction tran = null;
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        private int deliverySlipno;
        private int RetailsalesNumber;

        public int deliverySlipNum
        {
            get { return deliverySlipno; }
            set { deliverySlipno = value; }
        }

        public double IDSUP
        {
            get { return IDSupp; }
            set { IDSupp = value; }
        }

        public string TOTALLI
        {
            get { return totall; }
            set { totall = value; }
        }

        public string company
        {
            get { return COMPANY; }
            set { COMPANY = value; }
        }

        public ArrayList SUPID
        {
            get { return Supplierid; }
            set { Supplierid = value; }
        }

        public string LIKES
        {
            get { return like; }
            set { like = value; }
        }
        private int monthnumber;
        public int Months_Number_range
        {
            get { return monthnumber; }
            set { monthnumber = value; }
        }
        public void CreateorderSupplier(double supplierid, DataGridView grid)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO PO(SupID,SupCompany,Total,Date)VALUES('" + supplierid + "','" + COMPANY + "','" + totall +"','" + DateTime.Now.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) POnum FROM PO ORDER BY POnum DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            deliverySlipno = Convert.ToInt32(dr[0]);
                            dr.Close();

                        }
                    }

                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO POData(POnum,ProdID,ProdDesc,Qty,SupID)VALUES(@POnum1,@ProdID1,@ProdDesc1,@Qty1,'"+supplierid+"')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@POnum1", deliverySlipno));
                        cmdInsert.Parameters.Add(new SqlParameter("@ProdID1", Convert.ToDouble(grid.Rows[i].Cells[1].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ProdDesc1", grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Qty1", Convert.ToDouble(grid.Rows[i].Cells[5].Value.ToString())));

                         cmdInsert.ExecuteNonQuery();

                    }

          

                }
                tran.Commit();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("New Order Taken!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                    
                }
                grid.Rows.Clear();
            }
            catch (Exception )
            {
                tran.Rollback();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("No Supplier! Select the Supplier", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public SqlDataReader Search(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier WHERE SupLN LIKE'" + like + "%'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ClickSupplier(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier WHERE SupID = '" + IDSupp + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


       // ===============================


        private double custidd;
        private double empidd;
        private string custln;
        private string custfn;
        private string creditcardnumber;
        private string flagg;
        private double total;

        public double CUSTIDD
        {
            get { return custidd; }
            set { custidd = value; }
        }

        public double EMPIDD
        {
            get { return empidd; }
            set { empidd = value; }
        }

        public string CUSTLN
        {
            get { return custln; }
            set { custln = value; }
        }

        public string CUSTFN
        {
            get { return custfn; }
            set { custfn = value; }
        }

        public string CREDITCARDNUMBER
        {
            get { return creditcardnumber; }
            set { creditcardnumber = value; }
        }

        public string FLAG
        {
            get { return flagg; }
            set { flagg = value; }
        }

        public double TOTAL
        {
            get { return total; }
            set { total = value; }
        }

        private double Supbal;
        public double SUPBAL
        {
            get { return Supbal; }
            set { Supbal = value; }
        }

        public void CreateorderSupplier5(double supplierid, DataGridView grid6)
        {

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO Delivery(SupID,EmpID,SupCompany,Flag,Total,Date,UpdTotal,NewTotalD)VALUES('" + supplierid + "','" + empidd + "','" + COMPANY + "','" + flagg + "','" + totall + "','" + DateTime.Now.ToString() + "','" + totall + "','" + totall + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) DelID FROM Delivery ORDER BY DelID DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            deliverySlipno = Convert.ToInt32(dr[0]);
                            dr.Close();

                        }
                    }

                    for (int i = 0; i < grid6.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO DeliveryData(DelID,ProdID,ProdDesc,SalesQty,ProdDPrice,Amount,Barcode,ExpiryDate,NewSalesQtyy,NewAmountD,SupID,Date)VALUES(@del,@ProdID1,@ProdDesc1,@Qty1,@price,@amm,@code,@expiry,@newQ,@newAa,'" + supplierid + "','" + DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@del", deliverySlipno));
                        cmdInsert.Parameters.Add(new SqlParameter("@ProdID1", Convert.ToDouble(grid6.Rows[i].Cells[1].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ProdDesc1", grid6.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Qty1", Convert.ToDouble(grid6.Rows[i].Cells[5].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@newQ", Convert.ToDouble(grid6.Rows[i].Cells[5].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@price", Convert.ToDouble(grid6.Rows[i].Cells[3].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@amm", Convert.ToDouble(grid6.Rows[i].Cells[7].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@newAa", Convert.ToDouble(grid6.Rows[i].Cells[7].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@code", grid6.Rows[i].Cells[4].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@expiry", grid6.Rows[i].Cells[9].Value.ToString()));
                        cmdInsert.ExecuteNonQuery();

                    }
                }
                tran.Commit();
                for (int i = 0; i < grid6.Rows.Count; i++)
                {
                    string SqlSelect = "UPDATE Products SET ProdQty = '" + Convert.ToDouble(grid6.Rows[i].Cells[6].Value) + "'WHERE ProdID='" + grid6.Rows[i].Cells[1].Value + "'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

                string SqlSelect1 = "UPDATE Supplier SET SupBal = '" + Supbal + "'WHERE SupID='" + supplierid + "'";
                SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();

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


        private double cid;
        private string cLN;
        private string cFN;
        private double Ttall;
        private double emid;

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
                    string insert = "INSERT INTO RetSales(CustIDa,CustLNa,CustFNa,Totala,EmpIDa,Datea)VALUES('" + cid + "','" + cLN + "','" + cFN + "','" + Ttall + "','" + emid + "','" +DateTime.Now.ToString() + "')";
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
                        string sqlInsertDetails = "INSERT INTO RetSalesData(RetSalesNO,SalesNO,ProdID,ProdDesc,Qty,RPrice,Amount,Date)VALUES(@retsalesno,@salesno,@prodid,@Proddesc,@Qty,@rprice,@amm,'"+ DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@retsalesno",RetailsalesNumber));
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
                    Application.DoEvents();  
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
