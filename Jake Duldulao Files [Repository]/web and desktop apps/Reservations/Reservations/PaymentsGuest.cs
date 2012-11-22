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
    class PaymentsGuest
    {
        private double customeraidi;
        public double CUSTOMERIADI
        {
            get { return customeraidi; }
            set { customeraidi = value; }
        }
        private ArrayList custnew = new ArrayList();
        public ArrayList CUSTNEW
        {
            get { return custnew; }
            set { custnew = value; }
        }
        private string likethename;
        public string LIKETHENAME
        {
            get { return likethename; }
            set { likethename = value; }
        }
        private double Roomidc;
        public double ROOMIDC
        {
            get { return Roomidc; }
            set { Roomidc = value; }
        }
        private double CheckIN_ReservationIDmmmmmmmmmmmm;
        private string uost;
        public string OUSTSSSSSSSSSSSSSSSS
        {
            get { return uost; }
            set { uost = value; }
        }
        public double CheckIN_ReservationIDZZZZZZZZZZZZZZZZZZZMMMMMM
        {
            get { return CheckIN_ReservationIDmmmmmmmmmmmm; }
            set { CheckIN_ReservationIDmmmmmmmmmmmm = value; }
        }
        private string Gln;
        public string GLN
        {
            get { return Gln; }
            set { Gln = value; }
        }
        private double guestid;
        public double GUESTID
        {
            get { return guestid;}
            set { guestid = value; }
        }
        private ArrayList g = new ArrayList();
        private ArrayList News = new ArrayList();
        public ArrayList NEWS
        {
            get { return News; }
            set { News = value; }
        }
        public ArrayList G
        {
            get { return g; }
            set { g = value; }
        } 

        public SqlDataReader SearchGuest(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName  FROM         Guest INNER JOIN    CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID  WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Reserve')  AND (dbo.Guest.Balance > 0) AND GuestLastName LIKE '" + Gln + "%'ORDER BY GuestLastName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchGuestID(SqlConnection conn)
        {
            string comm = "SELECT * FROM  Guest WHERE GuestID = '" + guestid + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchCheckINPAYMENTSzTotalization(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, CheckIN_ReservationDetails.ReservationCheckStatus,     CheckIN_ReservationDetails.TotalBill    FROM         Guest INNER JOIN    CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID     WHERE     (CheckIN_ReservationDetails.TotalBill > 0) AND (CheckIN_ReservationDetails.ReservationCheckStatus = 'Check IN') AND Guest.GuestLastName LIKE '" + likethename +"%'ORDER BY Guest.GuestLastName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchCheckINPAYMENTSzTotalizationCHARGES(SqlConnection conn)
        {
            string comm = "SELECT     TOP (100) PERCENT Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, CheckIN_ReservationDetails.ReservationCheckStatus,    CheckIN_ReservationDetails.TotalBill   FROM         Guest INNER JOIN     CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID   WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Check OUT') AND (CheckIN_ReservationDetails.TotalBill > 0) AND Guest.GuestLastName LIKE '" + likethename + "%'ORDER BY Guest.GuestLastName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchGuestIDWithPayments(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestID, Payments.Date_Payment, Payments.TotalBillToPayed, Payments.Credit_Cash_Payment, Payments.Payments_Balance    FROM         Guest INNER JOIN     CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN     Payments ON Guest.GuestID = Payments.GuestID AND CheckIN_ReservationDetails.CheckIN_ReservationID = Payments.CheckIN_ReservationID WHERE Guest.GuestID = '" + guestid + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchGuestIDTransaction(SqlConnection conn)
        {
            string comm = "SELECT     CheckIN_ReservationDetails.CheckINDate, Room.RoomName, Guest.Balance,CheckIN_ReservationDetails.CheckIN_ReservationID,CheckIN_ReservationDetails.Expected_hours,Room.RoomID FROM         Guest INNER JOIN     CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN      Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID WHERE CheckIN_ReservationDetails.ReservationCheckStatus = 'Reserve' AND Guest.GuestID = '" + guestid + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader CheckINLISTDetails(SqlConnection conn)
        {
            string comm = "SELECT     CheckIN_ReservationDetails.CheckINDate, Room.RoomName, CheckIN_ReservationDetails.TotalBill, CheckIN_ReservationDetails.CheckIN_ReservationID,     CheckIN_ReservationDetails.Expected_hours, Room.RoomID   FROM         Guest INNER JOIN     CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN      Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID INNER JOIN    RoomType ON Room.RoomTypeID = RoomType.RoomTypeID WHERE Guest.GuestID = '" + customeraidi + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader CustomerDetalye(SqlConnection conn)
        {
            string comm = "SELECT * FROM Guest WHERE GuestID = '" + customeraidi + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double checkiz;
        private double guestids;
        private double employeeids;
        private double totalbilltopayed;
        private double creditcashpayments;
        private double paymentsbalance;
        private string creditcashstatus;
        public double CHEKIZ
        {
            get { return checkiz; }
            set { checkiz = value; }
        }
        public double GUESTIDS
        {
            get { return guestids; }
            set { guestids = value; }
        }
        public double EMPLOYEEIDS
        {
            get { return employeeids; }
            set { employeeids = value; }
        }
        public double TOTALBILLTOPAYEd
        {
            get { return totalbilltopayed; }
            set { totalbilltopayed = value; }
        }
        public double CREDITCASHPAYMENTS
        {
            get { return creditcashpayments; }
            set { creditcashpayments = value; }
        }
        public double PAYMENTSBALANCE
        {
            get { return paymentsbalance; }
            set { paymentsbalance = value; }
        }
        public string CREDITCASHSTATUS
        {
            get { return creditcashstatus; }
            set { creditcashstatus = value; }
        }
       
        
        public void AddPayments_Guest(SqlConnection conn)
        {
            string command = "INSERT INTO Payments(CheckIN_ReservationID,GuestID,EmployeeID,TotalBillToPayed,Credit_Cash_Status,Credit_Cash_Payment,Payments_Balance,Date_Payment)VALUES(@CheckIN_ReservationIDz,@GuestIDz,@EmployeeIDz,@TotalBillToPayedz,@Credit_Cash_Statusz,@Credit_Cash_Paymentz,@Payments_Balancez,@Date_Paymentz)";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@CheckIN_ReservationIDz", checkiz));
            cmd.Parameters.Add(new SqlParameter("@GuestIDz", guestids));
            cmd.Parameters.Add(new SqlParameter("@EmployeeIDz", employeeids));
            cmd.Parameters.Add(new SqlParameter("@TotalBillToPayedz", totalbilltopayed));
            cmd.Parameters.Add(new SqlParameter("@Credit_Cash_Statusz", creditcashstatus));
            cmd.Parameters.Add(new SqlParameter("@Credit_Cash_Paymentz", creditcashpayments));
            cmd.Parameters.Add(new SqlParameter("@Payments_Balancez", paymentsbalance));
            cmd.Parameters.Add(new SqlParameter("@Date_Paymentz", DateTime.Now.ToString()));
            cmd.ExecuteNonQuery();
            DialogResult okay = new DialogResult();
            okay = MessageBox.Show("Payments successfuly Saved:", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (okay == DialogResult.OK)
            {
                Application.DoEvents();
            }
           
        }

        public void UpdateGuestBalance(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Guest SET Balance = '" + paymentsbalance + "'WHERE GuestID='" + guestids + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public void UpdateGuestReservationToCheckIN(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE CheckIN_ReservationDetails SET ReservationCheckStatus = '" + "Check IN" + "', CheckINDate = '" + DateTime.Now.ToString() + "',Date_Out = '" + uost +"'WHERE CheckIN_ReservationID ='" + checkiz+ "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public void UpdateReservationBalance(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE CheckIN_ReservationDetails SET TotalBill = '" + paymentsbalance + "'WHERE CheckIN_ReservationID='" + checkiz + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public void UpdateReservationRoomDetailsStatus(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Check IN" + "'WHERE RoomID = '" + Roomidc + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }
    }
}
