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
    public partial class UC_QuanlyTacgiaSach : UserControl
    {
        string strConnectionString = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        public UC_QuanlyTacgiaSach()
        {
            InitializeComponent();
            this.Load += UC_QuanlyTacgiaSach_Load;
        }

        private void grpDauSach_Click(object sender, EventArgs e)
        {

        }

        private void dgvDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cell = dgvThongTinTacGia.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell == null || cell.Value == null)
                {
                    MessageBox.Show("Không tìm thấy giá trị tương ứng.");
                    return;
                }
                string maTacGia = dgvThongTinTacGia.Rows[e.RowIndex].Cells["Ma_Tac_Gia"].Value.ToString();
                LoadDauSachTheoTacGia(maTacGia);

            }

        }

       
        // --- LOAD DANH SÁCH ---
        private void LoadTacGia()
        {
            SqlConnection sqlConnection = new SqlConnection(strConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Ma_Tac_Gia, Ten_Tac_Gia FROM TAC_GIA", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvThongTinTacGia.DataSource = dataTable;
            dgvThongTinTacGia.Columns["Ma_Tac_Gia"].HeaderText = "Mã Tác Giả";
            dgvThongTinTacGia.Columns["Ten_Tac_Gia"].HeaderText = "Tên Tác Giả";

        }
        private void LoadDauSach()
        {
            SqlConnection sqlConnection = new SqlConnection(strConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Ma_Dau_Sach, Ten_Dau_Sach FROM DAU_SACH", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvThongTinDauSach.DataSource = dataTable;
            dgvThongTinDauSach.Columns["Ma_Dau_Sach"].HeaderText = "Mã Đầu Sách";
            dgvThongTinDauSach.Columns["Ten_Dau_Sach"].HeaderText = "Tên Đầu Sách";

        }



        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cell = dgvThongTinDauSach.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell == null || cell.Value == null)
                {
                    MessageBox.Show("Không tìm thấy giá trị tương ứng.");
                    return;
                }
                string maDauSach = dgvThongTinDauSach.Rows[e.RowIndex].Cells["Ma_Dau_Sach"].Value.ToString();
                LoadTacGiaTheoDauSach(maDauSach);
            }

        }
        private void LoadDauSachTheoTacGia(string maTacGia)
        {
            using (SqlConnection conn = new SqlConnection(strConnectionString))
            {
                string query = @"
            SELECT ds.Ma_Dau_Sach, ds.Ten_Dau_Sach
            FROM DAU_SACH ds
            INNER JOIN TG_DAU_SACH tgds ON ds.Ma_Dau_Sach = tgds.Ma_Dau_Sach
            WHERE tgds.Ma_Tac_Gia = @MaTacGia";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaTacGia", maTacGia);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThongTinDauSach.DataSource = dt;
            }

        }
        private void LoadTacGiaTheoDauSach(string maDauSach)
        {
            using (SqlConnection conn = new SqlConnection(strConnectionString))
            {
                string query = @"
            SELECT tg.Ma_Tac_Gia, tg.Ten_Tac_Gia
            FROM TAC_GIA tg
            INNER JOIN TG_DAU_SACH tgds ON tg.Ma_Tac_Gia = tgds.Ma_Tac_Gia
            WHERE tgds.Ma_Dau_Sach = @MaDauSach";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaDauSach", maDauSach);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThongTinTacGia.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoadTacGia();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoadDauSach();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // Nếu ô tìm kiếm trống -> bỏ chọn tất cả hàng
            if (string.IsNullOrEmpty(searchText))
            {
                dgvThongTinDauSach.ClearSelection();
                return;
            }

            bool found = false;

            // Duyệt từng dòng trong dgv Đầu Sách
            foreach (DataGridViewRow row in dgvThongTinDauSach.Rows)
            {
                // Kiểm tra nếu ô Tên Đầu Sách có giá trị
                if (row.Cells["Ten_Dau_Sach"].Value != null)
                {
                    string tenSach = row.Cells["Ten_Dau_Sach"].Value.ToString().ToLower();

                    // Nếu có chứa từ khóa tìm kiếm
                    if (tenSach.Contains(searchText))
                    {
                        // Chọn dòng đó
                        row.Selected = true;
                        dgvThongTinDauSach.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        break; // chỉ dừng ở dòng đầu tiên khớp
                    }
                }
            }

            // Nếu không tìm thấy, bỏ chọn tất cả
            if (!found)
            {
                dgvThongTinDauSach.ClearSelection();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_QuanlyTacgiaSach_Load(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.SplitterDistance = splitContainer1.Width / 2;
                LoadTacGia();
                LoadDauSach();

                dgvThongTinTacGia.AutoGenerateColumns = true;
                dgvThongTinDauSach.AutoGenerateColumns = true;

                dgvThongTinTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvThongTinDauSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SuaTacGia_Click(object sender, EventArgs e)
        {

        }

        private void btnChitiet_Click_1(object sender, EventArgs e)
        {
            // 1️, Kiểm tra có dòng nào được chọn không
            if (dgvThongTinDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đầu sách để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️, Lấy dữ liệu từ dòng đang chọn
            string maDauSach = dgvThongTinDauSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();

            // 3️, Gọi form chi tiết và truyền dữ liệu
            ProjectNhom4.ChiTietDauSach frmChiTiet = new ProjectNhom4.ChiTietDauSach(maDauSach);
            frmChiTiet.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
