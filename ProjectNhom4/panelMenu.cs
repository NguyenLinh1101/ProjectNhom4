using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (pnlSubCaiDat.Visible)
            {
                // Thu gọn lại
                pnlSubCaiDat.Visible = false;
                pnlSubCaiDat.Height = 0;
                btnCaiDat.Text = "Cài đặt  ▼";
                // Đẩy nút Đăng xuất lên
                btnDangXuat.Top = pnlSubCaiDat.Top;
            }
            else
            {
                // Mở rộng ra
                pnlSubCaiDat.Visible = true;
                pnlSubCaiDat.Height = 100; // đúng bằng chiều cao thật của panel con
                btnCaiDat.Text = "Cài đặt  ▲";
                // Đẩy nút Đăng xuất xuống
                btnDangXuat.Top = pnlSubCaiDat.Top + pnlSubCaiDat.Height + 10;
            }
        }

        private void LoadUserControl(UserControl uc)
        {
           panelHienthiUC.Controls.Clear(); // Xóa UC cũ (nếu có)
            uc.Dock = DockStyle.Fill;   // Cho UC full panel
           panelHienthiUC.Controls.Add(uc); // Thêm UC vào panel
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            UC_TrangChu ucTrangChu = new UC_TrangChu();
            LoadUserControl(ucTrangChu);
        }
      
        private void btnqltacgia_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyThongTinTacGia());
        }

        private void btnqldocgia_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyDocGia());
        }

        private void panelHienthiUC_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnqlmuontra_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyMuonTra_Ribbon());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnqlsach_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QL_DauSach());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Baocao());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QL_TaiKhoan());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
            "Bạn có chắc chắn muốn đăng xuất?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // 2. Kiểm tra xem người dùng có chọn "Yes" không
            if (dr == DialogResult.Yes)
            {
                // 3. Khởi động lại ứng dụng.
                // Tác vụ này sẽ đóng form hiện tại (kích hoạt Application.Exit)
                // và tự động mở một tiến trình mới, bắt đầu lại từ frmDangNhap.
                Application.Restart();
            }
        }

        private void frmMenu_Load_1(object sender, EventArgs e)
        {
            UC_TrangChu ucTrangChu = new UC_TrangChu();
            LoadUserControl(ucTrangChu);
        }
    }
}

