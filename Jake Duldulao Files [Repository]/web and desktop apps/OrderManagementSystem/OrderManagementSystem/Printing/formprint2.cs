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
    public partial class formprint2 : Form
    {
        public DataSet Prints = new DataSet();
        public formprint2()
        {
            InitializeComponent();
        }

        private void formprint2_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport7 report = new CrystalReport7();
            report.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
