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
    public partial class Form11 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        Class3 codess = new Class3(); 
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    codess.codesss = textBox1.Text;
                    SqlDataReader dr = codess.coding(conn);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Form2 m = new Form2();
                            m.ShowDialog();
                        }
                    }
                    else
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("The code you entered is not valid", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
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

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
