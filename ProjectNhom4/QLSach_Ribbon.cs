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
        private UserControl currentUC;
        private Size originalSize;
        private bool originalSizeSaved = false;

        public QLSach_Ribbon()
        {
            InitializeComponent();
        }

        private void LoadUserControlToPanel(UserControl uc)
        {
            panelContainer.Controls.Clear();
            currentUC = uc;

            if (!originalSizeSaved)
            {
                originalSize = uc.Size;
                originalSizeSaved = true;
            }

            panelContainer.Controls.Add(uc);
            uc.BringToFront();

            ScaleUC();
        }

        // SCALE MƯỢT, CĂN GIỮA, KHÔNG MÉO
        private void ScaleUC()
        {
            if (currentUC == null) return;

            currentUC.SuspendLayout();

            currentUC.Size = originalSize;

            float ratioX = (float)panelContainer.Width / originalSize.Width;
            float ratioY = (float)panelContainer.Height / originalSize.Height;
            float scale = Math.Min(ratioX, ratioY);

            currentUC.Scale(new SizeF(scale, scale));

            currentUC.Left = (panelContainer.Width - currentUC.Width) / 2;
            currentUC.Top = (panelContainer.Height - currentUC.Height) / 2;

            currentUC.ResumeLayout();
        }


        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private bool isCollapsed =true;

        private void btnDauSach_Click(object sender, EventArgs e)
        {
            LoadUserControlToPanel(new QL_DauSach());
        }


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
            timer1.Enabled = false;

            // Mỗi khi panelContainer thay đổi size → scale lại UC đang load
            panelContainer.Resize += (s, e2) => ScaleUC();

            dropDown_DanhMuc.Height = dropDown_DanhMuc.MinimumSize.Height;
            isCollapsed = true;
            timer1.Enabled = false; // Đảm bảo timer không tự chạy
        }

        private void panelContainer_Resize(object sender, EventArgs e)
        {
            ScaleUC();
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
            panelContainer.Controls.Clear(); // Xóa control cũ
            uc.Dock = DockStyle.Fill;        // Ép control mới lấp đầy Panel
            panelContainer.Controls.Add(uc); // Thêm control mới vào
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