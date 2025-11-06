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
    public partial class QLSach_Ribbon : UserControl
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelQLSach_contain.Controls.Clear();
            panelQLSach_contain.Controls.Add(userControl); // <-- Thêm vào panelContainer
            userControl.BringToFront();
        }
        public QLSach_Ribbon()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private bool isCollapsed =true;

        private void btnDauSach_Click(object sender, EventArgs e)
        {
            QL_DauSach uc = new QL_DauSach();

            loadControl(uc);
        }

        // Fix for CS0103: Define the AddUserControl method


        private void btnCuonSach_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnDanhMuc.Image = Properties.Resources.down_chevron;
                dropDown_DanhMuc.Height += 10;
                if (dropDown_DanhMuc.Size == dropDown_DanhMuc.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnDanhMuc.Image = Properties.Resources.down_arrow;
                dropDown_DanhMuc.Height -= 10;
                if (dropDown_DanhMuc.Size == dropDown_DanhMuc.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }
        private void QLSach_Ribbon_Load(object sender, EventArgs e)
        {
            dropDown_DanhMuc.Height = dropDown_DanhMuc.MinimumSize.Height;
            isCollapsed = true;
            timer1.Enabled = false; // Đảm bảo timer không tự chạy
        }
        private void btnDanhMuc_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panelQLSach_contain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuDe_Click(object sender, EventArgs e)
        {
            var f = new frmChuDe();
            f.ShowDialog();
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiSach();
            f.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panelQLSach_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadControl(UserControl uc)
        {
            panelQLSach_contain.Controls.Clear(); // Xóa control cũ
            uc.Dock = DockStyle.Fill;        // Ép control mới lấp đầy Panel
            panelQLSach_contain.Controls.Add(uc); // Thêm control mới vào
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDanhMuc_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}