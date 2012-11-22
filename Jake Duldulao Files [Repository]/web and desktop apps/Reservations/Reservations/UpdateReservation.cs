using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data; 

namespace Reservations
{
    class UpdateReservation
    {
        //SqlConnection conn = null;
        private double roomid;
        private double reservationid;
        private double expectedhours;
        private double roombill;
        private double excesstimestatus;
        private double totalbill;

        public double ROOMID
        {
            get { return roomid; }
            set { roomid = value; }
        }
        public double RESERVATIONID
        {
            get { return reservationid; }
            set { reservationid = value; }
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
        public void UPTodateCheckOUT(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE CheckIN_ReservationDetails SET RoomID = '" + roomid + "',ReservationCheckStatus = '" + "Reserve" + "',Expected_hours = '" + expectedhours + "',RoomBill = '" + roombill + "',ExcessTimeStatus = '" + excesstimestatus + "',TotalBill = '" + totalbill + "'WHERE CheckIN_ReservationID ='" + reservationid + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double bal;
        private double person;
        public double PERSON
        {
            get { return person; }
            set { person = value; }
        }
        public double BAL
        {
            get { return bal; }
            set { bal = value; }
        }
        private double guestid;
        public double GUESTID 
        {
            get { return guestid; }
            set { guestid = value; }
        }

        public void UPCustomer(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Guest SET Balance = '" + bal + "',No_Companion = '" + person + "'WHERE GuestID ='" + guestid + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double Excess_ChargeTIME_private;
        public double Excess_ChargeTIME_PUBLIC
        {
            get { return Excess_ChargeTIME_private; }
            set { Excess_ChargeTIME_private = value; }
        }

        private double Excess_ChargePERSON_private;
        public double Excess_ChargePERSON_PUBLIC
        {
            get { return Excess_ChargePERSON_private; }
            set { Excess_ChargePERSON_private = value; }
        }

        public void UPExcess_ChargeTIME(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE ExcessInformation SET Excess_ChargeTIME = '" + Excess_ChargeTIME_private + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public void UPExcess_ChargePERSON(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE ExcessInformation SET Excess_ChargePERSON = '" + Excess_ChargePERSON_private + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double refu;
        public double REFUND
        {
            get { return refu; }
            set { refu = value; }
        }
        public void UPPPPPPPCustomer(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Guest SET BalanceRefund = '" + refu + "'WHERE GuestID ='" + guestid + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public void UPNewRoom(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Available" + "'WHERE RoomID ='" + roomid + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        private double roooooooooomid;
        public double ROOOOOOOOOOOOOOMID
        {
            get { return roooooooooomid; }
            set { roooooooooomid = value; }
        }

        public void UPPreviusRoom(SqlConnection conn)
        {
            string SqlSelect1 = "UPDATE Room SET UpdatedStatus_Reserved_CheckIN_Available = '" + "Available" + "'WHERE RoomID ='" + roooooooooomid + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
        }

        public SqlDataReader RoomDetails(SqlConnection conn)
        {
            string comm = "SELECT     Room.RoomName, RoomType.UpdatedRoomTypeBill, RoomType.UpdatedRoomTypeBill_3hours, Room.UpdatedStatus_Reserved_CheckIN_Available,    RoomType.UpdatedRoomTypeName, RoomCondition.RoomConditionName,Room.RoomID,RoomType.Number_Expected_Person    FROM         Room INNER JOIN    RoomType ON Room.RoomTypeID = RoomType.RoomTypeID INNER JOIN    RoomCondition ON RoomType.RoomConditionID = RoomCondition.RoomConditionID";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

    }
}
