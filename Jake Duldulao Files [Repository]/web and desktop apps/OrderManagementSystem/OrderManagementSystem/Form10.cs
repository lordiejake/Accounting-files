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
    public partial class Form10 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=duldulaokzes-pc\sqlexpress;Database=Masters;Trusted_Connection=Yes");
        Class3 supplier = new Class3();
        public string id = "";
        public string nam = "";
        public Form10()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                supplier.ID = Convert.ToInt32(supplier.SUPIDD[comboBox1.SelectedIndex]);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = supplier.SearchSupplierID(conn);
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else { dataGridView1.Rows.Clear(); }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = supplier.SearchSupplier(conn);
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Clear();
                        supplier.SUPIDD.Clear();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[1].ToString() + "   " +  dr[2].ToString() + "  :" + dr[3].ToString());
                            supplier.SUPIDD.Add(dr[0]);   
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
                textBox2.Text = this.nam;
                textBox1.Text = this.id;   
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
