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
    public partial class frmQuanlyCuonSach : Form
    {
        string connStr = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        string selectedMaDauSach = "";
        public frmQuanlyCuonSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dv != null)
            {
                dv.RowFilter = $"Ten_Dau_Sach LIKE '%{txtSearch.Text}%'";
            }
        }

        private void frmQuanlyCuonSach_Load(object sender, EventArgs e)
        {
            dgvDauSach.DefaultCellStyle.Font = new Font(dgvDauSach.Font, FontStyle.Regular);
            dgvCuonSach.DefaultCellStyle.Font = new Font(dgvCuonSach.Font, FontStyle.Regular);

            LoadDauSach();
           
        }
               
        private void dgvDauSach_SelectionChanged(object sender, EventArgs e)
        {
            ShowCuonSachTheoDauSach();
        }
        private void ShowCuonSachTheoDauSach()
        {
            if (dgvDauSach.CurrentRow != null && dgvDauSach.CurrentRow.Index >= 0)
            {
                int index = dgvDauSach.CurrentRow.Index;
                var maDauSachCell = dgvDauSach.Rows[index].Cells["Ma_Dau_Sach"].Value;

                if (maDauSachCell != null)
                {
                    selectedMaDauSach = maDauSachCell.ToString();

                    using (conn = new SqlConnection(connStr))
                    {
                        string sql = "SELECT Ma_Sach, Ma_Dau_Sach, Tinh_Trang, Lib_Only, Mo_Ta FROM SACH WHERE Ma_Dau_Sach = @MaDauSach";
                        adapter = new SqlDataAdapter(sql, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@MaDauSach", selectedMaDauSach);
                        dt = new DataTable();
                        adapter.Fill(dt);
                    }

                    dgvCuonSach.DataSource = dt;
                    SetCuonSachHeaders();
                }
            }
        }
        private void LoadDauSach()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "SELECT Ma_Dau_Sach, Ten_Dau_Sach, Nam_XB FROM DAU_SACH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDauSach.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            dgvDauSach.Columns["Ma_Dau_Sach"].HeaderText = "Mã Đầu Sách";
            dgvDauSach.Columns["Ten_Dau_Sach"].HeaderText = "Tên Đầu Sách";
            dgvDauSach.Columns["Nam_XB"].HeaderText = "Năm Xuất Bản";
        }
        
        private void SetCuonSachHeaders()
        {             
            dgvCuonSach.Columns["Ma_Sach"].HeaderText = "Mã Sách";
            dgvCuonSach.Columns["Ma_Dau_Sach"].HeaderText = "Mã Đầu Sách";
            dgvCuonSach.Columns["Tinh_Trang"].HeaderText = "Tình Trạng";
            dgvCuonSach.Columns["Lib_Only"].HeaderText = "Đọc Tại Thư Viện";
            dgvCuonSach.Columns["Mo_Ta"].HeaderText = "Mô Tả";
        }
        private void dgvDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDauSach = dgvDauSach.Rows[e.RowIndex].Cells["Ma_Dau_Sach"].Value.ToString();
                LoadCuonSach(maDauSach);
            }
        }
        private void LoadCuonSach(string maDauSach = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM SACH";
                    if (!string.IsNullOrEmpty(maDauSach))
                    {
                        sql += " WHERE Ma_Dau_Sach = @MaDauSach";
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (!string.IsNullOrEmpty(maDauSach))
                    {
                        cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCuonSach.DataSource = dt;

                    dgvCuonSach.Columns["Ma_Sach"].HeaderText = "Mã Sách";
                    dgvCuonSach.Columns["Ma_Dau_Sach"].HeaderText = "Mã Đầu Sách";
                    dgvCuonSach.Columns["Tinh_Trang"].HeaderText = "Tình Trạng";
                    dgvCuonSach.Columns["Lib_Only"].HeaderText = "Đọc Tại Thư Viện";
                    dgvCuonSach.Columns["Mo_Ta"].HeaderText = "Mô Tả";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu cuốn sách: " + ex.Message);
            }
        }

        private void dgvCuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh lỗi click header
            {
                DataGridViewRow row = dgvDauSach.Rows[e.RowIndex];
 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đầu sách trước khi thêm!");
                return;
            }

            string maDauSach = dgvDauSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();

            frmCuonSach f = new frmCuonSach();
            f.IsEditMode = false;
            f.MaDauSach = maDauSach;

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCuonSachTheoDauSach(maDauSach); // Hàm load lại dgvCuonSach
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCuonSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần sửa!");
                return;
            }

            string maSach = dgvCuonSach.CurrentRow.Cells["Ma_Sach"].Value.ToString();
            string maDauSach = dgvCuonSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();

            frmCuonSach f = new frmCuonSach();
            f.IsEditMode = true;
            f.MaSach = maSach;
            f.MaDauSach = maDauSach;

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCuonSachTheoDauSach(maDauSach); // Load lại dgv
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCuonSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa cuốn sách này không?",
                                              "Thông báo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            try
            {
                string sql = "DELETE FROM SACH WHERE Ma_Sach = @MaSach";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", dgvCuonSach.CurrentRow.Cells["Ma_Sach"].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCuonSach(selectedMaDauSach);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // lỗi khóa ngoại
                {
                    MessageBox.Show("Không thể xóa vì cuốn sách này đang được tham chiếu ở bảng khác.",
                                    "Lỗi ràng buộc",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            // 1️, Kiểm tra có dòng nào được chọn không
            if (dgvDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đầu sách để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️, Lấy dữ liệu từ dòng đang chọn
            string maDauSach = dgvDauSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();

            // 3️, Gọi form chi tiết và truyền dữ liệu
            ProjectNhom4.ChiTietDauSach frmChiTiet = new ProjectNhom4.ChiTietDauSach(maDauSach);
            frmChiTiet.ShowDialog();
        }

        private void gnlPanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadCuonSachTheoDauSach(string maDauSach)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM SACH WHERE Ma_Dau_Sach = @Ma_Dau_Sach";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma_Dau_Sach", maDauSach);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCuonSach.DataSource = dt;
            }
        }

    }
}
