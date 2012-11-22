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
    public partial class Print4 : Form
    {
        public DataSet Prints = new DataSet(); 
        public Print4()
        {
            InitializeComponent();
        }

        private void Print4_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport3 reportc = new CrystalReport3();
            reportc.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = reportc;
            crystalReportViewer1.Refresh();
        }
    }
}
