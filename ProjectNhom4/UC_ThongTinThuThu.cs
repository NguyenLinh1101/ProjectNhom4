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
using System.IO;

namespace ProjectNhom4
{
    public partial class UC_ThongTinThuThu : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True");
        public UC_ThongTinThuThu()
        {
            InitializeComponent();
        }

        private void grbTTDG_Enter(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (txtMKht.PasswordChar == '\0')
            {
                txtMKht.PasswordChar = '*'; // Ẩn lại
            }
            else
            {
                txtMKht.PasswordChar = '\0'; // Hiển thị rõ
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (txtMKm.PasswordChar == '\0')
            {
                txtMKm.PasswordChar = '*'; // Ẩn lại
            }
            else
            {
                txtMKm.PasswordChar = '\0'; // Hiển thị rõ
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            openFile.Title = "Chọn ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Tải ảnh vào PictureBox và LƯU LẠI ĐƯỜNG DẪN
                picThuThu.Image = Image.FromFile(openFile.FileName);
                picThuThu.ImageLocation = openFile.FileName;
            }
        }

        private void UC_ThongTinThuThu_Load(object sender, EventArgs e)
        {
            grbDMK.Visible = false;
            panelBottom.Visible = false;
            txtMaThuThu.Enabled = false;
            txtTenDN.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            btnChonAnh.Enabled = false;
            txtTenTT.Enabled = false;
            txtXacNhan.PasswordChar = '*';
            txtMatKhau.ReadOnly = true;
            txtMatKhau.BackColor = Color.LightGray;   

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenDN, Email, SDT, AnhDaiDien, MatKhau, Ten_Thu_Thu FROM THU_THU WHERE Ma_Thu_Thu=@ma", conn);

                cmd.Parameters.AddWithValue("@ma", UserSession.MaThuThu);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    txtMaThuThu.Text = UserSession.MaThuThu;
                    txtTenDN.Text = rd["TenDN"].ToString();
                    txtEmail.Text = rd["Email"].ToString();
                    txtSDT.Text = rd["SDT"].ToString();
                    txtMatKhau.Text = rd["MatKhau"].ToString();
                    txtMatKhau.PasswordChar = '*';
                    txtTenTT.Text = rd["Ten_Thu_Thu"].ToString();

                    if (!rd.IsDBNull(rd.GetOrdinal("AnhDaiDien")))
                    {
                        string path = rd["AnhDaiDien"].ToString();
                        if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                            picThuThu.Image = Image.FromFile(path);
                    }

                }

                rd.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            grbDMK.Visible = true;
            panelBottom.Visible = true;
            txtMatKhau.ReadOnly = false;
            txtMatKhau.BackColor = Color.White;
            // tự động hiển thị mật khẩu hiện tại vào textbox
            txtMKht.Text = UserSession.MatKhau;
            txtMKht.PasswordChar = '*';
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string mkCu = txtMKht.Text;
            string mkMoi = txtMKm.Text;
            string xn = txtXacNhan.Text;

            if (string.IsNullOrWhiteSpace(mkCu) ||
                string.IsNullOrWhiteSpace(mkMoi) ||
                string.IsNullOrWhiteSpace(xn))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            if (mkCu != UserSession.MatKhau)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!");
                return;
            }

            if (mkMoi != xn)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE THU_THU SET MatKhau=@mk WHERE Ma_Thu_Thu=@ma", conn);

                cmd.Parameters.AddWithValue("@mk", mkMoi);
                cmd.Parameters.AddWithValue("@ma", UserSession.MaThuThu);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đổi mật khẩu thành công!");

                // Cập nhật Session
                UserSession.MatKhau = mkMoi;

                // Reset
                txtMKht.Clear();
                txtMKm.Clear();
                txtXacNhan.Clear();

                grbDMK.Visible = false;
                panelBottom.Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu!");
            }
            grbDMK.Visible = false;
            panelBottom.Visible = false;
            txtMatKhau.ReadOnly = true;
            txtMatKhau.BackColor = Color.LightGray;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            grbDMK.Visible = false;
            panelBottom.Visible = false;

            // Xóa trắng các textbox đổi mật khẩu
            txtMKht.Clear();
            txtMKm.Clear();
            txtXacNhan.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            btnChonAnh.Enabled = true;
            txtTenDN.Enabled = false;
            txtMaThuThu.Enabled = false;
            txtTenTT.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE THU_THU SET Email=@em, SDT=@sdt, AnhDaiDien=@anh WHERE Ma_Thu_Thu=@ma",
                    conn);

                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@anh", picThuThu.ImageLocation ?? "");
                cmd.Parameters.AddWithValue("@ma", txtMaThuThu.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã lưu thông tin!", "Thông báo");

                // Update UserSession
                UserSession.Email = txtEmail.Text;
                UserSession.SDT = txtSDT.Text;
                UserSession.AnhDaiDien = picThuThu.ImageLocation;
            }
            catch
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu!");
            }
        }

        private void txtMaThuThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
