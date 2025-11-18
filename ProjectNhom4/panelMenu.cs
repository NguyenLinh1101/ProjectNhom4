using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            // ========================
            // PHÂN QUYỀN
            // ========================
            if (UserSession.Quyen == "thuthu")
            {
                // Ẩn các chức năng chỉ dành cho ADMIN
                btnQLTaiKhoan.Visible = false;
                btnBaocao.Visible = false;
                //btnCaiDat.Visible = false;
                //pnlSubCaiDat.Visible = false;
                btnProfile.Visible = true;
                btnBaocao.Visible = false;
            }
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

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\BTL4\HDSD.pdf";

            if (System.IO.File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true // quan trọng để mở PDF
                });
            }
            else
            {
                MessageBox.Show("Không tìm thấy file Hướng dẫn sử dụng!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadUserControl (new UC_ThongTinThuThu());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Hộp thoại chọn nơi lưu file .bak
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup files (*.bak)|*.bak";
                save.Title = "Chọn nơi lưu file Backup";
                save.FileName = "QL_Thu_Vien" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

                if (save.ShowDialog() != DialogResult.OK)
                    return; // thoát nếu chưa chọn file

                string filePath = save.FileName;

                // Tạo thư mục nếu chưa có
                string folder = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                // Kết nối đến master để backup
                string connectionString = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $@"
                BACKUP DATABASE QL_Thu_Vien 
                TO DISK = '{filePath}' 
                WITH INIT, SKIP, STATS = 10
            ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Backup dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup thất bại!\n\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
