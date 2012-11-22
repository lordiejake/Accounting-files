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
    public partial class print3 : Form
    {
        public DataSet Prints = new DataSet();
        public print3()
        {
            InitializeComponent();
        }

        private void print3_Load(object sender, EventArgs e)
        {
            Printing.CrystalReport3 reporte = new CrystalReport3();
            reporte.Database.Tables[0].SetDataSource(Prints.Tables["DataTable1"]);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }
    }
}
