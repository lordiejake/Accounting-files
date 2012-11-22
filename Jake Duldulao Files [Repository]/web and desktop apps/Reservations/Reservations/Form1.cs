using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public string lasts = "";
        public string firsts = "";
        public string id = "";

        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.lasts;
            textBox2.Text = this.firsts;
            textBox3.Text = this.id;
            toolStripStatusLabel6.Text = this.lasts + "    " + this.firsts;  
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            Form4 l = new Form4();
            l.MdiParent = this;
            l.lnamez = this.textBox1.Text;
            l.fnamez = this.textBox2.Text;
            l.idz = this.textBox3.Text;
            l.Show();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 k = new Form3();
            k.MdiParent = this;
            k.Show();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.MdiParent = this;
            k.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                toolStripStatusLabel4.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
        }

        private void addWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 l = new Form4();
            l.MdiParent = this;
            l.lnamez = this.textBox1.Text;
            l.fnamez = this.textBox2.Text;
            l.idz = this.textBox3.Text;
            l.Show();
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 c = new Form8();
            c.ShowDialog();
        }
    }
}
