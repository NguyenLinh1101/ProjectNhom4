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
            pnlSubCaiDat.Visible = false;
            pnlSubCaiDat.Height = 0;
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
            panelContainer.Controls.Clear();
            // Ngăn Dock Fill phá scale
            uc.Dock = DockStyle.None;
            uc.Left = 0;
            uc.Top = 0;
            panelContainer.Controls.Add(uc);
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            LoadUserControl(new UC_TrangChu());
        }

        private void btnqltacgia_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new QLTacGia_Ribbon());
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

        private void btnBaocao_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new Baocao());
        }

        private void btnqlsach_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new QLSach_Ribbon());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sepBottom_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            LoadUserControl (new UC_TrangChu());
        }

        private void frmMenu_Load_1(object sender, EventArgs e)
        {
            LoadUserControl (new UC_TrangChu());
        }

        private void btnQLTaiKhoan_Click_1(object sender, EventArgs e)
        {
            LoadUserControl (new QL_TaiKhoan());
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
        "Bạn có chắc chắn muốn đăng xuất?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (dr == DialogResult.Yes)
            {
                this.Hide();  // Ẩn menu
                frmDangNhap login = new frmDangNhap();
                login.Show(); // Mở lại form đăng nhập
            }
        }
    }
}
