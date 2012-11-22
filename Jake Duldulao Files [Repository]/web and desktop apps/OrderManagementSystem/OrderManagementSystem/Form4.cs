using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderManagementSystem
{
    public partial class Form4 : Form
    {
        Class2 or = new Class2(); 
        CustomerOrders orders = new CustomerOrders();
        public string Valuein6name = "";
        public string Vualue6ID = "";
        Class3 warnings = new Class3();
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        transactions customerorderss = new transactions(); 
        public string ValueinForm7name;
        public string ValueinForm7id;
      
        double subtotal2;
        double total2 = 0;
        
        double total = 0;
        public Form4()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    orders.LIKEE = textBox5.Text;
                    SqlDataReader dr = orders.Search(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1].ToString(), dr[3].ToString(), dr[2].ToString(), dr[7].ToString(), dr[6].ToString());
                        }
                    }
                    else { dataGridView1.Rows.Clear(); }
                }
                else
                {
                    dataGridView1.Rows.Clear();  
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
            //try
            //{
            //    dataGridView2.Rows.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString());

            //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //    {
            //        this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            //        this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            //        Column18.Items.Clear();   
            //        Column18.Items.Add("1");
            //        Column18.Items.Add("2");
            //        Column18.Items.Add("3");
            //        Column18.Items.Add("4");
            //        Column18.Items.Add("5");
            //        Column18.Items.Add("6");
            //        Column18.Items.Add("7");
            //        Column18.Items.Add("8");
            //        Column18.Items.Add("9");
            //        Column18.Items.Add("10");
            //        Column18.Items.Add("11");
            //        Column18.Items.Add("12");
            //        dataGridView2.Columns[1].ReadOnly = true;
            //        dataGridView2.Columns[2].ReadOnly = true;
            //        dataGridView2.Columns[3].ReadOnly = true;
            //        dataGridView2.Columns[4].ReadOnly = true;
            //        dataGridView2.Columns[5].ReadOnly = true;
            //        dataGridView2.Columns[7].ReadOnly = true;
            //        dataGridView2.Columns[8].ReadOnly = true;
            //    }
            //}
            //catch (Exception)
            //{

            //    DialogResult okay = new DialogResult();
            //    okay = MessageBox.Show("Invalid. Click the Products you want to order.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    if (okay == DialogResult.OK)
            //    {
            //        Application.DoEvents();
            //    }
            //}
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (double.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString()) > 0)
                {
                    try
                    {
                        if (e.ColumnIndex == 6)
                        {
                            if (dataGridView2.CurrentRow.Cells[6].Value != null)
                            {
                                double subtotal = 0;
                                double mtotal2 = total2;
                                if (double.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()) >= double.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString()))
                                {

                                    subtotal = double.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()) - double.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString());
                                    dataGridView2.CurrentRow.Cells[7].Value = subtotal.ToString();
                                    total += subtotal;
                                    if (double.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString()) >= double.Parse(dataGridView2.CurrentRow.Cells[7].Value.ToString()))
                                    {
                                        DialogResult okay = new DialogResult();
                                        okay = MessageBox.Show("You need to Order new Sets of " + dataGridView2.CurrentRow.Cells[1].Value + "  NOW. As soon as possible\n\nthe Company has only:   " + dataGridView2.CurrentRow.Cells[7].Value.ToString() + " Items.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        if (okay == DialogResult.OK)
                                        {
                                            Application.DoEvents();
                                        }
                                    }
                                    subtotal2 = double.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString()) * double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                                    dataGridView2.CurrentRow.Cells[8].Value = string.Format("{0:N2}", subtotal2);
                                }
                                else
                                {
                                    DialogResult okay = new DialogResult();
                                    okay = MessageBox.Show(dataGridView2.CurrentRow.Cells[1].Value.ToString() + " has no enough Quantities. It has only " + dataGridView2.CurrentRow.Cells[3].Value + "  Items. ", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (okay == DialogResult.OK)
                                    {
                                        Application.DoEvents();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Invalid. check the number of items you entered.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                    double f = 0;
                    try
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            label14.Text = "Successfully added...";
                            f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[8].Value.ToString());
                            textBox7.Text = f.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        label14.Text = "Waiting..";
                    }
                    try
                    {
                        int a = Convert.ToInt32(dataGridView2.CurrentRow.Cells[9].Value.ToString());
                        DateTime NextMonth = System.DateTime.Now.AddMonths(a);
                        dataGridView2.CurrentRow.Cells[10].Value = NextMonth.ToString();
                    }
                    catch (Exception)
                    {
                        label14.Text = "Waiting..";
                    }
                }
                else
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Negative value is not allowed!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView2.CurrentRow.Cells[8].Value = null;
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception)
            {
               DialogResult okay = new DialogResult();
                okay = MessageBox.Show("String value is not allowed!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView2.CurrentRow.Cells[8].Value = null;   
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //textBox6.Text = DateTime.Now.ToString();
            //textBox4.Text = DateTime.Now.ToString("hh:  mm:  ss   tt");
            textBox9.Text = this.ValueinForm7name;
            textBox10.Text = this.ValueinForm7id;
            textBox5.Enabled = false;
            textBox11.Enabled = false;
            button2.Visible = false;
            button3.Visible = false;  
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].ReadOnly = true; 

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = warnings.Warnings(conn);
  
                    if (dr.HasRows)
                    {
                        dataGridView3.Rows.Clear();  
                        while (dr.Read())
                        {
                            dataGridView3.Rows.Add(dr[0].ToString(),dr[2].ToString(),dr[1].ToString(),"<Order new Quantities to the supplier.>"); 
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustNumber = '" + textBox2.Text + "'", conn);
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

               // textBox2.Clear();
            }

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    orders.CustNUMBER = textBox2.Text;
                    SqlDataReader dr = orders.Searchcustomer(conn);
                    if (dr.HasRows)
                    {
                       // textBox13.Clear();
                        while (dr.Read())
                        {
                            pictureBox1.BringToFront();  
                            textBox1.Text = dr[2].ToString();
                            textBox3.Text = dr[0].ToString();
                            textBox8.Text = dr[3].ToString();
                            textBox13.Text = dr[6].ToString();
                            textBox15.Text = dr[7].ToString();
                            if (double.Parse(textBox13.Text) >= double.Parse(textBox15.Text))
                            {
                                textBox5.Enabled = false;
                                button2.Visible = false;
                                button3.Visible = false;
                                textBox11.Enabled = false;
                                textBox14.Clear();
                                textBox5.Clear(); 
                                 
                                DialogResult okay = new DialogResult();
                                okay = MessageBox.Show("Warning. Customer already reached the MAXIMUM LIMIT:\n\n" + "BALANCE:  " + textBox13.Text + "\n" + "LIMIT:  " + textBox15.Text, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (okay == DialogResult.OK)
                                {
                                    Application.DoEvents();
                                }
                            }
                            else
                            {
                                button3.Visible = true;
                                textBox5.Enabled = true;
                                button2.Visible = true;
                                textBox11.Enabled = true;
                              
                            }
                        }
                    }
                    else
                    {
                        textBox15.Clear();  
                        textBox3.Clear();
                        textBox8.Clear();
                        textBox1.Clear();
                        pictureBox2.BringToFront();
                        textBox13.Clear();
                        textBox5.Clear();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                        textBox7.Clear();
                        textBox14.Clear();  
                        textBox5.Enabled = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        textBox11.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                pictureBox2.BringToFront();  
                    textBox8.Clear();
                    textBox1.Clear();
                    textBox3.Clear();
                
            }
            finally { conn.Close(); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            try
            {
            or.CUSTFN = textBox8.Text;
            or.CUSTLN = textBox1.Text;
            or.CUSTIDD = Convert.ToDouble(textBox3.Text);
            or.EMPIDD = Convert.ToDouble(textBox10.Text);  
            or.CREDITCARDNUMBER = textBox11.Text;
            or.FLAG = textBox12.Text;
            or.TOTAL = Convert.ToDouble(textBox7.Text);
            or.NEWbal = Convert.ToDouble(textBox14.Text);  
            or.Createordertocustomer(dataGridView2);
            textBox11.Clear();
            textBox12.Clear();
            textBox7.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox11.Clear();
            textBox12.Clear();
            pictureBox1.Image = null;
            textBox11.Enabled = false;
            textBox5.Enabled = false; 
            button3.Visible = false;
            button2.Visible = false;
            textBox14.Clear();  
            
            }
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Enter you Credit card number and the Flag.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }  
            }

            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;


            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = warnings.Warnings(conn);

                    if (dr.HasRows)
                    {
                        dataGridView3.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView3.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), "<Order new Quantities to the supplier.>");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = dataGridView2.Rows.Count;
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[11].Value != null)
                    {   
                        dataGridView2.Rows.Remove(dataGridView2.Rows[i]);  
                    }
                }
            }
            catch (Exception)
            {
                
                label14.Text = "Successfully added...";
            }
            
            double f = 0;
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    label14.Text = "Successfully added...";
                    f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[8].Value.ToString());
                    textBox7.Text = f.ToString();

                }

            }
            catch (Exception)
            {

                label14.Text = "Waiting..";
            }

            if (x==0)
            {
                textBox7.Text = "";     
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                textBox6.Text  = DateTime.Now.ToString("hh:  mm:  ss   tt");
                textBox4.Text  = DateTime.Now.ToString("hh:  mm:  ss   tt");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox12.Text = radioButton1.Text;
   
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox12.Text = radioButton2.Text;

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox7.Text);
                double y = Convert.ToDouble(textBox13.Text);
                double z;

                z = x + y;
                textBox14.Text = z.ToString();  

            }
            catch (Exception)
            {
                
                label15.Text = "."  ;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox7.Text);
                double y = Convert.ToDouble(textBox13.Text);
                double z;

                z = x + y;
                textBox14.Text = z.ToString();

            }
            catch (Exception)
            {

                label15.Text = ".";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    try
                    {
                        dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString());
                        dataGridView1.Rows[i].Cells[6].Value = null;
                        for (int h = 0; h < dataGridView2.Rows.Count; h++)
                        {
                            this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                            Column18.Items.Clear();
                            Column18.Items.Add("1");
                            Column18.Items.Add("2");
                            Column18.Items.Add("3");
                            Column18.Items.Add("4");
                            Column18.Items.Add("5");
                            Column18.Items.Add("6");
                            Column18.Items.Add("7");
                            Column18.Items.Add("8");
                            Column18.Items.Add("9");
                            Column18.Items.Add("10");
                            Column18.Items.Add("11");
                            Column18.Items.Add("12");
                            dataGridView2.Columns[1].ReadOnly = true;
                            dataGridView2.Columns[2].ReadOnly = true;
                            dataGridView2.Columns[3].ReadOnly = true;
                            dataGridView2.Columns[4].ReadOnly = true;
                            dataGridView2.Columns[5].ReadOnly = true;
                            dataGridView2.Columns[7].ReadOnly = true;
                            dataGridView2.Columns[8].ReadOnly = true;
                        }

                    }
                    catch (Exception)
                    {

                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Invalid. Click the Products you want to order.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                }

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
