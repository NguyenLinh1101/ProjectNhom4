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
    public partial class frmPhieuViPham : Form
    {
        public frmPhieuViPham()
        {
            InitializeComponent();
            UC_PhieuViPham uc = new UC_PhieuViPham();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void frmPhieuViPham_Load(object sender, EventArgs e)
        {
            UC_PhieuViPham uc = new UC_PhieuViPham();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
