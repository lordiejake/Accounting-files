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
    
    public partial class Form2 : Form
    {
        SqlConnection conn = null;
        Roomtype command = new Roomtype(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomCondition(conn);
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Clear();
                        command.ROOMCONDITIONID.Clear();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[1].ToString());
                            command.ROOMCONDITIONID.Add(dr[0]);
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
            command.RCID = Convert.ToInt32(command.ROOMCONDITIONID[comboBox1.SelectedIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
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
            command.AddRoomType(dataGridView1);  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
