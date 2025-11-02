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
            LoadUserControl(new UC_QuanlyThongTinTacGia());
        }
      
        private void btnqltacgia_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyThongTinTacGia());
        }

        private void btnqldocgia_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanlyDocGia());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            Baocao myUserControl = new Baocao();
            loadControl(myUserControl);

        }
        private void loadControl(UserControl uc)
        {
            // 1. Xóa tất cả control cũ đang có trong panelMain
            panelHienthiUC.Controls.Clear();

            // 2. Yêu cầu UserControl mới lấp đầy (Dock.Fill) panelMain
            uc.Dock = DockStyle.Fill;

            // 3. Thêm UserControl mới vào panelMain
            panelHienthiUC.Controls.Add(uc);
        }
    }
}

