using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OrderManagementSystem
{
    public partial class Form21 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class1 instance = new Class1();
        DataSet printJk = new Printing.DataSet1();
        DataSet printJkk = new Printing.DataSet2();

        public Form21()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    instance.LIKEeeee = textBox1.Text;
                    SqlDataReader dr = instance.searchcust(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();  
            try
            {
                instance.KKK = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader dr = instance.SelectCustomerOrders(conn);
                    if (dr.HasRows)
                    {
                        dataGridView3.Rows.Clear();
                        dataGridView2.Rows.Clear();  
                        while (dr.Read())
                        {
                            dataGridView3.Rows.Add(dr[4].ToString(),dr[5].ToString(),dr[3].ToString());   
                        }
                    }
                    else
                    {
                        dataGridView3.Rows.Clear();
                        dataGridView2.Rows.Clear();  
                    }
                }
            }
            catch (Exception)
            {

                throw;  
            }
            finally { conn.Close(); }
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustID = '" + double.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", conn);
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet("MyImages");
                    byte[] mydata = new byte[0];
                    dp.Fill(ds, "MyImages");
                    DataRow Myrow;
                    Myrow = ds.Tables["MyImages"].Rows[0];
                    mydata = (byte[])Myrow["CustPict"];
                    MemoryStream stream = new MemoryStream(mydata);
                    pictureBox1.Image = Image.FromStream(stream);
                    
                }
            }
            catch (Exception)
            {

                label3.Text = "."; 
            }
            finally { conn.Close(); }

            

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                instance.RETURNSTATEMENTSIDDDDDDDDDDD = Convert.ToInt32(dataGridView3.CurrentRow.Cells[1].Value.ToString());   
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = instance.Returnstatements(conn);
                    if (dr.HasRows)
                    {
                        dataGridView2.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add("<Empty>","<Empty>","<Empty>","<Empty>","<Empty>");  
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            try
            {
                instance.CUSTIDENTs = double.Parse(dataGridView3.CurrentRow.Cells[1].Value.ToString());
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = instance.SalesDataMoney(conn);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            textBox2.Text = dr[9].ToString();
                        }
                    }
                    else { textBox2.Clear(); }
                }
            }
            catch (Exception)
            {

                label3.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                printJkk.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(),label2.Text,textBox2.Text);
            }

            Printing.Print2 frm = new OrderManagementSystem.Printing.Print2();
            frm.Prints = printJkk;
            frm.ShowDialog();
            printJkk.Tables["DataTable1"].Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }
    }
}
