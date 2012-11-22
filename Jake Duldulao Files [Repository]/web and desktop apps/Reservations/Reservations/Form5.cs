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
    public partial class Form5 : Form
    {
        SqlConnection conn = null;
        Employee log = new Employee();
        Rooms ro = new Rooms();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer(); 
                if (conn.State == ConnectionState.Open)
                {
                    log.USERN = textBox1.Text;
                    log.PASS = textBox2.Text;
                    SqlDataReader dr = log.LOGIN(conn);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            textBox3.Text = dr[1].ToString();
                            textBox4.Text = dr[2].ToString();
                            label5.Text = dr[0].ToString();

                            Form1 instance = new Form1();
                            instance.lasts = this.textBox3.Text;
                            instance.firsts = this.textBox4.Text;
                            instance.id = this.label5.Text;
                            instance.ShowDialog();  
                            
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
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Login First", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }

            }
            finally { conn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 m = new Form6();
            m.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            MessageBox.Show(string.Format("You selected: {0}", node.Text));

        }
    }
}
