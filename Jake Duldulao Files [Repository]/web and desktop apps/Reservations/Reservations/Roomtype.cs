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
    class Roomtype
    {
        SqlConnection conn = null;
        private ArrayList RoomConditionId = new ArrayList();
        public ArrayList ROOMCONDITIONID
        {
            get { return RoomConditionId; }
            set { RoomConditionId = value; }
        }

        private ArrayList RoomtypeId = new ArrayList();
        public ArrayList ROOMTYPEIDZ
        {
            get { return RoomtypeId; }
            set { RoomtypeId = value; }
        }

        private double rcid;
        public double RCID
        {
            get { return rcid; }
            set { rcid = value; }
        }

        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public SqlDataReader SelectRoomsZ(SqlConnection conn)
        {
            string SqlSelect1 = "SELECT * FROM Room WHERE RoomTypeID = '" + r + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectRoomBILLS(SqlConnection conn)
        {
            string SqlSelect1 = "SELECT * FROM RoomType WHERE RoomTypeID = '" + r + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectRoomCondition(SqlConnection conn)
        {
            string SqlSelect1 = "SELECT * FROM RoomCondition";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            return dr;
        }

        public SqlDataReader Excess_Conditions(SqlConnection conn)
        {
            string SqlSelect1 = "SELECT * FROM ExcessInformation";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            return dr;
        }

        public SqlDataReader SelectRoomConditionCODES(SqlConnection conn)
        {
            string SqlSelect1 = "SELECT * FROM RoomType WHERE RoomConditionID = '" + rcid + "'";
            SqlCommand cmd1 = new SqlCommand(SqlSelect1, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            return dr;
        }

        public void AddRoomType(DataGridView grid)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO RoomType(UpdatedRoomTypeName,UpdatedRoomTypeBill,UpdatedRoomTypeStatus,RoomConditionID,Number_Expected_Person,UpdatedRoomTypeBill_3hours)VALUES(@URT,@URTB,@URTS,@RCI,@EX,@UP)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@URT", grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@URTB", Convert.ToDouble(grid.Rows[i].Cells[1].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@EX", Convert.ToDouble(grid.Rows[i].Cells[4].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@UP", Convert.ToDouble(grid.Rows[i].Cells[3].Value.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@URTS", grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@RCI", Convert.ToDouble(rcid.ToString())));
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
                okay = MessageBox.Show("Complete the Room Type information including the room condition", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }
    }
}
