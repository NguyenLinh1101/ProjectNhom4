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
            panelHienthiUC.Controls.Clear(); // Xóa UC cũ nếu có

            // Kích thước gốc của UC (giả sử kích thước được thiết kế ở design mode)
            int originalWidth = uc.PreferredSize.Width > 0 ? uc.PreferredSize.Width : uc.Width;
            int originalHeight = uc.PreferredSize.Height > 0 ? uc.PreferredSize.Height : uc.Height;

            // Tính tỉ lệ scale so với panel
            float ratioX = (float)panelHienthiUC.Width / originalWidth;
            float ratioY = (float)panelHienthiUC.Height / originalHeight;

            // Lấy tỉ lệ nhỏ hơn để tránh méo
            float scale = Math.Min(ratioX, ratioY);

            // Đặt lại AutoScaleMode cho UC để scale toàn bộ control con
            uc.AutoScaleMode = AutoScaleMode.None;

            // Áp dụng scale cho toàn bộ UC
            uc.SuspendLayout();
            uc.Scale(new SizeF(scale, scale));
            uc.ResumeLayout();

            // Căn giữa UC trong panel
            uc.Left = (panelHienthiUC.Width - uc.Width) / 2;
            uc.Top = (panelHienthiUC.Height - uc.Height) / 2;

            // Đảm bảo UC hiển thị đúng kích thước
            uc.Anchor = AnchorStyles.None;

            panelHienthiUC.Controls.Add(uc);
            uc.BringToFront();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyThongTinTacGia());
            LoadUserControl(new UC_QuanlyThongTinTacGia());

            // Khi panelHienthiUC resize, scale lại UC hiện tại
            panelHienthiUC.Resize += (object sender2, EventArgs e2) =>
            {
                if (panelHienthiUC.Controls.Count > 0)
                {
                    var uc = panelHienthiUC.Controls[0] as UserControl;
                    if (uc != null)
                    {
                        LoadUserControl(uc);
                    }
                }
            };
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            // Xóa mọi control cũ trên form (trừ các nút menu)
            foreach (Control c in this.Controls.OfType<UserControl>().ToList())
            {
                this.Controls.Remove(c);
                c.Dispose();
            }

            // Tạo mới UserControl
            QL_TaiKhoan ucTaiKhoan = new QL_TaiKhoan();

            // Thiết lập vị trí hiển thị (tuỳ form bạn có layout gì)
            ucTaiKhoan.Dock = DockStyle.Fill;

            // Thêm vào form (trực tiếp)
            this.Controls.Add(ucTaiKhoan);
            ucTaiKhoan.BringToFront(); // Cho nó nổi lên trên cùng
        }

        private void btnqlmuontra_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyMuonTra_Ribbon());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            Baocao myUserControl = new Baocao();
            LoadUserControl(myUserControl);

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_TrangChu());
        }

        private void btnqlsach_Click(object sender, EventArgs e)
        {
            LoadUserControl(new QLSach_Ribbon());
        }
    }
}

