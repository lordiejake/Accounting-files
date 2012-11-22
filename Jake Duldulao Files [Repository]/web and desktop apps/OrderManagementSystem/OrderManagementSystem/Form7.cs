using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;  
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class Form7 : System.Windows.Forms.Form   
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class1 log = new Class1(); 
        public Form7()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); 
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    log.USER = textBox1.Text;
                    log.PASSWORD = textBox2.Text;
                    SqlDataReader dr = log.LOGIN(conn);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            textBox3.Text = dr[0].ToString();
                            textBox4.Text = dr[2].ToString() + "  " + dr[3].ToString();


                            Form6 jake = new Form6();
                            jake.INtextbox7name = this.textBox4.Text;
                            jake.INtextbox7ID = this.textBox3.Text;


                            jake.ShowDialog();

                          
                             
                        }
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("The user name and password you entered did not match.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                            textBox4.Clear();
                            textBox3.Clear();  
                            
                        }
                    }
                }
            }
            catch (Exception )
            {

                //DialogResult okay = new DialogResult();
                //okay = MessageBox.Show("Login First", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //if (okay == DialogResult.OK)
                //{
                //    Application.DoEvents();
                //}

                throw;
            }
            finally { conn.Close(); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 j = new Form11();
            j.ShowDialog(); 
            //Form2 l = new Form2();
            //l.ShowDialog(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                label6.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                button1.PerformClick();  
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payments m = new Payments();
            m.ShowDialog();
        }

        
    }
}
