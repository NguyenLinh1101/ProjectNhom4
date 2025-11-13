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
    public partial class QLTacGia_Ribbon : UserControl
    {
        public QLTacGia_Ribbon()
        {
            InitializeComponent();
        }
        private void loadControl(UserControl uc)
        {
            panelQLTG_Contain.Controls.Clear(); // Xóa control cũ
            uc.Dock = DockStyle.Fill;        // Ép control mới lấp đầy Panel
            panelQLTG_Contain.Controls.Add(uc); // Thêm control mới vào
        }
        private void btnTacGia_Click(object sender, EventArgs e)
        {
            UC_QuanlyThongTinTacGia uc = new UC_QuanlyThongTinTacGia();

            loadControl(uc);
        }

        private void btnTacGiaSach_Click(object sender, EventArgs e)
        {
            var f = new frmTacgiaSach();  
            f.ShowDialog();
        }
    }
}
