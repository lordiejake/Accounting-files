using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reservations.Printing
{
    public partial class Print3 : Form
    {
        public DataSet Prints = new DataSet(); 
        public Print3()
        {
            InitializeComponent();
        }

        private void Print3_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport2 reportc = new CrystalReport2();
            reportc.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = reportc;
            crystalReportViewer1.Refresh();
        }
    }
}
