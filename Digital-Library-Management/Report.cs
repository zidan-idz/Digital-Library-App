using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Digital_Library_Management
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();

            rptDoc.Load(@"CrystalReport1.rpt");  

            crystalReportViewer1.ReportSource = rptDoc;
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
