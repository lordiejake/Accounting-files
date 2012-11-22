using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;   
using System.Windows.Forms;
using System.Drawing; 
using System.IO;
using System.Collections; 

namespace OrderManagementSystem
{
    class Class1
    {
        private double iddd;
        private string like;
        private string Usern;
        private string Pass;
        private string likee;
        SqlTransaction tran;
        private ArrayList ProductID = new ArrayList();
        private ArrayList Empid = new ArrayList();
        private ArrayList CustIDDDD = new ArrayList();
        private int RetailsalesNumber;
        private int DetailRetailsalesNumber;

        public ArrayList CUSTIDDDDDDDDDD
        {
            get { return CustIDDDD; }
            set { CustIDDDD = value; }
        }

        public string USER
        {
            get { return Usern; }
            set { Usern = value; }
        }

        public string PASSWORD
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public double IDDD
        {
            get { return iddd; }
            set { iddd = value; }
        }

        public ArrayList EMPID
        {
            get { return Empid; }
            set { Empid = value; }
        }

        public string LIKEE
        {
            get { return likee; }
            set { likee = value; }
        }
        public ArrayList PRODUCTID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }

        public string LIKE
        {
            get { return like; }
            set { like = value; }
        }
        private string likeeee;
        public string LIKEeeee
        {
            get { return likeeee; }
            set { likeeee = value; }
        }

        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");

        public void AddSupplier(DataGridView grid)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO Supplier(SupLN,SupFN,SupCompany,SupBal,SupContactnum,SupDate)VALUES(@LN,@FN,@company,@Bal,@cont,'" + DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@LN",grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@FN",grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@company",grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Bal", Convert.ToDouble(grid.Rows[i].Cells[3].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@cont", grid.Rows[i].Cells[4].Value.ToString()));

                        cmdInsert.ExecuteNonQuery();

                    }
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Save", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

           
        }


        private double cid;
        private string cLN;
        private string cFN;
        private double Ttall;
        private double emid;
        private double UpdateSalesno;
        private double upd;
        private double newBal;
        public double NEWBALCUS
        {
            get { return newBal; }
            set { newBal = value; }
        }

        public double UPDsales
        {
            get { return upd; }
            set { upd = value; }
        }
        public double UPDATESALESNO
        {
            get { return UpdateSalesno; }
            set { UpdateSalesno = value; }
        }

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

        public void AddRetail(DataGridView grid)
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

                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO RetSalesData(RetSalesNO,SalesNO,ProdID,ProdDesc,Qty,RPrice,Amount,Date)VALUES(@retsalesno,@salesno,@prodid,@Proddesc,@Qty,@rprice,@amm,'" + DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@retsalesno", RetailsalesNumber));
                        cmdInsert.Parameters.Add(new SqlParameter("@salesno", Convert.ToDouble(grid.Rows[i].Cells[6].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@prodid", Convert.ToDouble(grid.Rows[i].Cells[0].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@Proddesc", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Qty", Convert.ToDouble(grid.Rows[i].Cells[7].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@rprice", Convert.ToDouble(grid.Rows[i].Cells[2].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@amm", Convert.ToDouble(grid.Rows[i].Cells[15].Value.ToString())));
                        cmdInsert.ExecuteNonQuery();

                    }
                }

                tran.Commit();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Products Returned", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    string SqlSelect = "UPDATE Products SET ProdQty = '" + Convert.ToDouble(grid.Rows[i].Cells[8].Value) + "'WHERE ProdID='" + grid.Rows[i].Cells[0].Value + "'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    string SqlSelecta = "UPDATE SalesData SET  NewSalesQty= '" + Convert.ToDouble(grid.Rows[i].Cells[10].Value) + "',NewAmount = '" + Convert.ToDouble(grid.Rows[i].Cells[9].Value) + "'WHERE SalesDataID='" + grid.Rows[i].Cells[14].Value + "'";
                    SqlCommand cmda = new SqlCommand(SqlSelecta, conn);
                    cmda.CommandType = CommandType.Text;
                    cmda.ExecuteNonQuery();
                }

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    string SqlSelecta = "UPDATE SalesData SET  ReturnQtyy = '" + Convert.ToDouble(grid.Rows[i].Cells[17].Value) + "',NewRunningQty= '" + Convert.ToDouble(grid.Rows[i].Cells[8].Value) + "'WHERE SalesDataID='" + grid.Rows[i].Cells[14].Value + "'";
                    SqlCommand cmda = new SqlCommand(SqlSelecta, conn);
                    cmda.CommandType = CommandType.Text;
                    cmda.ExecuteNonQuery();
                }

                string SqlSelect2 = "UPDATE Sales SET UpdTotalAmountBalance = '" + Convert.ToDouble(upd) + "'WHERE SalesNO='" + UpdateSalesno + "'";
                SqlCommand cmd2 = new SqlCommand(SqlSelect2, conn);
                cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();

                string SqlSelect21 = "UPDATE Sales SET NewTotal = '" + Convert.ToDouble(Ttall) + "'WHERE SalesNO='" + UpdateSalesno + "'";
                SqlCommand cmd21 = new SqlCommand(SqlSelect21, conn);
                cmd21.CommandType = CommandType.Text;
                cmd21.ExecuteNonQuery();


                string SqlSelect3 = "UPDATE Customer SET CustBalance = '" + Convert.ToDouble(newBal) + "'WHERE CustID='" + cid + "'";
                SqlCommand cmd3 = new SqlCommand(SqlSelect3, conn);
                cmd3.CommandType = CommandType.Text;
                cmd3.ExecuteNonQuery();

                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            catch (Exception)
            {

                tran.Rollback();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Complete the process", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }

       //==========================================================================================================================================
        private double ssssupid;
        private double eeeeempid;
        private string ssssssupln;
        private string ssssupfn;
        private string ssssupcompany;
        private double totallllll;
        private double newSupbal;

        public double NEWSUPBAL
        {
            get { return newSupbal; }
            set { newSupbal = value; }
        } 

        public double SSSSupid
        {
            get { return ssssupid; }
            set { ssssupid = value; }
        }
        public double EEEEEEmpid
        {
            get { return eeeeempid; }
            set { eeeeempid = value; }
        }
        public string SSSSupln
        {
            get { return ssssssupln; }
            set { ssssssupln = value; }
        }
        public string SSSSupfn
        {
            get { return ssssupfn; }
            set { ssssupfn = value; }
        }
        public string SSSSSupcompani
        {
            get { return ssssupcompany; }
            set { ssssupcompany = value; }
        }
        private double TID;
        public double TIDDDDDDDD
        {
            get { return TID; }
            set { TID = value; }
        } 
        public double TTTTTTTotal
        {
            get { return totallllll; }
            set { totallllll = value; }
        }
        public void AddDeliveryReturns(DataGridView grid)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO RetDelivery(SupID,EmpID,Supln,Supfn,companyy,Total,Date)VALUES('" + ssssupid + "','" + eeeeempid + "','" + ssssssupln + "','" + ssssupfn +"','"+ ssssupcompany +"','" + totallllll + "','" + DateTime.Now.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) RetDeliveryNo FROM RetDelivery ORDER BY RetDeliveryNO DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            DetailRetailsalesNumber = Convert.ToInt32(dr[0]);
                            dr.Close();
                        }
                    }

                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO RetDeliveryData(RetDeliveryNO,DelID,ProdID,ProdDesc,Qty,DPrice,Amount,Date)VALUES(@1retsalesno,@1salesno,@1prodid,@1Proddesc,@1Qty,@1rprice,@1amm,'" + DateTime.Now.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@1retsalesno", DetailRetailsalesNumber));
                        cmdInsert.Parameters.Add(new SqlParameter("@1salesno", Convert.ToDouble(grid.Rows[i].Cells[6].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@1prodid", Convert.ToDouble(grid.Rows[i].Cells[0].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@1Proddesc", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@1Qty", Convert.ToDouble(grid.Rows[i].Cells[7].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@1rprice", Convert.ToDouble(grid.Rows[i].Cells[2].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@1amm", Convert.ToDouble(grid.Rows[i].Cells[15].Value.ToString())));
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                tran.Commit();

                //for (int i = 0; i < grid.Rows.Count; i++)
                //{
                //    string SqlSelect = "UPDATE Products SET ProdQty = '" + Convert.ToDouble(grid.Rows[i].Cells[8].Value) + "'WHERE ProdID='" + grid.Rows[i].Cells[0].Value + "'";
                //    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                //    cmd.CommandType = CommandType.Text;
                //    cmd.ExecuteNonQuery();
                //}

                //string SqlSelect3 = "UPDATE Supplier SET SupBal = '" + Convert.ToDouble(newSupbal) + "'WHERE SupID='" + cid + "'";
                //SqlCommand cmd3 = new SqlCommand(SqlSelect3, conn);
                //cmd3.CommandType = CommandType.Text;
                //cmd3.ExecuteNonQuery();

                //string SqlSelect21 = "UPDATE Delivery SET NewTotalD = '" + Convert.ToDouble(Ttall) + "'WHERE DelID='" + TID + "'";
                //SqlCommand cmd21 = new SqlCommand(SqlSelect21, conn);
                //cmd21.CommandType = CommandType.Text;
                //cmd21.ExecuteNonQuery();


                //string SqlSelect2 = "UPDATE Delivery SET UpdTotal = '" + Convert.ToDouble(upd) + "'WHERE DelID='" + TID + "'";
                //SqlCommand cmd2 = new SqlCommand(SqlSelect2, conn);
                //cmd2.CommandType = CommandType.Text;
                //cmd2.ExecuteNonQuery();

                //for (int i = 0; i < grid.Rows.Count; i++)
                //{
                //    string SqlSelecta = "UPDATE DeliveryData SET  NewSalesQtyy= '" + Convert.ToDouble(grid.Rows[i].Cells[10].Value) + "',NewAmountD = '" + Convert.ToDouble(grid.Rows[i].Cells[9].Value) + "'WHERE DelDataID='" + grid.Rows[i].Cells[14].Value + "'";
                //    SqlCommand cmda = new SqlCommand(SqlSelecta, conn);
                //    cmda.CommandType = CommandType.Text;
                //    cmda.ExecuteNonQuery();
                //}

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Products Returned", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            catch (Exception)
            {

                tran.Rollback();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Complete the process", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }


        //=========================================================================================================================================
        public void Browse(PictureBox pict)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "JPEG Images|*.jpg";
                o.AddExtension = true;
                o.RestoreDirectory = true;
                o.Title =  "Insert Image";
                o.InitialDirectory = @"D:/";
                string choosen_file = "";
                if (o.ShowDialog() != DialogResult.Cancel)
                {
                    choosen_file = o.FileName;
                    pict.Image = Image.FromFile(choosen_file);
                }
                o.Dispose();
                o = null;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public SqlDataReader ViewEmp(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT EmpID, EmpPict, EmpLN, EmpFN, EmpRate, EmpStatus, EmpDate FROM  Employee ORDER BY EmpLN,EmpID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader Search(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Products WHERE ProdDesc LIKE'" + like + "%'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectCustomersbyBalance(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer WHERE CustID ='" + k + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string Custnumbers;
        public string CUSTm
        {
            get { return Custnumbers; }
            set { Custnumbers = value; }
        }
        public SqlDataReader SelectCustomersbyBalanceINTRO(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer WHERE CustNumber ='" + Custnumbers + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchEmployee(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Employee WHERE EmpLN LIKE'" + likee + "%'ORDER BY EmpLN,EmpID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void AddProduct(DataGridView gridd)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < gridd.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO Products(ProdDesc,ProdQty,ProdRPrice,ProdDPrice,ProdAmount,MinQty,Barcode,ProdDate)VALUES(@des,@qty,@RP,@DP,@PA,@MIN,@barcde,'" + DateTime.Now.ToString()  + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@des", gridd.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@qty", Convert.ToDouble(gridd.Rows[i].Cells[1].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@RP", Convert.ToDouble(gridd.Rows[i].Cells[2].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@DP", Convert.ToDouble(gridd.Rows[i].Cells[3].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@PA", Convert.ToDouble(gridd.Rows[i].Cells[4].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@MIN", Convert.ToDouble(gridd.Rows[i].Cells[5].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@barcde",gridd.Rows[i].Cells[6].Value.ToString()));
                        cmdInsert.ExecuteNonQuery();

                    }
                    gridd.Rows.Clear();
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Check the values you entered.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

            


        }
        
        private ArrayList custid = new ArrayList();
        private double k;

        public double KKK
        {
            get { return k; }
            set { k = value; }
        }

        public ArrayList CUSTIDDD
        {
            get { return custid; }
            set { custid = value; }
        }
        public SqlDataReader searchcust(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer WHERE CustLN LIKE'" + likeeee + "%'ORDER BY CustLN,CustID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader searchcustclick(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer WHERE CustID = '" + k + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader LOGIN(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Employee WHERE UserName = '" + Usern + "'AND Password = '" + Pass + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectCustomers(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer ORDER BY CustLN,CustFN"; 
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader HighestCustomerID(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (1) CustID FROM            Customer ORDER BY CustID DESC";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double returnstatementsid;
        public double RETURNSTATEMENTSIDDDDDDDDDDD
        {
            get { return returnstatementsid; }
            set { returnstatementsid = value; }
        } 
        public SqlDataReader Returnstatements(SqlConnection conn)
        {
            string sqlSelect = "SELECT      PaymentsReceipt.Date, PayRecData.SalesNO, PayRecData.TotalPayments, PayRecData.Amount, PayRecData.Balancee FROM          PaymentsReceipt INNER JOIN    PayRecData ON PaymentsReceipt.PaymentsRecID = PayRecData.PaymentsRecID WHERE PayRecData.SalesNO = '" + returnstatementsid + "'ORDER BY PaymentsReceipt.Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectCustomerOrders(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT Customer.CustID, Customer.CustLN, Customer.CustFN, Sales.NewTotal,Sales.Date,Sales.SalesNO FROM Customer INNER JOIN   Sales ON Customer.CustID = Sales.CustID WHERE Customer.CustID = '" + k + "'ORDER BY Sales.Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        private string iio;
        public string IIO
        {
            get { return iio; }
            set { iio = value; }
        }

        public SqlDataReader SelectCustomerOrdersqqq(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT Customer.CustID, Customer.CustLN, Customer.CustFN, Sales.NewTotal,Sales.Date,Sales.SalesNO FROM Customer INNER JOIN   Sales ON Customer.CustID = Sales.CustID WHERE Customer.CustNumber = '" + iio + "'ORDER BY Sales.Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double Custidenti;
        public double CUSTIDENTs
        {
            get { return Custidenti; }
            set { Custidenti = value; }
        }

        public SqlDataReader SelectCustomerOrders_Detailed(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT SalesData.Date, SalesData.ProdDesc, SalesData.SalesQty, SalesData.ProductRetailPrice, SalesData.Amount,SalesData.NewAmount,SalesData.NewSalesQty FROM            SalesData INNER JOIN Products ON SalesData.ProdID = Products.ProdID INNER JOIN    Customer ON SalesData.CustID = Customer.CustID WHERE SalesData.SalesNO = '" + Custidenti + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectCustomerOrders_TotalPaaids(SqlConnection conn)
        {
            string sqlSelect = " SELECT  SUM(Amount) AS Expr1, SalesNO FROM PayRecData WHERE PayRecData.SalesNO = '" + Custidenti + "'GROUP BY SalesNO";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SalesDataMoney(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Sales WHERE SalesNO = '" + Custidenti + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        private string CCCCCCCCCCCCCCCCCCCCCCCCCC;
        public string CCIIII
        {
            get { return CCCCCCCCCCCCCCCCCCCCCCCCCC; }
            set { CCCCCCCCCCCCCCCCCCCCCCCCCC = value; }
        }
        public SqlDataReader RedundantDatas(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Customer WHERE CustLN = '" + CCCCCCCCCCCCCCCCCCCCCCCCCC + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader Changecode(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Codes";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectCustomerOrders_Detailed2(SqlConnection conn)
        {
            string sqlSelect = "SELECT        Sales.SalesNO, Employee.EmpID, Employee.EmpPict, Employee.EmpLN, Employee.EmpFN, Employee.Phone FROM            Employee INNER JOIN   Sales ON Employee.EmpID = Sales.EmpID INNER JOIN  SalesData ON Sales.SalesNO = SalesData.SalesNO WHERE SalesData.SalesNO = '" + Custidenti + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ProdDetails(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Products ORDER BY ProdDesc,ProdID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

     
        public SqlDataReader ProdDetails21(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Products ORDER BY ProdDesc,ProdID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }



        public SqlDataReader ProdDetails212(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Products WHERE ProdDesc LIKE '" + likee + "%'ORDER BY ProdDesc,ProdID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void updatePRODUCTS(DataGridView datagrid)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < datagrid.Rows.Count ; i++)
                    {
                        string SqlSelect = "UPDATE Products SET ProdDesc = '" + datagrid.Rows[i].Cells[1].Value + "',ProdRPrice = '" + Convert.ToDouble(datagrid.Rows[i].Cells[2].Value)+ "',ProdDPrice = '" + Convert.ToDouble(datagrid.Rows[i].Cells[3].Value)+ "',MinQty = '" + Convert.ToDouble(datagrid.Rows[i].Cells[4].Value) + "'WHERE ProdID='" + datagrid.Rows[i].Cells[0].Value + "'";
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

        public void updateSupplier(DataGridView datagrid)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < datagrid.Rows.Count; i++)
                    {
                        string SqlSelect = "UPDATE Products SET ProdDesc = '" + datagrid.Rows[i].Cells[1].Value + "',ProdRPrice = '" + Convert.ToDouble(datagrid.Rows[i].Cells[2].Value) + "',ProdDPrice = '" + Convert.ToDouble(datagrid.Rows[i].Cells[3].Value) + "',MinQty = '" + Convert.ToDouble(datagrid.Rows[i].Cells[4].Value) + "'WHERE ProdID='" + datagrid.Rows[i].Cells[0].Value + "'";
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

        public void updateSecuritycode(TextBox codes)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    
                        string SqlSelect = "UPDATE Codes SET Code = '" + codes.Text + "'";
                        SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Security Code was changed!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
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
