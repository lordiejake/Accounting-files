using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace Reservations
{
    class Rooms
    {
        SqlConnection conn = null;
        private ArrayList roomlist = new ArrayList();
        public ArrayList ROOMLIST
        {
            get { return roomlist; }
            set { roomlist = value; }
        }
        private double roomlistID;
        public double ROOMLISTID
        {
            get { return roomlistID; }
            set { roomlistID = value; }
        }
        public SqlDataReader RoomTypeSelection(SqlConnection conn)
        {
            string comm = "SELECT * FROM RoomType ORDER BY UpdatedRoomTypeName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ROOMSZ(SqlConnection conn)
        {
            string comm = "SELECT * FROM Room ORDER BY RoomName";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader RoomtypeINFORMATION(SqlConnection conn)
        {
            string comm = "SELECT * FROM Room WHERE RoomTypeID = '" + roomlistID + "'ORDER BY UpdatedStatus_Reserved_CheckIN_Available";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void AddRooms(DataGridView grid)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO Room(RoomName,UpdatedStatus_Reserved_CheckIN_Available,RoomTypeID)VALUES(@URT,@URTB,@URTS)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@URT", grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@URTB", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@URTS", Convert.ToDouble(roomlistID.ToString())));
                        cmdInsert.ExecuteNonQuery();

                    }
                    grid.Rows.Clear();
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
