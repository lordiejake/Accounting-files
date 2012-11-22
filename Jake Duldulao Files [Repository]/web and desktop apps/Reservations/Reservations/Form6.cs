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
    public partial class Form6 : Form
    {
        SqlConnection conn = null;
        Employee ems = new Employee();
 
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            double a = double.Parse(label15.Text);
            double b = double.Parse(label16.Text);
            double c = double.Parse(label17.Text);
            double d = double.Parse(label18.Text);
            double ez = double.Parse(label19.Text);
            double f = double.Parse(label20.Text);
            double g = double.Parse(label21.Text);
            double results = a + b + c + d + ez + f + g; 
            label22.Text = results.ToString();   
        }

        private void saveRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(label15.Text);
            double b = double.Parse(label16.Text);
            double c = double.Parse(label17.Text);
            double d = double.Parse(label18.Text);
            double ez = double.Parse(label19.Text);
            double f = double.Parse(label20.Text);
            double g = double.Parse(label21.Text);
            double results = a + b + c + d + ez + f + g;
            label22.Text = results.ToString();  

            if (label22.Text == "7")
            {
                try
                {
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        ems.LNAME = textBox1.Text;
                        ems.FNAME = textBox2.Text;
                        ems.MNAME = textBox3.Text;
                        ems.CONTACTS = textBox4.Text;
                        ems.ADDRESSS = textBox5.Text;
                        ems.USERNAME = textBox6.Text;
                        ems.PASSWORD = textBox7.Text;
                        ems.AddEmployee(conn);
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
            }
            else
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Sign all the informations", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text.Length.ToString();
            if (double.Parse(label8.Text)>0)
            {
                label15.Text = "1";
            }
            else
            {
                label15.Text = "0"; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox2.Text.Length.ToString();
            if (double.Parse(label9.Text) > 0)
            {
                label16.Text = "1";
            }
            else
            {
                label16.Text = "0"; 
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox3.Text.Length.ToString();
            if (double.Parse(label10.Text) > 0)
            {
                label17.Text = "1";
            }
            else
            {
                label17.Text = "0"; 
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox4.Text.Length.ToString();
            if (double.Parse(label11.Text) > 0)
            {
                label18.Text = "1";
            }
            else
            {
                label18.Text = "0"; 
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label12.Text = textBox5.Text.Length.ToString();
            if (double.Parse(label12.Text) > 0)
            {
                label19.Text = "1";
            }
            else
            {
                label19.Text = "0";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label13.Text = textBox6.Text.Length.ToString();
            if (double.Parse(label13.Text) > 0)
            {
                label20.Text = "1";
            }
            else
            {
                label20.Text = "0";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label14.Text = textBox7.Text.Length.ToString();
            if (double.Parse(label14.Text) > 0)
            {
                label21.Text = "1";
            }
            else
            {
                label21.Text = "0";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
           
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {
       
        }

        private void label18_Click(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {
           
        }

        private void label20_Click(object sender, EventArgs e)
        {
           
        }

        private void label21_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
