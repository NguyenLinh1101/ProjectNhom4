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
        private UserControl currentUC;
        private Size originalSize;
        private bool originalSizeSaved = false;
        private Panel panelRoot;  // Panel gốc bên trong mỗi UC con
        public QLTacGia_Ribbon()
        {
            InitializeComponent();
        }

        private void LoadUserControlToPanel(UserControl uc)
        {
            panelContainer.Controls.Clear();
            currentUC = uc;
            panelRoot = uc.Controls["panelRoot"] as Panel; // Lấy panel gốc

            if (!originalSizeSaved)
            {
                originalSize = uc.Size;
                originalSizeSaved = true;
            }

            panelContainer.Controls.Add(uc);
            uc.BringToFront();

            ScaleUC();
        }

        private void ScaleUC()
        {
            if (panelRoot == null) return;

            panelRoot.SuspendLayout();

            panelRoot.Size = originalSize;

            float ratioX = (float)panelContainer.Width / originalSize.Width;
            float ratioY = (float)panelContainer.Height / originalSize.Height;

            float scale = Math.Min(ratioX, ratioY);

            panelRoot.Scale(new SizeF(scale, scale));

            // căn giữa UC theo panelRoot
            panelRoot.Left = (panelContainer.Width - panelRoot.Width) / 2;
            panelRoot.Top = (panelContainer.Height - panelRoot.Height) / 2;

            panelRoot.ResumeLayout();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            LoadUserControlToPanel (new UC_QuanlyThongTinTacGia());
        }

        private void QLTacGia_Ribbon_Load(object sender, EventArgs e)
        {
            // Mỗi khi panelContainer thay đổi size → scale lại UC đang load
            panelContainer.Resize += (s, e2) => ScaleUC();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadControl(UserControl uc)
        {
            panelContainer.Controls.Clear(); // Xóa control cũ
            uc.Dock = DockStyle.Fill;        // Ép control mới lấp đầy Panel
            panelContainer.Controls.Add(uc); // Thêm control mới vào
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ScaleUC();
        }

        private void btnTacGiaSach_Click(object sender, EventArgs e)
        {
            LoadUserControlToPanel (new UC_QuanlyTacgiaSach());
        }
    }
}
