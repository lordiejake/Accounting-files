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
    public partial class Print2 : Form
    {
        public DataSet Prints = new DataSet(); 
        public Print2()
        {
            InitializeComponent();
        }

        private void Print2_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport2 report = new CrystalReport2();
            report.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
