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
    }
    }

