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
    public partial class UC_QuanlyMuonTra_Ribbon : UserControl
    {
        public UC_QuanlyMuonTra_Ribbon()
        {
            InitializeComponent();
        }
        private void LoadUserControlToPanel(UserControl uc)
        {
            panelContainer.Controls.Clear(); // Xóa UC cũ nếu có

            // Lấy kích thước gốc của UC (khi thiết kế trong Design)
            int originalWidth = uc.PreferredSize.Width > 0 ? uc.PreferredSize.Width : uc.Width;
            int originalHeight = uc.PreferredSize.Height > 0 ? uc.PreferredSize.Height : uc.Height;

            // Tính tỉ lệ scale dựa vào kích thước của panelContainer
            float ratioX = (float)panelContainer.Width / originalWidth;
            float ratioY = (float)panelContainer.Height / originalHeight;

            // Chọn tỉ lệ nhỏ hơn để không méo
            float scale = Math.Min(ratioX, ratioY);

            // Áp dụng scale đều toàn bộ UC (thu nhỏ từ trong ra ngoài)
            uc.AutoScaleMode = AutoScaleMode.None;
            uc.SuspendLayout();
            uc.Scale(new SizeF(scale, scale));
            uc.ResumeLayout();

            // Căn giữa UC trong panelContainer
            uc.Left = (panelContainer.Width - uc.Width) / 2;
            uc.Top = (panelContainer.Height - uc.Height) / 2;

            // Thêm UC vào panel
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            LoadUserControlToPanel(new UC_QuanlyMuonTra());
        }
        private void UC_QuanlyMuonTra_Ribbon_Load(object sender, EventArgs e)
        {
            panelContainer.Resize += (s, e2) =>
            {
                if (panelContainer.Controls.Count > 0)
                {
                    var uc = panelContainer.Controls[0] as UserControl;
                    if (uc != null)
                    {
                        LoadUserControlToPanel(uc);
                    }
                }
            };
        }
        public Panel PanelContainer
        {
            get { return panelContainer; }
        }

        private void panelRibbon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhieuPhat_Click(object sender, EventArgs e)
        {
            LoadUserControlToPanel(new UC_PhieuViPham());
        }
    }
}
