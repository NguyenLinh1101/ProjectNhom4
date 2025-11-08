using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Design;
using ProjectNhom4.Reports;

namespace ProjectNhom4
{
    public partial class Baocao : UserControl
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        public Baocao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSachHong_Click(object sender, EventArgs e)
        {
            Form f = new Baocaosachhong();
            f.ShowDialog();
        }

        private void Baocao_Load(object sender, EventArgs e)
        {

        }

        private void btnSachMat_Click(object sender, EventArgs e)
        {
            Form f = new frmBaocaosachmat();
            f.ShowDialog();
        }

        private void btnSachmuon_Click(object sender, EventArgs e)
        {
            Form f = new frmSachmuonnhieunhat();
            f.ShowDialog();
        }

        private void btnSachquahan_Click(object sender, EventArgs e)
        {
            Form f = new frmBCsachquahan();
            f.ShowDialog();
        }

        private void btnDocGiaVP_Click(object sender, EventArgs e)
        {
            Form f = new frmBCdocgiavipham();
            f.ShowDialog();
        }

        private void btnLVP_Click(object sender, EventArgs e)
        {
            Form f = new frmBCviphamtheoloai();
            f.ShowDialog();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            Form f = new BCdocgiamuonsach();
            f.ShowDialog();
        }
    }
}
