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
    public partial class Form4 : Form
    {
        double sayu;
        string COMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM;
        double lastL;
        string CheckINDAAAAAAAAAATEMM;
        string CheckINGLOBAL;
        string CheckINGLOBAL2;
        double Price;
        UpdateReservation Reservationupdate = new UpdateReservation();
        int k, kk, kkk, kkkk, kkkkk;
        int q, qq, qqq, qqqq, qqqqq;
        int QK;
        double RE;
        int hours;
        GroupReservation group = new GroupReservation();
        DataSet pr = new Printing.DataSet1();
        DataSet prr = new Printing.DataSet3();
        DataSet prrr = new Printing.DataSet4();
        DataSet prrrr = new Printing.DataSet5();
        public double ChechOUTReservationGlobal;
        public string DatesExpires;
        Employee fro = new Employee();
        PaymentsGuest pay = new PaymentsGuest();
        SqlConnection conn = null;
        Roomtype command = new Roomtype();
        transactions add = new transactions();
        double Previusroom;
        string UpdatedDate;
        public double GlobalTimeExess;
        public double idoftherum;
        public double guestingid3;
        public double residszxc;
        public double guestingid;
        public double guestingid2;
        public string romids = "";
        public string lnamez = "";
        public string fnamez = "";
        public string idz = "";
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double d = 0;
        public double f = 0;
        public double g = 0;
        public double aa = 0;
        public double bb = 0;
        public double cc = 0;
        public double dd = 0;
        public double ff = 0;
        public double gg = 0;
        public double statuz;
        public double reso;
        double rezzzzzzzzz;
        double custIdFORUPDATE = 0;
        public Form4()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(timer1_Tick);
            timer2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true; 
            //dataGridView1.SendToBack();
            groupBox15.SendToBack();
            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView2.SendToBack();
            groupBox23.SendToBack();
            groupBox29.SendToBack();
            tabControl2.SendToBack();

            groupBox33.Visible = false;
            groupBox29.Visible = false;
            // groupBox24.SendToBack();  
            dataGridView1.BringToFront();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.RoomSTATUStransaction(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),dr[7].ToString());
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

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true; 
            groupBox33.Visible = false;
            groupBox32.Visible = false;
            groupBox29.Visible = false;
            tabControl2.Visible = false;
            dataGridView2.Visible = true;
            // groupBox24.SendToBack();  
            dataGridView2.Columns[15].Visible = false;
            dataGridView1.SendToBack();
            groupBox15.SendToBack();
            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView1.SendToBack();
            dataGridView2.BringToFront();
            this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.RoomSTATUStransactionCheck(conn);
                    if (dr.HasRows)
                    {
                        dataGridView2.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), "", Reservations.Properties.Resources.ico290, "--------------", "--------------", Reservations.Properties.Resources.ico24, "", "", dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), "", dr[12].ToString());
                        }
                    }
                    else
                    {
                        dataGridView2.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView2.SendToBack();
            groupBox23.SendToBack();
            groupBox29.SendToBack();
            tabControl2.SendToBack();
            groupBox3.Visible = true; 
            groupBox33.Visible = false;
            groupBox29.Visible = false;
            groupBox3.BringToFront();
            groupBox3.BackColor = Color.White;
            groupBox4.BackColor = Color.White;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox35.Visible = false; 
            groupBox33.Visible = false;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label28.ForeColor = Color.Black;
            label27.ForeColor = Color.Black;
            // dataGridView14.Rows.Add(10);
            dataGridView13.Rows.Add(10);
            groupBox6.BackColor = Color.Silver;
            groupBox7.BackColor = Color.Silver;
            groupBox8.BackColor = Color.Silver;
            groupBox9.BackColor = Color.Silver;
            groupBox10.BackColor = Color.Silver;
            groupBox11.BackColor = Color.Silver;
            groupBox12.BackColor = Color.Silver;
            groupBox13.BackColor = Color.Silver;
            groupBox14.BackColor = Color.Silver;
            groupBox20.BackColor = Color.Silver;
            groupBox21.BackColor = Color.Silver;
            groupBox22.BackColor = Color.Silver;
            tabControl1.Appearance = TabAppearance.Normal;
            tabPage1.BackColor = Color.White;
            tabPage2.BackColor = Color.White;
            tabPage3.BackColor = Color.White;
            tabPage4.BackColor = Color.White;
            dataGridView3.Columns[0].Visible = false;
            //textBox18.Text = "1";
            button25.Enabled = true;
            textBox26.Visible = false;
            numericUpDown1.Enabled = false;
            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.StartPage(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {
                            double price = double.Parse(dr[3].ToString());
                            string Price = string.Format("{0:N2}", price);
                            dataGridView4.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Price.ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView4.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            // groupBox3.BringToFront();  
            // groupBox5.SendToBack();   
            dataGridView4.BringToFront();
            textBox16.Text = this.lnamez;
            textBox17.Text = this.fnamez;
            textBox18.Text = this.idz;
            textBox13.Text = "12";
            textBox11.Text = "12";
            dateTimePicker1.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox8.Enabled = true;
            //groupBox3.BringToFront();  
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomCondition(conn);
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Clear();
                        comboBox7.Items.Clear();
                        command.ROOMCONDITIONID.Clear();
                        while (dr.Read())
                        {
                            comboBox7.Items.Add(dr[1].ToString());
                            comboBox1.Items.Add(dr[1].ToString());
                            command.ROOMCONDITIONID.Add(dr[0]);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.Excess_Conditions(conn);
                    if (dr.HasRows)
                    {
                        textBox10.Clear();
                        textBox9.Clear();
                        while (dr.Read())
                        {
                            textBox9.Text = dr[1].ToString();
                            textBox10.Text = dr[2].ToString();
                            double Charge1 = double.Parse(textBox9.Text);
                            double Charge2 = double.Parse(textBox10.Text);
                            textBox9.Text = string.Format("{0:N2}", Charge1);
                            textBox10.Text = string.Format("{0:N2}", Charge2);
                            GlobalTimeExess = double.Parse(textBox9.Text);
                        }
                    }
                    else
                    {
                        textBox10.Clear();
                        textBox9.Clear();
                    }
                }
            }
            catch (Exception)
            {
                textBox10.Clear();
                textBox9.Clear();
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ReservationFullPaymentStatus(conn);
                    if (dr.HasRows)
                    {
                        comboBox6.Items.Clear();
                        add.GUESTKILANLAN.Clear();
                        add.GUESTKILANLANID.Clear();
                        add.NAIWAN_NA_RUMID.Clear();
                        add.EXPECTEDHOURS_______________.Clear();
                        while (dr.Read())
                        {
                            comboBox6.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + "  " + dr[3].ToString());
                            add.GUESTKILANLAN.Add(dr[0]);
                            add.GUESTKILANLANID.Add(dr[4]);
                            add.EXPECTEDHOURS_______________.Add(dr[5].ToString());
                            add.NAIWAN_NA_RUMID.Add(dr[6]);
                        }
                    }
                    else
                    {
                        comboBox6.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ROOMTYPE2(conn);
                    if (dr.HasRows)
                    {
                        comboBox9.Items.Clear();
                        add.XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.Clear();
                        while (dr.Read())
                        {
                            comboBox9.Items.Add(dr[1].ToString());
                            add.XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox9.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            command.RCID = Convert.ToInt32(command.ROOMCONDITIONID[comboBox1.SelectedIndex]);
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomConditionCODES(conn);
                    if (dr.HasRows)
                    {
                        comboBox2.Items.Clear();
                        command.ROOMTYPEIDZ.Clear();
                        dataGridView3.Rows.Clear();
                        label12.Text = "========";
                        label13.Text = "========";
                        while (dr.Read())
                        {
                            comboBox2.Items.Add(dr[1].ToString());
                            command.ROOMTYPEIDZ.Add(dr[0]);
                        }
                    }
                    else
                    {
                        dataGridView3.Rows.Clear();
                        comboBox2.Items.Clear();
                        label12.Text = "========";
                        label13.Text = "========";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            command.R = Convert.ToInt32(command.ROOMTYPEIDZ[comboBox2.SelectedIndex]);
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomsZ(conn);
                    if (dr.HasRows)
                    {
                        dataGridView3.Rows.Clear();
                        label12.Text = "========";
                        label13.Text = "========";
                        while (dr.Read())
                        {
                            dataGridView3.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView3.Rows.Clear();
                        dataGridView3.Rows.Add("Empty", "Empty");
                        label12.Text = "========";
                        label13.Text = "========";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomBILLS(conn);
                    if (dr.HasRows)
                    {
                        textBox7.Clear();
                        textBox8.Clear();
                        while (dr.Read())
                        {
                            textBox8.Text = dr[5].ToString();
                            textBox7.Text = dr[2].ToString();
                            double k = double.Parse(textBox7.Text);
                            textBox7.Text = string.Format("{0:N2}", k);
                        }
                    }
                    else
                    {
                        textBox7.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sayu = double.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            string status = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            string statu______s = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            if (status != "Check IN")
            {
                try
                {
                    add.rami = double.Parse(sayu.ToString());
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {

                        SqlDataReader dr = add.CHEEEEEEEEEEEEEEEEEEEEEEEEEEEEE(conn);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                DialogResult okay = new DialogResult();
                                okay = MessageBox.Show("Check The Reservation Allocation: This room is already reserved: CheckIN DATE:" + dr[0].ToString() + "  checkOUT: " + dr[1].ToString() + "", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    throw;
                }
                finally { conn.Close(); }
                try
                {
                    label12.Text = statu______s.ToString();
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show(statu______s.ToString() + "  is Selected" + " ", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox12.Enabled = true;
                    numericUpDown1.Enabled = true;
                    string statusx = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                    label13.Text = statusx.ToString();
                    romids = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }
            else
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show(dataGridView3.CurrentRow.Cells[1].Value.ToString() + " is NOT available: Thank you", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
                label12.Text = "========";
                label13.Text = status.ToString();

                
            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                double Expectednumber = double.Parse(textBox8.Text);
                double numberPerson = double.Parse(numericUpDown1.Value.ToString());
                if (Expectednumber < numberPerson)
                {
                    double roombil = double.Parse(textBox7.Text);
                    rezzzzzzzzz = numberPerson - Expectednumber;
                    label25.Text = rezzzzzzzzz.ToString();
                    double head = double.Parse(textBox10.Text);
                    double multiply = (rezzzzzzzzz * head) + roombil;
                    textBox6.Text = string.Format("{0:N2}", multiply);
                    textBox14.Text = textBox6.Text.ToString();
                }
                else
                {
                    label25.Text = "0";
                    textBox6.Text = textBox7.Text;
                }
            }
            catch (Exception)
            {

                label25.Text = "0";
            }
            try
            {
                int enterhour = int.Parse(textBox12.Text);
                int twelvehour = int.Parse(textBox13.Text);
                int result = twelvehour + enterhour;
                textBox11.Text = result.ToString();

                double excesshour = double.Parse(textBox9.Text);
                double four = double.Parse(textBox6.Text);
                double r = (excesshour * enterhour) + four;
                textBox15.Text = r.ToString();
            }
            catch (Exception)
            {
                if (checkBox5.Checked == true)
                {
                    textBox12.Clear();
                    textBox11.Text = "3";
                    textBox15.Text = textBox6.Text;
                }
                else
                {
                    textBox12.Clear();
                    textBox11.Text = "12";
                    textBox15.Text = textBox6.Text;
                }
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Expectednumber = double.Parse(textBox8.Text);
                double numberPerson = double.Parse(numericUpDown1.Value.ToString());
                if (Expectednumber < numberPerson)
                {
                    double result = numberPerson - Expectednumber;
                    label25.Text = result.ToString();
                }
                else
                {
                    label25.Text = "0";
                }
            }
            catch (Exception)
            {

                label25.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox32.Visible = false; 
            groupBox29.Visible = true;
            groupBox35.Visible = true; 
            //dataGridView1.Visible = true;
            //groupBox16.Visible = true;
            //groupBox15.Visible = true;
            //groupBox3.Visible = true;
            //dataGridView4.Visible = true;
            //groupBox5.Visible = true;
            //dataGridView2.Visible = true;
            //groupBox23.Visible = true;
            //groupBox29.Visible = true;
            //tabControl2.Visible = true;


            //dataGridView1.Visible = true;
            //groupBox16.Visible = true;
            //groupBox15.Visible = true;
            //groupBox3.Visible = true;
            //dataGridView4.Visible = true;
            //groupBox5.Visible = true;
            //dataGridView2.Visible = true;
            groupBox29.Visible = false; 
            //groupBox23.Visible = true;
            //tabControl2.Visible = true;
            groupBox33.Visible = true;
            groupBox29.SendToBack();
            //groupBox33.BringToFront(); 
            //dataGridView1.SendToBack(); 
            //groupBox29.SendToBack();
            //dataGridView1.SendToBack();
            //groupBox16.SendToBack();
            //groupBox15.SendToBack();
            //groupBox3.SendToBack();
            //dataGridView4.SendToBack();
            //groupBox5.SendToBack();
            //dataGridView2.SendToBack();
            //groupBox23.SendToBack();
            //groupBox29.SendToBack();
            //tabControl2.SendToBack();
            
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Reservationupdate.RoomDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView22.Rows.Clear();
                        while (dr.Read())
                        {
                            double x = double.Parse(dr[1].ToString());
                            double y = double.Parse(dr[2].ToString());
                            string xx = string.Format("{0:N2}", x);
                            string yy = string.Format("{0:N2}", y);
                            dataGridView22.Rows.Add("Select", dr[0].ToString(), xx.ToString(), yy.ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                    }
                    else
                    {
                        dataGridView22.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox32.Visible = true;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (sender == timer1)
            //{
            //    label32.Text  = DateTime.Now.ToString("hh:mm:ss tt");
            //    DatesExpires = label32.Text;
            //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //    {
            //        dataGridView2.Rows[i].Cells[9].Value = DateTime.Now.ToShortDateString() + " " + label32.Text;    
            //    }
            //}
        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
          
            if (textBox20.Text == "Reserve")
            {
                textBox19.Clear();
                try
                {
                    double eleven = double.Parse(textBox11.Text);
                    string x = dateTimePicker2.Text + " " + textBox75.Text;
                    DateTime date = Convert.ToDateTime(x.ToString());
                    CheckINGLOBAL = date.ToString();
                    DateTime dates = Convert.ToDateTime(date.AddHours(eleven).ToString());
                    textBox21.Text = dates.ToString();
                }
                catch (Exception)
                {

                    textBox21.Clear();
                }
            }
            if (textBox20.Text == "")
            {
                textBox19.Clear();
            }
            if (textBox20.Text == "Check IN")
            {
                try
                {
                    double num = int.Parse(textBox11.Text);
                    textBox19.Text = DateTime.Now.AddHours(num).ToString();
                    DateTime ads = Convert.ToDateTime(textBox19.Text);
                    textBox21.Text = ads.AddMinutes(2).ToString();

                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            button19.Enabled = true;
            button17.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            if (textBox20.Text == "Reserve")
            {
                textBox19.Clear();
                //textBox21.Clear();
                try
                {
                    int enterhour = int.Parse(textBox12.Text);
                    int twelvehour = int.Parse(textBox13.Text);
                    int result = twelvehour + enterhour;
                    textBox11.Text = result.ToString();
                    double excesshour = double.Parse(textBox9.Text);
                    double four = double.Parse(textBox6.Text);
                    double r = (excesshour * enterhour) + four;
                    textBox15.Text = r.ToString();
                }
                catch (Exception)
                {
                    if (checkBox5.Checked == true)
                    {
                        textBox12.Clear();
                        textBox11.Text = "3";
                        textBox15.Text = textBox6.Text;
                        textBox19.Clear();
                  //      textBox21.Clear();
                    }
                    else
                    {
                        textBox12.Clear();
                        textBox11.Text = "12";
                        textBox15.Text = textBox6.Text;
                        textBox19.Clear();
                    //    textBox21.Clear();
                    }
                }
            }
            else
            {
                try
                {
                    int enterhour = int.Parse(textBox12.Text);
                    int twelvehour = int.Parse(textBox13.Text);
                    int result = twelvehour + enterhour;
                    textBox11.Text = result.ToString();
                    double excesshour = double.Parse(textBox9.Text);
                    double four = double.Parse(textBox6.Text);
                    double r = (excesshour * enterhour) + four;
                    textBox15.Text = r.ToString();
                    if (int.Parse(enterhour.ToString()) == 0)
                    {
                        double num = 12;
                        textBox19.Text = DateTime.Now.AddHours(num).ToString();
                        DateTime ads = Convert.ToDateTime(textBox19.Text);
                        textBox21.Text = ads.AddMinutes(3).ToString();
                    }

                }
                catch (Exception)
                {
                    if (checkBox5.Checked == true)
                    {
                        textBox12.Clear();
                        textBox11.Text = "3";
                        textBox15.Text = textBox6.Text;
                        textBox19.Clear();
                        textBox21.Clear();
                    }
                    else
                    {
                        textBox12.Clear();
                        textBox11.Text = "12";
                        textBox15.Text = textBox6.Text;
                        textBox19.Clear();
                        textBox21.Clear();
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text.Length.ToString());
            if (a > 0)
            {
                aa = double.Parse("1");
            }
            else
            {
                aa = double.Parse("0");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = double.Parse(textBox2.Text.Length.ToString());
            if (b > 0)
            {
                bb = double.Parse("1");
            }
            else
            {
                bb = double.Parse("0");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = double.Parse(textBox3.Text.Length.ToString());
            if (c > 0)
            {
                cc = double.Parse("1");
            }
            else
            {
                cc = double.Parse("0");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            d = double.Parse(textBox4.Text.Length.ToString());
            if (d > 0)
            {
                dd = double.Parse("1");
            }
            else
            {
                dd = double.Parse("0");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            f = double.Parse(textBox5.Text.Length.ToString());
            if (f > 0)
            {
                ff = double.Parse("1");
            }
            else
            {
                ff = double.Parse("0");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox29.Visible = true; 
            groupBox33.Visible = false;
            textBox62.Text = "12";
            textBox64.Text = "12";
            groupBox29.Visible = true;
            tabControl2.Visible = true;
            groupBox17.Visible = false;
            monthCalendar2.Visible = false;
            dataGridView1.SendToBack();
            dataGridView2.Visible = false;
            dataGridView2.SendToBack();
            groupBox15.SendToBack();
            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView1.SendToBack();
            dataGridView2.SendToBack();
            groupBox16.SendToBack();
            groupBox23.SendToBack();
            dataGridView8.SendToBack();
            groupBox29.BringToFront();
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ReservationUpdating(conn);
                    if (dr.HasRows)
                    {
                        dataGridView18.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView18.Rows.Add("Click here", dr[0].ToString() + " ," + dr[1].ToString() + " " + dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView18.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double eleven = double.Parse(textBox11.Text);
                string x = dateTimePicker2.Text + " " + textBox75.Text;
                DateTime date = Convert.ToDateTime(x.ToString());
                CheckINGLOBAL = date.ToString();
                DateTime dates = Convert.ToDateTime(date.AddHours(eleven).ToString());
                textBox21.Text = dates.ToString();
            }
            catch (Exception)
            {

                textBox21.Clear();
            }
            textBox19.Clear();
            textBox21.Clear();
            if (radioButton1.Checked == true)
            {
                textBox20.Text = radioButton1.Text;
                dateTimePicker2.Enabled = true;
                
            }
            if (radioButton1.Checked == false)
            {
                textBox20.Text = radioButton2.Text;
                dateTimePicker2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                textBox20.Text = radioButton2.Text;
            }
            if (radioButton2.Checked == false)
            {
                textBox20.Text = radioButton1.Text;
            }
            try
            {
                double num = int.Parse(textBox11.Text);
                textBox19.Text = DateTime.Now.AddHours(num).ToString();
                DateTime ads = Convert.ToDateTime(textBox19.Text);
                textBox21.Text = ads.AddMinutes(2).ToString();
            }
            catch (Exception)
            {

                label24.Text = ".";
            }

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            g = double.Parse(textBox20.Text.Length.ToString());
            if (g > 0)
            {
                gg = double.Parse("1");
            }
            else
            {
                gg = double.Parse("0");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox16.Visible = true; 
            groupBox33.Visible = false;
            groupBox29.Visible = false;
            tabControl2.Visible = false;
            tabControl2.SendToBack();
            // groupBox24.Visible = false;   
            dataGridView10.Visible = true;
            dataGridView1.SendToBack();
            groupBox15.SendToBack();
            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView1.SendToBack();
            dataGridView2.SendToBack();
            groupBox16.BringToFront();
            //groupBox24.SendToBack();  
            groupBox23.BringToFront();
            this.dataGridView10.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView10.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.RoomSTATUStransactionxxx(conn);
                    if (dr.HasRows)
                    {
                        dataGridView10.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView10.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "<Cancel Now>", dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), DateTime.Now.ToString());
                        }
                    }
                    else
                    {
                        dataGridView10.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox20.Text == "Reserve")
            {
                if (label13.Text == "Check IN")
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Room " + label12.Text + " is NOT available", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                else
                {
                    statuz = aa + bb + cc + dd + ff + gg;
                    if (statuz == 6)
                    {
                        try
                        {
                            add.RID = double.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                            add.GLN = textBox1.Text;
                            add.GFN = textBox2.Text;
                            add.GMN = textBox3.Text;
                            add.GADRESS = textBox4.Text;
                            add.GCN = textBox5.Text;
                            add.GBAL = double.Parse(textBox15.Text);
                            add.GCOMPANION = double.Parse(numericUpDown1.Value.ToString());
                            add.ROOMID = double.Parse(romids.ToString());
                            add.EMPLOYEEID = double.Parse(textBox18.Text);
                            add.STATUAS = "Reserve";
                            add.CHECKIN = CheckINGLOBAL;
                            add.CHECKOUT = textBox21.Text;
                            add.EXPECTEDHOURS = double.Parse(textBox11.Text);
                            add.ROOMBILL = double.Parse(textBox7.Text);
                            add.EXESSTIMESTATUS = double.Parse(textBox12.Text);
                            add.TOTALBILL = double.Parse(textBox15.Text);
                            add.ROOMSTAT = textBox20.Text;
                            add.CreateReservation();
                            add.AddCheckingReservation();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox12.Clear();
                            label25.Text = "0";
                            numericUpDown1.Value = 0;
                            textBox19.Clear();
                            textBox6.Clear();
                            textBox15.Clear();
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            textBox12.Enabled = false;
                            numericUpDown1.Enabled = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            button19.Enabled = false;
                            button17.Enabled = false;
                            dateTimePicker2.Enabled = false;
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            textBox7.Clear();
                            dataGridView3.Rows.Clear();
                            comboBox2.Items.Clear();
                            textBox20.Clear();
                        }
                        catch (Exception)
                        {

                            DialogResult okay = new DialogResult();
                            okay = MessageBox.Show("Complete all the information above", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (okay == DialogResult.OK)
                            {
                                Application.DoEvents();
                            }
                        }
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Complete all the information above", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                }
            }
            else
            {
                if (label13.Text == "Check IN")
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Room " + label12.Text + " is NOT available", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                else
                {
                    statuz = aa + bb + cc + dd + ff + gg;
                    if (statuz == 6)
                    {
                        try
                        {
                            add.RID = double.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                            add.GLN = textBox1.Text;
                            add.GFN = textBox2.Text;
                            add.GMN = textBox3.Text;
                            add.GADRESS = textBox4.Text;
                            add.GCN = textBox5.Text;
                            add.GBAL = double.Parse(textBox15.Text);
                            add.GCOMPANION = double.Parse(numericUpDown1.Value.ToString());
                            add.ROOMID = double.Parse(romids.ToString());
                            add.EMPLOYEEID = double.Parse(textBox18.Text);
                            add.STATUAS = "Check IN";
                            add.CHECKIN = DateTime.Now.ToString();
                            add.CHECKOUT = textBox21.Text;
                            add.EXPECTEDHOURS = double.Parse(textBox11.Text);
                            add.ROOMBILL = double.Parse(textBox7.Text);
                            add.EXESSTIMESTATUS = double.Parse(textBox12.Text);
                            add.TOTALBILL = double.Parse(textBox15.Text);
                            add.ROOMSTAT = textBox20.Text;
                            add.CreateReservation2();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox12.Clear();
                            label25.Text = "0";
                            numericUpDown1.Value = 0;
                            textBox19.Clear();
                            textBox6.Clear();
                            textBox15.Clear();
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            textBox12.Enabled = false;
                            numericUpDown1.Enabled = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            button19.Enabled = false;
                            button17.Enabled = false;
                            dateTimePicker2.Enabled = false;
                            textBox7.Clear();
                            dataGridView3.Rows.Clear();
                            comboBox2.Items.Clear();
                            textBox20.Clear();

                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Complete all the information above", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox12.Clear();
            label25.Text = "0";
            numericUpDown1.Value = 0;
            textBox19.Clear();
            textBox6.Clear();
            textBox15.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
      
            groupBox5.SendToBack();
            dataGridView2.SendToBack();
            groupBox23.SendToBack();
            groupBox29.SendToBack();
            tabControl2.SendToBack();

            dataGridView4.Visible = true; 
            groupBox33.Visible = false;
            groupBox29.Visible = false;
            //groupBox24.SendToBack();  
            dataGridView4.BringToFront();
            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.StartPage(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {
                            double price = double.Parse(dr[3].ToString());
                            string Price = string.Format("{0:N2}", price);
                            dataGridView4.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Price.ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView4.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true; 
            groupBox33.Visible = false;
            groupBox29.Visible = false;
            //groupBox24.SendToBack();  
            groupBox5.BringToFront();
            dataGridView2.SendToBack();
            groupBox23.SendToBack();
            groupBox29.SendToBack();
            tabControl2.SendToBack();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    pay.GLN = textBox22.Text;
                    SqlDataReader dr = pay.SearchGuest(conn);
                    if (dr.HasRows)
                    {
                        textBox23.Clear();
                        textBox24.Clear();
                        textBox25.Clear();
                        listBox1.Items.Clear();
                        comboBox3.Items.Clear();
                        label44.Text = "=================";
                        label45.Text = "=================";
                        label46.Text = "=================";
                        label47.Text = "=================";
                        pay.G.Clear();
                        dataGridView5.Rows.Clear();
                        while (dr.Read())
                        {
                            comboBox3.Items.Clear();
                            listBox1.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString());
                            pay.G.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox3.Items.Clear();
                        textBox23.Clear();
                        textBox24.Clear();
                        textBox25.Clear();
                        dataGridView5.Rows.Clear();
                        listBox1.Items.Clear();
                        label44.Text = "=================";
                        label45.Text = "=================";
                        label46.Text = "=================";
                        label47.Text = "=================";
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
            dataGridView5.Columns[0].ReadOnly = true;
            dataGridView5.Columns[1].ReadOnly = true;
            dataGridView5.Columns[2].ReadOnly = true;
            this.dataGridView5.RowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            try
            {
                pay.GUESTID = Convert.ToInt32(pay.G[listBox1.SelectedIndex]);
                guestingid = double.Parse(pay.GUESTID.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.SearchGuestID(conn);
                    if (dr.HasRows)
                    {
                        textBox23.Clear();
                        comboBox3.Items.Clear();
                        textBox24.Clear();
                        textBox25.Clear();
                        while (dr.Read())
                        {
                            label44.Text = dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString();
                            label45.Text = dr[5].ToString();
                            label46.Text = dr[4].ToString();
                            label47.Text = dr[6].ToString();
                            double b = double.Parse(label47.Text);
                            string la = string.Format("{0:N2}", b);
                            label47.Text = la.ToString();
                        }
                    }
                    else
                    {
                        comboBox3.Items.Clear();
                        textBox23.Clear();
                        textBox24.Clear();
                        textBox25.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                pay.GUESTID = Convert.ToInt32(pay.G[listBox1.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.SearchGuestIDTransaction(conn);
                    if (dr.HasRows)
                    {
                        dataGridView5.Rows.Clear();
                        while (dr.Read())
                        {
                            double price = double.Parse(dr[2].ToString());
                            string Price = string.Format("{0:N2}", price);
                            dataGridView5.Rows.Add(dr[0].ToString(), dr[1].ToString(), Price.ToString(), dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView5.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox24.Enabled = true;
            try
            {
                residszxc = double.Parse(dataGridView5.CurrentRow.Cells[3].Value.ToString());
                textBox23.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
                comboBox3.Items.Clear();
                comboBox3.Items.Add(dataGridView5.CurrentRow.Cells[1].Value.ToString());
                double n = double.Parse(textBox23.Text);
                string mn = string.Format("{0:N2}", n);
                textBox23.Text = mn.ToString();
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox23.Text);
            double resultes = x / 2;
            if (double.Parse(textBox24.Text)>=resultes)
            {
                try
                {
                    if (double.Parse(textBox24.Text) <= double.Parse(textBox23.Text))
                    {
                        double t4 = double.Parse(textBox24.Text);
                        double t3 = double.Parse(textBox23.Text);
                        double ansers = t3 - t4;
                        string converted = string.Format("{0:N2}", ansers);
                        textBox25.Text = converted.ToString();

                    }
                    else
                    {

                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Enter Proper Amount", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                        textBox24.Clear();
                        textBox25.Clear();
                    }
                }
                catch (Exception)
                {
                    textBox24.Clear();
                    textBox25.Clear();
                    label24.Text = ".";
                }    
            }
            else
            {
                textBox25.Text = "50 % and aBove(down Payment)"; 
            }
            
            }
            catch (Exception)
            {
                
                  label24.Text = ".";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton3.Checked == true)
                {
                    textBox26.Text = radioButton3.Text;
                    textBox24.Enabled = true;
                    textBox24.Clear();
                    textBox25.Clear();
                }
                else
                {
                    textBox26.Text = radioButton4.Text;
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton4.Checked == true)
                {
                    textBox26.Text = radioButton4.Text;
                    double bn = double.Parse(textBox23.Text);
                    textBox24.Text = bn.ToString();
                    textBox24.Enabled = false;

                }
                else
                {
                    textBox26.Text = radioButton3.Text;
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox23.Text) == 0.00)
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("You are already paid: No need to pay again. Thank you.", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                else
                {
                    try
                    {
                        conn = Connection.ConnectToServer();
                        if (conn.State == ConnectionState.Open)
                        {
                            pay.CHEKIZ = residszxc;
                            pay.GUESTIDS = guestingid;
                            pay.EMPLOYEEIDS = double.Parse(textBox18.Text);
                            pay.TOTALBILLTOPAYEd = double.Parse(textBox23.Text);
                            pay.CREDITCASHSTATUS = textBox26.Text;
                            pay.CREDITCASHPAYMENTS = double.Parse(textBox24.Text);
                            pay.PAYMENTSBALANCE = double.Parse(textBox25.Text);
                            pay.AddPayments_Guest(conn);
                            pay.UpdateGuestBalance(conn);
                            pay.UpdateReservationBalance(conn);

                            textBox22.Clear();
                            textBox23.Clear();
                            textBox24.Clear();
                            textBox25.Clear();
                            listBox1.Items.Clear();
                            comboBox3.Items.Clear();
                            label44.Text = "=================";
                            label45.Text = "=================";
                            label46.Text = "=================";
                            label47.Text = "=================";
                            dataGridView5.Rows.Clear();
                            radioButton3.Checked = false;
                            radioButton4.Checked = false;
                        }
                    }
                    catch (Exception)
                    {

                        label24.Text = ".";
                    }
                    finally { conn.Close(); }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }


        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    pay.GLN = textBox27.Text;
                    SqlDataReader dr = pay.SearchGuest(conn);
                    if (dr.HasRows)
                    {
                        listBox3.Items.Clear();
                        textBox29.Clear();
                        textBox30.Clear();
                        textBox31.Clear();
                        listBox2.Items.Clear();
                        comboBox4.Items.Clear();
                        label54.Text = "=================";
                        label55.Text = "=================";
                        label56.Text = "=================";
                        label57.Text = "=================";
                        pay.G.Clear();
                        dataGridView6.Rows.Clear();
                        while (dr.Read())
                        {
                            comboBox4.Items.Clear();
                            listBox2.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString());
                            pay.G.Add(dr[0]);
                        }
                    }
                    else
                    {
                        listBox3.Items.Clear();
                        textBox29.Clear();
                        textBox30.Clear();
                        textBox31.Clear();
                        dataGridView6.Rows.Clear();
                        listBox2.Items.Clear();
                        comboBox4.Items.Clear();
                        label54.Text = "=================";
                        label55.Text = "=================";
                        label56.Text = "=================";
                        label57.Text = "=================";
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
            dataGridView6.Columns[0].ReadOnly = true;
            dataGridView6.Columns[1].ReadOnly = true;
            dataGridView6.Columns[2].ReadOnly = true;
            this.dataGridView6.RowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView6.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            try
            {
                pay.GUESTID = Convert.ToInt32(pay.G[listBox2.SelectedIndex]);
                guestingid = double.Parse(pay.GUESTID.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.SearchGuestID(conn);
                    if (dr.HasRows)
                    {
                        textBox29.Clear();
                        comboBox4.Items.Clear();
                        textBox30.Clear();
                        textBox31.Clear();
                        while (dr.Read())
                        {
                            label57.Text = dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString();
                            label56.Text = dr[5].ToString();
                            label55.Text = dr[4].ToString();
                            label54.Text = dr[6].ToString();
                            double b = double.Parse(label54.Text);
                            string la = string.Format("{0:N2}", b);
                            label54.Text = la.ToString();
                        }
                    }
                    else
                    {
                        comboBox4.Items.Clear();
                        textBox29.Clear();
                        textBox30.Clear();
                        textBox31.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                pay.GUESTID = Convert.ToInt32(pay.G[listBox2.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.SearchGuestIDTransaction(conn);
                    if (dr.HasRows)
                    {
                        dataGridView6.Rows.Clear();
                        while (dr.Read())
                        {
                            double price = double.Parse(dr[2].ToString());
                            string Price = string.Format("{0:N2}", price);
                            dataGridView6.Rows.Add(dr[0].ToString(), dr[1].ToString(), Price.ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                        }
                    }
                    else
                    {
                        dataGridView6.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }


            try
            {
                pay.GUESTID = Convert.ToInt32(pay.G[listBox2.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.SearchGuestIDWithPayments(conn);
                    if (dr.HasRows)
                    {
                        listBox3.Items.Clear();
                        while (dr.Read())
                        {
                            listBox3.Items.Add("---------------------------Payments history--------------------------");
                            double dr2 = double.Parse(dr[2].ToString());
                            double dr3 = double.Parse(dr[3].ToString());
                            double dr4 = double.Parse(dr[4].ToString());
                            string DR2 = string.Format("{0:N2}", dr2);
                            string DR3 = string.Format("{0:N2}", dr3);
                            string DR4 = string.Format("{0:N2}", dr4);
                            listBox3.Items.Add("Date Paid: \t" + dr[1].ToString());
                            listBox3.Items.Add("Amount:    \t" + DR2.ToString());
                            listBox3.Items.Add("Credit:    \t\t" + DR3.ToString());
                            listBox3.Items.Add("Balance:   \t" + DR4.ToString());
                            listBox3.Items.Add("  ");
                        }
                    }
                    else
                    {
                        listBox3.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CheckINDAAAAAAAAAATEMM = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(CheckINDAAAAAAAAAATEMM.ToString()); 
            textBox30.Enabled = true;
            try
            {
                residszxc = double.Parse(dataGridView6.CurrentRow.Cells[3].Value.ToString());
                textBox31.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
                comboBox4.Items.Clear();
                comboBox4.Items.Add(dataGridView6.CurrentRow.Cells[1].Value.ToString());
                double n = double.Parse(textBox31.Text);
                string mn = string.Format("{0:N2}", n);
                textBox33.Text = dataGridView6.CurrentRow.Cells[4].Value.ToString();
                idoftherum = double.Parse(dataGridView6.CurrentRow.Cells[5].Value.ToString());
                CheckINDAAAAAAAAAATEMM = dataGridView6.CurrentRow.Cells[0].Value.ToString();
                //MessageBox.Show(idoftherum.ToString());  
                textBox31.Text = mn.ToString();
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox30.Text) <= double.Parse(textBox31.Text))
                {
                    double t4 = double.Parse(textBox30.Text);
                    double t3 = double.Parse(textBox31.Text);
                    double ansers = t3 - t4;
                    string converted = string.Format("{0:N2}", ansers);
                    textBox29.Text = converted.ToString();

                }
                else
                {

                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Enter Proper Amount", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                    textBox30.Clear();
                    textBox31.Clear();
                }
            }
            catch (Exception)
            {
                textBox30.Clear();
                textBox29.Clear();
                label24.Text = ".";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime Datenow = Convert.ToDateTime(DateTime.Now.ToString());
            DateTime Dateszzzz = Convert.ToDateTime(CheckINDAAAAAAAAAATEMM);
            if (Datenow <= Dateszzzz)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Conflict time: Expected date of CheckIN is: " + Dateszzzz + "", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            else
            {
                try
                {
                    if (double.Parse(textBox31.Text) == 0.00)
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("You are already paid: No need to pay again. Thank you.", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                    else
                    {
                        try
                        {
                            conn = Connection.ConnectToServer();
                            if (conn.State == ConnectionState.Open)
                            {
                                pay.ROOMIDC = idoftherum;
                                pay.CHEKIZ = residszxc;
                                pay.GUESTIDS = guestingid;
                                pay.EMPLOYEEIDS = double.Parse(textBox18.Text);
                                pay.TOTALBILLTOPAYEd = double.Parse(textBox31.Text);
                                pay.CREDITCASHSTATUS = textBox28.Text;
                                pay.CREDITCASHPAYMENTS = double.Parse(textBox30.Text);
                                pay.PAYMENTSBALANCE = double.Parse(textBox29.Text);
                                pay.OUSTSSSSSSSSSSSSSSSS = textBox32.Text;
                                pay.AddPayments_Guest(conn);
                                pay.UpdateGuestBalance(conn);
                                pay.UpdateReservationBalance(conn);
                                pay.UpdateGuestReservationToCheckIN(conn);
                                pay.UpdateReservationRoomDetailsStatus(conn);

                                listBox3.Items.Clear();
                                textBox29.Clear();
                                textBox27.Clear();
                                textBox30.Clear();
                                textBox31.Clear();
                                textBox33.Clear();
                                textBox32.Clear();
                                listBox2.Items.Clear();
                                comboBox4.Items.Clear();
                                label54.Text = "=================";
                                label55.Text = "=================";
                                label56.Text = "=================";
                                label57.Text = "=================";
                                dataGridView6.Rows.Clear();
                                checkBox1.Checked = false;
                            }
                        }
                        catch (Exception)
                        {

                            label24.Text = ".";
                        }
                        finally { conn.Close(); }
                    }
                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPage1.Text == "Payments(Reservation)")
            {
                label93.Text = "=================";
                label92.Text = "=================";
                label91.Text = "=================";
                label90.Text = "=================";
                textBox45.Clear();
                textBox44.Clear();
                textBox43.Clear();
                dataGridView9.Rows.Clear();
                listBox7.Items.Clear();
                textBox47.Clear();
                listBox3.Items.Clear();
                textBox29.Clear();
                textBox27.Clear();
                textBox30.Clear();
                textBox31.Clear();
                textBox33.Clear();
                textBox32.Clear();
                listBox2.Items.Clear();
                comboBox4.Items.Clear();
                label54.Text = "=================";
                label55.Text = "=================";
                label56.Text = "=================";
                label57.Text = "=================";
                dataGridView6.Rows.Clear();
                checkBox1.Checked = false;
                textBox40.Clear();
                checkBox2.Checked = false;
                textBox39.Clear();
                textBox38.Clear();
                textBox37.Clear();
                textBox36.Clear();
                textBox35.Clear();
                textBox34.Clear();
                comboBox5.Items.Clear();
                label76.Text = "=================";
                label75.Text = "=================";
                label74.Text = "=================";
                label73.Text = "=================";
                listBox4.Items.Clear();
                dataGridView7.Rows.Clear();
            }

            if (tabPage2.Text == "Payments CheckIN(After Reservation)")
            {
                label93.Text = "=================";
                label92.Text = "=================";
                label91.Text = "=================";
                label90.Text = "=================";
                textBox45.Clear();
                textBox44.Clear();
                textBox43.Clear();
                dataGridView9.Rows.Clear();
                listBox7.Items.Clear();
                textBox47.Clear();
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                listBox1.Items.Clear();
                comboBox3.Items.Clear();
                label44.Text = "=================";
                label45.Text = "=================";
                label46.Text = "=================";
                label47.Text = "=================";
                dataGridView5.Rows.Clear();
                textBox40.Clear();
                checkBox2.Checked = false;
                textBox39.Clear();
                textBox38.Clear();
                textBox37.Clear();
                textBox36.Clear();
                textBox35.Clear();
                textBox34.Clear();
                comboBox5.Items.Clear();
                label76.Text = "=================";
                label75.Text = "=================";
                label74.Text = "=================";
                label73.Text = "=================";
                listBox4.Items.Clear();
                dataGridView7.Rows.Clear();
            }


            if (tabPage3.Text == "Payments(Direct CheckIN)")
            {
                label93.Text = "=================";
                label92.Text = "=================";
                label91.Text = "=================";
                label90.Text = "=================";
                textBox45.Clear();
                textBox44.Clear();
                textBox43.Clear();
                dataGridView9.Rows.Clear();
                listBox7.Items.Clear();
                textBox47.Clear();
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                listBox1.Items.Clear();
                comboBox3.Items.Clear();
                label44.Text = "=================";
                label45.Text = "=================";
                label46.Text = "=================";
                label47.Text = "=================";
                dataGridView5.Rows.Clear();

                listBox3.Items.Clear();
                textBox29.Clear();
                textBox27.Clear();
                textBox30.Clear();
                textBox31.Clear();
                textBox33.Clear();
                textBox32.Clear();
                listBox2.Items.Clear();
                comboBox4.Items.Clear();
                label54.Text = "=================";
                label55.Text = "=================";
                label56.Text = "=================";
                label57.Text = "=================";
                dataGridView6.Rows.Clear();
                checkBox1.Checked = false;
            }

            if (tabPage4.Text == "Charges")
            {
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                listBox1.Items.Clear();
                comboBox3.Items.Clear();
                label44.Text = "=================";
                label45.Text = "=================";
                label46.Text = "=================";
                label47.Text = "=================";
                dataGridView5.Rows.Clear();

                listBox3.Items.Clear();
                textBox29.Clear();
                textBox27.Clear();
                textBox30.Clear();
                textBox31.Clear();
                textBox33.Clear();
                textBox32.Clear();
                listBox2.Items.Clear();
                comboBox4.Items.Clear();
                label54.Text = "=================";
                label55.Text = "=================";
                label56.Text = "=================";
                label57.Text = "=================";
                dataGridView6.Rows.Clear();
                checkBox1.Checked = false;
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox28.Text = checkBox1.Text;
                try
                {
                    double se = double.Parse(textBox33.Text);
                    DateTime b = Convert.ToDateTime(DateTime.Now.ToString());
                    DateTime v = Convert.ToDateTime(b.AddHours(se).ToString());
                    DateTime Xz = Convert.ToDateTime(v.AddMinutes(2).ToString());
                    textBox32.Text = Xz.ToString();
                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }
            else
            {
                textBox28.Clear();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            textBox29.Clear();
            textBox27.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox33.Clear();
            textBox32.Clear();
            listBox2.Items.Clear();
            comboBox4.Items.Clear();
            label54.Text = "=================";
            label55.Text = "=================";
            label56.Text = "=================";
            label57.Text = "=================";
            dataGridView6.Rows.Clear();
            checkBox1.Checked = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            listBox1.Items.Clear();
            comboBox3.Items.Clear();
            label44.Text = "=================";
            label45.Text = "=================";
            label46.Text = "=================";
            label47.Text = "=================";
            dataGridView5.Rows.Clear();
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    pay.LIKETHENAME = textBox40.Text;
                    SqlDataReader dr = pay.SearchCheckINPAYMENTSzTotalization(conn);
                    if (dr.HasRows)
                    {
                        checkBox2.Checked = false;
                        textBox39.Clear();
                        textBox38.Clear();
                        textBox37.Clear();
                        textBox36.Clear();
                        textBox35.Clear();
                        textBox34.Clear();
                        comboBox5.Items.Clear();
                        label76.Text = "=================";
                        label75.Text = "=================";
                        label74.Text = "=================";
                        label73.Text = "=================";
                        listBox4.Items.Clear();
                        dataGridView7.Rows.Clear();
                        pay.CUSTNEW.Clear();
                        while (dr.Read())
                        {
                            listBox4.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString());
                            pay.CUSTNEW.Add(dr[0]);
                        }
                    }
                    else
                    {
                        checkBox2.Checked = false;
                        textBox39.Clear();
                        textBox38.Clear();
                        textBox37.Clear();
                        textBox36.Clear();
                        textBox35.Clear();
                        textBox34.Clear();
                        comboBox5.Items.Clear();
                        label76.Text = "=================";
                        label75.Text = "=================";
                        label74.Text = "=================";
                        label73.Text = "=================";
                        listBox4.Items.Clear();
                        dataGridView7.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView7.Columns[0].ReadOnly = true;
            dataGridView7.Columns[1].ReadOnly = true;
            dataGridView7.Columns[2].ReadOnly = true;
            try
            {
                pay.CUSTOMERIADI = Convert.ToInt32(pay.CUSTNEW[listBox4.SelectedIndex]);
                guestingid3 = double.Parse(pay.CUSTOMERIADI.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.CheckINLISTDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView7.Rows.Clear();
                        while (dr.Read())
                        {
                            double price = double.Parse(dr[2].ToString());
                            string Price = string.Format("{0:N2}", price);
                            dataGridView7.Rows.Add(dr[0].ToString(), dr[1].ToString(), Price.ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                        }
                    }
                    else
                    {
                        dataGridView7.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                pay.CUSTOMERIADI = Convert.ToInt32(pay.CUSTNEW[listBox4.SelectedIndex]);
                guestingid3 = double.Parse(pay.CUSTOMERIADI.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.CustomerDetalye(conn);
                    if (dr.HasRows)
                    {
                        label76.Text = "=================";
                        label75.Text = "=================";
                        label74.Text = "=================";
                        label73.Text = "=================";
                        while (dr.Read())
                        {
                            label76.Text = dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString();
                            label75.Text = dr[5].ToString();
                            label74.Text = dr[4].ToString();
                            label73.Text = dr[6].ToString();
                        }
                    }
                    else
                    {
                        label76.Text = "=================";
                        label75.Text = "=================";
                        label74.Text = "=================";
                        label73.Text = "=================";
                    }
                }
            }
            catch (Exception)
            {
                //throw;
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void dataGridView7_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                textBox37.Enabled = true;
                residszxc = double.Parse(dataGridView7.CurrentRow.Cells[3].Value.ToString());
                textBox38.Text = dataGridView7.CurrentRow.Cells[2].Value.ToString();
                comboBox5.Items.Clear();
                comboBox5.Items.Add(dataGridView7.CurrentRow.Cells[1].Value.ToString());
                double n = double.Parse(textBox38.Text);
                string mn = string.Format("{0:N2}", n);
                textBox39.Text = dataGridView7.CurrentRow.Cells[4].Value.ToString();
                idoftherum = double.Parse(dataGridView7.CurrentRow.Cells[5].Value.ToString());
                // MessageBox.Show(idoftherum.ToString());  
                textBox38.Text = mn.ToString();
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox37.Text) <= double.Parse(textBox38.Text))
                {
                    double t4 = double.Parse(textBox37.Text);
                    double t3 = double.Parse(textBox38.Text);
                    double ansers = t3 - t4;
                    string converted = string.Format("{0:N2}", ansers);
                    textBox36.Text = converted.ToString();

                }
                else
                {

                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Enter Proper Amount", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                    textBox37.Clear();

                }
            }
            catch (Exception)
            {
                textBox37.Clear();
                textBox36.Clear();
                label24.Text = ".";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox35.Text = checkBox2.Text;
                try
                {
                    double se = double.Parse(textBox39.Text);
                    DateTime b = Convert.ToDateTime(DateTime.Now.ToString());
                    DateTime v = Convert.ToDateTime(b.AddHours(se).ToString());
                    DateTime Xz = Convert.ToDateTime(v.AddMinutes(2).ToString());
                    textBox34.Text = Xz.ToString();
                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }
            else
            {
                textBox35.Clear();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox35.Text == "Cash")
            {
                try
                {
                    if (double.Parse(textBox38.Text) == 0.00)
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("You are already paid: No need to pay again. Thank you.", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                    else
                    {
                        try
                        {
                            conn = Connection.ConnectToServer();
                            if (conn.State == ConnectionState.Open)
                            {
                                pay.ROOMIDC = idoftherum;
                                pay.CHEKIZ = residszxc;
                                pay.GUESTIDS = guestingid3;
                                pay.EMPLOYEEIDS = double.Parse(textBox18.Text);
                                pay.TOTALBILLTOPAYEd = double.Parse(textBox38.Text);
                                pay.CREDITCASHSTATUS = textBox35.Text;
                                pay.CREDITCASHPAYMENTS = double.Parse(textBox37.Text);
                                pay.PAYMENTSBALANCE = double.Parse(textBox36.Text);
                                pay.AddPayments_Guest(conn);
                                pay.UpdateGuestBalance(conn);
                                pay.UpdateReservationBalance(conn);
                                textBox40.Clear();
                                checkBox2.Checked = false;
                                textBox39.Clear();
                                textBox38.Clear();
                                textBox37.Clear();
                                textBox36.Clear();
                                textBox35.Clear();
                                textBox34.Clear();
                                comboBox5.Items.Clear();
                                label76.Text = "=================";
                                label75.Text = "=================";
                                label74.Text = "=================";
                                label73.Text = "=================";
                                listBox4.Items.Clear();
                                dataGridView7.Rows.Clear();
                            }
                        }
                        catch (Exception)
                        {

                            label24.Text = ".";
                        }
                        finally { conn.Close(); }
                    }
                }
                catch (Exception)
                {
                    throw;
                    //label24.Text = ".";
                }
            }
            else
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Check the (Cash box text below)", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if (sender == timer1)
            //{
            //    dateex = DateTime.Now.ToString("hh:mm:ss tt");
            //}
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            groupBox15.Visible = true; 
            groupBox33.Visible = false;
            groupBox29.Visible = false;
            tabControl2.Visible = false;
            dataGridView8.Visible = true;

            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView2.SendToBack();
            groupBox23.SendToBack();
            groupBox29.SendToBack();
            tabControl2.SendToBack();

            //groupBox24.SendToBack();  
            groupBox16.SendToBack();
            dataGridView2.SendToBack();
            groupBox15.BringToFront();
            this.dataGridView8.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView8.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.RoomSTATUStransactionCheck(conn);
                    if (dr.HasRows)
                    {
                        dataGridView8.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView8.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                        }
                    }
                    else
                    {
                        dataGridView8.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //int intpart = (int)3.99999999999;
            //MessageBox.Show(intpart.ToString());  
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 10)
            {
                dataGridView2.Columns[15].Visible = true;
                dataGridView2.CurrentRow.Cells[11].Value = DateTime.Now.ToString();
                DateTime NOW = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[11].Value.ToString());
                DateTime Expiry = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[8].Value.ToString());
                TimeSpan Resultscz = NOW - Expiry;
                string j = Resultscz.TotalHours.ToString();

                if (Expiry > NOW)
                {
                    double Tb = double.Parse(dataGridView2.CurrentRow.Cells[20].Value.ToString());
                    dataGridView2.CurrentRow.Cells[12].Value = "Complete: No Charges";
                    dataGridView2.CurrentRow.Cells[13].Value = Reservations.Properties.Resources.Check_iconx;
                    dataGridView2.CurrentRow.Cells[14].Value = "0.00";
                    dataGridView2.CurrentRow.Cells[19].Value = "0.00";
                    double AS = Tb + double.Parse(dataGridView2.CurrentRow.Cells[14].Value.ToString());
                    dataGridView2.CurrentRow.Cells[21].Value = AS.ToString();
                }
                else
                {
                    double Tb = double.Parse(dataGridView2.CurrentRow.Cells[20].Value.ToString());
                    double d = double.Parse(j.ToString());
                    int dd = (int)d;
                    double Incoming_results = dd * GlobalTimeExess;
                    string Incoming_resultsz = string.Format("{0:N2}", Incoming_results);
                    dataGridView2.CurrentRow.Cells[13].Value = Reservations.Properties.Resources.Check_iconx;
                    dataGridView2.CurrentRow.Cells[12].Value = "Complete: The hour/s Excess in:" + dd.ToString() + " Hour/s";
                    dataGridView2.CurrentRow.Cells[19].Value = dd.ToString();
                    dataGridView2.CurrentRow.Cells[12].Style.ForeColor = Color.Red;
                    dataGridView2.CurrentRow.Cells[14].Value = Incoming_resultsz.ToString();
                    double AS = Tb + double.Parse(dataGridView2.CurrentRow.Cells[14].Value.ToString());
                    dataGridView2.CurrentRow.Cells[21].Value = AS.ToString();

                }
            }
            else
            {
                label24.Text = ".";
            }

            if (e.ColumnIndex == 15)
            {
                if (dataGridView2.CurrentRow.Cells[14].Value == "")
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Check the arrow icon first", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                else
                {
                    try
                    {
                        conn = Connection.ConnectToServer();
                        if (conn.State == ConnectionState.Open)
                        {
                            double BillofRights = double.Parse(dataGridView2.CurrentRow.Cells[21].Value.ToString());
                            double Roomidentity = double.Parse(dataGridView2.CurrentRow.Cells[16].Value.ToString());
                            double guestidentity = double.Parse(dataGridView2.CurrentRow.Cells[17].Value.ToString());
                            double reservationIdentyti = double.Parse(dataGridView2.CurrentRow.Cells[18].Value.ToString());
                            string Excez = dataGridView2.CurrentRow.Cells[19].Value.ToString();
                            add.DATED = dataGridView2.CurrentRow.Cells[11].Value.ToString();
                            add.BILLOF = BillofRights;
                            add.GUEST___________ID = guestidentity;
                            add.R_________________________________________________________ = reservationIdentyti;
                            add.R____________ROOM = Roomidentity;
                            add.EXCESSIVE = Excez;
                            add.UPTodateCheckOUT(conn);
                            add.UPTodateCheckOUTRoomAvailability(conn);
                            add.UPTodateCheckOUTRoomAvailabilityCUSTOMER(conn);
                            DialogResult okay = new DialogResult();
                            okay = MessageBox.Show("Check OUT", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (okay == DialogResult.OK)
                            {
                                Application.DoEvents();
                            }
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            groupBox17.Visible = true;
            monthCalendar2.Visible = true;
            dataGridView10.Visible = false;
            groupBox23.SendToBack();
            groupBox16.BringToFront();
            groupBox23.SendToBack();
            dataGridView1.SendToBack();
            groupBox15.SendToBack();
            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView1.SendToBack();
            dataGridView2.SendToBack();
            groupBox16.BringToFront();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            groupBox3.BringToFront();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckINGLOBAL2 = Convert.ToString(add.NAIWAN_NA_RUMIDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDd[comboBox6.SelectedIndex]);
           // MessageBox.Show(CheckINGLOBAL2.ToString()); 
            try
            {

                add.GUEST__________ = Convert.ToInt32(add.GUESTKILANLAN[comboBox6.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ReservationFullPaymentStatus1(conn);
                    if (dr.HasRows)
                    {
                        listBox5.Items.Clear();
                        while (dr.Read())
                        {
                            listBox5.Items.Clear();
                            listBox5.Items.Add("-----------------------------------------------------------------------------------------------------------------------------");
                            listBox5.Items.Add("LastName:\t\t\t" + dr[1].ToString());
                            listBox5.Items.Add("FirstName:\t\t\t" + dr[2].ToString());
                            listBox5.Items.Add("MiddleName:\t\t\t" + dr[3].ToString());
                            listBox5.Items.Add("-----------------------------------------------------------------------------------------------------------------------------");
                        }
                    }
                    else
                    {
                        listBox5.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                add.RESERVATION_______________ = Convert.ToInt32(add.GUESTKILANLANID[comboBox6.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ReservationFullPaymentStatus2(conn);
                    if (dr.HasRows)
                    {
                        listBox6.Items.Clear();
                        while (dr.Read())
                        {
                            double T = double.Parse(dr[0].ToString());
                            string t = string.Format("{0:N2}", T);

                            double B = double.Parse(dr[1].ToString());
                            string b = string.Format("{0:N2}", B);

                            double B1 = double.Parse(dr[2].ToString());
                            string b1 = string.Format("{0:N2}", B1);
                            listBox6.Items.Clear();
                            listBox6.Items.Add("-----------------------------------------------------------------------------------------------------------------------------");
                            listBox6.Items.Add("Total Amount To Paid:\t\t" + t.ToString());
                            listBox6.Items.Add("Cash:\t\t\t\t" + b.ToString());
                            listBox6.Items.Add("Balance:\t\t\t\t" + b1.ToString());
                            listBox6.Items.Add("Date Paid:\t\t\t" + dr[3].ToString());
                            listBox6.Items.Add("-----------------------------------------------------------------------------------------------------------------------------");
                        }
                    }
                    else
                    {
                        listBox6.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            int expectedz = Convert.ToInt32(add.EXPECTEDHOURS_______________[comboBox6.SelectedIndex]);
            DateTime DatesNow = Convert.ToDateTime(DateTime.Now.ToString());
            DateTime casez = DatesNow.AddHours(expectedz);
            DateTime Last = casez.AddMinutes(5);
            UpdatedDate = Last.ToString();
            add.NAIWANROOM = Convert.ToInt32(add.NAIWAN_NA_RUMID[comboBox6.SelectedIndex]);
            // MessageBox.Show(add.NAIWANROOM.ToString());
            //MessageBox.Show(casez.ToString());  

        }

        private void button26_Click(object sender, EventArgs e)
        {
            DateTime dateExpecteds = Convert.ToDateTime(CheckINGLOBAL2.ToString());
            DateTime Datenowes = Convert.ToDateTime(DateTime.Now.ToString());
            if (Datenowes <= dateExpecteds)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("CheckInDATE:  " + dateExpecteds + " You cannot check IN right now", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            else
            {
                try
                {
                    add.RESERVATION_______________ = Convert.ToInt32(add.GUESTKILANLANID[comboBox6.SelectedIndex]);

                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        add.D__________________________ = UpdatedDate.ToString();
                        add.UPTodateCheckin(conn);
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Ok", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                        listBox5.Items.Clear();
                        listBox6.Items.Clear();
                    }
                }
                catch (Exception)
                {

                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Select a Name", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                finally { conn.Close(); }

                try
                {
                    add.NAIWANROOM = Convert.ToInt32(add.NAIWAN_NA_RUMID[comboBox6.SelectedIndex]);
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        add.UPTodateCheckOUTRoomAvailabilityzzzzzzzzzzzzz(conn);
                    }
                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
                finally { conn.Close(); }
                try
                {
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = add.ReservationFullPaymentStatus(conn);
                        if (dr.HasRows)
                        {
                            comboBox6.Items.Clear();
                            add.GUESTKILANLAN.Clear();
                            add.GUESTKILANLANID.Clear();
                            while (dr.Read())
                            {
                                comboBox6.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + "  " + dr[3].ToString());
                                add.GUESTKILANLAN.Add(dr[0]);
                                add.GUESTKILANLANID.Add(dr[4]);
                            }
                        }
                        else
                        {
                            comboBox6.Items.Clear();
                        }
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    pay.LIKETHENAME = textBox47.Text;
                    SqlDataReader dr = pay.SearchCheckINPAYMENTSzTotalizationCHARGES(conn);
                    if (dr.HasRows)
                    {
                        listBox7.Items.Clear();
                        pay.CUSTNEW.Clear();
                        while (dr.Read())
                        {
                            listBox7.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString());
                            pay.CUSTNEW.Add(dr[0]);
                        }
                    }
                    else
                    {
                        listBox7.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView9.Columns[0].ReadOnly = true;
            dataGridView9.Columns[1].ReadOnly = true;
            dataGridView9.Columns[2].ReadOnly = true;
            try
            {
                pay.CUSTOMERIADI = Convert.ToInt32(pay.CUSTNEW[listBox7.SelectedIndex]);
                guestingid3 = double.Parse(pay.CUSTOMERIADI.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.CheckINLISTDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView9.Rows.Clear();
                        while (dr.Read())
                        {
                            double price = double.Parse(dr[2].ToString());
                            string Price = string.Format("{0:N2}", price);
                            dataGridView9.Rows.Add(dr[0].ToString(), dr[1].ToString(), Price.ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                        }
                    }
                    else
                    {
                        dataGridView9.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                pay.CUSTOMERIADI = Convert.ToInt32(pay.CUSTNEW[listBox7.SelectedIndex]);
                //guestingid3 = double.Parse(pay.CUSTOMERIADI.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = pay.CustomerDetalye(conn);
                    if (dr.HasRows)
                    {
                        label93.Text = "=================";
                        label92.Text = "=================";
                        label91.Text = "=================";
                        label90.Text = "=================";
                        while (dr.Read())
                        {
                            label93.Text = dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString();
                            label92.Text = dr[5].ToString();
                            label91.Text = dr[4].ToString();
                            double lo9 = double.Parse(dr[6].ToString());
                            string LO9 = string.Format("{0:N2}", lo9);
                            label90.Text = LO9.ToString();
                        }
                    }
                    else
                    {
                        label93.Text = "=================";
                        label92.Text = "=================";
                        label91.Text = "=================";
                        label90.Text = "=================";
                    }
                }
            }
            catch (Exception)
            {
                //throw;
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void dataGridView9_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox44.Enabled = true;
                textBox45.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
                ChechOUTReservationGlobal = double.Parse(dataGridView9.CurrentRow.Cells[3].Value.ToString());
                //MessageBox.Show(ChechOUTReservationGlobal.ToString());
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double t45 = double.Parse(textBox45.Text);
                double t44 = double.Parse(textBox44.Text);
                double resres = t45 - t44;

                if (t44 > t45)
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Enter Enough Amount", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                    textBox43.Clear();
                }
                else
                {
                    textBox43.Text = resres.ToString();
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
                textBox43.Clear();
                textBox44.Clear();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    if (textBox41.Text == "Cash")
                    {
                        pay.CHEKIZ = ChechOUTReservationGlobal;
                        pay.GUESTIDS = guestingid3;
                        pay.EMPLOYEEIDS = double.Parse(textBox18.Text);
                        pay.TOTALBILLTOPAYEd = double.Parse(textBox45.Text);
                        pay.CREDITCASHSTATUS = textBox41.Text;
                        pay.CREDITCASHPAYMENTS = double.Parse(textBox44.Text);
                        pay.PAYMENTSBALANCE = double.Parse(textBox43.Text);
                        pay.AddPayments_Guest(conn);
                        pay.UpdateGuestBalance(conn);
                        pay.UpdateReservationBalance(conn);
                        label93.Text = "=================";
                        label92.Text = "=================";
                        label91.Text = "=================";
                        label90.Text = "=================";
                        textBox45.Clear();
                        textBox44.Clear();
                        textBox43.Clear();
                        dataGridView9.Rows.Clear();
                        listBox7.Items.Clear();
                        textBox47.Clear();
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Complete the information.", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }

                }
            }
            catch (Exception)
            {

                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Enter proper Data", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label93.Text = "=================";
            label92.Text = "=================";
            label91.Text = "=================";
            label90.Text = "=================";
            textBox45.Clear();
            textBox44.Clear();
            textBox43.Clear();
            dataGridView9.Rows.Clear();
            listBox7.Items.Clear();
            textBox47.Clear();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox41.Text = checkBox3.Text;
            }
            else
            {
                textBox41.Clear();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ReservationFullPaymentStatus(conn);
                    if (dr.HasRows)
                    {
                        comboBox6.Items.Clear();
                        add.GUESTKILANLAN.Clear();
                        add.GUESTKILANLANID.Clear();
                        add.NAIWAN_NA_RUMID.Clear();
                        add.EXPECTEDHOURS_______________.Clear();
                        add.NAIWAN_NA_RUMIDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDd.Clear();
                        while (dr.Read())
                        {
                            comboBox6.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + "  " + dr[3].ToString());
                            add.GUESTKILANLAN.Add(dr[0]);
                            add.GUESTKILANLANID.Add(dr[4]);
                            add.EXPECTEDHOURS_______________.Add(dr[5].ToString());
                            add.NAIWAN_NA_RUMID.Add(dr[6].ToString());
                            add.NAIWAN_NA_RUMIDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDd.Add(dr[7]); 
                        }
                    }
                    else
                    {
                        comboBox6.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        //=====================================================================================================================================================
        private void dataGridView10_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {

                    try
                    {
                        dataGridView10.CurrentRow.Cells[14].Value = "Refund Payments.(50 Percent of the down payment)";
                        //DateTime first = Convert.ToDateTime(dataGridView10.CurrentRow.Cells[11].Value.ToString());
                        //DateTime second = Convert.ToDateTime(dataGridView10.CurrentRow.Cells[12].Value.ToString());
                        //TimeSpan third = second - first;
                        //dataGridView10.CurrentRow.Cells[13].Value = third.Minutes.ToString();
                        //double intervals = double.Parse(dataGridView10.CurrentRow.Cells[13].Value.ToString());
                        //if (intervals > 30)
                        //{
                        //    dataGridView10.CurrentRow.Cells[14].Value = "Can't refund Payments.";
                        //}
                        //else
                        //{
                        //    dataGridView10.CurrentRow.Cells[14].Value = "Refund Payments.";
                        //}
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    //MessageBox.Show(third.Minutes.ToString());  
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Are you sure you want to cancel the specific reservation?", "RDG Hotel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (okay == DialogResult.OK)
                    {
                        try
                        {
                            fro.RESERVATIONid = double.Parse(dataGridView10.CurrentRow.Cells[8].Value.ToString());
                            fro.NAIWANROOM = double.Parse(dataGridView10.CurrentRow.Cells[9].Value.ToString());
                            conn = Connection.ConnectToServer();
                            if (conn.State == ConnectionState.Open)
                            {
                                fro.Cancelation(conn);
                                fro.UPTodateCheckOUTRoomAvailabilityzzzzzzzzzzzzz(conn);
                                DialogResult okayz = new DialogResult();
                                okayz = MessageBox.Show("Canceled", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (okayz == DialogResult.OK)
                                {
                                    Application.DoEvents();
                                }
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        finally { conn.Close(); }



                        this.dataGridView10.RowsDefaultCellStyle.BackColor = Color.White;
                        this.dataGridView10.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
                        try
                        {
                            conn = Connection.ConnectToServer();
                            if (conn.State == ConnectionState.Open)
                            {
                                SqlDataReader dr = add.RoomSTATUStransactionxxx(conn);
                                if (dr.HasRows)
                                {
                                    dataGridView10.Rows.Clear();
                                    while (dr.Read())
                                    {
                                        dataGridView10.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "<Cancel Now>", dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), DateTime.Now.ToString());
                                    }
                                }
                                else
                                {
                                    dataGridView10.Rows.Clear();
                                }
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        finally { conn.Close(); }
                    }
                    if (okay == DialogResult.Cancel)
                    {
                        //MessageBox.Show("no"); 
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }
        //=====================================================================================================================================================
        private void button31_Click(object sender, EventArgs e)
        {
            groupBox32.Visible = false; 
            tabControl2.Visible = true; 
            groupBox33.Visible = false;
            groupBox29.Visible = false;
            this.dataGridView13.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView13.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            tabControl2.Visible = true;
            groupBox17.Visible = false;
            monthCalendar2.Visible = false;
            dataGridView1.SendToBack();
            dataGridView2.Visible = false;
            dataGridView2.SendToBack();
            groupBox15.SendToBack();
            groupBox3.SendToBack();
            dataGridView4.SendToBack();
            groupBox5.SendToBack();
            dataGridView1.SendToBack();
            dataGridView2.SendToBack();
            groupBox16.SendToBack();
            groupBox23.SendToBack();
            dataGridView8.SendToBack();
            tabControl2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox25_Enter(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                fro.DATE11 = dateTimePicker11.Text + " 12:01:00 AM";
                fro.DATE22 = dateTimePicker12.Text + " 11:59:00 PM";
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.PopulateSQltransactionReservation(conn);
                    if (dr.HasRows)
                    {
                        dataGridView13.Rows.Clear();
                        while (dr.Read())
                        {
                            this.dataGridView13.RowsDefaultCellStyle.BackColor = Color.White;
                            this.dataGridView13.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
                            dataGridView13.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                    }
                    else
                    {
                        this.dataGridView13.RowsDefaultCellStyle.BackColor = Color.White;
                        this.dataGridView13.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                        dataGridView13.Rows.Clear();
                        dataGridView13.Rows.Add(10);
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView13.Rows)
                {
                    pr.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), "", item.Cells[7].Value.ToString(), dateTimePicker11.Text + " \t\t" + "Check OUT Details:", dateTimePicker12.Text);
                }

                Printing.Print1 frm = new Reservations.Printing.Print1();
                frm.Prints = pr;
                frm.ShowDialog();
                pr.Tables["DataTable1"].Rows.Clear();

            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                fro.DATE11 = dateTimePicker7.Text + " 12:01:00 AM";
                fro.DATE22 = dateTimePicker8.Text + " 11:59:00 PM";
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.PopulateSQltransactionReservation________________________________(conn);
                    if (dr.HasRows)
                    {
                        dataGridView11.Rows.Clear();
                        while (dr.Read())
                        {
                            this.dataGridView11.RowsDefaultCellStyle.BackColor = Color.White;
                            this.dataGridView11.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
                            dataGridView11.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                    }
                    else
                    {
                        this.dataGridView11.RowsDefaultCellStyle.BackColor = Color.White;
                        this.dataGridView11.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                        dataGridView11.Rows.Clear();
                        dataGridView11.Rows.Add(10);
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView11.Rows)
                {
                    pr.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), "", item.Cells[7].Value.ToString(), dateTimePicker7.Text + " \t\t" + "Check IN Details:", dateTimePicker8.Text);
                }

                Printing.Print1 frm = new Reservations.Printing.Print1();
                frm.Prints = pr;
                frm.ShowDialog();
                pr.Tables["DataTable1"].Rows.Clear();

            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.BBBBBBBBBBBBBBBBBBBBBBBBBBLZZZZZZZZZZZZZZZZZZ(conn);
                    if (dr.HasRows)
                    {
                        dataGridView12.Rows.Clear();
                        while (dr.Read())
                        {
                            double b = double.Parse(dr[1].ToString());
                            string v = string.Format("{0:N2}", b);
                            dataGridView12.Rows.Add(dr[0].ToString(), v.ToString(), dr[3].ToString());
                        }
                    }
                    else
                    {
                        dataGridView12.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    fro.N________ = textBox42.Text;
                    SqlDataReader dr = fro.CustomerSelect1Search(conn);
                    if (dr.HasRows)
                    {
                        listBox8.Items.Clear();
                        while (dr.Read())
                        {
                            //listBox1.Items.Clear();   
                            listBox8.Items.Add("Last Name: \t\t\t\t<" + dr[1].ToString() + ">");
                            listBox8.Items.Add("FirstName: \t\t\t\t<" + dr[2].ToString() + ">");
                            listBox8.Items.Add("Middle Name: \t\t\t\t<" + dr[3].ToString() + ">");
                            listBox8.Items.Add("Contact #: \t\t\t\t<" + dr[4].ToString() + ">");
                            listBox8.Items.Add("Address: \t\t\t\t\t<" + dr[5].ToString() + ">");
                            listBox8.Items.Add("Balance: \t\t\t\t\t<" + dr[6].ToString() + ">");
                            listBox8.Items.Add("No of Companion: \t\t\t\t<" + dr[7].ToString() + ">");
                            listBox8.Items.Add("");
                            listBox8.Items.Add("");
                        }
                    }
                    else
                    {
                        listBox8.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.CustomerSelect1Search(conn);
                    if (dr.HasRows)
                    {
                        dataGridView14.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView14.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                    }
                    else
                    {
                        dataGridView14.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void dataGridView12_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                fro.GUESTID = double.Parse(dataGridView12.CurrentRow.Cells[2].Value.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.CustomerSelect(conn);
                    if (dr.HasRows)
                    {
                        listBox8.Items.Clear();
                        while (dr.Read())
                        {
                            listBox8.Items.Add("Last Name: \t\t\t\t<" + dr[1].ToString() + ">");
                            listBox8.Items.Add("FirstName: \t\t\t\t<" + dr[2].ToString() + ">");
                            listBox8.Items.Add("Middle Name: \t\t\t\t<" + dr[3].ToString() + ">");
                            listBox8.Items.Add("Contact #: \t\t\t\t<" + dr[4].ToString() + ">");
                            listBox8.Items.Add("Address: \t\t\t\t\t<" + dr[5].ToString() + ">");
                            listBox8.Items.Add("Balance: \t\t\t\t\t<" + dr[6].ToString() + ">");
                            listBox8.Items.Add("No of Companion: \t\t\t\t<" + dr[7].ToString() + ">");
                            listBox8.Items.Add("");
                            listBox8.Items.Add("");
                        }
                    }
                    else
                    {
                        listBox8.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }

            try
            {
                fro.GUESTID = double.Parse(dataGridView12.CurrentRow.Cells[2].Value.ToString());
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.CustomerSelect(conn);
                    if (dr.HasRows)
                    {
                        dataGridView14.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView14.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                    }
                    else
                    {
                        dataGridView14.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView14.Rows)
                {
                    prr.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString() + " ," + item.Cells[1].Value.ToString() + " " + item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[6].Value.ToString());
                }

                Printing.Print3 frm = new Reservations.Printing.Print3();
                frm.Prints = prr;
                frm.ShowDialog();
                prr.Tables["DataTable1"].Rows.Clear();

            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView15.Rows)
                {
                    prrr.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), textBox48.Text, dateTimePicker10.Text, dateTimePicker13.Text);
                }

                Printing.Print4 frm = new Reservations.Printing.Print4();
                frm.Prints = prrr;
                frm.ShowDialog();
                prrr.Tables["DataTable1"].Rows.Clear();

            }
            catch (Exception)
            {

                label24.Text = ".";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                fro.DATE11 = dateTimePicker10.Text + " 12:01:00 AM";
                fro.DATE22 = dateTimePicker13.Text + " 11:59:00 PM";
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.PopulateIncome2(conn);
                    if (dr.HasRows)
                    {
                        listBox9.Items.Clear();
                        while (dr.Read())
                        {
                            double x = double.Parse(dr[0].ToString());
                            string y = string.Format("{0:N2}", x);
                            listBox9.Items.Add(dr[1].ToString() + "\t\t================\t\t" + y.ToString() + " Pesos");
                        }
                    }
                    else { listBox9.Items.Clear(); }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }


            try
            {
                fro.DATE11 = dateTimePicker10.Text + " 12:01:00 AM";
                fro.DATE22 = dateTimePicker13.Text + " 11:59:00 PM";
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.PopulateIncome(conn);
                    if (dr.HasRows)
                    {
                        textBox48.Clear();
                        while (dr.Read())
                        {
                            double x = double.Parse(dr[0].ToString());
                            string y = string.Format("{0:N2}", x);
                            textBox48.Text = y.ToString() + " Pesos";
                        }
                    }
                    else { textBox48.Clear(); ; }
                }
            }
            catch (Exception)
            {
                textBox48.Clear();
            }
            finally { conn.Close(); }

            try
            {
                fro.DATE11 = dateTimePicker10.Text + " 12:01:00 AM";
                fro.DATE22 = dateTimePicker13.Text + " 11:59:00 PM";
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = fro.PopulateIncome2(conn);
                    if (dr.HasRows)
                    {
                        dataGridView15.Rows.Clear();
                        while (dr.Read())
                        {
                            double x = double.Parse(dr[0].ToString());
                            string y = string.Format("{0:N2}", x);
                            dataGridView15.Rows.Add(dr[1].ToString(), y.ToString() + "  Php");
                        }
                    }
                    else { dataGridView15.Rows.Clear(); }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                try
                {
                    foreach (DataGridViewRow item in dataGridView16.Rows)
                    {
                        prrrr.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), label118.Text);
                    }

                    Printing.Print5 frm = new Reservations.Printing.Print5();
                    frm.Prints = prrrr;
                    frm.ShowDialog();
                    prrrr.Tables["DataTable1"].Rows.Clear();

                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow item in dataGridView17.Rows)
                    {
                        prrrr.Tables["DataTable1"].Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), label118.Text);
                    }

                    Printing.Print5 frm = new Reservations.Printing.Print5();
                    frm.Prints = prrrr;
                    frm.ShowDialog();
                    prrrr.Tables["DataTable1"].Rows.Clear();

                }
                catch (Exception)
                {

                    label24.Text = ".";
                }
            }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    add.SHIFTLIKE = textBox49.Text;
                    SqlDataReader dr = add.ShiftReceipt(conn);
                    if (dr.HasRows)
                    {
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                        listBox10.Items.Clear();
                        listBox11.Items.Clear();
                        listBox12.Items.Clear();
                        add.SHIFTLIST.Clear();
                        label118.Text = "<>";
                        dataGridView16.Rows.Clear();
                        dataGridView17.Rows.Clear();
                        while (dr.Read())
                        {
                            listBox10.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString());
                            add.SHIFTLIST.Add(dr[0].ToString());
                        }
                    }
                    else
                    {
                        listBox10.Items.Clear();
                        listBox11.Items.Clear();
                        listBox12.Items.Clear();
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                        label118.Text = "<>";
                        dataGridView16.Rows.Clear();
                        dataGridView17.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                add.ShiftReceiptCommunicationid____________ = Convert.ToInt32(add.SHIFTLIST[listBox10.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ShiftReceiptCommunication(conn);
                    if (dr.HasRows)
                    {
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                        listBox11.Items.Clear();
                        listBox12.Items.Clear();
                        add.CONNECTINGthedatabases.Clear();
                        dataGridView16.Rows.Clear();
                        dataGridView17.Rows.Clear();
                        add.COMMMANDZes.Clear(); 
                        while (dr.Read())
                        {
                            listBox11.Items.Add(dr[3].ToString() + ":   " + dr[4].ToString());
                            label118.Text = dr[1].ToString() + " " + dr[2].ToString() + " " + dr[6].ToString();
                            add.CONNECTINGthedatabases.Add(dr[5]);
                            add.COMMMANDZes.Add(dr[4]);
                        }
                    }
                    else
                    {
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                        listBox11.Items.Clear();
                        listBox12.Items.Clear();
                        dataGridView16.Rows.Clear();
                        dataGridView17.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM = Convert.ToString(add.COMMMANDZes[listBox11.SelectedIndex]);
           // MessageBox.Show(COMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.ToString()); 
            try
            {
                add.SHIFTRESID____lll = Convert.ToInt32(add.CONNECTINGthedatabases[listBox11.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ShiftReceiptPAymentsBlaBlaBla(conn);
                    if (dr.HasRows)
                    {
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                        listBox12.Items.Clear();
                        add.JOOMLAId.Clear();
                        dataGridView16.Rows.Clear();
                        dataGridView17.Rows.Clear();
                        while (dr.Read())
                        {
                            double k = double.Parse(dr[4].ToString());
                            double kk = double.Parse(dr[6].ToString());
                            double kkk = double.Parse(dr[7].ToString());
                            string l = string.Format("{0:N2}", k);
                            string ll = string.Format("{0:N2}", kk);
                            string lll = string.Format("{0:N2}", kkk);
                            double x = double.Parse(dr[4].ToString());
                            string y = string.Format("{0:N2}", x);
                            listBox12.Items.Add("Payments* Balance: " + y.ToString() + " " + dr[8].ToString());
                            dataGridView16.Rows.Add(dr[0].ToString(), l.ToString() + " Php", dr[5].ToString(), ll.ToString() + " Php", lll.ToString() + " Php", dr[8].ToString());
                            add.JOOMLAId.Add(dr[0]);
                        }
                    }
                    else
                    {
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                        listBox12.Items.Clear();
                        dataGridView16.Rows.Clear();
                        dataGridView17.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                add.ID_PAYS = Convert.ToInt32(add.JOOMLAId[listBox12.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ShiftReceiptPAymentsBlaBlaBla___________________(conn);
                    if (dr.HasRows)
                    {
                        dataGridView17.Rows.Clear();
                        while (dr.Read())
                        {
                            double k = double.Parse(dr[4].ToString());
                            double kk = double.Parse(dr[6].ToString());
                            double dei = kk / 2;
                            lastL = double.Parse(dei.ToString());
                            //MessageBox.Show(lastL.ToString()); 
                            double kkk = double.Parse(dr[7].ToString());
                            string l = string.Format("{0:N2}", k);
                            string ll = string.Format("{0:N2}", kk);
                            string lll = string.Format("{0:N2}", kkk);
                            textBox51.Text = l.ToString() + " Php";
                            textBox52.Text = ll.ToString() + " Php";
                            textBox53.Text = lll.ToString() + " Php";
                            dataGridView17.Rows.Add(dr[0].ToString(), l.ToString() + " Php", dr[5].ToString(), ll.ToString() + " Php", lll.ToString() + " Php", dr[8].ToString());
                            textBox76.Text = dr[0].ToString(); 
                        }
                    }
                    else
                    {
                        dataGridView17.Rows.Clear();
                        textBox51.Clear();
                        textBox52.Clear();
                        textBox53.Clear();
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void groupBox28_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox11.Text = "3";
                textBox13.Text = "3";
                comboBox7.Enabled = true;
                comboBox8.Enabled = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox12.Clear();
                label25.Text = "0";
                numericUpDown1.Value = 0;
                textBox19.Clear();
                textBox6.Clear();
                textBox15.Clear();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox12.Enabled = false;
                numericUpDown1.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                button19.Enabled = false;
                button17.Enabled = false;
                dateTimePicker2.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox7.Clear();
                dataGridView3.Rows.Clear();
                comboBox2.Items.Clear();
                textBox20.Clear();
            }
            else
            {
                comboBox8.Items.Clear();
                textBox11.Text = "12";
                textBox13.Text = "12";
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox12.Clear();
                label25.Text = "0";
                numericUpDown1.Value = 0;
                textBox19.Clear();
                textBox6.Clear();
                textBox15.Clear();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox12.Enabled = false;
                numericUpDown1.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                button19.Enabled = false;
                button17.Enabled = false;
                dateTimePicker2.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox7.Clear();
                dataGridView3.Rows.Clear();
                comboBox2.Items.Clear();
                textBox20.Clear();
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                command.RCID = Convert.ToInt32(command.ROOMCONDITIONID[comboBox7.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomConditionCODES(conn);
                    if (dr.HasRows)
                    {
                        comboBox8.Items.Clear();
                        command.ROOMTYPEIDZ.Clear();
                        dataGridView3.Rows.Clear();
                        label12.Text = "========";
                        label13.Text = "========";
                        while (dr.Read())
                        {
                            comboBox8.Items.Add(dr[1].ToString());
                            command.ROOMTYPEIDZ.Add(dr[0]);
                        }
                    }
                    else
                    {
                        dataGridView3.Rows.Clear();
                        comboBox8.Items.Clear();
                        label12.Text = "========";
                        label13.Text = "========";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            command.R = Convert.ToInt32(command.ROOMTYPEIDZ[comboBox8.SelectedIndex]);
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomsZ(conn);
                    if (dr.HasRows)
                    {
                        dataGridView3.Rows.Clear();
                        label12.Text = "========";
                        label13.Text = "========";
                        while (dr.Read())
                        {
                            dataGridView3.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView3.Rows.Clear();
                        dataGridView3.Rows.Add("Empty", "Empty");
                        label12.Text = "========";
                        label13.Text = "========";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.SelectRoomBILLS(conn);
                    if (dr.HasRows)
                    {
                        textBox7.Clear();
                        textBox8.Clear();
                        while (dr.Read())
                        {
                            textBox8.Text = dr[5].ToString();
                            textBox7.Text = dr[6].ToString();
                            double k = double.Parse(textBox7.Text);
                            textBox7.Text = string.Format("{0:N2}", k);
                        }
                    }
                    else
                    {
                        textBox7.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        private void groupBox30_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView18_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    double zas = double.Parse(dataGridView18.CurrentRow.Cells[5].Value.ToString());
                    string ZAS = string.Format("{0:N2}",zas);
                    textBox67.Text = ZAS.ToString();
                    textBox58.Text = dataGridView18.CurrentRow.Cells[15].Value.ToString();
                    textBox57.Text = dataGridView18.CurrentRow.Cells[16].Value.ToString();
                    textBox56.Text = dataGridView18.CurrentRow.Cells[17].Value.ToString();
                    textBox55.Text = dataGridView18.CurrentRow.Cells[7].Value.ToString();
                    textBox54.Text = dataGridView18.CurrentRow.Cells[6].Value.ToString();
                    custIdFORUPDATE = double.Parse(dataGridView18.CurrentRow.Cells[12].Value.ToString());
                    RE = double.Parse(dataGridView18.CurrentRow.Cells[13].Value.ToString());
                    Previusroom = double.Parse(dataGridView18.CurrentRow.Cells[14].Value.ToString());
                    //MessageBox.Show(Previusroom.ToString());
                    numericUpDown2.Value = Convert.ToInt32(dataGridView18.CurrentRow.Cells[8].Value.ToString());
                    // numericUpDown3.Value = Convert.ToInt32(dataGridView18.CurrentRow.Cells[9].Value.ToString());
                    hours = Convert.ToInt32(dataGridView18.CurrentRow.Cells[9].Value.ToString());
                    label136.Text = hours.ToString();
                    try
                    {
                        conn = Connection.ConnectToServer();
                        if (conn.State == ConnectionState.Open)
                        {
                            add.WE = RE;
                            SqlDataReader dr = add.TotalPaidsGUEST(conn);
                            if (dr.HasRows)
                            {
                                textBox61.Text = "No payments yet";
                                while (dr.Read())
                                {
                                    double vv = double.Parse(dr[0].ToString());
                                    string VV = string.Format("{0:N2}", vv);
                                    textBox61.Text = VV.ToString();
                                }
                            }
                            else
                            {
                                textBox61.Text = "No payments yet";
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
            catch (Exception)
            {
                label24.Text = ".";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox58.Enabled = true;
                textBox57.Enabled = true;
                textBox56.Enabled = true;
                textBox55.Enabled = true;
                textBox54.Enabled = true;
                button45.Enabled = true;
            }
            else
            {
                textBox58.Enabled = false;
                textBox57.Enabled = false;
                textBox56.Enabled = false;
                textBox55.Enabled = false;
                textBox54.Enabled = false;
                button45.Enabled = false;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (QK == 5)
            {
                add.CUSTIDUPDATE = custIdFORUPDATE;
                add.CUSTLN = textBox58.Text;
                add.CUSTFN = textBox57.Text;
                add.CUSTMN = textBox56.Text;
                add.CUSTADDRESS = textBox55.Text;
                add.CUSTCONTACT = textBox54.Text;
                add.updateCustomer(conn);
            }
            else
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Something Error: Check the Data you entered(Something Missing).", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            k = textBox58.Text.Length;
            if (k > 0)
            {
                q = 1;
            }
            if (k == 0)
            {
                q = 0;
            }
            QK = q + qq + qqq + qqqq + qqqqq;
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            kk = textBox57.Text.Length;
            if (kk > 0)
            {
                qq = 1;
            }
            if (kk == 0)
            {
                qq = 0;
            }
            QK = q + qq + qqq + qqqq + qqqqq;
            // MessageBox.Show(QK.ToString()); 
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            kkk = textBox56.Text.Length;
            if (kkk > 0)
            {
                qqq = 1;
            }
            if (kkk == 0)
            {
                qqq = 0;
            }
            QK = q + qq + qqq + qqqq + qqqqq;
            //MessageBox.Show(QK.ToString()); 
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            kkkk = textBox55.Text.Length;
            if (kkkk > 0)
            {
                qqqq = 1;
            }
            if (kkkk == 0)
            {
                qqqq = 0;
            }
            QK = q + qq + qqq + qqqq + qqqqq;
            // MessageBox.Show(QK.ToString()); 
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            kkkkk = textBox54.Text.Length;
            if (kkkkk > 0)
            {
                qqqqq = 1;
            }
            if (kkkkk == 0)
            {
                qqqqq = 0;
            }
            QK = q + qq + qqq + qqqq + qqqqq;
            //MessageBox.Show(QK.ToString()); 
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            add.ROOMTYPEID2222222 = Convert.ToInt32(add.XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX[comboBox9.SelectedIndex]);
            if (checkBox6.Checked == true)
            {
                try
                {
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = add.ROOMTYPE2details(conn);
                        if (dr.HasRows)
                        {
                            textBox59.Clear();
                            textBox60.Clear();
                            textBox84.Clear();
                            textBox63.Clear(); 
                            textBox66.Clear();
                            while (dr.Read())
                            {
                                double vv = double.Parse(dr[6].ToString());
                                string VV = string.Format("{0:N2}", vv);
                                textBox59.Text = VV.ToString();
                                textBox66.Text = dr[5].ToString();

                            }
                        }
                        else
                        {
                            textBox59.Clear();
                            textBox66.Clear();
                        }
                    }
                }
                catch (Exception)
                {
                    label24.Text = ".";
                }
                finally { conn.Close(); }
            }
            if (checkBox6.Checked == false)
            {
                try
                {
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = add.ROOMTYPE2details(conn);
                        if (dr.HasRows)
                        {
                            textBox59.Clear();
                            textBox66.Clear();
                            textBox60.Clear();
                            textBox84.Clear();
                            textBox63.Clear(); 
                            while (dr.Read())
                            {
                                double vv = double.Parse(dr[2].ToString());
                                string VV = string.Format("{0:N2}", vv);
                                textBox59.Text = VV.ToString();
                                textBox66.Text = dr[5].ToString();
                            }
                        }
                        else
                        {
                            textBox59.Clear();
                            textBox66.Clear();
                        }
                    }
                }
                catch (Exception)
                {
                    label24.Text = ".";
                }
                finally { conn.Close(); }
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = add.ROOMTxxxxxxxxxxxxxxxxxdetails(conn);
                    if (dr.HasRows)
                    {
                        comboBox10.Items.Clear();
                        add.ROOM2ARRAY.Clear();
                        while (dr.Read())
                        {
                            comboBox10.Items.Add(dr[1].ToString() + "(" + dr[2].ToString() + ")");
                            add.ROOM2ARRAY.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox10.Items.Clear();
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
            finally { conn.Close(); }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox65.Clear();
            textBox63.Clear();
            textBox59.Clear();
            textBox60.Clear();
            if (checkBox6.Checked == true)
            {
                textBox59.Clear();
                textBox62.Text = "3";
                textBox64.Text = "3";

            }
            else
            {
                textBox59.Clear();
                textBox62.Text = "12";
                textBox64.Text = "12";
            }
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox63.Text);
                double y = double.Parse(textBox64.Text);
                double result = x + y;
                textBox62.Text = result.ToString();
            }
            catch (Exception)
            {
                if (checkBox6.Checked == true)
                {
                    textBox62.Text = "3";
                }
                if (checkBox6.Checked == false)
                {
                    textBox62.Text = "12";
                }
            }
            try
            {
                double y = double.Parse(textBox59.Text);
                double x = double.Parse(textBox63.Text);
                double excesshour = double.Parse(textBox9.Text);
                double result = (x * excesshour) + y;
                textBox60.Text = result.ToString();
                textBox65.Text = result.ToString();
            }
            catch (Exception)
            {
                label24.Text = ".";
                textBox60.Text = textBox59.Text;
                textBox65.Text = textBox59.Text;
            }

            try
            {

                double asz = double.Parse(textBox66.Text);
                double yy = double.Parse(numericUpDown4.Value.ToString());
                double rer = yy - asz;
                if (yy >= asz)
                {
                    try
                    {
                        double x = double.Parse(textBox10.Text);
                        double z = double.Parse(textBox65.Text);
                        double result = (rer * x) + z;
                        textBox60.Text = result.ToString();
                    }
                    catch (Exception)
                    {
                        label24.Text = ".";
                    }
                }

            }
            catch (Exception)
            {
                label24.Text = ".";
            }


            try
            {
                double x = double.Parse(textBox60.Text);
                double y = double.Parse(textBox61.Text);
                double z = double.Parse(textBox67.Text);
                double res = (x - y) + z;

                if (x >= y)
                {
                    textBox84.Text = res.ToString();
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    double x = double.Parse(label136.Text);
            //    double y = double.Parse(numericUpDown3.Value.ToString());
            //    if (y>x)
            //    {
            //        MessageBox.Show(y.ToString()); 
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                double asz = double.Parse(textBox66.Text);
                double y = double.Parse(numericUpDown4.Value.ToString());
                double rer = y - asz;
                if (y >= asz)
                {
                    try
                    {
                        double x = double.Parse(textBox10.Text);
                        double z = double.Parse(textBox65.Text);
                        double result = (rer * x) + z;
                        textBox60.Text = result.ToString();
                    }
                    catch (Exception)
                    {
                        label24.Text = ".";
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
           

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.ROOMIDARRAYSZ = Convert.ToInt32(add.ROOM2ARRAY[comboBox10.SelectedIndex]);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (textBox61.Text != "No payments yet")
            {
                try
                {
                    double x = double.Parse(textBox60.Text);
                    double y = double.Parse(textBox61.Text);
                    if (x >= y)
                    {
                        try
                        {
                            Reservationupdate.ROOOOOOOOOOOOOOMID = double.Parse(Previusroom.ToString());
                            Reservationupdate.GUESTID = double.Parse(custIdFORUPDATE.ToString());
                            add.ROOMIDARRAYSZ = Convert.ToInt32(add.ROOM2ARRAY[comboBox10.SelectedIndex]);
                            Reservationupdate.ROOMID = double.Parse(add.ROOMIDARRAYSZ.ToString());
                            Reservationupdate.RESERVATIONID = RE;
                            conn = Connection.ConnectToServer();
                            if (conn.State == ConnectionState.Open)
                            {
                                Reservationupdate.PERSON = double.Parse(numericUpDown4.Value.ToString());
                                Reservationupdate.BAL = double.Parse(textBox84.Text);
                                Reservationupdate.EXPECTEDHOURS = double.Parse(textBox62.Text);
                                Reservationupdate.ROOMBILL = double.Parse(textBox59.Text);
                                Reservationupdate.EXESSTIMESTATUS = double.Parse(textBox63.Text);
                                Reservationupdate.TOTALBILL = double.Parse(textBox60.Text);

                                Reservationupdate.UPTodateCheckOUT(conn);
                                Reservationupdate.UPCustomer(conn);
                                Reservationupdate.UPPreviusRoom(conn);
                                Reservationupdate.UPNewRoom(conn);

                                DialogResult okay = new DialogResult();
                                okay = MessageBox.Show("The Data successfuly updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (okay == DialogResult.OK)
                                {
                                    Application.DoEvents();
                                }

                                textBox65.Clear();
                                textBox63.Clear();
                                textBox59.Clear();
                                textBox60.Clear();
                                comboBox10.Items.Clear();
                                numericUpDown4.Value = Convert.ToInt32("0".ToString());
                            }
                        }
                        catch (Exception)
                        {
                            label24.Text = ".";
                        }
                        finally { conn.Close(); }

                    }
                    if (x<y)
                    {
                         MessageBox.Show("x<y");
                         try
                         {
                             Reservationupdate.ROOOOOOOOOOOOOOMID = double.Parse(Previusroom.ToString());
                             Reservationupdate.GUESTID = double.Parse(custIdFORUPDATE.ToString());
                             add.ROOMIDARRAYSZ = Convert.ToInt32(add.ROOM2ARRAY[comboBox10.SelectedIndex]);
                             Reservationupdate.ROOMID = double.Parse(add.ROOMIDARRAYSZ.ToString());
                             Reservationupdate.RESERVATIONID = RE;
                             conn = Connection.ConnectToServer();
                             if (conn.State == ConnectionState.Open)
                             {
                                 int c = 0;
                                 int cc = 0;
                                 Reservationupdate.PERSON = double.Parse(numericUpDown4.Value.ToString());
                                 Reservationupdate.BAL = double.Parse(c.ToString());
                                 Reservationupdate.EXPECTEDHOURS = double.Parse(textBox62.Text);
                                 Reservationupdate.ROOMBILL = double.Parse(textBox59.Text);
                                 Reservationupdate.EXESSTIMESTATUS = double.Parse(textBox63.Text);
                                 Reservationupdate.TOTALBILL = double.Parse(cc.ToString());
                                 Reservationupdate.REFUND = double.Parse(textBox85.Text); 
                                 Reservationupdate.UPTodateCheckOUT(conn);
                                 Reservationupdate.UPCustomer(conn);
                                 Reservationupdate.UPPreviusRoom(conn);
                                 Reservationupdate.UPNewRoom(conn);
                                 Reservationupdate.UPPPPPPPCustomer(conn); 

                                 DialogResult okay = new DialogResult();
                                 okay = MessageBox.Show("The Data successfuly updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 if (okay == DialogResult.OK)
                                 {
                                     Application.DoEvents();
                                 }

                                 textBox65.Clear();
                                 textBox63.Clear();
                                 textBox59.Clear();
                                 textBox60.Clear();
                                 comboBox10.Items.Clear();
                                 numericUpDown4.Value = Convert.ToInt32("0".ToString());
                             }
                         }
                         catch (Exception)
                         {
                             label24.Text = ".";
                         }
                         finally { conn.Close(); }
                    }
                }
                catch (Exception)
                {
                    label24.Text = ".";
                }
            }
            if (textBox61.Text == "No payments yet")
            {
                try
                {
                    Reservationupdate.ROOOOOOOOOOOOOOMID = double.Parse(Previusroom.ToString());
                    Reservationupdate.GUESTID = double.Parse(custIdFORUPDATE.ToString());
                    add.ROOMIDARRAYSZ = Convert.ToInt32(add.ROOM2ARRAY[comboBox10.SelectedIndex]);
                    Reservationupdate.ROOMID = double.Parse(add.ROOMIDARRAYSZ.ToString());
                    Reservationupdate.RESERVATIONID = RE;
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        Reservationupdate.PERSON = double.Parse(numericUpDown4.Value.ToString());
                        Reservationupdate.BAL = double.Parse(textBox60.Text);
                        Reservationupdate.EXPECTEDHOURS = double.Parse(textBox62.Text);
                        Reservationupdate.ROOMBILL = double.Parse(textBox59.Text);
                        Reservationupdate.EXESSTIMESTATUS = double.Parse(textBox63.Text);
                        Reservationupdate.TOTALBILL = double.Parse(textBox60.Text);
                        Reservationupdate.UPTodateCheckOUT(conn);
                        Reservationupdate.UPCustomer(conn);
                        Reservationupdate.UPPreviusRoom(conn);
                        Reservationupdate.UPNewRoom(conn);
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("The Data successfuly updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }

                        textBox65.Clear();
                        textBox63.Clear();
                        textBox59.Clear();
                        textBox60.Clear();
                        comboBox10.Items.Clear();
                        numericUpDown4.Value = Convert.ToInt32("0".ToString());
                    }
                }
                catch (Exception)
                {
                    label24.Text = ".";
                }
                finally { conn.Close(); }

                try
                {
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = add.ReservationUpdating(conn);
                        if (dr.HasRows)
                        {
                            dataGridView18.Rows.Clear();
                            while (dr.Read())
                            {
                                dataGridView18.Rows.Add("Click here", dr[0].ToString() + " ," + dr[1].ToString() + " " + dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                            }
                        }
                        else
                        {
                            dataGridView18.Rows.Clear();
                        }
                    }
                }
                catch (Exception)
                {
                    label24.Text = ".";
                }
                finally { conn.Close(); }
            }

        }

        private void dataGridView19_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView20_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                for (int i = 0; i < dataGridView20.Rows.Count; i++)
                {
                    dataGridView20.Rows[i].Cells[10].Value = DateTime.Now.ToString();   
                }
            }
            if (radioButton5.Checked == true)
            {
                for (int i = 0; i < dataGridView20.Rows.Count; i++)
                {
                    dataGridView20.Rows[i].Cells[10].Value = null;
                }
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                try
                {
                    group.EMPLOYEEID = double.Parse(textBox18.Text);
                    group.GLN = textBox72.Text;
                    group.GFN = textBox71.Text;
                    group.GMN = textBox70.Text;
                    group.GADRESS = textBox69.Text;
                    group.GCN = textBox68.Text;
                    group.GBAL = double.Parse(textBox73.Text);
                    group.GRANDTOTAL = double.Parse(textBox73.Text);
                    group.GCOMPANION = double.Parse(textBox74.Text);
                    group.CreateCustomerFirst();
                    group.CreateReservationGroup(dataGridView20);
                    textBox73.Clear();
                    textBox72.Clear();
                    textBox71.Clear();
                    textBox70.Clear();
                    textBox69.Clear();
                    textBox68.Clear();
                    textBox74.Clear(); 
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (radioButton5.Checked == true)
            {
 
            }
          
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label143.Visible = true;
                dateTimePicker16.Visible = true; 
            }
            if (radioButton6.Checked == true)
            {
                label143.Visible = false;
                dateTimePicker16.Visible = false; 
            }
        }

        private void groupBox34_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker16_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView20.Rows.Count; i++)
            {
                dataGridView20.Rows[i].Cells[10].Value = dateTimePicker16.Text;  
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double eleven = double.Parse(textBox11.Text);
                string x = dateTimePicker2.Text + " " + textBox75.Text;
                DateTime date = Convert.ToDateTime(x.ToString());
                CheckINGLOBAL = date.ToString();
                DateTime dates = Convert.ToDateTime(date.AddHours(eleven).ToString());
                textBox21.Text = dates.ToString();
            }
            catch (Exception)
            {

                textBox21.Clear();
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (COMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM != "ReservationCanceled")
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Error: it is not a reservetion detail canceled: Thank you", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            else
            {
                try
                {
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        add.BEGINBACK = double.Parse(lastL.ToString());
                        add.PAYMENTIDz = double.Parse(textBox76.Text);
                        add.BackPayments(conn);
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
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

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                dataGridView1.Visible = false;
                groupBox16.Visible = false;
                groupBox15.Visible = false;
                groupBox3.Visible = false;
                dataGridView4.Visible = false;
                groupBox5.Visible = false;
                dataGridView2.Visible = false;
                groupBox23.Visible = false;
                groupBox29.Visible = false;
                tabControl2.Visible = false;
                groupBox35.Visible = false; 
                button4.Enabled = false;
                button7.Enabled = false;
                button6.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
                button5.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button31.Enabled = false;
                groupBox32.Visible = false;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
            }
            else
            {
                groupBox35.Visible = false;
                dataGridView1.Visible = true;
                groupBox16.Visible = true;
                groupBox15.Visible = true;
                groupBox3.Visible = true;
                dataGridView4.Visible = true;
                groupBox5.Visible = true;
                dataGridView2.Visible = true;
                groupBox23.Visible = true;
                groupBox29.Visible = true;
                tabControl2.Visible = true;

                button4.Enabled = true;
                button7.Enabled = true;
                button6.Enabled = true;
                button9.Enabled = true;
                button8.Enabled = true;
                button5.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button31.Enabled = true;

                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
            }
        }

        private void dataGridView22_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string status = dataGridView22.CurrentRow.Cells[4].Value.ToString();
                if (status != "Available")
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Status:" + dataGridView22.CurrentRow.Cells[1].Value.ToString() + ":" + dataGridView19.CurrentRow.Cells[4].Value.ToString() + "\nMessage: Not Available", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
                else
                {
                    textBox83.Enabled = true;
                    textBox82.Enabled = true;
                    textBox81.Enabled = true;
                    textBox80.Enabled = true;
                    textBox79.Enabled = true;
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                    button49.Enabled = true;
                    if (e.ColumnIndex == 0)
                    {
                        dataGridView21.Rows.Add("", dataGridView22.CurrentRow.Cells[7].Value.ToString(), dataGridView22.CurrentRow.Cells[1].Value.ToString(), dataGridView22.CurrentRow.Cells[3].Value.ToString(), dataGridView22.CurrentRow.Cells[2].Value.ToString(), dataGridView22.CurrentRow.Cells[8].Value.ToString());
                        //for (int i = 0; i < dataGridView21.Rows.Count; i++)
                        //{
                        dataGridViewComboBoxColumn1.Items.Clear();
                        dataGridViewComboBoxColumn1.Items.Add("HalfDay(12 hours)");
                        dataGridViewComboBoxColumn1.Items.Add("ShortTime(3 hours)");
                        //}
                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
        }

        private void dataGridView21_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string x = dataGridView21.CurrentRow.Cells[0].Value.ToString();
                if (x == "HalfDay(12 hours)")
                {
                    double goodfor = double.Parse(dataGridView21.CurrentRow.Cells[5].Value.ToString());
                    double inputPerson = double.Parse(dataGridView21.CurrentRow.Cells[6].Value.ToString());
                    double excesshourInput = double.Parse(dataGridView21.CurrentRow.Cells[7].Value.ToString());
                    double excesshour = double.Parse(textBox9.Text);
                    double excess = excesshourInput * excesshour;

                    double excessPerson = double.Parse(textBox10.Text);
                    double resres = inputPerson - goodfor;
                    double additionalperson = resres * excessPerson;

                    dataGridView21.CurrentRow.Cells[13].Value = dataGridView21.CurrentRow.Cells[4].Value.ToString();
                    dataGridView21.CurrentRow.Cells[4].Style.ForeColor = Color.Red;
                    dataGridView21.CurrentRow.Cells[3].Style.ForeColor = Color.Black;
                    double xx = double.Parse(dataGridView21.CurrentRow.Cells[4].Value.ToString());
                    Price = double.Parse(xx.ToString());
                    double twelve = 12;
                    double checkoutdate;
                    //MessageBox.Show(Price.ToString());

                    if (inputPerson <= goodfor)
                    {
                        dataGridView21.CurrentRow.Cells[8].Value = dataGridView21.CurrentRow.Cells[4].Value.ToString();
                        double total1 = double.Parse(dataGridView21.CurrentRow.Cells[8].Value.ToString()) + excess;
                        dataGridView21.CurrentRow.Cells[9].Value = total1.ToString();
                        dataGridView21.CurrentRow.Cells[12].Value = "0";

                        checkoutdate = excesshourInput + twelve;
                        DateTime dai = Convert.ToDateTime(DateTime.Now.AddHours(checkoutdate));
                        dataGridView21.CurrentRow.Cells[11].Value = dai.ToString();
                    }
                    else
                    {
                        dataGridView21.CurrentRow.Cells[8].Value = dataGridView21.CurrentRow.Cells[4].Value.ToString();
                        double total1 = double.Parse(dataGridView21.CurrentRow.Cells[8].Value.ToString()) + excess + additionalperson;
                        dataGridView21.CurrentRow.Cells[9].Value = total1.ToString();
                        dataGridView21.CurrentRow.Cells[12].Value = resres.ToString();

                        checkoutdate = excesshourInput + twelve;
                        DateTime dai = Convert.ToDateTime(DateTime.Now.AddHours(checkoutdate));
                        dataGridView21.CurrentRow.Cells[11].Value = dai.ToString();

                    }


                }
                if (x == "ShortTime(3 hours)")
                {
                    double goodfor = double.Parse(dataGridView21.CurrentRow.Cells[5].Value.ToString());
                    double inputPerson = double.Parse(dataGridView21.CurrentRow.Cells[6].Value.ToString());
                    double excesshourInput = double.Parse(dataGridView21.CurrentRow.Cells[7].Value.ToString());
                    double excesshour = double.Parse(textBox9.Text);
                    double excess = excesshourInput * excesshour;

                    double excessPerson = double.Parse(textBox10.Text);
                    double resres = inputPerson - goodfor;
                    double additionalperson = resres * excessPerson;

                    double three = 3;
                    double checkoutdate;

                    dataGridView21.CurrentRow.Cells[13].Value = dataGridView21.CurrentRow.Cells[3].Value.ToString();
                    dataGridView21.CurrentRow.Cells[3].Style.ForeColor = Color.Red;
                    dataGridView21.CurrentRow.Cells[4].Style.ForeColor = Color.Black;
                    double xx = double.Parse(dataGridView21.CurrentRow.Cells[3].Value.ToString());
                    Price = double.Parse(xx.ToString());
                    //MessageBox.Show(Price.ToString());

                    if (inputPerson <= goodfor)
                    {
                        dataGridView21.CurrentRow.Cells[8].Value = dataGridView21.CurrentRow.Cells[3].Value.ToString();
                        double total1 = double.Parse(dataGridView21.CurrentRow.Cells[8].Value.ToString()) + excess;
                        dataGridView21.CurrentRow.Cells[9].Value = total1.ToString();
                        dataGridView21.CurrentRow.Cells[12].Value = "0";

                        checkoutdate = excesshourInput + three;
                        DateTime dai = Convert.ToDateTime(DateTime.Now.AddHours(checkoutdate));
                        dataGridView21.CurrentRow.Cells[11].Value = dai.ToString();

                    }
                    else
                    {
                        dataGridView21.CurrentRow.Cells[8].Value = dataGridView21.CurrentRow.Cells[3].Value.ToString();
                        double total1 = double.Parse(dataGridView21.CurrentRow.Cells[8].Value.ToString()) + excess + additionalperson;
                        dataGridView21.CurrentRow.Cells[9].Value = total1.ToString();
                        dataGridView21.CurrentRow.Cells[12].Value = resres.ToString();

                        checkoutdate = excesshourInput + three;
                        DateTime dai = Convert.ToDateTime(DateTime.Now.AddHours(checkoutdate));
                        dataGridView21.CurrentRow.Cells[11].Value = dai.ToString();

                    }
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }

            double f = 0;
            try
            {
                for (int i = 0; i < dataGridView21.Rows.Count; i++)
                {
                    f = double.Parse(f.ToString()) + Convert.ToDouble(dataGridView21.Rows[i].Cells[9].Value.ToString());
                    textBox78.Text = f.ToString();
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }

            double fx = 0;
            try
            {
                for (int i = 0; i < dataGridView21.Rows.Count; i++)
                {
                    fx = double.Parse(fx.ToString()) + Convert.ToDouble(dataGridView21.Rows[i].Cells[6].Value.ToString());
                    textBox77.Text = fx.ToString();
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                for (int i = 0; i < dataGridView21.Rows.Count; i++)
                {
                    dataGridView21.Rows[i].Cells[10].Value = DateTime.Now.ToString();
                }
            }
            if (radioButton8.Checked == true)
            {
                for (int i = 0; i < dataGridView21.Rows.Count; i++)
                {
                    dataGridView21.Rows[i].Cells[10].Value = null;
                }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                label147.Visible = true;
                dateTimePicker18.Visible = true;
            }
            if (radioButton7.Checked == true)
            {
                label147.Visible = false;
                dateTimePicker18.Visible = false;
            }
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox60.Text);
                double y = double.Parse(textBox61.Text);
                double z = double.Parse(textBox67.Text);
                double res = (x - y) + z;
                double ress = y - x;

                if (x>=y)
                {
                    textBox84.Text = res.ToString();
                    textBox85.Text = "0.00"; 
                }
                if (x<y)
                {
                    textBox84.Clear();
                    textBox85.Text = ress.ToString();
                }
            }
            catch (Exception)
            {
                label24.Text = ".";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
               // MessageBox.Show("CheckIN"); 
                try
                {
                    group.EMPLOYEEID = double.Parse(textBox18.Text);
                    group.GRANDTOTAL = double.Parse(textBox78.Text);
                    group.GLN = textBox83.Text;
                    group.GFN = textBox82.Text;
                    group.GMN = textBox81.Text;
                    group.GCN = textBox79.Text;
                    group.GADRESS = textBox80.Text;
                    group.GBAL = double.Parse(textBox78.Text);
                    group.GCOMPANION = double.Parse(textBox77.Text);
                    group.CreateCustomerFirst();
                    group.CreateReservationGroup(dataGridView21);
                    textBox77.Clear();
                    textBox78.Clear();
                    textBox79.Clear();
                    textBox80.Clear();
                    textBox81.Clear();
                    textBox82.Clear();
                    textBox83.Clear();
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                }
                catch (Exception)
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Complete the details", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                }
            }
            if (radioButton8.Checked == true)
            {
                MessageBox.Show("reserve"); 
            }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = Reservationupdate.RoomDetails(conn);
                    if (dr.HasRows)
                    {
                        dataGridView22.Rows.Clear();
                        while (dr.Read())
                        {
                            double x = double.Parse(dr[1].ToString());
                            double y = double.Parse(dr[2].ToString());
                            string xx = string.Format("{0:N2}", x);
                            string yy = string.Format("{0:N2}", y);
                            dataGridView22.Rows.Add("Select", dr[0].ToString(), xx.ToString(), yy.ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                    }
                    else
                    {
                        dataGridView22.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    Reservationupdate.Excess_ChargeTIME_PUBLIC = double.Parse(textBox110.Text);
                    Reservationupdate.UPExcess_ChargeTIME(conn);
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }

                    textBox110.Clear(); 
                }
            }
            catch (Exception)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Invalid value", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.Excess_Conditions(conn);
                    if (dr.HasRows)
                    {
                        textBox10.Clear();
                        textBox9.Clear();
                        while (dr.Read())
                        {
                            textBox9.Text = dr[1].ToString();
                            textBox10.Text = dr[2].ToString();
                            double Charge1 = double.Parse(textBox9.Text);
                            double Charge2 = double.Parse(textBox10.Text);
                            textBox9.Text = string.Format("{0:N2}", Charge1);
                            textBox10.Text = string.Format("{0:N2}", Charge2);
                            GlobalTimeExess = double.Parse(textBox9.Text);
                        }
                    }
                    else
                    {
                        textBox10.Clear();
                        textBox9.Clear();
                    }
                }
            }
            catch (Exception)
            {
                textBox10.Clear();
                textBox9.Clear();
            }
            finally
            {
                conn.Close();
            }

            textBox111.Clear();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    Reservationupdate.Excess_ChargePERSON_PUBLIC = double.Parse(textBox111.Text);
                    Reservationupdate.UPExcess_ChargePERSON(conn);
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Updated", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }

                    textBox111.Clear(); 
                }
            }
            catch (Exception)
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Invalid value", "RDG Hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = command.Excess_Conditions(conn);
                    if (dr.HasRows)
                    {
                        textBox10.Clear();
                        textBox9.Clear();
                        while (dr.Read())
                        {
                            textBox9.Text = dr[1].ToString();
                            textBox10.Text = dr[2].ToString();
                            double Charge1 = double.Parse(textBox9.Text);
                            double Charge2 = double.Parse(textBox10.Text);
                            textBox9.Text = string.Format("{0:N2}", Charge1);
                            textBox10.Text = string.Format("{0:N2}", Charge2);
                            GlobalTimeExess = double.Parse(textBox9.Text);
                        }
                    }
                    else
                    {
                        textBox10.Clear();
                        textBox9.Clear();
                    }
                }
            }
            catch (Exception)
            {
                textBox10.Clear();
                textBox9.Clear();
            }
            finally
            {
                conn.Close();
            }

            textBox111.Clear(); 
        }

        private void button53_Click(object sender, EventArgs e)
        {

        }
    }
 }

