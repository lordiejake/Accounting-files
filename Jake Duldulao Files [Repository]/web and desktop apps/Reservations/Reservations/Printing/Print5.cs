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
    public partial class Print5 : Form
    {
        public DataSet Prints = new DataSet(); 
        public Print5()
        {
            InitializeComponent();
        }

        private void Print5_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport5 reportc = new CrystalReport5();
            reportc.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = reportc;
            crystalReportViewer1.Refresh();
        }
    }
}
