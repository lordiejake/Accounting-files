using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reservations
{
    public partial class Form3 : Form
    {
        SqlConnection conn = null;
        Roomtype command = new Roomtype();
        Rooms rooms = new Rooms();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = rooms.RoomTypeSelection(conn);
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        rooms.ROOMLIST.Clear();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[1].ToString());
                            comboBox2.Items.Add(dr[1].ToString());
                            rooms.ROOMLIST.Add(dr[0]);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rooms.ROOMLISTID = Convert.ToInt32(rooms.ROOMLIST[comboBox1.SelectedIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add();
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            dataGridViewTextBoxColumn4.Items.Clear();
            dataGridViewTextBoxColumn4.Items.Add("Available");
            dataGridViewTextBoxColumn4.Items.Add("Under Construction"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rooms.AddRooms(dataGridView3);
            try
            {
                rooms.ROOMLISTID = Convert.ToInt32(rooms.ROOMLIST[comboBox2.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = rooms.RoomtypeINFORMATION(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView4.Rows.Add("Empty", "Empty");
                    }
                }
            }
            catch (Exception)
            {

                label3.Text = ".";
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("No Rows Left", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                rooms.ROOMLISTID = Convert.ToInt32(rooms.ROOMLIST[comboBox2.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = rooms.RoomtypeINFORMATION(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView4.Rows.Add("Empty", "Empty");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
