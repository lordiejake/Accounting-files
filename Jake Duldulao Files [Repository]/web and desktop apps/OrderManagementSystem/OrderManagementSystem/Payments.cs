using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderManagementSystem
{
    public partial class Payments : Form
    {
        Class1 m = new Class1();
        
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = m.Changecode(conn);
                    if (dr.HasRows)
                    {
                        textBox3.Clear();
                        while (dr.Read())
                        {
                            textBox3.Text = dr[1].ToString();
                        }
                    }
                    else
                    {
                        textBox3.Clear();
                    }
                }
            }
            catch (Exception)
            {

                string x = "x";
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox1.Text)
            {
                MessageBox.Show("Wrong security code: You must enter the old security code first!"); 
            }
            else
            {
                m.updateSecuritycode(textBox2);
                textBox1.Clear();
                textBox2.Clear(); 
            }

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = m.Changecode(conn);
                    if (dr.HasRows)
                    {
                        textBox3.Clear(); 
                        while (dr.Read())
                        {
                            textBox3.Text = dr[1].ToString();
                        }
                    }
                    else
                    {
                        textBox3.Clear(); 
                    }
                }
            }
            catch (Exception)
            {

                string x = "x";
            }
            conn.Close();
        }
    }
}
