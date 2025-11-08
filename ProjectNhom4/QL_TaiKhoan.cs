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

        }
    }
}
