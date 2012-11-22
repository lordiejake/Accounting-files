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
using System.Collections; 
 

namespace OrderManagementSystem
{
    public partial class Form3 :Form
    {

        public string ValueFromForm7texbox1 = "";
        public string ValueFromForm7texbox2 = "";


        Class1 add = new Class1();
        Class3 COUNT = new Class3(); 
        transactions transact = new transactions();
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        double total = 0;
        double total2 = 0;
  
        public Form3()
        {

            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

                dataGridView1.Rows[i].Cells[1].Value = "0".ToString();
                dataGridView1.Rows[i].Cells[4].Value = "0.00".ToString();
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            add.AddProduct(dataGridView1);

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = COUNT.ZeroQuantity(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        while (dr.Read())
                        {

                            listBox1.Items.Add(">>>>>>>>>>>" + " " + dr[1].ToString());
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

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ProdDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[6].ToString(), dr[0].ToString());
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
                    SqlDataReader dr = COUNT.countAll(conn);
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {

                            label13.Text = dr[0].ToString();
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
                    SqlDataReader dr = COUNT.countZero(conn);
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {

                            label15.Text = dr[0].ToString();
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            int coll = 1;
            int coll2 = 2;
            try
            {
                for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                {
                    if (double.Parse(dataGridView4[coll, i].Value.ToString()) < double.Parse(dataGridView4[coll2, i].Value.ToString()))
                    {

                        dataGridView4[coll, i].Style.ForeColor = Color.Red;
                        dataGridView4[coll2, i].Style.ForeColor = Color.Red;
                        dataGridView4.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                        dataGridView4[coll, i].Style.BackColor = Color.Salmon;
                        dataGridView4[coll2, i].Style.BackColor = Color.Salmon;
                        dataGridView4.Rows[i].Cells[0].Style.BackColor = Color.Salmon;


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


      

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    add.LIKE = textBox4.Text;
                    SqlDataReader dr = add.Search(conn);
                    if (dr.HasRows)
                    {
                        dataGridView3.Rows.Clear();
                        add.PRODUCTID.Clear();
                        while (dr.Read())
                        {
                            
                            dataGridView3.Rows.Add(dr[2].ToString(), dr[0], dr[1].ToString(), dr[4].ToString(), dr[7].ToString(),dr[3].ToString(),dr[5].ToString());
                            add.PRODUCTID.Add(dr[0]);
                        }
                    }
                    else
                    {
                        dataGridView3.Rows.Clear();  
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    transact.LIKES = textBox3.Text; 
                    SqlDataReader dr = transact.Search(conn);
                    if (dr.HasRows)
                    {
                        transact.SUPID.Clear();
                        listBox2.Items.Clear();
                        while (dr.Read())
                        {
                            transact.SUPID.Add(dr[0]);
                            listBox2.Items.Add(dr[1].ToString() + " ," + dr[2].ToString());
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
            try
            {
                transact.IDSUP = Convert.ToInt32(transact.SUPID[listBox2.SelectedIndex]);   
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = transact.ClickSupplier(conn);
                    if (dr.HasRows)
                    {
                        textBox1.Clear();
                        while (dr.Read())
                        {
                            textBox1.Text = dr[3].ToString();
                            textBox8.Text = dr[4].ToString();  
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Click on the item: Create an order!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
               
            }
            finally { conn.Close(); }

            try
            {
                double totaL = Convert.ToDouble(textBox2.Text);
                double balance = Convert.ToDouble(textBox8.Text);
                double result;
                result = totaL + balance;
                textBox9.Text = result.ToString();
            }
            catch (Exception)
            {

                label20.Text = ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise; 
   
                try
                {
                
                transact.company = textBox1.Text;
                transact.TOTALLI = textBox2.Text;
                transact.EMPIDD = Convert.ToDouble(textBox6.Text);
                transact.FLAG = textBox5.Text;
                transact.SUPBAL = Convert.ToDouble(textBox9.Text);   
                transact.CreateorderSupplier5(transact.IDSUP, dataGridView2);
               // transact.CreateorderSupplier(transact.IDSUP, dataGridView2);
                textBox1.Clear();  
                textBox2.Clear();
                textBox5.Clear();
                textBox4.Clear();
                dataGridView3.Rows.Clear();
                textBox3.Clear();
              //  listBox2.Items.Clear();
               
               
                }
                catch (Exception)
                {

                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Invalid. Enter all the Information!.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
 
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = add.ProdDetails(conn);
                        if (dr.HasRows)
                        {
                            dataGridView4.Rows.Clear();
                            while (dr.Read())
                            {
                                dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[6].ToString(),dr[0].ToString());
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
                        SqlDataReader dr = COUNT.ZeroQuantity(conn);
                        if (dr.HasRows)
                        {
                            listBox1.Items.Clear();
                            while (dr.Read())
                            {

                                listBox1.Items.Add(">>>>>>>>>>>" + " " + dr[1].ToString());
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

                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = COUNT.countZero(conn);
                        if (dr.HasRows)
                        {

                            while (dr.Read())
                            {

                                label15.Text = dr[0].ToString();
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
                        SqlDataReader dr = COUNT.countAll(conn);
                        if (dr.HasRows)
                        {

                            while (dr.Read())
                            {

                                label13.Text = dr[0].ToString();
                            }
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally { conn.Close(); }


                int colll = 1;
                int colll2 = 2;
                try
                {
                    for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                    {
                        if (double.Parse(dataGridView4[colll, i].Value.ToString()) < double.Parse(dataGridView4[colll2, i].Value.ToString()))
                        {

                            dataGridView4[colll, i].Style.ForeColor = Color.Red;
                            dataGridView4[colll2, i].Style.ForeColor = Color.Red;
                            dataGridView4[colll, i].Style.BackColor = Color.Salmon;
                            dataGridView4[colll2, i].Style.BackColor = Color.Salmon;
                            dataGridView4.Rows[i].Cells[0].Style.BackColor = Color.Salmon;
                            dataGridView4.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            int months = Convert.ToInt32(comboBox1.Text);
            DateTime range = DateTime.Now.AddMonths(months);
            MessageBox.Show(range.ToString());  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 p = new Form9();
            p.ShowDialog(); 
   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            k.ShowDialog(); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                 dataGridView2.Rows.Add(dataGridView3.CurrentRow.Cells[0].Value.ToString(), dataGridView3.CurrentRow.Cells[1].Value.ToString(), dataGridView3.CurrentRow.Cells[2].Value.ToString(), dataGridView3.CurrentRow.Cells[3].Value.ToString(), dataGridView3.CurrentRow.Cells[4].Value.ToString());
                 for (int i = 0; i < dataGridView2.Rows.Count; i++)
                 {
                     this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                     this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                     dataGridView2.Columns[0].ReadOnly = true;
                     dataGridView2.Columns[2].ReadOnly = true;
                     dataGridView2.Columns[3].ReadOnly = true;
                     dataGridView2.Columns[4].ReadOnly = true;
                     dataGridView2.Columns[6].ReadOnly = true;
                     dataGridView2.Columns[7].ReadOnly = true;
                     Column16.Items.Clear();   
                     Column16.Items.Add("1");
                     Column16.Items.Add("2");
                     Column16.Items.Add("3");
                     Column16.Items.Add("4");
                     Column16.Items.Add("5");
                     Column16.Items.Add("6");
                     Column16.Items.Add("7");
                     Column16.Items.Add("8");
                     Column16.Items.Add("9");
                     Column16.Items.Add("10");
                     Column16.Items.Add("11");
                     Column16.Items.Add("12");





                 }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Invalid. Click the Products you want to order.","Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
                
            }
               
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                label8.Text = DateTime.Now.ToString("hh:  mm:  ss   tt");
            }
        }



        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (double.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString()) > 0)
                {
                    try
                    {
                        if (e.ColumnIndex == 5)
                        {
                            if (dataGridView2.CurrentRow.Cells[5].Value != null)
                            {
                                double subtotal = 0;
                                subtotal = double.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString()) + double.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                                dataGridView2.CurrentRow.Cells[6].Value = string.Format("{0:N2}", subtotal);
                                total += subtotal;
                                double subtotal2 = 0;
                                subtotal2 = double.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()) * double.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString());
                                dataGridView2.CurrentRow.Cells[7].Value = string.Format("{0:N2}", subtotal2);
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
                            label19.Text = "Successfully Added......";
                            f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value.ToString());
                            textBox2.Text = f.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        label19.Text = "Waiting.......";
                    }
                    try
                    {
                        int a = Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value.ToString());
                        DateTime NextMonth = System.DateTime.Now.AddMonths(a);
                        dataGridView2.CurrentRow.Cells[9].Value = NextMonth.ToString();
                    }
                    catch (Exception)
                    {
                        label19.Text = "Waiting.......";
                    }
                }
                else
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Negative value and 0 is not allowed.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception)
            {
               DialogResult okay = new DialogResult();
               okay = MessageBox.Show("String is not allowed.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
               dataGridView2.CurrentRow.Cells[7].Value = null;   
               if (okay == DialogResult.OK)
                 {
                     Application.DoEvents();
                 }
            }         
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                    
               
        }

        private void Form3_Load(object sender, EventArgs  e)
        {
            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            textBox9.Visible = false;
            textBox8.Visible = false;
            textBox5.Visible = false;
            comboBox1.Text = "1"; 
            textBox7.Text = this.ValueFromForm7texbox1;
            textBox6.Text = this.ValueFromForm7texbox2;

            dataGridView4.Columns[0].ReadOnly = true;
            dataGridView4.Columns[1].ReadOnly = true;
            dataGridView4.Columns[2].ReadOnly = true; 
            dataGridView4.Columns[3].ReadOnly = true; 
           // textBox6.Text = "13"; 
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

            try
            {
                conn.Open(); 
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ProdDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[6].ToString(), dr[0].ToString());
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
                    SqlDataReader dr = COUNT.ZeroQuantity(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        while (dr.Read())
                        {

                            listBox1.Items.Add(">>>>>>>>>>>" + " " + dr[1].ToString());
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

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = COUNT.countZero(conn);
                    if (dr.HasRows)
                    {
                          
                        while (dr.Read())
                        {

                            label15.Text = dr[0].ToString();  
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
                    SqlDataReader dr = COUNT.countAll(conn);
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {

                            label13.Text = dr[0].ToString();
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            int col = 1;
            int col2 = 2;
            try
            {
                for (int i = 0; i < dataGridView4.Rows.Count -1; i++)
                {
                    if (double.Parse(dataGridView4[col, i].Value.ToString()) < double.Parse(dataGridView4[col2, i].Value.ToString()))
                    {

                        dataGridView4[col, i].Style.ForeColor = Color.Red;
                        dataGridView4[col2, i].Style.ForeColor = Color.Red;
                        dataGridView4.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                        dataGridView4[col, i].Style.BackColor = Color.Salmon;
                        dataGridView4[col2, i].Style.BackColor = Color.Salmon;
                        dataGridView4.Rows[i].Cells[0].Style.BackColor = Color.Salmon;

                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Warning: No rows left.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ProdDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[6].ToString(), dr[0].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            int color1 = 1;
            int color2 = 2;
            try
            {
                for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                {
                    if (double.Parse(dataGridView4[color1, i].Value.ToString()) < double.Parse(dataGridView4[color2, i].Value.ToString()))
                    {

                        dataGridView4[color1, i].Style.ForeColor = Color.Red;
                        dataGridView4[color2, i].Style.ForeColor = Color.Red;
                        dataGridView4.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                        dataGridView4[color1, i].Style.BackColor = Color.Salmon;
                        dataGridView4[color2, i].Style.BackColor = Color.Salmon;
                        dataGridView4.Rows[i].Cells[0].Style.BackColor = Color.Salmon;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
               
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form14 k = new Form14();
            k.Empname = this.textBox7.Text;
            k.EmpID = this.textBox6.Text;  
            k.ShowDialog(); 
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
               
                try
                {
                    COUNT.PRODUCTs_SUPPLIERID = double.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString());
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = COUNT.ClickSupplier(conn);
                        if (dr.HasRows)
                        {
                            listBox3.Items.Clear();   
                            while (dr.Read())
                            {
                                
                                listBox3.Items.Add("//..............................................//");
                                listBox3.Items.Add("//..............................................//");
                                listBox3.Items.Add("Product Name:  " + dr[4].ToString());
                                listBox3.Items.Add("Supplier company:  " + dr[2].ToString());
                                listBox3.Items.Add("Contact Person:  " + dr[0].ToString() + "  " + dr[1].ToString());
                                listBox3.Items.Add("Quantity:  " + dr[5].ToString());
                                listBox3.Items.Add("Date Ordered:  " + dr[6].ToString());
                                listBox3.Items.Add("//..............................................//");
                                listBox3.Items.Add("//..............................................//");   

                               
                            }
                        }
                        else
                        {
                            DialogResult okay = new DialogResult();
                            okay = MessageBox.Show("Warning:  " + dataGridView4.CurrentRow.Cells[0].Value.ToString() + "  has no Quantity yet.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (okay == DialogResult.OK)
                            {
                                Application.DoEvents();
                                listBox3.Items.Clear();   
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
                    COUNT.IDe = double.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString());
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = COUNT.countORDERS(conn);
                        if (dr.HasRows)
                        {
                            
                            while (dr.Read())
                            {
                                label17.Text = dr[0].ToString();  
                            }
                        }
                        else
                        {
                            label17.Text = "0"; 
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally { conn.Close(); }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            try
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Warning: No rows left.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                    textBox2.Text = "0"; 
                }
            }

            double f = 0;
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    label19.Text = "Status";
                    f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value.ToString());
                    textBox2.Text = f.ToString();

                }

            }
            catch (Exception)
            {

                label19.Text = "Waiting....";
            }
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox5.Text = radioButton1.Text;
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox5.Text = radioButton2.Text;   
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double totaL = Convert.ToDouble(textBox2.Text);
                double balance = Convert.ToDouble(textBox8.Text);
                double result;
                result = totaL + balance;
                textBox9.Text = result.ToString();  
            }
            catch (Exception)
            {

                label20.Text = "."; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double totaL = Convert.ToDouble(textBox2.Text);
                double balance = Convert.ToDouble(textBox8.Text);
                double result;
                result = totaL + balance;
                textBox9.Text = result.ToString();
            }
            catch (Exception)
            {

                label20.Text = ".";
            }
        }

    }
}
