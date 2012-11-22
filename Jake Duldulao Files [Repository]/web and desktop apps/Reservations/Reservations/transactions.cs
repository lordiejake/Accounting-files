using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections; 

namespace Reservations
{
    class transactions
    {
        SqlConnection conn = null;
        SqlTransaction tran = null;
        private int Customeridx;
        private string gln;
        private string gfn;
        private string gmn;
        private string gcn;
        private string gadress;
        private double gbal;
        private double gcompanion;
        private ArrayList room2array = new ArrayList();
        public ArrayList ROOM2ARRAY
        {
            get { return room2array; }
            set { room2array = value; }
        }
        private double roomidarray;
        public double ROOMIDARRAYSZ
        {
            get { return roomidarray; }
            set { roomidarray = value; }
        }
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

        //============================================
        private double roomid;
        private double employeeid;
        private string statuas;
        private string checkin;
        private string checkout;
        private double expectedhours;
        private double roombill;
        private double excesstimestatus;
        private double totalbill;

        public double ROOMID
        {
            get { return roomid; }
            set { roomid = value; }
        }
        public double EMPLOYEEID
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        public string STATUAS
        {
            get { return statuas; }
            set { statuas = value; }
        }
        public string CHECKIN
        {
            get { return checkin; }
            set { checkin = value; }
        }
        public string CHECKOUT
        {
            get { return checkout; }
            set { checkout = value; }
        }
        public double EXPECTEDHOURS
        {
            get { return expectedhours; }
            set { expectedhours = value; }
        }
        public double ROOMBILL
        {
            get { return roombill; }
            set { roombill = value; }
        }
        public double EXESSTIMESTATUS
        {
            get { return excesstimestatus; }
            set { excesstimestatus = value; }
        }
        public double TOTALBILL
        {
            get { return totalbill; }
            set { totalbill = value; }
        }

        public SqlDataReader RoomSTATUStransaction(SqlConnection conn)
        {
            string comm = "SELECT     Room.RoomName, Guest.GuestLastName + '   ,' + Guest.GuestFirstName + '   ' + Guest.GuestMiddleName AS Expr1, Guest.No_Companion,    RoomType.UpdatedRoomTypeName, RoomCondition.RoomConditionName, CheckIN_ReservationDetails.ReservationCheckStatus,    CheckIN_ReservationDetails.CheckINDate,CheckIN_ReservationDetails.Date_Out  FROM         RoomCondition INNER JOIN      RoomType ON RoomCondition.RoomConditionID = RoomType.RoomConditionID INNER JOIN     Room ON RoomType.RoomTypeID = Room.RoomTypeID INNER JOIN    CheckIN_ReservationDetails ON Room.RoomID = CheckIN_ReservationDetails.RoomID INNER JOIN   Guest ON CheckIN_ReservationDetails.GuestID = Guest.GuestID WHERE ReservationCheckStatus = 'Reserve' ORDER BY Room.RoomName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string shiftlike;
        public string SHIFTLIKE
        {
            get { return shiftlike; }
            set { shiftlike = value; }
        }
        private ArrayList ShiftList = new ArrayList();
        public ArrayList SHIFTLIST
        {
            get { return ShiftList; }
            set { ShiftList = value; }
        }
        private ArrayList connecting_thedatabases = new ArrayList();
        public ArrayList CONNECTINGthedatabases
        {
            get { return connecting_thedatabases; }
            set { connecting_thedatabases = value; }
        }
        public SqlDataReader ShiftReceipt(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, CheckIN_ReservationDetails.ReservationCheckStatus  FROM         Guest INNER JOIN    CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID  WHERE  (CheckIN_ReservationDetails.ReservationCheckStatus != 'Check OUT') AND Guest.GuestLastName LIKE'" + shiftlike + "%'ORDER BY Guest.GuestLastName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double shiftREsid;
        public double SHIFTRESID____lll
        {
            get { return shiftREsid; }
            set { shiftREsid = value; }
        }
        public SqlDataReader ShiftReceiptPAymentsBlaBlaBla(SqlConnection conn)
        {
            string comm = "SELECT * FROM Payments WHERE CheckIN_ReservationID = '" + shiftREsid + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private ArrayList XXXXXXXXXXXXXXXX = new ArrayList();
        public ArrayList XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        {
            get { return XXXXXXXXXXXXXXXX; }
            set { XXXXXXXXXXXXXXXX = value; }
        }
        public SqlDataReader ROOMTYPE2(SqlConnection conn)
        {
            string comm = "SELECT * FROM RoomType";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string date1;
        public string DATE1
        {
            get { return date1; }
            set { date1 = value; }
        }
        private string date2;
        public string DATE2
        {
            get { return date2; }
            set { date2 = value; }
        }
        private double RAMI;
        public double rami
        {
            get { return RAMI; }
            set { RAMI = value; }
        }
        public SqlDataReader ChechingofdateReservation(SqlConnection conn)
        {
            string comm = "SELECT * FROM CheckIN_ReservationDetails WHERE ReservationCheckStatus = 'Reserve' AND CheckINDate BETWEEN '" + date1 + "'AND'" + date2  + "'AND RoomID = '" +  RAMI  + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader CHEEEEEEEEEEEEEEEEEEEEEEEEEEEEE(SqlConnection conn)
        {
            string comm = "SELECT     CheckINDate, Date_Out  FROM  dbo.CheckIN_ReservationDetails WHERE ReservationCheckStatus = 'Reserve' AND RoomID = '" + RAMI + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double roomtypeid2222222;
        public double ROOMTYPEID2222222
        {
            get { return roomtypeid2222222; }
            set { roomtypeid2222222 = value; }
        }
        public SqlDataReader ROOMTYPE2details(SqlConnection conn)
        {
            string comm = "SELECT * FROM RoomType WHERE RoomTypeID = '" + roomtypeid2222222 + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ROOMTxxxxxxxxxxxxxxxxxdetails(SqlConnection conn)
        {
            string comm = "SELECT * FROM Room WHERE (UpdatedStatus_Reserved_CheckIN_Available != 'Check IN') AND RoomTypeID = '" + roomtypeid2222222 + "'ORDER BY RoomName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        
        private double we;
        public double WE
        {
            get { return we; }
            set { we = value; }
        }
        public SqlDataReader TotalPaidsGUEST(SqlConnection conn)
        {
            string comm = "SELECT     SUM(Credit_Cash_Payment) AS Expr1   FROM Payments  WHERE CheckIN_ReservationID = '" + we+ "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double ID_pay;
        public double ID_PAYS
        {
            get { return ID_pay; }
            set { ID_pay = value; }
        }
        public SqlDataReader ShiftReceiptPAymentsBlaBlaBla___________________(SqlConnection conn)
        {
            string comm = "SELECT * FROM Payments WHERE PaymentsID = '" + ID_pay + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private ArrayList joomlaid = new ArrayList();
        public ArrayList JOOMLAId
        {
            get { return joomlaid; }
            set { joomlaid = value; }
        }

        private double ShiftReceiptCommunicationid;
        public double ShiftReceiptCommunicationid____________
        {
            get { return ShiftReceiptCommunicationid; }
            set { ShiftReceiptCommunicationid = value; }
        }
        public SqlDataReader Communication(SqlConnection conn)
        {
            string comm = "SELECT * FROM Guest WHERE GuestID = '" + ShiftReceiptCommunicationid + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader ShiftReceiptCommunication(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Room.RoomName, CheckIN_ReservationDetails.ReservationCheckStatus,    CheckIN_ReservationDetails.CheckIN_ReservationID,Guest.GuestMiddleName    FROM         CheckIN_ReservationDetails INNER JOIN    Guest ON CheckIN_ReservationDetails.GuestID = Guest.GuestID INNER JOIN  Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID WHERE Guest.GuestID = '" + ShiftReceiptCommunicationid + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader RoomSTATUStransactionxxx(SqlConnection conn)
        {
            string comm = "SELECT     TOP (100) PERCENT Room.RoomName, Guest.GuestLastName + '   ,' + Guest.GuestFirstName + '   ' + Guest.GuestMiddleName AS Expr1, Guest.No_Companion,     RoomType.UpdatedRoomTypeName, RoomCondition.RoomConditionName, CheckIN_ReservationDetails.ReservationCheckStatus,      CheckIN_ReservationDetails.CheckINDate, CheckIN_ReservationDetails.CheckIN_ReservationID, Room.RoomID, Guest.GuestID,     CheckIN_ReservationDetails.ReservationDate  FROM         RoomCondition INNER JOIN   RoomType ON RoomCondition.RoomConditionID = RoomType.RoomConditionID INNER JOIN    Room ON RoomType.RoomTypeID = Room.RoomTypeID INNER JOIN    CheckIN_ReservationDetails ON Room.RoomID = CheckIN_ReservationDetails.RoomID INNER JOIN     Guest ON CheckIN_ReservationDetails.GuestID = Guest.GuestID   WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Reserve')  ORDER BY Room.RoomName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader RoomSTATUStransactionCheck(SqlConnection conn)
        {
            string comm = "SELECT     TOP (100) PERCENT Room.RoomName, Guest.GuestLastName + '   ,' + Guest.GuestFirstName + '   ' + Guest.GuestMiddleName AS Expr1, Guest.No_Companion,     RoomType.UpdatedRoomTypeName, RoomCondition.RoomConditionName, CheckIN_ReservationDetails.ReservationCheckStatus,     CheckIN_ReservationDetails.CheckINDate, CheckIN_ReservationDetails.Expected_hours, CheckIN_ReservationDetails.Date_Out, Room.RoomID, Guest.GuestID,     CheckIN_ReservationDetails.CheckIN_ReservationID, Guest.Balance  FROM         RoomCondition INNER JOIN   RoomType ON RoomCondition.RoomConditionID = RoomType.RoomConditionID INNER JOIN    Room ON RoomType.RoomTypeID = Room.RoomTypeID INNER JOIN   CheckIN_ReservationDetails ON Room.RoomID = CheckIN_ReservationDetails.RoomID INNER JOIN    Guest ON CheckIN_ReservationDetails.GuestID = Guest.GuestID  WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Check IN')  ORDER BY Room.RoomName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader StartPage(SqlConnection conn)
        {
            string comm = "SELECT     TOP (100) PERCENT RoomCondition.RoomConditionName, RoomType.UpdatedRoomTypeName, Room.RoomName, RoomType.UpdatedRoomTypeBill,     Room.UpdatedStatus_Reserved_CheckIN_Available   FROM         RoomCondition INNER JOIN   RoomType ON RoomCondition.RoomConditionID = RoomType.RoomConditionID INNER JOIN   Room ON RoomType.RoomTypeID = Room.RoomTypeID  ORDER BY Room.RoomName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private ArrayList guestkilanlan = new ArrayList();
        public ArrayList GUESTKILANLAN
        {
            get { return guestkilanlan; }
            set { guestkilanlan = value; }
        }

        private double Guest________;
        public double GUEST__________
        {
            get { return Guest________; }
            set { Guest________ = value; }
        }

        private double Reservation__________;
        public double RESERVATION_______________
        {
            get { return Reservation__________; }
            set { Reservation__________ = value; }
        }


        private ArrayList guestkilanlanID = new ArrayList();
        public ArrayList GUESTKILANLANID
        {
            get { return guestkilanlanID; }
            set { guestkilanlanID = value; }
        }

        private ArrayList expectedhours___________ = new ArrayList();
        public ArrayList EXPECTEDHOURS_______________
        {
            get { return expectedhours___________; }
            set { expectedhours___________ = value; }
        }

        private ArrayList Naiwan_na_rumID = new ArrayList();
        public ArrayList NAIWAN_NA_RUMID
        {
            get { return Naiwan_na_rumID; }
            set { Naiwan_na_rumID = value; }
        }

        private  ArrayList commandes = new ArrayList();
        public ArrayList COMMMANDZes
        {
            get { return commandes; }
            set { commandes = value; }
        }

        private ArrayList Naiwan_na_rumIDdddddddddddddddddddddddddddddd = new ArrayList();
        public ArrayList NAIWAN_NA_RUMIDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDd
        {
            get { return Naiwan_na_rumIDdddddddddddddddddddddddddddddd; }
            set { Naiwan_na_rumIDdddddddddddddddddddddddddddddd = value; }
        }

        private double Naiwanroom;
        public double NAIWANROOM
        {
            get { return Naiwanroom; }
            set { Naiwanroom = value; }
        }

        public void UPTodateCheckOUTRoomAvailabilityzzzzzzzzzzzzz(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Check IN" + "'WHERE RoomID ='" + Naiwanroom + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public SqlDataReader ReservationFullPaymentStatus(SqlConnection conn)
        {
            string comm = "SELECT     TOP (100) PERCENT Guest.GuestID, Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, CheckIN_ReservationDetails.CheckIN_ReservationID,   CheckIN_ReservationDetails.Expected_hours, Room.RoomID, CheckIN_ReservationDetails.CheckINDate  FROM         Payments INNER JOIN   Guest ON Payments.GuestID = Guest.GuestID INNER JOIN   CheckIN_ReservationDetails ON Payments.CheckIN_ReservationID = CheckIN_ReservationDetails.CheckIN_ReservationID AND   Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN    Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID  WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Reserve') AND (Guest.Balance = 0)  ORDER BY Guest.GuestLastName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ReservationFullPaymentStatus1(SqlConnection conn)
        {
            string comm = "SELECT * FROM Guest WHERE GuestID = '" + Guest________ + "'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ReservationUpdating(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestLastName, Guest.GuestFirstName, Guest.GuestMiddleName, CheckIN_ReservationDetails.ReservationCheckStatus, Room.RoomName,    CheckIN_ReservationDetails.CheckINDate, Guest.Balance, Guest.ContactNumber, Guest.Address, Guest.No_Companion,     CheckIN_ReservationDetails.Expected_hours, CheckIN_ReservationDetails.RoomBill, CheckIN_ReservationDetails.ExcessTimeStatus, Guest.GuestID,     CheckIN_ReservationDetails.CheckIN_ReservationID, Room.RoomID    FROM         Guest INNER JOIN   CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID INNER JOIN   Room ON CheckIN_ReservationDetails.RoomID = Room.RoomID   WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus = 'Reserve')";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader BBBBBBBBBBBBBBBBBBBBBBBBBBLZZZZZZZZZZZZZZZZZZ(SqlConnection conn)
        {
            string comm = "SELECT     Guest.GuestLastName + ',  ' + Guest.GuestFirstName + '   ' + Guest.GuestMiddleName AS NameLIST, Guest.Balance,    CheckIN_ReservationDetails.ReservationCheckStatus, Guest.GuestID  FROM         Guest INNER JOIN     CheckIN_ReservationDetails ON Guest.GuestID = CheckIN_ReservationDetails.GuestID  WHERE     (CheckIN_ReservationDetails.ReservationCheckStatus <> 'Check OUT') AND (dbo.CheckIN_ReservationDetails.ReservationCheckStatus <> 'ReservationCanceled')";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ReservationFullPaymentStatus2(SqlConnection conn)
        {
            string comm = "SELECT     Payments.TotalBillToPayed, Payments.Credit_Cash_Payment, Payments.Payments_Balance, Payments.Date_Payment   FROM         CheckIN_ReservationDetails INNER JOIN     Payments ON CheckIN_ReservationDetails.CheckIN_ReservationID = Payments.CheckIN_ReservationID WHERE CheckIN_ReservationDetails.CheckIN_ReservationID = '" + Reservation__________ +"'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string d_____________________________;
        public string D__________________________
        {
            get { return d_____________________________; }
            set { d_____________________________ = value; }
        }
        public void UPTodateCheckin(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE CheckIN_ReservationDetails SET ReservationCheckStatus = '" + "Check IN" + "',CheckINDate = '" + DateTime.Now.ToString()    + "',Date_Out = '" + d_____________________________ + "'WHERE CheckIN_ReservationID ='" + Reservation__________ + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double r______________________________________________________;
        public double R_________________________________________________________
        {
            get { return r______________________________________________________; }
            set { r______________________________________________________ = value; }
        }


        private string excess;
        public string EXCESSIVE
        {
            get { return excess; }
            set { excess = value; }
        }

        private double Billof;
        public double BILLOF
        {
            get { return Billof; }
            set { Billof = value; }
        }

        private string Dated;
        public string DATED
        {
            get { return Dated; }
            set { Dated = value; }
        }
        public void UPTodateCheckOUT(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE CheckIN_ReservationDetails SET ReservationCheckStatus = '" + "Check OUT" + "',Date_Out = '" + Dated + "',ExcessTimeStatus = '" + excess + "',TotalBill = '" + Billof + "'WHERE CheckIN_ReservationID ='" + r______________________________________________________ + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double BeginBack;
        private double PaymentsIz;
        public double BEGINBACK
        {
            get { return BeginBack; }
            set { BeginBack = value; }
        }
        public double PAYMENTIDz
        {
            get { return PaymentsIz; }
            set { PaymentsIz = value; }
        }
        public void BackPayments(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Payments SET Credit_Cash_Payment = '" +  BeginBack + "'WHERE PaymentsID ='" + PaymentsIz + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }


        private double r______________________________________________________Room;
        public double R____________ROOM
        {
            get { return r______________________________________________________Room; }
            set { r______________________________________________________Room = value; }
        }
        public void UPTodateCheckOUTRoomAvailability(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Available" + "'WHERE RoomID ='" + r______________________________________________________Room + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double Guest__________id;
        public double GUEST___________ID
        {
            get { return Guest__________id; }
            set { Guest__________id = value; }
        }
        private double BBBBb;
        public void UPTodateCheckOUTRoomAvailabilityCUSTOMER(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Guest SET Balance = '" +  Billof  + "'WHERE GuestID ='" + Guest__________id + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double rid;
        public double RID
        {
            get { return rid; }
            set { rid = value; }
        }
        private string roomstat;
        public string ROOMSTAT
        {
            get { return roomstat; }
            set { roomstat = value; }
        }

        private string custln;
        private string custfn;
        private string custmn;
        private string custaddress;
        private string custcontact;
        private double custidupdate;

        public double CUSTIDUPDATE
        {
            get { return custidupdate; }
            set { custidupdate = value; }
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
        public string CUSTMN
        {
            get { return custmn; }
            set { custmn = value; }
        }
        public string CUSTADDRESS
        {
            get { return custaddress; }
            set { custaddress = value; }
        }
        public string CUSTCONTACT
        {
            get { return custcontact; }
            set { custcontact = value; }
        }

        public void updateCustomer(SqlConnection conn)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                        string SqlSelect = "UPDATE Guest SET GuestLastName = '" + custln + "',GuestFirstName = '" + custfn + "',GuestMiddleName = '" + custmn + "',ContactNumber = '" + custcontact + "',Address = '" + custaddress + "'WHERE GuestID ='" + custidupdate + "'";
                        SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Successfuly Updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Something Error: Check the Data you entered.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }

        public void CreateReservation()
        {
            try
            {
                conn = Connection.ConnectToServer();  
                if (conn.State == ConnectionState.Open)
                {
                    tran = conn.BeginTransaction();
                    string insert = "INSERT INTO Guest(GuestLastName,GuestFirstName,GuestMiddleName,ContactNumber,Address,Balance,No_Companion,BalanceRefund)VALUES('" + gln + "','" + gfn + "','" + gmn + "','" + gcn + "','" + gadress + "','" + gbal + "','" + gcompanion + "','" + 0.0000 + "')";
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

                        string sqlInsertDetails = "INSERT INTO CheckIN_ReservationDetails(GuestID,RoomID,EmployeeID,ReservationCheckStatus,ReservationDate,CheckINDate,Date_Out,Expected_hours,RoomBill,ExcessTimeStatus,TotalBill)VALUES(@GuestIDs,@RoomIDs,@EmployeeIDs,@ReservationCheckStatuss,@ReservationDates,@CheckINDates,@Date_Outs,@Expected_hourss,@RoomBills,@ExcessTimeStatuss,@TotalBills)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Transaction = tran;
                        cmdInsert.Parameters.Add(new SqlParameter("@GuestIDs", Customeridx));
                        cmdInsert.Parameters.Add(new SqlParameter("@RoomIDs", Convert.ToDouble(roomid.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@EmployeeIDs", Convert.ToDouble(employeeid.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ReservationCheckStatuss", statuas.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@ReservationDates", DateTime.Now.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@CheckINDates", checkin.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Date_Outs", checkout.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Expected_hourss", Convert.ToDouble(expectedhours.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@RoomBills", Convert.ToDouble(roombill.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@ExcessTimeStatuss", Convert.ToDouble(excesstimestatus.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@TotalBills", Convert.ToDouble(totalbill.ToString())));
                        cmdInsert.ExecuteNonQuery(); 
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Save! Welcome " + gln + " ," + gfn  + " " , "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        } 
                }
                tran.Commit();
                //string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + roomstat + "'WHERE RoomID='" + rid + "'";
                //SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
                //cmd1.CommandType = CommandType.Text;
                //cmd1.ExecuteNonQuery();

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


        public void CreateReservation2()
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

                    string sqlInsertDetails = "INSERT INTO CheckIN_ReservationDetails(GuestID,RoomID,EmployeeID,ReservationCheckStatus,ReservationDate,CheckINDate,Date_Out,Expected_hours,RoomBill,ExcessTimeStatus,TotalBill)VALUES(@GuestIDs,@RoomIDs,@EmployeeIDs,@ReservationCheckStatuss,@ReservationDates,@CheckINDates,@Date_Outs,@Expected_hourss,@RoomBills,@ExcessTimeStatuss,@TotalBills)";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.Transaction = tran;
                    cmdInsert.Parameters.Add(new SqlParameter("@GuestIDs", Customeridx));
                    cmdInsert.Parameters.Add(new SqlParameter("@RoomIDs", Convert.ToDouble(roomid.ToString())));
                    cmdInsert.Parameters.Add(new SqlParameter("@EmployeeIDs", Convert.ToDouble(employeeid.ToString())));
                    cmdInsert.Parameters.Add(new SqlParameter("@ReservationCheckStatuss", statuas.ToString()));
                    cmdInsert.Parameters.Add(new SqlParameter("@ReservationDates", DateTime.Now.ToString()));
                    cmdInsert.Parameters.Add(new SqlParameter("@CheckINDates", checkin.ToString()));
                    cmdInsert.Parameters.Add(new SqlParameter("@Date_Outs", checkout.ToString()));
                    cmdInsert.Parameters.Add(new SqlParameter("@Expected_hourss", Convert.ToDouble(expectedhours.ToString())));
                    cmdInsert.Parameters.Add(new SqlParameter("@RoomBills", Convert.ToDouble(roombill.ToString())));
                    cmdInsert.Parameters.Add(new SqlParameter("@ExcessTimeStatuss", Convert.ToDouble(excesstimestatus.ToString())));
                    cmdInsert.Parameters.Add(new SqlParameter("@TotalBills", Convert.ToDouble(totalbill.ToString())));
                    cmdInsert.ExecuteNonQuery();
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Save! Welcome " + gln + " ," + gfn + " ", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                tran.Commit();
                string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + roomstat + "'WHERE RoomID='" + rid + "'";
                SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();

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

        public void AddCheckingReservation()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    
                        string sqlInsertDetails = "INSERT INTO SingleRoomCheckingReservation(RoomID,ExpectedDateCheckIN,HoursToStay)VALUES(@URT,@URTB,@URTS)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@URT", Convert.ToDouble(roomid.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@URTB", checkin.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@URTS", Convert.ToDouble(expectedhours.ToString())));
                        cmdInsert.ExecuteNonQuery();
                    
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Complete the Room information including the room type", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }



    }
}
