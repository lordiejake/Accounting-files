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
    public partial class print4 : Form
    {
        public DataSet Prints = new DataSet(); 
        public print4()
        {
            InitializeComponent();
        }

        private void print4_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport4 reportc = new CrystalReport4();
            reportc.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = reportc;
            crystalReportViewer1.Refresh();
        }
    }
}
