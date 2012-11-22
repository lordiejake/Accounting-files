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
using System.Collections;

namespace OrderManagementSystem
{

    public partial class Form17 : Form
    {
        List<ImageList> list;
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        CustomerOrders orders = new CustomerOrders();
        Class1 add = new Class1();
        ArrayList ordersid = new ArrayList();
        Class4 returnsz = new Class4();
        transactions CustReturnz = new transactions();
        DataSet printJkk = new Printing.DataSet6();  
        public string empnem = "";
        public string emaid = "";
        public Form17()
        {
            InitializeComponent();
        }


        //public Image k
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustNumber = '" + textBox1.Text + "'", conn);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("MyImages");
                byte[] mydata = new byte[0];
                dp.Fill(ds, "MyImages");
                DataRow Myrow;
                Myrow = ds.Tables["MyImages"].Rows[0];
                mydata = (byte[])Myrow["CustPict"];
                MemoryStream stream = new MemoryStream(mydata);
                pictureBox1.Image  = Image.FromStream(stream);
                //dataGridView2.Columns[0] = Image.FromStream(stream);
                dataGridView2.Rows.Add(Image.FromStream(stream));
                dataGridView2.Rows.Add(); 
                //dataGridView2.Rows.Add(5); 
              
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
                    orders.CustNUMBER = textBox1.Text;
                    SqlDataReader dr = orders.Searchcustomer(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();
                        dataGridView1.Rows.Clear();
                        textBox13.Clear();
                        textBox14.Clear();  
                        while (dr.Read())
                        {
                          
                            textBox5.Text = dr[0].ToString();
                            listBox1.Items.Add("NAME:");
                            listBox1.Items.Add(dr[2].ToString() + " " + dr[3].ToString());
                            listBox1.Items.Add("\n");
                            listBox1.Items.Add("Informations:");
                            listBox1.Items.Add(dr[4].ToString());
                            listBox1.Items.Add(dr[5].ToString());
                            textBox13.Text = dr[3].ToString();
                            textBox14.Text = dr[2].ToString();  
                          
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();  
                        listBox2.Items.Clear(); 
                        listBox1.Items.Clear();
                        textBox5.Clear();
                        textBox2.Clear();
                        pictureBox1.Image = null;
                        textBox16.Text = null;
                    }
                }
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    add.CUSTm = textBox1.Text;
                    SqlDataReader dr = add.SelectCustomersbyBalanceINTRO(conn);
                    if (dr.HasRows)
                    {
                        textBox2.Clear();  
                        while (dr.Read())
                        {

                            textBox2.Text = dr[6].ToString();  

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

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    add.IIO = textBox1.Text; 
                    SqlDataReader dr = add.SelectCustomerOrdersqqq(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();
                        ordersid.Clear();  
                        while (dr.Read())
                        {
                            listBox2.Items.Add(dr[4].ToString() + " \t" + dr[1].ToString() + "\tTotal: \t----->\t" + dr[3].ToString() + " \t\t\t PESOS");
                            ordersid.Add(dr[5]);  
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form17_Load(object sender, EventArgs e)
        {



            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT CustPict FROM Customer", conn);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet("MyImages");
                    //byte[] mydata = new byte[0];
                    dp.Fill(ds, "MyImages");
                    dataGridView2.DataSource  = ds.Tables["MyImages"] ;

                    //DataRow Myrow;
                    //Myrow = ds.Tables["MyImages"].Rows[0];
                    //mydata = (byte[])Myrow["CustPict"];
                    //MemoryStream stream = new MemoryStream(mydata);
                    ////dataGridView2.DataSource = Image.FromStream(stream);
                    //dataGridView2.Rows.Add(Image.FromStream(stream), "llo");
                    ////dataGridView2.DataSource = Myrow; 

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }


            textBox7.Text = this.empnem;
            textBox6.Text = this.emaid;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox16.Text = null;  
            textBox3.Clear();
            textBox10.Clear();
            textBox11.Clear();  
            textBox12.Visible = false;
            label14.Visible = false;  
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
            dataGridView1.Columns[15].ReadOnly = true;
            try
            {
                returnsz.RETURNSSALES = Convert.ToInt32(ordersid[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = returnsz.ViewCustomerReturns(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),dr[6].ToString(),"0","","","",DateTime.Now.ToString(),dr[7].ToString(),"",dr[8].ToString(),"",dr[9].ToString());  
                            textBox15.Text = returnsz.RETURNSSALES.ToString();

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
                                     dataGridView1.Rows[i].Cells[15].Value = dataGridView1.Rows[i].Cells[7].Value.ToString();
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
                }
            }
            catch (Exception)
            {

                label13.Text = ","; 
            }
            finally { conn.Close(); }

            try
            {
                add.CUSTIDENTs = Convert.ToInt32(ordersid[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.SalesDataMoney(conn);
                    if (dr.HasRows)
                    {
                        textBox4.Clear();
                        textBox9.Clear();
                        
                        while (dr.Read())
                        {
                            textBox4.Text = dr[10].ToString();
                            textBox9.Text = dr[9].ToString();
                            
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
                add.CUSTIDENTs = Convert.ToInt32(ordersid[listBox2.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.SelectCustomerOrders_TotalPaaids(conn);
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
                        textBox8.Text = "0";
                    }
                }
            }
            catch (Exception)
            {

                label13.Text = ",";
            }
            finally { conn.Close(); }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()) >= 0)
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
                                    result = x + y;
                                    dataGridView1.CurrentRow.Cells[8].Value = result.ToString();
                                    double xx = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                                    double yy = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                                    double resultt;
                                    resultt = xx - yy;
                                    dataGridView1.CurrentRow.Cells[10].Value = resultt.ToString();
                                    double z = resultt;
                                    double a = double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                    double resulttt = z * a;
                                    dataGridView1.CurrentRow.Cells[9].Value = resulttt.ToString();
                                    double xxx = double.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                                    double yyy = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                                    double resultth;
                                    resultth = xxx * yyy;//7+16
                                    dataGridView1.CurrentRow.Cells[15].Value = resultth.ToString();
                                    double xxxx = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                                    double yyyy = double.Parse(dataGridView1.CurrentRow.Cells[16].Value.ToString());
                                    double addresult;
                                    addresult = xxxx + yyyy;
                                    dataGridView1.CurrentRow.Cells[17].Value = addresult.ToString();     
                                    
                                }
                            }
                        }
                        else
                        {
                            dataGridView1.CurrentRow.Cells[7].Value = "0";
                            dataGridView1.CurrentRow.Cells[15].Value = "0";   
                            dataGridView1.CurrentRow.Cells[8].Value = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                            dataGridView1.CurrentRow.Cells[10].Value = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                            dataGridView1.CurrentRow.Cells[9].Value = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                            dataGridView1.CurrentRow.Cells[17].Value = dataGridView1.CurrentRow.Cells[7].Value.ToString();
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

                    double fz = 0;
                    try
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            label13.Text = ".";
                            fz = double.Parse(fz.ToString()) + Convert.ToDouble(dataGridView1.Rows[i].Cells[15].Value.ToString());
                            textBox16.Text = fz.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            pictureBox1.Image = null; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(textBox3.Text)) >= double.Parse(textBox8.Text))
                {
                    label14.Visible = false;
                    textBox12.Visible = false; 
                    double a = double.Parse(textBox3.Text);
                    double b = double.Parse(textBox8.Text);
                    double resultAB = a - b;
                    textBox11.Text = resultAB.ToString();

                    double f = double.Parse(textBox2.Text);
                    double g = double.Parse(textBox9.Text);
                    double diff = f - g;
                    double sum = diff + resultAB;
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

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                printJkk.Tables["DataTable1"].Rows.Add(item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[7].Value.ToString(), item.Cells[15].Value.ToString(),item.Cells[9].Value.ToString(),textBox4.Text,textBox8.Text,textBox9.Text,textBox3.Text,textBox8.Text,textBox11.Text,textBox12.Text);
            }

            Printing.formprint2 frm = new OrderManagementSystem.Printing.formprint2();
            frm.Prints = printJkk;
            frm.ShowDialog();
            printJkk.Tables["DataTable1"].Rows.Clear();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            add.NEWBALCUS = Convert.ToDouble(textBox10.Text); 
            add.UPDATESALESNO = Convert.ToDouble(textBox15.Text);
            add.UPDsales = Convert.ToDouble(textBox11.Text);  
            add.EMID = Convert.ToDouble(textBox6.Text);
            add.CID = Convert.ToDouble(textBox5.Text);
            add.CLN = textBox14.Text;
            add.CFN = textBox13.Text;
            add.TTALL = Convert.ToDouble(textBox3.Text);
            add.AddRetail(dataGridView1);
            
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("complete the calculation", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
    }
}
