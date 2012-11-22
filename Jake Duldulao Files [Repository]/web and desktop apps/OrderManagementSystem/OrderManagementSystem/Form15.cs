using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;  

namespace OrderManagementSystem
{
    public partial class Form15 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class1 addd = new Class1();
        Updatesupplier m = new Updatesupplier(); 
        public Form15()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.SelectCustomers(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView1.Rows.Add(dr[2].ToString() + "  " + dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[9].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    m.NAMESz = textBox1.Text; 
                    SqlDataReader dr = m.PopulateCUSTOMERSearch(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView1.Rows.Add(dr[2].ToString() + "  " + dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[9].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
