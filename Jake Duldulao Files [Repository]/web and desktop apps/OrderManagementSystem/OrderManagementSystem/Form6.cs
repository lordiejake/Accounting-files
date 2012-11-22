using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace OrderManagementSystem
{
    public partial class Form6 : Form
    {
        public string INtextbox7name = "";
        public string INtextbox7ID = "";


        public Form6()
        {
            InitializeComponent();
        }

        private void productsCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 k = new Form4();
            k.ValueinForm7name = this.textBox1.Text;
            k.ValueinForm7id = this.textBox2.Text;
            k.ShowDialog(); 
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.INtextbox7name;
            textBox2.Text = this.INtextbox7ID;


            toolStripComboBox1.Items.Clear();    
            toolStripComboBox1.Items.Clear();   
            toolStripComboBox1.Items.Add("Customer Payments");
            toolStripComboBox1.Items.Add("Supplier Payments");
            toolStripComboBox1.Items.Add("Returns to Supplier");
            toolStripComboBox1.Items.Add("Customer Returns");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 em = new Form3();
            em.ValueFromForm7texbox1 = this.textBox1.Text;
            em.ValueFromForm7texbox2 = this.textBox2.Text;
            em.ShowDialog(); 
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 show = new Form1();
            show.ShowDialog();  
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 showw = new Form5();
            showw.ShowDialog(); 
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 shw = new Form3();
            shw.ValueFromForm7texbox1 = this.textBox1.Text;
            shw.ValueFromForm7texbox2 = this.textBox2.Text;  
            shw.ShowDialog(); 
        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 p = new Form8();
            p.IDD = this.textBox2.Text;
            p.nameM = this.textBox1.Text; 
            p.ShowDialog(); 
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 k = new Form9();
            k.ShowDialog(); 
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 b = new Form12();
            b.ShowDialog(); 
        }

        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.ShowDialog(); 
        }

        private void storeIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 income = new Form13();
            income.ShowDialog();  
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            Form13 childForm = new Form13();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form16 income = new Form16();
            income.ShowDialog(); 
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form15 childForm = new Form15();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void returnOrdersCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 income = new Form17();
            income.empnem = this.textBox1.Text;
            income.emaid = this.textBox2.Text; 
            income.ShowDialog(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void supplierOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 k = new Form14();
            k.Empname = this.textBox1.Text;
            k.EmpID = this.textBox2.Text;
            k.ShowDialog(); 
        }

        private void returnOrdersSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 b = new Form19();
            b.Empname = this.textBox1.Text;
            b.EmpID = this.textBox2.Text;
            b.ShowDialog(); 
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Customer Payments")
            {
                
            }
            if (toolStripComboBox1.Text == "Supplier Payments")
            {
                
            }
            if (toolStripComboBox1.Text == "Returns to Supplier")
            {
                
            }
            if (toolStripComboBox1.Text == "Customer Returns")
            {
                
            }
        }

        private void customerPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 k = new Form21();
            k.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form22 tempDialog = new Form22();
            tempDialog.ShowDialog();

        }
        public void msgme()
        {
            MessageBox.Show("Parent Function Called");
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void utilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
