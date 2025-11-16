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
            // 1. Set đường dẫn báo cáo
            string rdlcPath = Path.Combine(Application.StartupPath, "Reports", "rptPhieuMuon.rdlc");
            if (!File.Exists(rdlcPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {rdlcPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reportViewer1.LocalReport.ReportPath = rdlcPath;

            // 2. Bind DataSet vào Table trong báo cáo
            ReportDataSource rds = new ReportDataSource("dsPhieuMuon", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // 3. Truyền giá trị Parameter từ DataSet
            object ngayThucTraObj = ds.Tables[0].Rows[0]["Ngay_Thuc_Tra"];
            string ngayThucTraValue = ngayThucTraObj == DBNull.Value ? "" : Convert.ToDateTime(ngayThucTraObj).ToString("dd/MM/yyyy");

            object hanTraObj = ds.Tables[0].Rows[0]["Han_Tra"];
            string hanTraValue = hanTraObj == DBNull.Value ? "" : Convert.ToDateTime(hanTraObj).ToString("dd/MM/yyyy");

            object ngayMuonObj = ds.Tables[0].Rows[0]["Ngay_Muon"];
            string ngayMuonValue = ngayMuonObj == DBNull.Value ? "" : Convert.ToDateTime(ngayMuonObj).ToString("dd/MM/yyyy");

            ReportParameter[] parameters = new ReportParameter[]
            {
        new ReportParameter("p_NgayThucTra", ngayThucTraValue),
        new ReportParameter("p_HanTra", hanTraValue),
        new ReportParameter("p_NgayMuon", ngayMuonValue)
            };
            reportViewer1.LocalReport.SetParameters(parameters);

            // 4. Refresh báo cáo
            reportViewer1.RefreshReport();
        }



    }
}

