using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;  

namespace Reservations
{
    class GroupReservation
    {
        SqlConnection conn = null;
        SqlTransaction tran = null;
        double groupreservationcheckinid;
        private double employeeid;
        private double grandtotal;
        public double EMPLOYEEID
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        public double GRANDTOTAL
        {
            get { return grandtotal; }
            set { grandtotal = value; }
        }

        //===========================================================
        double Customeridx;
        private string gln;
        private string gfn;
        private string gmn;
        private string gcn;
        private string gadress;
        private double gbal;
        private double gcompanion;
        public string GLN
        {
            get { return gln; }
            set { gln = value; }
        }
        public string GFN
        {
            get { return gfn; }
            set { gfn = value; }
        }
        public string GMN
        {
            get { return gmn; }
            set { gmn = value; }
        }
        public string GCN
        {
            get { return gcn; }
            set { gcn = value; }
        }
        public string GADRESS
        {
            get { return gadress; }
            set { gadress = value; }
        }
        public double GBAL
        {
            get { return gbal; }
            set { gbal = value; }
        }
        public double GCOMPANION
        {
            get { return gcompanion; }
            set { gcompanion = value; }
        }

        public void CreateCustomerFirst()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO Guest(GuestLastName,GuestFirstName,GuestMiddleName,ContactNumber,Address,Balance,No_Companion)VALUES('" + gln + "','" + gfn + "','" + gmn + "','" + gcn + "','" + gadress + "','" + gbal + "','" + gcompanion + "')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) GuestID FROM Guest ORDER BY GuestID DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            Customeridx = Convert.ToInt32(dr[0]);
                            dr.Close();
                        }
                    }     
                }
                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Complete all the information above", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public SqlDataReader CustomerSelect1Search(SqlConnection conn)
        {
            string sqlSelect = "SELECT  TOP (1) GuestID FROM Guest ORDER BY GuestID DESC";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader CustomerSearchs(SqlConnection conn)
        {
            string sqlSelect = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, GroupReservationCheckIN.GrandTotal   FROM         Guest INNER JOIN GroupReservationCheckIN ON Guest.GuestID = GroupReservationCheckIN.GuestID WHERE  GroupReservationCheckIN.TransactionStatus = 'CheckIN' AND";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public void CreateReservationGroup(DataGridView datas)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO GroupReservationCheckIN(GuestID,EmployeeID,dateRESERVATION,GrandTotal,TransactionStatus)VALUES('" + Customeridx + "','" + employeeid + "','" + DateTime.Now.ToString() + "','" + grandtotal + "','" + "CheckIN" +"')";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Transaction = tran;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string sqlSelect = "SELECT  TOP (1) GroupReservationCheckINID FROM GroupReservationCheckIN ORDER BY GroupReservationCheckINID DESC";
                        SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                        cmdSelect.Transaction = tran;
                        SqlDataReader dr = cmdSelect.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            groupreservationcheckinid = Convert.ToInt32(dr[0]);
                            dr.Close();
                        }
                    }
                    for (int i = 0; i < datas.Rows.Count ; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO GroupReservationCheckINdetails(GroupReservationCheckINID,RoomID,RoomBillz,PersonOccupied,ExcessPersonz,ExcessTimeHour,dateCHECKIN,dateCHECKOUT,AmountTobepaid)VALUES(@ddGroupReservationCheckINID,@ddRoomID,@ddRoomBillz,@ddPersonOccupied,@ddExcessPersonz,@ddExcessTimeHour,@dddateCHECKIN,@dddateCHECKOUT,@ddAmountTobepaid)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@ddGroupReservationCheckINID", groupreservationcheckinid));
                        cmdInsert.Parameters.Add(new SqlParameter("@ddRoomID", Convert.ToDouble(datas.Rows[i].Cells[1].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ddRoomBillz", Convert.ToDouble(datas.Rows[i].Cells[13].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ddPersonOccupied", Convert.ToDouble(datas.Rows[i].Cells[6].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ddExcessPersonz", Convert.ToDouble(datas.Rows[i].Cells[12].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ddExcessTimeHour", Convert.ToDouble(datas.Rows[i].Cells[7].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@dddateCHECKIN", datas.Rows[i].Cells[10].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@dddateCHECKOUT", datas.Rows[i].Cells[11].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@ddAmountTobepaid", Convert.ToDouble(datas.Rows[i].Cells[9].Value.ToString())));
                        cmdInsert.ExecuteNonQuery();
                    }                 
                }
                tran.Commit();

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Save! Welcome " + gln + " ," + gfn + " ", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
                for (int i = 0; i < datas.Rows.Count; i++)
                {
                    string SqlSelect = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Check IN" + "'WHERE RoomID = '" + double.Parse(datas.Rows[i].Cells[1].Value.ToString()) + "'";
                    SqlCommand cmdz = new SqlCommand(SqlSelect, conn);
                    cmdz.CommandType = CommandType.Text;
                    cmdz.ExecuteNonQuery();
                }
                datas.Rows.Clear();
            }
            catch (Exception)
            {
                tran.Rollback();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Complete all the information above", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
