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
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class1 browse = new Class1();
        Class3 updates = new Class3();
 
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browse.Browse(pictureBox1);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            if (textBox10.Text != textBox11.Text)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("The password you entered did not match: Confirm the password.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string sqlInsertDetails = "INSERT INTO Employee(EmpPict,EmpLN,EmpFN,EmpRate,EmpStatus,Phone,Status,UserName,Password,NumberStreet,city,state,zipcode,EmpDate)VALUES(@Pic,@LNN,@FNN,@Rate,@Statuss,@phone,@status,@user,@pass,@nustreet,@citi,@statee,@zip,'" + DateTime.Now.ToString()+ "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;

                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        cmdInsert.Parameters.AddWithValue("@Pic", pic);

                        cmdInsert.Parameters.Add(new SqlParameter("@LNN", textBox1.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@FNN", textBox2.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@Rate", Convert.ToDouble(textBox3.Text)));
                        cmdInsert.Parameters.Add(new SqlParameter("@Statuss", textBox4.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@phone", textBox5.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@user", textBox9.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@pass", textBox10.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@nustreet", textBox6.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@citi", textBox7.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@statee", comboBox1.Text));
                        cmdInsert.Parameters.Add(new SqlParameter("@zip", textBox8.Text));
                        if (radioButton1.Checked == true)
                        {
                            cmdInsert.Parameters.Add(new SqlParameter("@status", radioButton1.Text));
                        }
                        if (radioButton2.Checked == true)
                        {
                            cmdInsert.Parameters.Add(new SqlParameter("@status", radioButton2.Text));
                        }
                        if (radioButton3.Checked == true)
                        {
                            cmdInsert.Parameters.Add(new SqlParameter("@status", radioButton3.Text));
                        }



                        cmdInsert.ExecuteNonQuery();

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        textBox10.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        textBox13.Clear();
                        textBox14.Clear();
                        textBox15.Clear();  
                        
                      
                    }
                }
                catch (Exception)
                {

                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Sign all the informations", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                finally { conn.Close(); }
            }
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = browse.ViewEmp(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();  
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[2].ToString() + ", " + dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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
                    SqlDataReader dr = updates.EmployeeUsers(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();
                        while (dr.Read())
                        {

                            listBox2.Items.Add(dr[8].ToString());
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

        private void Form2_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            listBox2.Visible = false;  
            
            listBox1.Enabled = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true; 
         
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = browse.ViewEmp(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();  
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[2].ToString() + ", " + dr[3].ToString(),dr[4].ToString(),dr[5].ToString(),dr[6].ToString());  
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
                    SqlDataReader dr = updates.EmployeeUsers(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();   
                        while (dr.Read())
                        {

                            listBox2.Items.Add(dr[8].ToString());   
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Employee SET EmpPict = @Pic WHERE EmpID ='" + textBox15.Text + "'", conn);

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
                    }
                }
            }

            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Enter first your account below", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    updates.EmpIDDd = Convert.ToDouble(textBox15.Text);   
                    updates.last1 = textBox1.Text;
                    updates.first1 = textBox2.Text;
                    updates.rate1 = Convert.ToDouble(textBox3.Text);
                    updates.empstat1 = textBox4.Text;
                    updates.phon1 = textBox5.Text;
                    updates.strtnum1 = textBox6.Text;
                    updates.citii1 = textBox7.Text;
                    updates.statee1 = comboBox1.Text;
                    updates.zipcodes1 = textBox8.Text;
                    updates.stat1 = textBox14.Text;
                    updates.userN1 = textBox9.Text;
                    updates.passW1 = textBox10.Text;
                    updates.UpdateEmployeeInformation(conn);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    listBox1.Items.Clear();   
                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Error occured during updating: The image was updated but the Informations are not. \n\nCheck the rate above!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    SqlDataReader dr = browse.ViewEmp(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[2].ToString() + ", " + dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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
                    SqlDataReader dr = updates.EmployeeUsers(conn);
                    if (dr.HasRows)
                    {
                        listBox2.Items.Clear();
                        while (dr.Read())
                        {

                            listBox2.Items.Add(dr[8].ToString());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();  
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true; 

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE UserName = '" + textBox12.Text + "'AND Password = '" + textBox13.Text + "'", conn);
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

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();  
            }
        

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    browse.USER = textBox12.Text;
                    browse.PASSWORD = textBox13.Text;
                    SqlDataReader dr = browse.LOGIN(conn);
                    if (dr.HasRows)
                    {
                        listBox1.Items.Clear();   
                        while (dr.Read())
                        {
                            textBox1.Text = dr[2].ToString();
                            textBox2.Text = dr[3].ToString();
                            textBox3.Text = dr[4].ToString();
                            textBox4.Text = dr[5].ToString();
                            textBox5.Text = dr[6].ToString();
                            textBox6.Text = dr[10].ToString();
                            textBox7.Text = dr[11].ToString();
                            textBox8.Text = dr[13].ToString();
                            textBox9.Text = dr[8].ToString();
                            textBox10.Text = dr[9].ToString();
                            textBox11.Text = dr[9].ToString();
                            comboBox1.Text = dr[12].ToString();
                            textBox14.Text = dr[7].ToString();
                            textBox15.Text = dr[0].ToString();

                            listBox1.Items.Add("LASTNAME:    "+dr[2].ToString());
                            listBox1.Items.Add("FIRSTNAME:    " +dr[3].ToString());
                            listBox1.Items.Add("RATE:    " +dr[4].ToString());
                            listBox1.Items.Add("STATUS:    " + dr[5].ToString());
                            listBox1.Items.Add("PHONE:    " + dr[6].ToString());  
                        }
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("The user name and password you entered did not match.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                            listBox1.Items.Clear();   
                        }
                    }
                }
            }
            catch (Exception)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Sign in first before you can edit your account.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox14.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox14.Text = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox14.Text = radioButton3.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int index = listBox2.FindStringExact(this.textBox9.Text);
            if (0 <= index)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("The user name: " + textBox9.Text + " Is already in used." , "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                    textBox9.Clear();  
                }
            }
        }
    }
}
