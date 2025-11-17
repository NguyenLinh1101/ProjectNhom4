using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class frmDangNhap : Form
    {
        private string connectionString =
            "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM THU_THU WHERE Email = @Email AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maThuThu = reader["Ma_Thu_Thu"].ToString(); // Lấy mã thủ thư
                                string tenThuThu = reader["Ten_Thu_Thu"].ToString();
                                string quyen = reader["Quyen"].ToString();   // lấy quyền từ DB

                                // --- Lưu vào UserSession ---
                                UserSession.MaThuThu = maThuThu;
                                UserSession.TenNguoiDung = tenThuThu;
                                UserSession.Quyen = quyen;


                                UserSession.TenNguoiDung = reader["Ten_Thu_Thu"].ToString();
                                UserSession.Quyen = reader["Quyen"].ToString();
                                UserSession.Email = reader["Email"].ToString();
                                UserSession.MatKhau = reader["MatKhau"].ToString();
                                UserSession.SDT = reader["SDT"].ToString();

                                MessageBox.Show("Đăng nhập thành công!\nXin chào " + UserSession.TenNguoiDung,
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();
                                frmMenu formMenu = new frmMenu();
                                formMenu.FormClosed += (s, args) => Application.Exit();
                                formMenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Email hoặc mật khẩu không đúng!",
                                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
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
    }
}
