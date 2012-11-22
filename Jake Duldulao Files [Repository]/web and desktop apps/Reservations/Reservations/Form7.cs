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
    public partial class Form7 : Form
    {
        Employee from = new Employee();
        SqlConnection conn = null;
        transactions add = new transactions();  
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.BBBBBBBBBBBBBBBBBBBBBBBBBBLZZZZZZZZZZZZZZZZZZ(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            double b = double.Parse(dr[1].ToString());
                            string v = string.Format("{0:N2}",b);
                            dataGridView1.Rows.Add(dr[0].ToString(), v.ToString(),dr[3].ToString());
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

            try
            {
                from.GUESTID = double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = from.CustomerSelect(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        while (dr.Read())
                        {
                            listBox1.Items.Add("Last Name: \t\t\t\t<" + dr[1].ToString() + ">");
                            listBox1.Items.Add("FirstName: \t\t\t\t<" + dr[2].ToString() + ">");
                            listBox1.Items.Add("Middle Name: \t\t\t\t<" + dr[3].ToString() + ">");
                            listBox1.Items.Add("Contact #: \t\t\t\t<" + dr[4].ToString() + ">");
                            listBox1.Items.Add("Address: \t\t\t\t\t<" + dr[5].ToString() + ">");
                            listBox1.Items.Add("Balance: \t\t\t\t\t<" + dr[6].ToString() + ">");     
                            listBox1.Items.Add("No of Companion: \t\t\t\t<" + dr[7].ToString() + ">");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("");    
                        }
                    }
                    else
                    {
                        listBox1.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("click on the item");  
            }
            finally { conn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = from.CustomerSelect1(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        while (dr.Read())
                        {
                            //listBox1.Items.Clear();   
                            listBox1.Items.Add("Last Name: \t\t\t\t<" + dr[1].ToString() + ">");
                            listBox1.Items.Add("FirstName: \t\t\t\t<" + dr[2].ToString() + ">");
                            listBox1.Items.Add("Middle Name: \t\t\t\t<" + dr[3].ToString() + ">");
                            listBox1.Items.Add("Contact #: \t\t\t\t<" + dr[4].ToString() + ">");
                            listBox1.Items.Add("Address: \t\t\t\t\t<" + dr[5].ToString() + ">");
                            listBox1.Items.Add("Balance: \t\t\t\t\t<" + dr[6].ToString() + ">");
                            listBox1.Items.Add("No of Companion: \t\t\t\t<" + dr[7].ToString() + ">");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("");
                        }
                    }
                    else
                    {
                        listBox1.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("click on the item");
            }
            finally { conn.Close(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    from.N________ = textBox1.Text; 
                    SqlDataReader dr = from.CustomerSelect1Search(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        while (dr.Read())
                        {
                            //listBox1.Items.Clear();   
                            listBox1.Items.Add("Last Name: \t\t\t\t<" + dr[1].ToString() + ">");
                            listBox1.Items.Add("FirstName: \t\t\t\t<" + dr[2].ToString() + ">");
                            listBox1.Items.Add("Middle Name: \t\t\t\t<" + dr[3].ToString() + ">");
                            listBox1.Items.Add("Contact #: \t\t\t\t<" + dr[4].ToString() + ">");
                            listBox1.Items.Add("Address: \t\t\t\t\t<" + dr[5].ToString() + ">");
                            listBox1.Items.Add("Balance: \t\t\t\t\t<" + dr[6].ToString() + ">");
                            listBox1.Items.Add("No of Companion: \t\t\t\t<" + dr[7].ToString() + ">");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("");
                        }
                    }
                    else
                    {
                        listBox1.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

               // MessageBox.Show("click on the item");
            }
            finally { conn.Close(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
