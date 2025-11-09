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
    public partial class QL_TaiKhoan : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False");
        bool isAdding = false;
        bool isEditing = false; // thêm biến này để kiểm soát chế độ sửa

        public QL_TaiKhoan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // 🔹 Load dữ liệu từ bảng THU_THU
        void LoadTaiKhoan()
        {
            try
            {
                string sql = "SELECT Ma_Thu_Thu, Ten_Thu_Thu, TenDN, MatKhau, Email, SDT, Quyen FROM THU_THU";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTaiKhoan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message);
            }
        }

        // 🔹 Khi chọn dòng trong DataGridView -> hiển thị lên textbox
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                // Cập nhật các textbox và combobox tương ứng
                cboThuThu.Text = row.Cells["Ten_Thu_Thu"].Value.ToString();
                txtTenDN.Text = row.Cells["TenDN"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cboQuyen.Text = row.Cells["Quyen"].Value.ToString();
            }
        }

        // 🔹 Load dữ liệu lên ComboBox Quyen
        void LoadQuyen()
        {
            cboQuyen.Items.Clear();
            cboQuyen.Items.Add("admin");
            cboQuyen.Items.Add("thuthu");
            cboQuyen.SelectedIndex = 0;
        }

        // 🔹 Load dữ liệu lên ComboBox ThuThu
        void LoadThuThu()
        {
            try
            {
                conn.Open();
                string sql = "SELECT Ma_Thu_Thu, Ten_Thu_Thu FROM THU_THU";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboThuThu.DataSource = dt;
                cboThuThu.DisplayMember = "Ten_Thu_Thu";
                cboThuThu.ValueMember = "Ma_Thu_Thu";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thủ thư: " + ex.Message);
            }
        }
        private void QL_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            LoadThuThu();
            LoadQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboThuThu.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd;

                if (isAdding)
                {
                    // Thêm mới tài khoản
                    string sqlInsert = @"UPDATE THU_THU
                                         SET TenDN=@TenDN, MatKhau=@MatKhau, Email=@Email, Quyen=@Quyen
                                         WHERE Ma_Thu_Thu=@Ma_Thu_Thu";
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@Ma_Thu_Thu", cboThuThu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm tài khoản thành công!");
                    isAdding = false;
                }
                else
                {
                    // Sửa thông tin tài khoản
                    string sqlUpdate = @"UPDATE THU_THU
                                         SET TenDN=@TenDN, MatKhau=@MatKhau, Email=@Email, Quyen=@Quyen
                                         WHERE Ma_Thu_Thu=@Ma_Thu_Thu";
                    cmd = new SqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@Ma_Thu_Thu", cboThuThu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật thông tin tài khoản!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadTaiKhoan();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            cboQuyen.SelectedIndex = -1;
            cboThuThu.SelectedIndex = -1;
            isAdding = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboThuThu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE THU_THU SET TenDN=NULL, MatKhau=NULL, Email=NULL, Quyen=NULL WHERE Ma_Thu_Thu=@Ma_Thu_Thu";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ma_Thu_Thu", cboThuThu.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã xóa tài khoản thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadTaiKhoan();
                }
            }
    }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboThuThu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdding = false;
            isEditing = true;

            MessageBox.Show("Hãy thay đổi thông tin trong các ô, sau đó nhấn 'Thêm' để lưu lại thay đổi!",
                            "Chế độ sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
