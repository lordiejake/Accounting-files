using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data; 
using System.Windows.Forms;
using System.Collections; 
  

namespace OrderManagementSystem
{
    class Class2
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        private int SalesSlipno;
        SqlTransaction tran = null;

        private ArrayList ReturnsID = new ArrayList();
        private ArrayList Suplieaiid = new ArrayList(); 
        private double custidd;
        private double empidd;
        private string custln;
        private string custfn;
        private string creditcardnumber;
        private string flagg;
        private double total;

        public ArrayList SUPIDiD
        {
            get { return Suplieaiid; }
            set { Suplieaiid = value; }
        }
        public ArrayList RETURNZID
        {
            get { return ReturnsID; }
            set { ReturnsID = value; }
        }
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

        private double newbalance;

        public double NEWbal
        {
            get { return newbalance; }
            set { newbalance = value; }
        }

        private string supln;
        public string SUPLNe
        {
            get { return supln; }
            set { supln = value; }
        }

        private double RetID;
        public double RETID
        {
            get { return RetID; }
            set { RetID = value; }
        }

        private double K;
        public double IDSupK
        {
            get { return K; }
            set { K = value; }
        }
        public SqlDataReader SupplierReturns(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT Delivery.DelID, Delivery.Date, Supplier.SupLN, Supplier.SupFN, Supplier.SupCompany, Delivery.Total,Supplier.SupID,Delivery.NewTotalD FROM            Supplier INNER JOIN    Delivery ON Supplier.SupID = Delivery.SupID WHERE Supplier.SupLN LIKE '" + supln + "%'Order BY Supplier.SupLN";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader DDDDDDIDDD(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Delivery WHERE DelID = '" + RetID + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SupplierBalance(SqlConnection conn)
        {
            string sqlSelect = "Select * FROM Supplier WHERE SupID ='" + K + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SupplierTOTAL(SqlConnection conn)
        {
            string sqlSelect = "Select * FROM Delivery WHERE DelID ='" + RetID + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SupplierTOTALpaid(SqlConnection conn)
        {
            string sqlSelect = "SELECT SUM(Amount) AS Expr1, DelID FROM PayDelData WHERE DelID ='" + RetID + "'GROUP BY DelID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SupplierReturns212(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT DeliveryData.DelDataID, DeliveryData.DelID, DeliveryData.ProdID, DeliveryData.ProdDesc, DeliveryData.SalesQty,        DeliveryData.ProdDPrice, DeliveryData.Amount, DeliveryData.Barcode, DeliveryData.ExpiryDate, DeliveryData.SupID, DeliveryData.Date,Products.ProdQty,DeliveryData.NewSalesQtyy,DeliveryData.NewAmountD  FROM            DeliveryData INNER JOIN   Products ON DeliveryData.ProdID = Products.ProdID WHERE DeliveryData.DelID = '" + RetID + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public void Createordertocustomer(DataGridView grid5)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO Sales(CustID,EmpID,CustLN,CustFN,CreditCardNo,Flag,Total,Date,UpdTotalAmountBalance,NewTotal)VALUES('" + custidd + "','" + empidd + "','" + custln + "','" + custfn + "','" + creditcardnumber + "','" + flagg + "','" + total + "','" + DateTime.Now.ToString() + "','" + total + "','"+total+"')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) SalesNO FROM Sales ORDER BY SalesNO DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            SalesSlipno = Convert.ToInt32(dr[0]);
                            dr.Close();

                        }
                    }

                    for (int i = 0; i < grid5.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO SalesData(SalesNO,ProdID,ProdDesc,SalesQty,ProductRetailPrice,Amount,Barcode,ExpiryDate,NewSalesQty,NewAmount,ProdBalance,RunningQty,ReturnQtyy,NewRunningQty,CustID,Date)VALUES(@salenu,@prodnu,@ProdDesck,@salesqty,@prp,@Amounttt,@barcodee,@Ex,@NewS,@NewA,@eProdBalance,@eRunningQty,@NewReturnQty,@nnewRunningQty,'" + custidd + "','" + DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@salenu", SalesSlipno));
                        cmdInsert.Parameters.Add(new SqlParameter("@prodnu", Convert.ToDouble(grid5.Rows[i].Cells[0].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ProdDesck", grid5.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@salesqty", Convert.ToDouble(grid5.Rows[i].Cells[6].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@NewS", Convert.ToDouble(grid5.Rows[i].Cells[6].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@prp", Convert.ToDouble(grid5.Rows[i].Cells[2].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@Amounttt", Convert.ToDouble(grid5.Rows[i].Cells[8].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@NewA", Convert.ToDouble(grid5.Rows[i].Cells[8].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@barcodee", grid5.Rows[i].Cells[4].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Ex", grid5.Rows[i].Cells[10].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@eProdBalance", grid5.Rows[i].Cells[3].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@eRunningQty", grid5.Rows[i].Cells[7].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@NewReturnQty", "0"));
                        cmdInsert.Parameters.Add(new SqlParameter("@nnewRunningQty", grid5.Rows[i].Cells[7].Value.ToString()));
                        cmdInsert.ExecuteNonQuery();               
                                              
                    }
                }
                tran.Commit();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("New Order Taken!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                    for (int i = 0; i < grid5.Rows.Count; i++)
                    {
                        string SqlSelect = "UPDATE Products SET ProdQty = '" + Convert.ToDouble(grid5.Rows[i].Cells[7].Value) + "'WHERE ProdID='" + grid5.Rows[i].Cells[0].Value + "'";
                        SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        
                    }

                    string SqlSelect2 = "UPDATE Customer SET CustBalance = '" + newbalance + "'WHERE CustID='" + custidd + "'";
                    SqlCommand cmd2 = new SqlCommand(SqlSelect2, conn);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                }
                grid5.Rows.Clear();
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
                //DialogResult okay = new DialogResult();
                //okay = MessageBox.Show("Enter you Credit card number and the Flag.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //if (okay == DialogResult.OK)
                //{
                //    Application.DoEvents();
                //}
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
