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
    public partial class Form19 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class2 Returns = new Class2();
        Class1 d = new Class1(); 
        public string Empname = "";
        public string EmpID = "";
        public Form19()
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
                    Returns.SUPLNe = textBox1.Text;
                    SqlDataReader dr = Returns.SupplierReturns(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();
                        Returns.RETURNZID.Clear();
                        Returns.SUPIDiD.Clear();   
                        while (dr.Read())
                        {
                            listBox2.Items.Add("Order#:"+dr[0].ToString() + "   " + dr[1].ToString() + "\t" + dr[2].ToString() + "   " + dr[3].ToString() + "\t    Company: " + dr[4].ToString() + "    \t   Total:\t  " + dr[7].ToString());
                            Returns.RETURNZID.Add(dr[0]);
                            Returns.SUPIDiD.Add(dr[6].ToString());   
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

                throw;
            }
            finally { conn.Close(); }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;
            dataGridView1.Columns[9].ReadOnly = true;
            dataGridView1.Columns[10].ReadOnly = true;
            try
            {
                Returns.RETID = Convert.ToInt32(Returns.RETURNZID[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader dr = Returns.DDDDDDIDDD(conn);
                    if (dr.HasRows)
                    {
                        textBox15.Clear();
                        while (dr.Read())
                        {
                            textBox15.Text = dr[0].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {

                label13.Text = ".";
            }
            finally { conn.Close(); }
            try
            {
                Returns.RETID  = Convert.ToInt32(Returns.RETURNZID[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Returns.SupplierReturns212(conn);
                    if (dr.HasRows)
                    {
                        textBox3.Clear();
                        textBox10.Clear();
                        textBox12.Clear();  
                        dataGridView1.Rows.Clear();    
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[2].ToString(),dr[3].ToString(),dr[5].ToString(),dr[11].ToString(),dr[12].ToString(),dr[13].ToString(),dr[1].ToString(),"0","","","",DateTime.Now.ToString(),dr[8].ToString(),"",dr[0].ToString());
      
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                DateTime startdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[11].Value.ToString());
                                DateTime endDate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[12].Value.ToString());
                                if (startdate >= endDate)
                                {
                                    dataGridView1.Columns[13].ReadOnly = true;
                                    dataGridView1.Columns[12].ReadOnly = true;
                                    dataGridView1.Rows[i].Cells[13].Value = "Expired";
                                    dataGridView1.Rows[i].Cells[13].Style.ForeColor = Color.Red;
                                    dataGridView1.Rows[i].Cells[8].Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                    dataGridView1.Rows[i].Cells[9].Value = dataGridView1.Rows[i].Cells[5].Value.ToString();
                                    dataGridView1.Rows[i].Cells[10].Value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                                    dataGridView1.Rows[i].Cells[7].ReadOnly = true;

                                }
                                else
                                {
                                    dataGridView1.Columns[13].ReadOnly = true;
                                    dataGridView1.Columns[12].ReadOnly = true;
                                    dataGridView1.Rows[i].Cells[13].Value = "Return accepted";
                                    dataGridView1.Rows[i].Cells[13].Style.ForeColor = Color.Green;
                                }
                            }
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

                label13.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                Returns.IDSupK = Convert.ToInt32(Returns.SUPIDiD[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Returns.SupplierBalance(conn);
                    if (dr.HasRows)
                    {
                        textBox2.Clear();
                        textBox5.Clear();
                        textBox13.Clear();
                        textBox14.Clear();
                        textBox17.Clear();  
                        while (dr.Read())
                        {
                            textBox5.Text = dr[0].ToString();  
                            textBox2.Text = dr[4].ToString();
                            textBox13.Text = dr[2].ToString();
                            textBox14.Text = dr[1].ToString();
                            textBox17.Text = dr[3].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {

                label13.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                Returns.RETID = Convert.ToInt32(Returns.RETURNZID[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Returns.SupplierTOTAL(conn);
                    if (dr.HasRows)
                    {
                        textBox4.Clear();  
                        while (dr.Read())
                        {
                            textBox4.Text = dr[9].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {

                label13.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                Returns.RETID = Convert.ToInt32(Returns.RETURNZID[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Returns.SupplierTOTALpaid(conn);
                    if (dr.HasRows)
                    {
                        textBox8.Clear();
                        while (dr.Read())
                        {
                            textBox8.Text = dr[0].ToString();
                        }
                    }
                    else
                    {
                        textBox8.Text = "0.00"; 
                    }
                }
            }
            catch (Exception)
            {

                label13.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                Returns.RETID = Convert.ToInt32(Returns.RETURNZID[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Returns.SupplierTOTAL(conn);
                    if (dr.HasRows)
                    {
                        textBox9.Clear();
                        while (dr.Read())
                        {
                            textBox9.Text = dr[8].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {

                label13.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()) >= 0)
                {
                    if (double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) >= double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()))
                    {
                        try
                        {
                            if (double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) >= double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()))
                            {
                                if (e.ColumnIndex == 7)
                                {
                                    if (dataGridView1.CurrentRow.Cells[6].Value != null)
                                    {
                                        double x = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                                        double y = double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                                        double result;
                                        result = y - x;
                                        dataGridView1.CurrentRow.Cells[8].Value = result.ToString();
                                        double xx = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                                        double yy = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                                        double resultt;
                                        resultt = xx - yy;
                                        dataGridView1.CurrentRow.Cells[10].Value = resultt.ToString();
                                        double xxx = double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                        double yyy = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                                        double resulttc;
                                        resulttc = xxx * yyy;
                                        dataGridView1.CurrentRow.Cells[15].Value = resulttc.ToString();
                                        double z = resultt;
                                        double a = double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                        double resulttt = z * a;
                                        dataGridView1.CurrentRow.Cells[9].Value = resulttt.ToString();
                                    }
                                }
                            }
                            else
                            {
                                dataGridView1.CurrentRow.Cells[7].Value = "0";
                                dataGridView1.CurrentRow.Cells[8].Value = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                                dataGridView1.CurrentRow.Cells[10].Value = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                                dataGridView1.CurrentRow.Cells[9].Value = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                            }
                        }
                        catch (Exception)
                        {
                            dataGridView1.CurrentRow.Cells[8].Value = null;
                            dataGridView1.CurrentRow.Cells[9].Value = null;
                            dataGridView1.CurrentRow.Cells[10].Value = null;
                            dataGridView1.CurrentRow.Cells[7].Value = "incorrect input";
                            dataGridView1.CurrentRow.Cells[8].Value = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        }
                        double f = 0;
                        try
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                label13.Text = ".";
                                f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value.ToString());
                                textBox3.Text = f.ToString();
                            }
                        }
                        catch (Exception)
                        {
                            label13.Text = ".";
                        }
                        double f1 = 0;
                        try
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                label13.Text = ".";
                                f1 = double.Parse(f1.ToString()) + Convert.ToDouble(dataGridView1.Rows[i].Cells[15].Value.ToString());
                                textBox16.Text = f1.ToString();
                            }
                        }
                        catch (Exception)
                        {
                            label13.Text = ".";
                        }
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("You cant return that product. \nProduct Stoct: " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "\nProduct returned quantuty: " + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "\n\nError in Quantity returns: Not allow!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridView1.CurrentRow.Cells[15].Value = null;
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();

                        }
                    }
                }
                else
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Negative is not allowed", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.CurrentRow.Cells[15].Value = null;
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception)
            {               
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("String value is not allowed", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.CurrentRow.Cells[15].Value = null;
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();

                }
            }           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            textBox7.Text = this.Empname;
            textBox6.Text = this.EmpID;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE EmpID = '" + textBox6.Text + "'", conn);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("MyImages");
                byte[] mydata = new byte[0];
                dp.Fill(ds, "MyImages");
                DataRow Myrow;
                Myrow = ds.Tables["MyImages"].Rows[0];
                mydata = (byte[])Myrow["EmpPict"];
                MemoryStream stream = new MemoryStream(mydata);
                pictureBox1.Image = Image.FromStream(stream);
            }
            catch (Exception)
            {

                // textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox3.Text) >= double.Parse(textBox8.Text))
                {
                    label14.Visible = false;
                    textBox12.Visible = false;
                    double k = double.Parse(textBox3.Text);
                    double z = double.Parse(textBox8.Text);
                    double result = k - z;
                    textBox11.Text = result.ToString();

                    double f = double.Parse(textBox2.Text);
                    double g = double.Parse(textBox9.Text);
                    double diff = f - g;
                    double sum = diff + result;
                    textBox10.Text = sum.ToString();   
                }
                else
                {
                    double n = double.Parse(textBox8.Text);
                    double m = double.Parse(textBox3.Text);
                    double nn = double.Parse(textBox2.Text);
                    double mm = double.Parse(textBox9.Text);
                    double MMNN = nn - mm;
                    textBox10.Text = MMNN.ToString();
                    double mn = n - m;
                    textBox11.Text = "0";
                    label14.Visible = true;
                    textBox12.Visible = true;
                    textBox12.Text = mn.ToString();
                   
                }
                
            }
            catch (Exception)
            {

                label13.Text = ".";
            }
             
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    d.CID = Convert.ToDouble(textBox5.Text);
                    d.NEWSUPBAL = Convert.ToDouble(textBox10.Text);  
                    d.SSSSupfn = textBox13.Text;
                    d.SSSSupln = textBox14.Text;
                    d.SSSSupid = Convert.ToDouble(textBox5.Text);
                    d.EEEEEEmpid = Convert.ToDouble(textBox6.Text);
                    d.TTTTTTTotal = Convert.ToDouble(textBox16.Text);
                    d.SSSSSupcompani = textBox17.Text;
                    d.TIDDDDDDDD = Convert.ToDouble(textBox15.Text);  
                    d.TTALL = Convert.ToDouble(textBox3.Text);
                    d.UPDsales = Convert.ToDouble(textBox11.Text);  
                    d.AddDeliveryReturns(dataGridView1); 
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }  

   }
 }
