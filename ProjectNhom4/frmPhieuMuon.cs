using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class frmPhieuMuon : Form
    {
        private DataSet ds;

        public frmPhieuMuon(DataSet data)
        {
            InitializeComponent();
            ds = data;
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            string rdlcPath = Path.Combine(Application.StartupPath, "rptPhieuMuon.rdlc");
            if (!File.Exists(rdlcPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {rdlcPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         

            reportViewer1.LocalReport.ReportPath = rdlcPath;

            ReportDataSource rds = new ReportDataSource("dsPhieuMuon", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}

