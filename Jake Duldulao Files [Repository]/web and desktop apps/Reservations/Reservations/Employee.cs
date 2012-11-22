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
    class Employee
    {
        private string Lname;
        private string Fname;
        private string Mname;
        private string Contactnumber;
        private string EmployeeAdress;
        private string Uname;
        private string Passw;

        public string LNAME
        {
            get { return Lname; }
            set { Lname = value; }
        }
        public string FNAME
        {
            get { return Fname; }
            set { Fname = value; }
        }
        public string MNAME
        {
            get { return Mname; }
            set { Mname = value; }
        }
        public string CONTACTS
        {
            get { return Contactnumber; }
            set { Contactnumber = value; }
        }
        public string ADDRESSS
        {
            get { return EmployeeAdress; }
            set { EmployeeAdress = value; }
        }
        public string USERNAME
        {
            get { return Uname; }
            set { Uname = value; }
        }
        public string PASSWORD
        {
            get { return Passw; }
            set { Passw = value; }
        }
        
        private string Usern;
        private string Pass;
        public string USERN
        {
            get { return Usern; }
            set { Usern = value; }
        }
        public string PASS
        {
            get { return Pass; }
            set { Pass = value; }
        }
        public SqlDataReader LOGIN(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Employee WHERE EmployeeUserName = '" + Usern + "'AND EmployeePassword = '" + Pass + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double Guestid;
        public double GUESTID
        {
            get { return Guestid; }
            set { Guestid = value; }
        }
        public SqlDataReader CustomerSelect(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Guest WHERE GuestID = '" + Guestid + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader CustomerSelect1(SqlConnection conn)
        {
            string sqlSelect = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, Guest.ContactNumber, Guest.Address, Guest.Balance,    Guest.No_Companion, CheckIN_ReservationDetails.ReservationCheckStatus    FROM         CheckIN_ReservationDetails INNER JOIN    Guest ON CheckIN_ReservationDetails.GuestID = Guest.GuestID   WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus <> 'Check OUT') AND (dbo.CheckIN_ReservationDetails.ReservationCheckStatus <> 'ReservationCanceled') ORDER BY Guest.GuestLastName";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string n;
        public string N________
        {
            get { return n; }
            set { n = value; }
        }
        public SqlDataReader CustomerSelect1Search(SqlConnection conn)
        {
            string sqlSelect = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, Guest.ContactNumber, Guest.Address, Guest.Balance,    Guest.No_Companion, CheckIN_ReservationDetails.ReservationCheckStatus    FROM         CheckIN_ReservationDetails INNER JOIN    Guest ON CheckIN_ReservationDetails.GuestID = Guest.GuestID   WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus <> 'Check OUT') AND (dbo.CheckIN_ReservationDetails.ReservationCheckStatus <> 'ReservationCanceled') AND Guest.GuestLastName LIKE '" + n + "%'ORDER BY Guest.GuestLastName";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double Resid;
        public double RESERVATIONid
        {
            get { return Resid; }
            set { Resid = value; }
        }
        public void Cancelation(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE CheckIN_ReservationDetails SET ReservationCheckStatus = '" + "ReservationCanceled" + "'WHERE CheckIN_ReservationID ='" + Resid +"'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double Naiwanroom;
        public double NAIWANROOM
        {
            get { return Naiwanroom; }
            set { Naiwanroom = value; }
        }

        public void UPTodateCheckOUTRoomAvailabilityzzzzzzzzzzzzz(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Available" + "'WHERE RoomID ='" + Naiwanroom + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
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

        public SqlDataReader PopulateIncome2(SqlConnection conn)
        {
            string sqlSelect = "SELECT     SUM(Credit_Cash_Payment) AS Expr1, Date_Payment  FROM         Payments   WHERE Date_Payment BETWEEN '" + date11 + "'AND'" + date22 + "'GROUP BY Date_Payment";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader PopulateIncome(SqlConnection conn)
        {
            string sqlSelect = "SELECT     SUM(Credit_Cash_Payment) AS Expr1  FROM Payments   WHERE Date_Payment BETWEEN '" + date11 + "'AND'" + date22 + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader PopulateSQltransactionReservation(SqlConnection conn)
        {
            string sqlSelect = "SELECT     CheckIN_ReservationDetails.CheckINDate, CheckIN_ReservationDetails.Date_Out,     Guest.GuestLastName + ',  ' + Guest.GuestFirstName + '  ' + Guest.GuestMiddleName AS Names, Guest.No_Companion, Room.RoomName,    RoomType.UpdatedRoomTypeName, RoomCondition.RoomConditionName,CheckIN_ReservationDetails.RoomBill,      CheckIN_ReservationDetails.ReservationCheckStatus   FROM         Guest INNER JOIN   CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN    Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID INNER JOIN     RoomType ON Room.RoomTypeID = RoomType.RoomTypeID INNER JOIN   RoomCondition ON RoomType.RoomConditionID = RoomCondition.RoomConditionID  WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Check OUT') AND CheckIN_ReservationDetails.Date_Out BETWEEN '" + date11 + "'AND'" + date22 + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader PopulateSQltransactionReservation________________________________(SqlConnection conn)
        {
            string sqlSelect = "SELECT     CheckIN_ReservationDetails.CheckINDate, CheckIN_ReservationDetails.Date_Out,     Guest.GuestLastName + ',  ' + Guest.GuestFirstName + '  ' + Guest.GuestMiddleName AS Names, Guest.No_Companion, Room.RoomName,    RoomType.UpdatedRoomTypeName, RoomCondition.RoomConditionName, CheckIN_ReservationDetails.RoomBill,      CheckIN_ReservationDetails.ReservationCheckStatus   FROM         Guest INNER JOIN   CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN    Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID INNER JOIN     RoomType ON Room.RoomTypeID = RoomType.RoomTypeID INNER JOIN   RoomCondition ON RoomType.RoomConditionID = RoomCondition.RoomConditionID  WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Check OUT' OR CheckIN_ReservationDetails.ReservationCheckStatus = 'Check IN') AND CheckIN_ReservationDetails.CheckINDate BETWEEN '" + date11 + "'AND'" + date22 + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void AddEmployee(SqlConnection conn)
        {       
                string command = "INSERT INTO Employee(EmployeeLastName,EmployeeFirstName,EmployeeMiddleName,ContactNumber,EmployeeAddress,EmployeeUserName,EmployeePassword)VALUES(@LN,@FN,@MN,@C,@A,@User,@PASS)";
                SqlCommand cmd = new SqlCommand(command,conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@LN", Lname));
                cmd.Parameters.Add(new SqlParameter("@FN", Fname));
                cmd.Parameters.Add(new SqlParameter("@MN", Mname));
                cmd.Parameters.Add(new SqlParameter("@C", Contactnumber));
                cmd.Parameters.Add(new SqlParameter("@A", EmployeeAdress));
                cmd.Parameters.Add(new SqlParameter("@User", Uname));
                cmd.Parameters.Add(new SqlParameter("@PASS", Passw));
                cmd.ExecuteNonQuery();
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Successfuly Saved: Thank you " + Lname + " ," + Fname + " " + Mname+ " ", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
        }
    }
}
