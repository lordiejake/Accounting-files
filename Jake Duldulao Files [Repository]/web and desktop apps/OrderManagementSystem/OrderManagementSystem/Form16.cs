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
    public partial class Form16 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class1 add = new Class1();
        CustomerOrders Pro = new CustomerOrders();
        DataSet printJk = new Printing.DataSet1();
        
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;      
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ProdDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear(); 
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add("* "+dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString(),dr[5].ToString(),dr[8].ToString(),dr[0].ToString());  
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
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    add.LIKEE = textBox1.Text; 
                    SqlDataReader dr = add.ProdDetails212(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add("* " + dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[8].ToString(),dr[0].ToString());
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataGridView2.DefaultCellStyle.BackColor = Color.White;
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                label2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
                Pro.RUNNINGID = double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Pro.Running(conn);
                    if (dr.HasRows)
                    {
                        dataGridView2.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView2.Rows.Add(dr[16].ToString(),dr[0].ToString(),dr[2].ToString(),dr[3].ToString(),dr[11].ToString(),dr[4].ToString(),dr[12].ToString(),dr[13].ToString(),dr[14].ToString());  
                        }
                    }
                    else
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add("<Empty>", "<Empty>", "<Empty>", "<Empty>", "<Empty>", "<Empty>", "<Empty>", "<Empty>", "<Empty>");  
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                printJk.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[6].Value.ToString(), item.Cells[7].Value.ToString(), item.Cells[8].Value.ToString(),label2.Text,label4.Text,label6.Text);
            }
               
            Printing.PrintForm frm = new OrderManagementSystem.Printing.PrintForm();
            frm.Print = printJk;
            frm.ShowDialog();

            printJk.Tables["DataTable1"].Rows.Clear();
        }
    }
}
