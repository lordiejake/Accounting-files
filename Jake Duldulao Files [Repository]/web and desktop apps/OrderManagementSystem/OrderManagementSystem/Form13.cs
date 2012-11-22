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
    public partial class Form13 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Updatesupplier date = new Updatesupplier();
        DataSet printJkk = new Printing.DataSet5();
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            date.DATE1 = dateTimePicker1.Text + " 12:01:00 AM";
            date.DATE2 = dateTimePicker2.Text + " 11:59:00 PM";

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = date.PopulateSalesBYProduct(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[0].ToString(), dr[3].ToString());
                        }
                    }
                    else { dataGridView1.Rows.Clear(); }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            date.DATE11 = dateTimePicker3.Text + " 12:01:00 AM";
            date.DATE22 = dateTimePicker4.Text + " 11:59:00 PM";

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = date.PopulateIncome2(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        dataGridView2.Rows.Clear();   
                        while (dr.Read())
                        {
                            listBox1.Items.Add(dr[1].ToString() + " " + dr[0].ToString());
                            dataGridView2.Rows.Add(dr[0].ToString());  
                        }
                    }
                    else { listBox1.Items.Clear(); }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            double f = 0;
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                 //   label19.Text = "Successfully Added......";
                    f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    textBox1.Text = f.ToString();

                }

            }
            catch (Exception)
            {

                textBox1.Text  = "Waiting.......";
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    printJkk.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(),dateTimePicker1.Text,dateTimePicker2.Text);
                }

                Printing.print4 frm = new OrderManagementSystem.Printing.print4();
                frm.Prints = printJkk;
                frm.ShowDialog();
                printJkk.Tables["DataTable1"].Rows.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}