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
    public partial class frmCuonSach : Form
    {
        SqlConnection conn;
        string strConn = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";

        public bool IsEditMode { get; set; } = false;   // false = thêm mới, true = sửa
        public string MaDauSach { get; set; }           // nhận từ dgvDauSach hoặc dgvCuonSach
        public string MaSach { get; set; }              // nhận mã sách khi sửa

        public frmCuonSach()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtMaDauSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                string sql;

                if (IsEditMode)
                {
                    // CẬP NHẬT
                    sql = "UPDATE SACH SET Tinh_Trang = @Tinh_Trang, Lib_Only = @Lib_Only, Mo_Ta = @Mo_Ta WHERE Ma_Sach = @Ma_Sach";
                }
                else
                {
                    // THÊM MỚI
                    sql = "INSERT INTO SACH (Ma_Sach, Ma_Dau_Sach, Tinh_Trang, Lib_Only, Mo_Ta) " +
                          "VALUES (@Ma_Sach, @Ma_Dau_Sach, @Tinh_Trang, @Lib_Only, @Mo_Ta)";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma_Sach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("@Ma_Dau_Sach", txtMaDauSach.Text);
                cmd.Parameters.AddWithValue("@Tinh_Trang", cboTinhTrang.Text);
                cmd.Parameters.AddWithValue("@Lib_Only", cbLibOnly.Checked);
                cmd.Parameters.AddWithValue("@Mo_Ta", txtMoTa.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show(IsEditMode ? "Cập nhật thành công!" : "Thêm cuốn sách mới thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCuonSach_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            // Load combo box tình trạng
            cboTinhTrang.Items.Clear();
            cboTinhTrang.Items.Add("Có sẵn");
            cboTinhTrang.Items.Add("Đang mượn");

            if (IsEditMode)
            {
                // --- CHẾ ĐỘ SỬA ---
                txtMaSach.Text = MaSach;
                txtMaSach.ReadOnly = true;
                txtMaDauSach.Text = MaDauSach;
                txtMaDauSach.ReadOnly = true;

                // Lấy dữ liệu cuốn sách từ DB
                string sql = "SELECT * FROM SACH WHERE Ma_Sach = @Ma_Sach";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma_Sach", MaSach);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cboTinhTrang.Text = reader["Tinh_Trang"].ToString();
                    cbLibOnly.Checked = Convert.ToBoolean(reader["Lib_Only"]);
                    txtMoTa.Text = reader["Mo_Ta"].ToString();
                }
                reader.Close();
            }
            else
            {
                // --- CHẾ ĐỘ THÊM ---
                txtMaDauSach.Text = MaDauSach;
                txtMaDauSach.ReadOnly = true;

                // Tự sinh mã sách mới (max + 1)
                string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(Ma_Sach, 3, LEN(Ma_Sach)-2) AS INT)), 0) + 1 AS NewId FROM SACH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int newId = (int)cmd.ExecuteScalar();
                txtMaSach.Text = "CS" + newId.ToString("000");
                txtMaSach.ReadOnly = true;
            }
        }
        private void frmCuonSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

    }
}
