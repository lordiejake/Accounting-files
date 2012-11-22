using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DateTime expiryDate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    DateTime datenow = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value.ToString());
        
                    if (datenow >= expiryDate)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = "di na";
                      

                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[2].Value = "pwd pa";
                    }
                }
            }
            catch (Exception)
            {

                label1.Text = "."; 
            }
        }
    }
}
