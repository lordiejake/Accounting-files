using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderManagementSystem.Printing
{
    public partial class PrintForm : Form
    {
        public DataSet Print = new DataSet(); 
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport1 repor = new CrystalReport1();
            repor.Database.Tables[0].SetDataSource(Print.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = repor;
            crystalReportViewer1.Refresh();
        }
    }
}
