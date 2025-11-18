using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class UC_QuanlyCuonSach : UserControl
    {
        string connStr = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";

        DataTable dtDauSach;
        DataTable dtCuonSach;
        string selectedMaDauSach = "";
        public Size BaseSize;

        public UC_QuanlyCuonSach()
        {
            InitializeComponent();
            BaseSize = this.Size;
        }

        private void UC_QuanlyCuonSach_Load(object sender, EventArgs e)
        {
            dgvDauSach.DefaultCellStyle.Font = new Font(dgvDauSach.Font, FontStyle.Regular);
            dgvCuonSach.DefaultCellStyle.Font = new Font(dgvCuonSach.Font, FontStyle.Regular);

            LoadDauSach();
            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dtDauSach == null) return;

            var rows = dtDauSach.Select($"Ten_Dau_Sach LIKE '%{txtSearch.Text}%'");

            if (rows.Length > 0)
            {
                dgvDauSach.DataSource = rows.CopyToDataTable();
            }
            else
            {
                // Trả về một bảng rỗng nhưng vẫn giữ cấu trúc
                dgvDauSach.DataSource = dtDauSach.Clone();
            }
        }
        private void LoadDauSach()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Ma_Dau_Sach, Ten_Dau_Sach, Nam_XB FROM DAU_SACH";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    dtDauSach = new DataTable();
                    da.Fill(dtDauSach);
                    dgvDauSach.DataSource = dtDauSach;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow != null)
            {
                selectedMaDauSach = dgvDauSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();
                LoadCuonSach(selectedMaDauSach);
            }
        }

        private void LoadCuonSach(string maDauSach)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT Ma_Sach, Ma_Dau_Sach, Tinh_Trang, Lib_Only, Mo_Ta FROM SACH WHERE Ma_Dau_Sach = @MaDauSach";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtCuonSach = new DataTable();
                    da.Fill(dtCuonSach);
                    dgvCuonSach.DataSource = dtCuonSach;
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu cuốn sách: " + ex.Message);
            }
        }

        // Thêm 1 cuốn sách
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


        // Sửa trực tiếp trong DataGridView
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCuonSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần sửa!");
                return;
            }

            string maSach = dgvCuonSach.CurrentRow.Cells["Ma_Sach"].Value.ToString();
            string maDauSach = dgvCuonSach.CurrentRow.Cells["Ma_Dau_Sach1"].Value.ToString();

            frmCuonSach f = new frmCuonSach();
            f.IsEditMode = true;
            f.MaSach = maSach;
            f.MaDauSach = maDauSach;

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCuonSachTheoDauSach(maDauSach); // Load lại dgv
            }
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
        // Xóa cuốn sách
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

        private void panelRoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoadDauSach();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gnlPanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTieude_Click(object sender, EventArgs e)
        {

        }
    }
}


