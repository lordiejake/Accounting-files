using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;       
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;  
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class Form8 : Form
    {
        PaymentsTransactions Payment = new PaymentsTransactions(); 
        Class1 addd = new Class1();
        Class4 gett = new Class4();
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        public string IDD = "";
        public string nameM = "";
        DataSet printJkk = new Printing.DataSet3();
        public Form8()
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
                    addd.LIKEeeee = textBox1.Text;
                    SqlDataReader dr = addd.searchcust(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        addd.CUSTIDDD.Clear();
                        dataGridView1.Rows.Clear();
                        listBox2.Items.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox6.Enabled = false;  

                        while (dr.Read())
                        {
                            listBox1.Items.Add(dr[2].ToString() + ",  "+ dr[3].ToString());
                            addd.CUSTIDDD.Add(dr[0]);
                            pictureBox3.BringToFront();
                        }
                    }
                    else
                    {
                        listBox1.Items.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        dataGridView1.Rows.Clear();
                        listBox2.Items.Clear();
                        textBox6.Enabled = false;

                    }
                }
            }
            catch (Exception)
            {


            }
            finally { conn.Close(); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                addd.KKK = Convert.ToInt32(addd.CUSTIDDD[listBox1.SelectedIndex]);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustID = '" + addd.KKK + "'", conn);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("MyImages");
                byte[] mydata = new byte[0];
                dp.Fill(ds, "MyImages");
                DataRow Myrow;
                Myrow = ds.Tables["MyImages"].Rows[0];
                mydata = (byte[])Myrow["CustPict"];
                MemoryStream stream = new MemoryStream(mydata);
                pictureBox1.Image = Image.FromStream(stream);
                textBox6.Enabled = false; 
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }

            try
            {
                addd.KKK = Convert.ToInt32(addd.CUSTIDDD[listBox1.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    
                    SqlDataReader dr = addd.SelectCustomerOrders(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        dataGridView1.Rows.Clear();  
                        addd.CUSTIDDDDDDDDDD.Clear();
                        
                        while (dr.Read())
                        {
                            listBox2.Items.Add(dr[4].ToString() + "   \t" + dr[1].ToString() + "   , " + dr[2].ToString() + "     Total:  \t" + dr[3].ToString() + "\tclick here to view details:");
   
                            addd.CUSTIDDDDDDDDDD.Add(dr[5].ToString());
                            textBox6.Enabled = false; 
                            
                        }
                    }
                    else
                    {
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        listBox2.Items.Clear();
                        dataGridView1.Rows.Clear();
                        pictureBox3.BringToFront();
                        dataGridView1.Rows.Clear();  

                    }
                }
            }
            catch (Exception)
            {


            }
            finally { conn.Close(); }

            try
            {
                addd.KKK = Convert.ToInt32(addd.CUSTIDDD[listBox1.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader dr = addd.SelectCustomersbyBalance(conn);
                    if (dr.HasRows)
                    {
                        textBox8.Clear();  

                        while (dr.Read())
                        {
                            textBox8.Text = dr[6].ToString();  
                            textBox6.Enabled = false;

                        }
                    }
                    else
                    {
                        

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

            try
            {
                addd.CUSTIDENTs = Convert.ToInt32(addd.CUSTIDDDDDDDDDD[listBox2.SelectedIndex]);
                SqlCommand cmd = new SqlCommand("SELECT        Sales.SalesNO, Employee.EmpID, Employee.EmpPict, Employee.EmpLN, Employee.EmpFN, Employee.Phone FROM            Employee INNER JOIN   Sales ON Employee.EmpID = Sales.EmpID INNER JOIN  SalesData ON Sales.SalesNO = SalesData.SalesNO WHERE SalesData.SalesNO = '" + addd.CUSTIDENTs + "'", conn);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("MyImages");
                byte[] mydata = new byte[0];
                dp.Fill(ds, "MyImages");
                DataRow Myrow;
                Myrow = ds.Tables["MyImages"].Rows[0];
                mydata = (byte[])Myrow["EmpPict"];
                MemoryStream stream = new MemoryStream(mydata);
                pictureBox2.BringToFront();  
                pictureBox2.Image = Image.FromStream(stream);
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
           // addd.CUSTIDENTs = Convert.ToInt32(addd.CUSTIDDDDDDDDDD[listBox2.SelectedIndex]);
            //MessageBox.Show(addd.CUSTIDENTs.ToString());  
            try
            {
                addd.CUSTIDENTs = Convert.ToInt32(addd.CUSTIDDDDDDDDDD[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.SelectCustomerOrders_Detailed(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(),dr[1].ToString(),dr[6].ToString(),dr[3].ToString(),dr[5].ToString());
                            textBox6.Enabled = true; 
                        }
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }



            try
            {
                addd.CUSTIDENTs = Convert.ToInt32(addd.CUSTIDDDDDDDDDD[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.SalesDataMoney(conn);
                    if (dr.HasRows)
                    {
                        textBox4.Clear();
                        textBox5.Clear();  
                        while (dr.Read())
                        {
                            textBox4.Text = dr[10].ToString();
                            textBox5.Text = dr[9].ToString(); 
                            textBox6.Enabled = true;   
                        }
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.SelectCustomerOrders_Detailed2(conn);
                    if (dr.HasRows)
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                        while (dr.Read())
                        {
                            textBox2.Text = dr[3].ToString();
                            textBox3.Text = dr[4].ToString();
                            textBox6.Enabled = true; 

                        }
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

            try
            {
                if ((double.Parse(textBox5.Text)) >= (double.Parse(textBox6.Text)))
                {
                    double x = Convert.ToDouble(textBox5.Text);
                    double y = Convert.ToDouble(textBox6.Text);
                    double w = Convert.ToDouble(textBox8.Text);
                    double v;
                    double z;

                    z = x - y;
                    textBox9.Text = z.ToString();

                    v = w - y;
                    textBox7.Text = v.ToString();
                }
                else
                {
                    textBox9.Text = "You reached the max. amount";
                }

            }
            catch (Exception)
            {

                textBox9.Text = "<Waiting...>";
            }

            try
            {
                addd.CUSTIDENTs = Convert.ToInt32(addd.CUSTIDDDDDDDDDD[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.SelectCustomerOrders_TotalPaaids(conn);
                    if (dr.HasRows)
                    {
                        textBox12.Clear();
                        while (dr.Read())
                        {
                            textBox12.Text = dr[0].ToString();
                            textBox6.Enabled = true;
                        }
                    }
                    else 
                    {
                        textBox12.Text = "0"; 
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(textBox5.Text)) >= (double.Parse(textBox6.Text)))
                {
                    double x = Convert.ToDouble(textBox5.Text);
                    double y = Convert.ToDouble(textBox6.Text);
                    double w = Convert.ToDouble(textBox8.Text);
                    double v;
                    double z;

                    z = x - y;
                    textBox9.Text = z.ToString();

                    v = w - y;
                    textBox7.Text = v.ToString();
                }
                else
                {
                    textBox9.Text = "You reached the max. amount"; 
                }

            }
            catch (Exception)
            {

                textBox9.Text = "<Waiting...>";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            textBox10.Text = this.IDD;
            textBox11.Text = this.nameM; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Payment.EMPID2 = Convert.ToDouble(textBox10.Text);
                Payment.TOTALL2 = Convert.ToDouble(textBox6.Text);
                Payment.REMAIN2 = Convert.ToDouble(textBox9.Text);
                Payment.CUSTBAL2 = Convert.ToDouble(textBox7.Text);
                Payment.TOTALPAYMENTSSSSSSSSS = Convert.ToDouble(textBox5.Text);
                Payment.BALANCEEEEEEEE = Convert.ToDouble(textBox9.Text);
                Payment.CreatePaymentsReceipt(addd.KKK, addd.CUSTIDENTs);
               
            }
            catch (Exception)
            {        
                MessageBox.Show("Error. Enter credit");  
            }
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = gett.ViewhighestReceiptNO(conn);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            label10.Text = dr[0].ToString();
                        }
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
                addd.CUSTIDENTs = Convert.ToInt32(addd.CUSTIDDDDDDDDDD[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.SelectCustomerOrders_TotalPaaids(conn);
                    if (dr.HasRows)
                    {
                        textBox12.Clear();
                        while (dr.Read())
                        {
                            textBox12.Text = dr[0].ToString();
                            textBox6.Enabled = true;
                        }
                    }
                    else
                    {
                        textBox12.Text = "0";
                    }
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    printJkk.Tables["DataTable1"].Rows.Add(item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), textBox6.Text, textBox4.Text, textBox5.Text, textBox12.Text, item.Cells[0].Value.ToString(), label10.Text, addd.CUSTIDENTs.ToString(),textBox9.Text);
                }

                Printing.print3 frm = new OrderManagementSystem.Printing.print3();
                frm.Prints = printJkk;
                frm.ShowDialog();
                printJkk.Tables["DataTable1"].Rows.Clear();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    printJkk.Tables["DataTable1"].Rows.Add(item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), textBox6.Text, textBox4.Text, textBox5.Text, textBox12.Text, item.Cells[0].Value.ToString(),"", addd.CUSTIDENTs.ToString(), textBox9.Text);
                }

                Printing.print3 frm = new OrderManagementSystem.Printing.print3();
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
