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
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False");

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
