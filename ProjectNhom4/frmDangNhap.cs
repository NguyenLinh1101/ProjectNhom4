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
            if (txtMatKhau.PasswordChar == '\0')
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn lại
            }
            else
            {
                txtMatKhau.PasswordChar = '\0'; // Hiển thị rõ
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (email == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                string sql = "SELECT * FROM THU_THU WHERE Email = @Email AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string tenThuThu = reader["Ten_Thu_Thu"].ToString();
                    MessageBox.Show("Đăng nhập thành công!\nXin chào " + tenThuThu,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ẩn form đăng nhập
                    this.Hide();

                    // Mở form Menu chính
                    frmMenu formMenu = new frmMenu();

                    // Khi form Menu đóng, thì tắt hẳn ứng dụng
                    formMenu.FormClosed += (s, args) => Application.Exit();

                    formMenu.Show(); // Hiện form menu
                }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không đúng!",
                        "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
