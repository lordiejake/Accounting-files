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
    class PaymentsTransactions
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        SqlTransaction tran = null;
        private int paymentsdeliveryID;
        private int paymentsreceiptID;

        private double AMOunt;
        public double AMOUNT
        {
            get { return AMOunt; }
            set { AMOunt = value; }
        }
        private double empid;
        private double totall;
        public double TOTALL
        {
            get { return totall; }
            set { totall = value; }
        }

        public double EMPid
        {
            get { return empid; }
            set { empid = value; }
        }
       // private double remaining;
        //public double remainingAMOUNT
        //{
        //    get { return remaining; }
        //    set { remaining = value; }
        //}

        private double Remain;
        public double remainingtotal
        {
            get { return Remain; }
            set { Remain = value; }
        }

        private double del;
        public double DEL
        {
            get { return del; }
            set { del = value; }
        }

        private double Supbal;
        public double SUPBAL
        {
            get { return Supbal; }
            set { Supbal = value; }
        }

        private double Supiden;
        public double SUPidentification
        {
            get { return Supiden; }
            set { Supiden = value; }
        }
        

        public void CreatePaymentsdelivery(double supplierid, double deliveryno)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO PaymentsDel(SupID,EmpID,TotalAmount,Date)VALUES('" + supplierid + "','" + empid + "','" + totall +"','" + DateTime.Now.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) PayDID FROM PaymentsDel ORDER BY PayDID DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            paymentsdeliveryID = Convert.ToInt32(dr[0]);
                            dr.Close();

                        }
                    }


                        string sqlInsertDetails = "INSERT INTO PayDelData(PayDID,Amount,DelID,SupID)VALUES(@payid,@amount,'"+ deliveryno +"','" + supplierid + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@payid", paymentsdeliveryID));
                        cmdInsert.Parameters.Add(new SqlParameter("@amount", totall));
                        cmdInsert.ExecuteNonQuery();




                }
                tran.Commit();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Payments add to records!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                    string SqlSelect = "UPDATE Delivery SET UpdTotal = '" + Remain + "'WHERE DelID='" + del + "'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    string SqlSelect1 = "UPDATE Supplier SET SupBal = '" + Supbal + "'WHERE SupID='" + Supiden + "'";
                    SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                tran.Rollback();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("error", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // ================================ ...............................===========================................................========================


        private double emdid2;
        private double totall2;
        private double remain2;
     //   private double sales2;
        private double custbal2;
       // private double custid;

        public double EMPID2
        {
            get { return emdid2; }
            set { emdid2 = value; }
        }

        public double TOTALL2
        {
            get { return totall2; }
            set { totall2 = value; }
        }

        public double REMAIN2
        {
            get { return remain2; }
            set { remain2 = value; }
        }

        public double CUSTBAL2
        {
            get { return custbal2; }
            set { custbal2 = value; }
        }
        private double Totalpayments;
        public double TOTALPAYMENTSSSSSSSSS
        {
            get { return Totalpayments; }
            set { Totalpayments = value; }
        }
        private double ballllllll;
        public double BALANCEEEEEEEE 
        {
            get { return ballllllll; }
            set { ballllllll = value; }
        }
       


        public void CreatePaymentsReceipt(double customerId, double salesno)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO PaymentsReceipt(CustID,EmpID,TotalAmountRec,Date)VALUES('" + customerId + "','" + emdid2 + "','" + totall2 + "','" + DateTime.Now.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) PaymentsRecID FROM PaymentsReceipt ORDER BY PaymentsRecID DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            paymentsreceiptID = Convert.ToInt32(dr[0]);
                            dr.Close();

                        }
                    }


                    string sqlInsertDetails = "INSERT INTO PayRecData(PaymentsRecID,Amount,TotalPayments,Balancee,SalesNO,CustID)VALUES(@payid,@amount,@Totals,@ball,'" + salesno + "','" + customerId + "')";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.Transaction = tran;
                    cmdInsert.Parameters.Add(new SqlParameter("@payid", paymentsreceiptID));
                    cmdInsert.Parameters.Add(new SqlParameter("@amount", totall2));
                    cmdInsert.Parameters.Add(new SqlParameter("@Totals", Totalpayments));
                    cmdInsert.Parameters.Add(new SqlParameter("@ball", ballllllll));
                    cmdInsert.ExecuteNonQuery();




                }
                tran.Commit();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Payments add to records!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                    string SqlSelect = "UPDATE Sales SET UpdTotalAmountBalance = '" + remain2 + "'WHERE SalesNO='" + salesno  + "'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    string SqlSelect1 = "UPDATE Customer SET CustBalance = '" + custbal2 + "'WHERE CustID='" + customerId + "'";
                    SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                tran.Rollback();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("error", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}