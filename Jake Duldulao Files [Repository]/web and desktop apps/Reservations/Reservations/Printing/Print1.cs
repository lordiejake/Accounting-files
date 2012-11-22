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
    public partial class Print1 : Form
    {

        public DataSet Prints = new DataSet(); 
        public Print1()
        {
            InitializeComponent();
        }

        private void Print1_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport1 reportc = new CrystalReport1();
            reportc.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = reportc;
            crystalReportViewer1.Refresh();
        }
    }
}
