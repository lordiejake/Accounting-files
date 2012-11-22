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
    public partial class Form8 : Form
    {
        SqlConnection conn = null;
        Employee date = new Employee(); 
        public Form8()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                  date.DATE11 = dateTimePicker3.Text + " 12:01:00 AM";
                  date.DATE22 = dateTimePicker4.Text + " 11:59:00 PM";
                  conn = Connection.ConnectToServer();  
                  if (conn.State == ConnectionState.Open)
                  {
                      SqlDataReader dr = date.PopulateIncome2(conn);
                      if (dr.HasRows)
                      {
                          listBox1.Items.Clear();
                          while (dr.Read())
                          {
                              double x = double.Parse(dr[0].ToString());
                              string y = string.Format("{0:N2}",x); 
                              listBox1.Items.Add(dr[1].ToString() + "\t\t================\t\t" + y.ToString() + " Pesos");
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
                date.DATE11 = dateTimePicker3.Text + " 12:01:00 AM";
                date.DATE22 = dateTimePicker4.Text + " 11:59:00 PM";
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = date.PopulateIncome(conn);
                    if (dr.HasRows)
                    {
                        textBox1.Clear();  
                        while (dr.Read())
                        {
                            double x = double.Parse(dr[0].ToString());
                            string y = string.Format("{0:N2}", x);
                            textBox1.Text = y.ToString() + " Pesos"; 
                        }
                    }
                    else { textBox1.Clear(); }
                }
            }
            catch (Exception)
            {

                textBox1.Clear();  
            }
            finally { conn.Close(); }
        }
    }
}
