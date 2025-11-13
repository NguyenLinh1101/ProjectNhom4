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
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent();
        }

        private void pic1Background_Click(object sender, EventArgs e)
        {

        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            lblXinchao.Text = "Chào mừng trở lại, " + UserSession.TenNguoiDung + "!";
        }
    }
}
