using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;   

namespace OrderManagementSystem
{
    public partial class Form5 : Form
    {
        double DETECTOR_USERNAME;
        double k;
        Class1 addd = new Class1();
        Class3 update = new Class3();
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPEG Images|*.jpg";
            o.AddExtension = true;
            o.RestoreDirectory = true;
            o.Title = textBox1.Text + "Insert Image";
            o.InitialDirectory = @"D:/";
            string choosen_file = "";
            if (o.ShowDialog() != DialogResult.Cancel)
            {
                choosen_file = o.FileName;
                pictureBox1.Image = Image.FromFile(choosen_file);
            }
            o.Dispose();
            o = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DETECTOR_USERNAME == 6)
            {
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;


                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        k = Convert.ToDouble(textBox9.Text) + 1;
                        SqlCommand cmd = new SqlCommand("INSERT INTO Customer(CustPict,CustLN,CustFN,CustPhone,CustAddress,CustBalance,CustLimit,CustDate,CustNumber)VALUES(@Pic,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Convert.ToDouble(textBox5.Text) + "','" + Convert.ToDouble(textBox6.Text) + "','" + DateTime.Now.ToString() + "','" + "cust_" + k + "')", conn);

                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        cmd.Parameters.AddWithValue("@Pic", pic);
                        cmd.ExecuteNonQuery();

                        StreamWriter writer = new StreamWriter(@"D:\Customer.txt", true);

                        writer.WriteLine("LastName: " + textBox1.Text);
                        writer.WriteLine("FirstName: " + textBox2.Text);
                        writer.WriteLine("Phone: " + textBox3.Text);
                        writer.WriteLine("Address: " + textBox4.Text);
                        writer.WriteLine("Limit: " + textBox6.Text);
                        writer.WriteLine("======================================================================================\n\n");
                        writer.Close();


                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show(textBox1.Text + "  " + textBox2.Text + " is added to list ", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            listBox1.Items.Clear();
                        }
                    }
                }

                catch (Exception)
                {

                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Enter values", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {

                    }
                }
                finally { conn.Close(); }

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
            if (DETECTOR_USERNAME == 5)
            {
                MessageBox.Show("UserNAme is already registered");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    addd.LIKEeeee = textBox7.Text;  
                    SqlDataReader dr = addd.searchcust(conn);  
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        listBox1.Items.Clear();
                        addd.CUSTIDDD.Clear();

  
                        while (dr.Read())
                        {
                           
                                listBox1.Items.Add(dr[2].ToString() + "   , " + dr[3].ToString());
                                addd.CUSTIDDD.Add(dr[0]);
                        
                        }
                    }
                    else 
                    {
                        listBox1.Items.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                       // textBox7.Clear();

                    }
                }
            }
            catch (Exception u)
            {
                MessageBox.Show(u.ToString())  ; 
                
                
            }
            finally { conn.Close(); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                addd.KKK = Convert.ToInt32(addd.CUSTIDDD[listBox1.SelectedIndex]);  
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustID = '" + addd.KKK  + "'", conn);
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
                    SqlDataReader dr = addd.searchcustclick(conn);  
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            textBox1.Text = dr[2].ToString();
                            textBox2.Text = dr[3].ToString();
                            textBox3.Text = dr[4].ToString();
                            textBox4.Text = dr[5].ToString();
                            textBox5.Text = dr[6].ToString();
                            textBox6.Text = dr[7].ToString();
                            textBox8.Text = dr[0].ToString();  
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
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            textBox5.Text = "0.00"; 
            textBox9.Visible = false;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true; 
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
                            
                            dataGridView1.Rows.Add(dr[2].ToString() + "  " + dr[3].ToString(),dr[4].ToString(),dr[5].ToString(),dr[6].ToString(),dr[7].ToString(),dr[9].ToString());  
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
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = addd.HighestCustomerID(conn);
                    if (dr.HasRows)
                    {
                        textBox9.Clear();
                        while (dr.Read())
                        {
                            textBox9.Text = dr[0].ToString();
                        }
                    }
                    else { textBox9.Text = "0"; }
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            listBox1.Items.Clear();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true; 
          
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET CustPict = @Pic WHERE CustID ='" + textBox8.Text + "'", conn);

                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Pic", pic);
                    cmd.ExecuteNonQuery();
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show(" Change! ", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                        pictureBox1.Image = null; 
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

                    update.CUSTOMERid = Convert.ToDouble(textBox8.Text);
                    update.LAST = textBox1.Text;
                    update.FIRST = textBox2.Text;
                    update.CONTACT = textBox3.Text;
                    update.ADDRESS = textBox4.Text;
                    update.MINI = Convert.ToDouble(textBox6.Text);
                    update.UpdateCustomerInformation(conn);


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    listBox1.Items.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.Source + ex.StackTrace);  
            }
            finally { conn.Close(); }

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

                            dataGridView1.Rows.Add(dr[2].ToString() + "  " + dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),dr[9].ToString());
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

        private void button4_Click(object sender, EventArgs e)
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
                    addd.CCIIII = textBox1.Text;
                    SqlDataReader dr = addd.RedundantDatas(conn);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            MessageBox.Show(dr[2].ToString() + " IS already Registered");
                            DETECTOR_USERNAME = 5;
                        }
                    }
                    else
                    {
                        DETECTOR_USERNAME = 6;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
    }
}
