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
    public partial class Form14 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        public string Empname = "";
        public string EmpID = "";
        Class4 supply = new Class4();
        PaymentsTransactions payments = new PaymentsTransactions(); 
        public Form14()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    supply.Lname = textBox1.Text;  
                    SqlDataReader dr = supply.ViewSupplier(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        textBox4.Clear();  
                        supply.SUPID.Clear();
                        textBox2.Clear();
                        textBox9.Clear(); 
                        while (dr.Read())
                        {
                            listBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString() + "   Compny: " + dr[3].ToString());
                            supply.SUPID.Add(dr[0]);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        textBox4.Clear();  
                        textBox2.Clear();
                        textBox9.Clear(); 
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //supply.IDSUP = Convert.ToInt32(supply.SUPID[listBox1.SelectedIndex]);
            //MessageBox.Show(supply.IDSUP.ToString());  
            try
            {
                supply.IDSUP = Convert.ToInt32(supply.SUPID[listBox1.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader dr = supply.ViewSupplierDelivery(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();
                        dataGridView1.Rows.Clear();
                        supply.DELIVERYNUM.Clear();
                        textBox4.Clear();
                        textBox2.Clear();
                        textBox5.Clear();
                        textBox3.Clear();
                        textBox6.Clear();
                        textBox9.Clear();
                        while (dr.Read())
                        {
                            listBox2.Items.Add(dr[0].ToString() + " With the Total of:" + dr[4].ToString() + "Pesos");
                            label10.Text = dr[3].ToString();
                            supply.DELIVERYNUM.Add(dr[2]);
                        }
                    }
                    else
                    {
                        listBox2.Items.Clear();   
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the Items", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();

                }
            }
            finally { conn.Close(); }

            try
            {
                supply.IDSUP = Convert.ToInt32(supply.SUPID[listBox1.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                      
                    SqlDataReader dr = supply.ViewSupplierBalance(conn);
                    if (dr.HasRows)
                    {
                        textBox4.Clear();  
                        while (dr.Read())
                        {
                            textBox4.Text = dr[4].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {

               
            }
            finally { conn.Close(); }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
           // MessageBox.Show(supply.DELIVERYID.ToString());

            try
            {
                supply.DELIVERYID = Convert.ToInt32(supply.DELIVERYNUM[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    
                    SqlDataReader dr = supply.ViewSupplierDeliveryWithProducts(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();  
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(),dr[5].ToString());
                            label9.Text = dr[0].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the Items", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();

                }
            }
            finally { conn.Close(); }

            try
            {
                supply.DELIVERYID = Convert.ToInt32(supply.DELIVERYNUM[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader dr = supply.ViewSupplierDeliveryTotal(conn);
                    if (dr.HasRows)
                    {
                        textBox2.Clear();
                        textBox9.Clear();  
                        while (dr.Read())
                        {
                            textBox2.Text = dr[2].ToString();
                            textBox9.Text = dr[1].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            try
            {
                supply.DELIVERYID = Convert.ToInt32(supply.DELIVERYNUM[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader dr = supply.ViewSupplierDeliveryTotalPaids(conn);
                    if (dr.HasRows)
                    {
                        textBox10.Clear();

                        while (dr.Read())
                        {
                            textBox10.Text = dr[0].ToString();

                        }
                    }
                    else
                    {
                        textBox10.Text = "0.00"; 
                    }
                }
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

           
                try
                {
                    if ((double.Parse(textBox9.Text)) >= (double.Parse(textBox3.Text)))
                    {

                        double Total = Convert.ToDouble(textBox9.Text);
                        double Credit = Convert.ToDouble(textBox3.Text);
                        double Balance = Convert.ToDouble(textBox4.Text);
                        double result = Convert.ToDouble(textBox5.Text);
                        textBox5.Text = (Total - Credit).ToString();
                        result = Convert.ToDouble(textBox5.Text);
                        textBox6.Text = (Balance - Credit).ToString();
                    }
                    else
                    {
                        textBox5.Text = "Max amount already reached";
                    }


                }
                catch (Exception)
                {

                    textBox5.Text = "0.00";
                    textBox6.Clear();
                }
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if ((double.Parse(textBox9.Text)) >= (double.Parse(textBox3.Text)))
                {
                    try
                    {

                        double Total = Convert.ToDouble(textBox9.Text);
                        double Credit = Convert.ToDouble(textBox3.Text);
                        double Balance = Convert.ToDouble(textBox4.Text);
                        double result = Convert.ToDouble(textBox5.Text);
                        textBox5.Text = (Total - Credit).ToString();
                        result = Convert.ToDouble(textBox5.Text);
                        textBox6.Text = (Balance - Credit).ToString();



                    }
                    catch (Exception)
                    {

                        textBox5.Text = "0.00";
                        textBox6.Clear();
                    }
                }
                else { textBox5.Text = "Max amount already reached"; }
            }
            catch (Exception)
            {
                
                MessageBox.Show("string is not allowed");
            }

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            textBox5.Text = "00.0000";
            textBox7.Text = this.EmpID;
            textBox8.Text = this.Empname;
  
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                payments.AMOUNT = Convert.ToDouble(textBox3.Text);
                payments.TOTALL = Convert.ToDouble(textBox3.Text);
                payments.EMPid = Convert.ToDouble(textBox7.Text);
              //  payments.remainingAMOUNT = Convert.ToDouble(textBox5.Text);
                payments.remainingtotal = Convert.ToDouble(textBox5.Text);
                payments.DEL = Convert.ToDouble(label9.Text);
                payments.SUPBAL = Convert.ToDouble(textBox6.Text);
                payments.SUPidentification = Convert.ToDouble(label10.Text);   
                payments.CreatePaymentsdelivery(supply.IDSUP, supply.DELIVERYID);
                listBox2.Items.Clear();
                textBox4.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox3.Clear();
                textBox6.Clear();
                textBox9.Clear();  
                
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
