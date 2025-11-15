using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class UC_PhieuTraSach : UserControl
    {
        // Chuỗi kết nối SQL Server
        string strCon = @"Data Source=LAPTOP-SO78PQJP\MSSQLSERVER01;Initial Catalog=QL_THUVIEN;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        // Biến lưu mã phiếu mượn đang chọn
        private string selectedMaPM;
        public UC_PhieuTraSach()
        {
            InitializeComponent();
            this.Load += UC_PhieuTraSach_Load; // gắn event Load
        }

        private void UC_PhieuTraSach_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
