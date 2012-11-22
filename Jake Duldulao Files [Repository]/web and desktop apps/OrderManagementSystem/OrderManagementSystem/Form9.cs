using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace OrderManagementSystem
{
    public partial class Form9 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class1 add1 = new Class1(); 
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add1.ProdDetails21(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                           
                              dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    add1.LIKEE = textBox1.Text;  
                    SqlDataReader dr = add1.ProdDetails212(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();  
                    }
  
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
         
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            add1.updatePRODUCTS(dataGridView1);  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
