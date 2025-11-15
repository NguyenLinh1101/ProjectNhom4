using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class UC_PhieuViPham: UserControl
    {
        private bool isLoadingData = false;


        string connectionString = "Data Source=LAPTOP-SO78PQJP\\MSSQLSERVER01;Initial Catalog=QL_THUVIEN;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dtPhieuPhat;        // DGV trái
        DataTable dtChiTiet;          // DGV chi tiết
        bool isAdding = false;        // Trạng thái Thêm
        bool isEditing = false;       // Trạng thái Sửa

        private const string COL_MA_SACH = "Ma_Sach"; // Hoặc tên cột trong Designer
        private const string COL_TEN_SACH = "Ten_Sach";
        private const string COL_LY_DO = "Ly_Do";
        private const string COL_TIEN_PHAT = "Tien_Phat";
        private const string COL_MA_VI_PHAM = "Ma_Vi_Pham";
        public UC_PhieuViPham()
        {
            InitializeComponent();
            this.Load += UC_PhieuPhat_Load;

        }
        

        private void lblNgayLap_Click(object sender, EventArgs e)
        {

        }

        private void UC_PhieuPhat_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            InitChiTietDataTable();
            isLoadingData = true;
            LoadDanhSachPhieuPhat();
            LoadTrangThaiComboBox();
            LoadThuThu();
            LoadTrangThai();
            isLoadingData = false;
            dtpNgayLapPhieu.Value = DateTime.Now;
            txtTongTienPhat.Text = "0 VNĐ";

            dgvChiTietViPham.AutoGenerateColumns = false;
            dgvChiTietViPham.DataSource = dtChiTiet;
        }
        #region -- Init / Load Helpers --

        private void InitChiTietDataTable()
        {
            dtChiTiet = new DataTable();
            dtChiTiet.Columns.Add("Ma_Sach", typeof(string));
            dtChiTiet.Columns.Add("Ten_Sach", typeof(string));
            dtChiTiet.Columns.Add("Ly_Do", typeof(string));
            dtChiTiet.Columns.Add("Tien_Phat", typeof(decimal));
            dtChiTiet.Columns.Add("Ma_Vi_Pham", typeof(string));
        }
        private void LoadThuThu()
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Ma_Thu_Thu, Ten_Thu_Thu FROM THU_THU";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboThuThu.DataSource = dt;
                cboThuThu.DisplayMember = "Ten_Thu_Thu";
                cboThuThu.ValueMember = "Ma_Thu_Thu";
                cboThuThu.SelectedIndex = -1;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách thủ thư: " + ex.Message);
            }
        }

        private void LoadTrangThai()
        {
            cboTrangthainopphat.Items.Clear();
            cboTrangthainopphat.Items.Add("Đã nộp");
            cboTrangthainopphat.Items.Add("Chưa nộp");
            cboTrangthainopphat.SelectedIndex = 1;
        }

        private string SinhMaPhieuPhatMoi()
        {
            string prefix = "PP";
            int nextNumber = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT TOP 1 Ma_Phieu_Phat FROM PHIEU_PHAT ORDER BY Ma_Phieu_Phat DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string lastMa = result.ToString();   // VD: PP012
                    int numberPart = int.Parse(lastMa.Substring(2));
                    nextNumber = numberPart + 1;
                }
            }

            return prefix + nextNumber.ToString("D3"); // PP001, PP002...
        }


        private void LoadDanhSachPhieuPhat(string trangThai = "", string tenDocGia = "")
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    string query = @"
SELECT
    PP.Ma_Phieu_Phat AS [Mã Phiếu Phạt],
    DG.Ho_Ten AS [Độc Giả],
    PP.Ngay_Lap_Phieu AS [Ngày Lập],
    -- TÍNH TRẠNG THÁI TỔNG THỂ CỦA PHIẾU PHẠT
    CASE
        WHEN EXISTS (
            SELECT 1 FROM CT_PHIEU_PHAT CP
            WHERE CP.Ma_Phieu_Phat = PP.Ma_Phieu_Phat
            AND CP.Trang_Thai_Phieu = N'Chưa nộp' -- Nếu TỒN TẠI bất kỳ chi tiết nào CHƯA NỘP
        ) THEN N'Chưa nộp'
        ELSE N'Đã nộp' -- Nếu KHÔNG TỒN TẠI chi tiết nào Chưa nộp, nghĩa là Đã nộp hết
    END AS [Trạng Thái]
FROM PHIEU_PHAT PP
JOIN PHIEU_MUON PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
JOIN THE_DOC_GIA TDG ON PM.Ma_The = TDG.Ma_The
JOIN DOC_GIA DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
GROUP BY PP.Ma_Phieu_Phat, DG.Ho_Ten, PP.Ngay_Lap_Phieu
HAVING (DG.Ho_Ten LIKE @TenDocGia OR @TenDocGia = '%%')
AND (
    (CASE
        WHEN EXISTS (
            SELECT 1 FROM CT_PHIEU_PHAT CP_Filter
            WHERE CP_Filter.Ma_Phieu_Phat = PP.Ma_Phieu_Phat AND CP_Filter.Trang_Thai_Phieu = N'Chưa nộp'
        ) THEN N'Chưa nộp' ELSE N'Đã nộp'
    END = @TrangThai) OR @TrangThai = N'Tất cả' OR @TrangThai = ''
)
ORDER BY PP.Ngay_Lap_Phieu DESC";
                    da = new SqlDataAdapter(query, c);
                    da.SelectCommand.Parameters.AddWithValue("@TrangThai", trangThai);
                    da.SelectCommand.Parameters.AddWithValue("@TenDocGia", "%" + tenDocGia + "%");
                    dtPhieuPhat = new DataTable();
                    da.Fill(dtPhieuPhat);
                    dgvPhieuViPham.DataSource = dtPhieuPhat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách Phiếu Phạt: " + ex.Message);
            }
        }


        private void LoadTrangThaiComboBox()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Tất cả");
            cboTrangThai.Items.Add("Đã nộp");
            cboTrangThai.Items.Add("Chưa nộp");
            cboTrangThai.SelectedIndex = 0;
        }

        private void grpThongTinPhieuPhat_Enter(object sender, EventArgs e)
        {

        }

        private void btnluuphieuphat_Click(object sender, EventArgs e)
        {
            if (!isAdding && !isEditing)
            {
                MessageBox.Show("Vui lòng nhấn nút Thêm hoặc Sửa trước khi thêm chi tiết vi phạm.");
                return;
            }

            // Đảm bảo DataGridView đã hoàn tất việc chỉnh sửa ô hiện tại
            dgvChiTietViPham.EndEdit();

            // 1. Kiểm tra hàng cuối cùng (hàng nhập liệu mới)
            // Lấy dòng cuối cùng (hoặc dòng đang được thêm nếu AllowUserToAddRows = true)
            DataGridViewRow currentRow = dgvChiTietViPham.CurrentRow;

            if (currentRow == null) return;


            // Cố gắng lấy giá trị từ các ô của dòng cuối cùng (giả định là dòng đang được nhập)
            object maSachValue = currentRow.Cells[COL_MA_SACH].Value;
            object lyDoValue = currentRow.Cells[COL_LY_DO].Value;
            object tienPhatValue = currentRow.Cells[COL_TIEN_PHAT].Value;
            object maViPhamValue = currentRow.Cells[COL_MA_VI_PHAM].Value;

            // Validate
            if (maSachValue == null || string.IsNullOrWhiteSpace(maSachValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập Mã Sách cho dòng hiện tại!");
                return;
            }
            if (lyDoValue == null || string.IsNullOrWhiteSpace(lyDoValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập Lý Do Vi Phạm cho dòng hiện tại!");
                return;
            }
            if (maViPhamValue == null || string.IsNullOrWhiteSpace(maViPhamValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập Mã Vi Phạm cho dòng hiện tại!");
                return;
            }
            if (tienPhatValue == null || !decimal.TryParse(tienPhatValue.ToString(), out decimal tienPhat) || tienPhat < 0)
            {
                MessageBox.Show("Tiền phạt không hợp lệ cho dòng hiện tại!");
                return;
            }
            // 2. Thêm một DataRow mới vào DataTable với dữ liệu đã nhập
            // (Thao tác này thường được tự động hóa nếu bạn dùng BindingSource, 
            // nhưng vì bạn muốn nhấn nút để thêm, ta sẽ thêm thủ công vào dtChiTiet)
            DataRow newRow = dtChiTiet.NewRow();
            newRow["Ma_Sach"] = maSachValue.ToString();
            newRow["Ten_Sach"] = currentRow.Cells[COL_TEN_SACH].Value?.ToString() ?? "";
            newRow["Ly_Do"] = lyDoValue.ToString();
            newRow["Ma_Vi_Pham"] = maViPhamValue.ToString();
            newRow["Tien_Phat"] = tienPhat;

            dtChiTiet.Rows.Add(newRow);
            // ❗ Reset lại dòng đang nhập sau khi thêm vào DataTable
            currentRow.Cells[COL_MA_SACH].Value = "";
            currentRow.Cells[COL_TEN_SACH].Value = "";
            currentRow.Cells[COL_LY_DO].Value = "";
            currentRow.Cells[COL_MA_VI_PHAM].Value = "";
            currentRow.Cells[COL_TIEN_PHAT].Value = 0;

            // 3. Cập nhật DGV và tính tổng tiền
            // Dòng nhập liệu cũ sẽ bị xóa (tự động với DataBinding hoặc cần xóa thủ công nếu không có binding)
            // Giả định bạn đang dùng DataBinding, DGV sẽ tự cập nhật.

            TinhTongTienPhat();

            MessageBox.Show("Đã thêm chi tiết vi phạm vào danh sách. Nhấn Lưu để ghi vào Database.");

            // Reset dòng nhập liệu mới nếu cần, hoặc chỉ cần focus vào nó.
            if (dgvChiTietViPham.AllowUserToAddRows)
            {
                dgvChiTietViPham.CurrentCell = dgvChiTietViPham.Rows[dgvChiTietViPham.Rows.Count - 1].Cells[0];
            }
        }

        private void lblLoc_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieuViPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy Mã Phiếu Phạt từ dòng đang chọn
                object maPPValue = dgvPhieuViPham.Rows[e.RowIndex].Cells["Mã Phiếu Phạt"].Value;
                if (maPPValue == null) return;
                string maPP = maPPValue.ToString();


                // 1. Nạp chi tiết vào GroupBox
                NapThongTinPhieuPhat(maPP);

                // 2. Tải chi tiết các lỗi vi phạm
                LoadChiTietViPham(maPP);

                isAdding = false;
                isEditing = false;
                btnLuu.Enabled = false;
                txtMaPhieuPhat.ReadOnly = true;
            }
        }
        private void LoadChiTietViPham(string maPP)
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
    CP.Ma_Sach AS Ma_Sach,
    S.Ten_Sach AS Ten_Sach,
    VP.Ma_Vi_Pham AS Ma_Vi_Pham,
    CP.Ly_Do AS Ly_Do,
    CP.So_Tien_Phat AS Tien_Phat
                FROM CT_PHIEU_PHAT CP
                JOIN PHIEU_PHAT PP ON CP.Ma_Phieu_Phat = PP.Ma_Phieu_Phat
                LEFT JOIN PHIEU_MUON PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
                LEFT JOIN VI_PHAM VP ON CP.Ma_Vi_Pham = VP.Ma_Vi_Pham
                WHERE CP.Ma_Phieu_Phat = @MaPP";

                    da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPP", maPP);
                    dtChiTiet = new DataTable();
                    da.Fill(dtChiTiet);


                    dgvChiTietViPham.DataSource = dtChiTiet;
                    TinhTongTienPhat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết vi phạm: " + ex.Message);
            }
        }
        private void NapThongTinPhieuPhat(string maPP)
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Lấy thông tin chính của Phiếu Phạt, Phiếu Mượn và Độc Giả
                    string query = @"
SELECT
    PP.Ma_Phieu_Phat, PP.Ma_Phieu_Muon, PP.Ngay_Lap_Phieu, PP.Ma_Thu_Thu,
    TDG.Ma_Doc_Gia, DG.Ho_Ten,
    (SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP) AS Tong_Tien_Phat,
    -- Tính toán trạng thái phiếu dựa trên chi tiết
    CASE
        WHEN EXISTS (
            SELECT 1 FROM CT_PHIEU_PHAT CP
            WHERE CP.Ma_Phieu_Phat = @MaPP AND CP.Trang_Thai_Phieu = N'Chưa nộp'
        ) THEN N'Chưa nộp'
        ELSE N'Đã nộp'
    END AS Trang_Thai_Tong
FROM PHIEU_PHAT PP
LEFT JOIN PHIEU_MUON PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
LEFT JOIN THE_DOC_GIA TDG ON PM.Ma_The = TDG.Ma_The
LEFT JOIN DOC_GIA DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
WHERE PP.Ma_Phieu_Phat = @MaPP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPP", maPP);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Nạp thông tin chính
                            txtMaPhieuPhat.Text = reader["Ma_Phieu_Phat"].ToString();
                            txtMaPhieuMuon.Text = reader["Ma_Phieu_Muon"].ToString();
                            dtpNgayLapPhieu.Value = Convert.ToDateTime(reader["Ngay_Lap_Phieu"]);

                            // Nạp thông tin Độc Giả và Thủ Thư
                            txtMaDocGia.Text = reader["Ma_Doc_Gia"].ToString();
                            txtTenDocGia.Text = reader["Ho_Ten"].ToString();
                            
                            cboThuThu.SelectedValue = reader["Ma_Thu_Thu"].ToString();
                            string trangThaiTong = reader["Trang_Thai_Tong"].ToString();
                            cboTrangthainopphat.SelectedItem = trangThaiTong;


                            // Hiển thị Tổng Tiền Phạt
                            decimal tongTien = reader["Tong_Tien_Phat"] != DBNull.Value ? Convert.ToDecimal(reader["Tong_Tien_Phat"]) : 0;
                            txtTongTienPhat.Text = tongTien.ToString("N0") + " VNĐ";
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp chi tiết Phiếu Phạt: " + ex.Message);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (isLoadingData) return;
            LoadDanhSachPhieuPhat(cboTrangThai.SelectedItem?.ToString(), txtTimKiem.Text.Trim());
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingData) return; 
            string selectedTrangThai = cboTrangThai.SelectedItem?.ToString();
            string tenDocGia = txtTimKiem.Text.Trim();
            LoadDanhSachPhieuPhat(selectedTrangThai, tenDocGia);
        }

        private void txtMaPhieuPhat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboThuThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Hàm mới để lấy Ho_Ten, Ma_Doc_Gia từ Ma_Phieu_Muon
        private bool LayThongTinDocGiaTuPM(string maPM)
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    TDG.Ma_Doc_Gia, DG.Ho_Ten
                FROM PHIEU_MUON PM
                LEFT JOIN THE_DOC_GIA TDG ON PM.Ma_The = TDG.Ma_The
                LEFT JOIN DOC_GIA DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
                WHERE PM.Ma_Phieu_Muon = @MaPM AND PM.Ngay_Thuc_Tra IS NOT NULL"; // CHỈ LẤY PHIẾU ĐÃ TRẢ

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPM);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtMaDocGia.Text = reader["Ma_Doc_Gia"].ToString();
                            txtTenDocGia.Text = reader["Ho_Ten"].ToString();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin Độc Giả: " + ex.Message);
            }
            return false;
        }
        #endregion
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            // 1. Sinh mã mới
            txtMaPhieuPhat.Text = SinhMaPhieuPhatMoi();
            txtMaPhieuPhat.ReadOnly = true;

            // 2. Reset các trường
            txtMaPhieuMuon.Clear();
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtTongTienPhat.Text = "0 VNĐ";

            // 3. Ngày lập mặc định hôm nay
            dtpNgayLapPhieu.Value = DateTime.Now;

            // 4. Dropdown
            cboThuThu.SelectedIndex = -1;
            cboTrangthainopphat.SelectedIndex = 1;

            // 5. Xóa bảng chi tiết vi phạm
            dtChiTiet.Rows.Clear();
            dgvChiTietViPham.DataSource = dtChiTiet;

            // 6. Trạng thái nút (phù hợp quy trình)
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            MessageBox.Show("Sẵn sàng tạo Phiếu Phạt mới.\nVui lòng nhập Mã Phiếu Mượn.");
            txtMaPhieuMuon.Focus();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            isEditing = false;

            txtMaPhieuPhat.Clear();
            txtMaPhieuMuon.Clear();
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtTongTienPhat.Text = "0";

            dtChiTiet = new DataTable();
            dgvChiTietViPham.DataSource = dtChiTiet;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPP = txtMaPhieuPhat.Text;

            if (string.IsNullOrEmpty(maPP))
            {
                MessageBox.Show("Vui lòng chọn Phiếu Phạt cần xóa.");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa Phiếu Phạt {maPP}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string deleteCT = "DELETE FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                    SqlCommand cmd1 = new SqlCommand(deleteCT, conn, tran);
                    cmd1.Parameters.AddWithValue("@MaPP", maPP);
                    cmd1.ExecuteNonQuery();

                    string deletePP = "DELETE FROM PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                    SqlCommand cmd2 = new SqlCommand(deletePP, conn, tran);
                    cmd2.Parameters.AddWithValue("@MaPP", maPP);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Xóa Phiếu Phạt thành công!");

                    btnHuy_Click(sender, e);
                    LoadDanhSachPhieuPhat();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuPhat.Text))
            {
                MessageBox.Show("Vui lòng chọn Phiếu Phạt cần sửa.");
                return;
            }
            isEditing = true;
            isAdding = false;
            btnLuu.Enabled = true;
            MessageBox.Show("Đã chuyển sang chế độ Sửa. Bạn có thể thay đổi thông tin chi tiết và nhấn Lưu.");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuPhat.Text) || string.IsNullOrWhiteSpace(txtMaPhieuMuon.Text) || cboThuThu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã Phiếu Phạt, Mã Phiếu Mượn và Thủ Thư.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu phạt phải có ít nhất một Chi Tiết Vi Phạm.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                string maPP = txtMaPhieuPhat.Text;
                try
                {
                    if (isAdding)
                    {
                        // Insert PHIEU_PHAT
                        string insertPP = @"
INSERT INTO PHIEU_PHAT(Ma_Phieu_Phat, Ma_Phieu_Muon, Ma_Thu_Thu, Ngay_Lap_Phieu)
VALUES (@MaPhieuPhat, @MaPhieuMuon, @MaThuThu, @NgayLap)";


                        SqlCommand cmd = new SqlCommand(insertPP, conn, tran);
                        cmd.Parameters.AddWithValue("@MaPhieuPhat", maPP);
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", txtMaPhieuMuon.Text);
                        cmd.Parameters.AddWithValue("@MaThuThu", cboThuThu.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLapPhieu.Value);

                        cmd.ExecuteNonQuery();

                    }
                    else if (isEditing)
                    {
                        // 1. Update PHIEU_PHAT 
                        string updatePP = @"
UPDATE PHIEU_PHAT SET
    Ma_Phieu_Muon = @MaPhieuMuon,
    Ma_Thu_Thu = @MaThuThu,
    Ngay_Lap_Phieu = @NgayLap
WHERE Ma_Phieu_Phat = @MaPhieuPhat";


                        SqlCommand cmd = new SqlCommand(updatePP, conn, tran);
                        cmd.Parameters.AddWithValue("@MaPhieuPhat", maPP);
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", txtMaPhieuMuon.Text);
                        cmd.Parameters.AddWithValue("@MaThuThu", cboThuThu.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLapPhieu.Value);
                        cmd.ExecuteNonQuery();

                        // Xóa toàn bộ CT_PHIEU_PHAT cũ để chèn lại
                        string deleteCT = "DELETE FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                        SqlCommand cmdDelete = new SqlCommand(deleteCT, conn, tran);
                        cmdDelete.Parameters.AddWithValue("@MaPP", maPP);
                        cmdDelete.ExecuteNonQuery();

                    }
                    // 2. Insert CT_PHIEU_PHAT (Thêm chi tiết)
                    string insertCT = @"
INSERT INTO CT_PHIEU_PHAT(Ma_Phieu_Phat, Ma_Sach, Ma_Vi_Pham, Ly_Do, So_Tien_Phat, Trang_Thai_Phieu)
VALUES(@MaPhieuPhat, @MaSach, @MaViPham, @LyDo, @TienPhat, @TrangThaiChiTiet)";


                    // Lấy trạng thái từ ComboBox trên giao diện để áp dụng cho tất cả chi tiết
                    string trangThaiChiTiet = cboTrangthainopphat.SelectedItem?.ToString() ?? "Chưa nộp";


                    foreach (DataRow r in dtChiTiet.Rows)
                    {
                        SqlCommand cmd2 = new SqlCommand(insertCT, conn, tran);
                        cmd2.Parameters.AddWithValue("@MaPhieuPhat", maPP);
                        cmd2.Parameters.AddWithValue("@MaSach", r["Ma_Sach"].ToString());
                        cmd2.Parameters.AddWithValue("@LyDo", r["Ly_Do"].ToString());
                        cmd2.Parameters.AddWithValue("@MaViPham", r["Ma_Vi_Pham"]);
                        cmd2.Parameters.AddWithValue("@TienPhat", Convert.ToDecimal(r["Tien_Phat"]));
                        cmd2.Parameters.AddWithValue("@TrangThaiChiTiet", trangThaiChiTiet);
                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Lưu Phiếu Phạt thành công!");

                    isAdding = false;
                    isEditing = false;
                    btnLuu.Enabled = false;
                    LoadDanhSachPhieuPhat();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                }
            }
        }
        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            string maPM = txtMaPhieuMuon.Text.Trim();

            // 1. Xóa thông tin cũ
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            // DGV chi tiết vi phạm cũng cần xóa
            dtChiTiet?.Clear();
            dgvChiTietViPham.Refresh();

            if (string.IsNullOrEmpty(maPM))
            {
                return;
            }

            // 2. Kiểm tra tính hợp lệ và nạp thông tin
            if (LayThongTinDocGiaTuPM(maPM))
            {
                // Mã PM hợp lệ và đã được trả
                // Có thể gọi LoadSachViPham(maPM) nếu cần hiển thị sách bị lỗi ngay
            }
            else
            {
                // Mã PM không tồn tại hoặc chưa được trả
                MessageBox.Show("Mã Phiếu Mượn không tồn tại hoặc Phiếu chưa được trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhieuMuon.Focus(); // Bắt người dùng sửa lại
            }
        }
        private void TinhTongTienPhat()
        {
            decimal tong = 0;
            if (dtChiTiet == null) return;
            foreach (DataRow r in dtChiTiet.Rows)
            {
                if (r.Table.Columns.Contains("Tien_Phat") && r["Tien_Phat"] != DBNull.Value)
                {
                    if (decimal.TryParse(r["Tien_Phat"].ToString(), out decimal t))
                    {
                        tong += t;
                    }
                }
            }
            txtTongTienPhat.Text = tong.ToString("N0") + " VNĐ";
        }


        private void txtTongTienPhat_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void dgvChiTietViPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvChiTietViPham.AllowUserToAddRows = true;

            // Cập nhật tổng tiền khi sửa cột Tien_Phat
            if (dgvChiTietViPham.Columns[e.ColumnIndex].DataPropertyName == "Tien_Phat")
            {
                TinhTongTienPhat();
            }
        }

        private void dgvChiTietViPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Logic khi click vào danh sách Phiếu Phạt
            if (e.RowIndex >= 0)
            {
                object maPPValue = dgvPhieuViPham.Rows[e.RowIndex].Cells["Mã Phiếu Phạt"].Value;
                if (maPPValue == null) return;
                string maPP = maPPValue.ToString();

                NapThongTinPhieuPhat(maPP);
                LoadChiTietViPham(maPP);

                isAdding = false;
                isEditing = false;
                btnLuu.Enabled = false;
                txtMaPhieuPhat.ReadOnly = true;
            }

        }
        private void dgvChiTietViPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang load dữ liệu thì bỏ qua (tránh tự kích hoạt)
            if (isLoadingData) return;

            // Bỏ qua nếu hàng không hợp lệ
            if (e.RowIndex < 0) return;

            // Nếu không phải cột Mã Sách thì không xử lý
            if (e.ColumnIndex != dgvChiTietViPham.Columns[COL_MA_SACH].Index)
                return;

            // Lấy mã sách
            var cellValue = dgvChiTietViPham.Rows[e.RowIndex]
                              .Cells[COL_MA_SACH].Value;

            string maSach = cellValue?.ToString()?.Trim();
            if (string.IsNullOrEmpty(maSach))
            {
                dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_TEN_SACH].Value = "";
                return;
            }

            // Lấy tên sách
            string tenSach = LayTenSach(maSach);

            dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_TEN_SACH].Value = tenSach;
        }
        // 1) Hàm lấy tên sách an toàn
        private string LayTenSach(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                return string.Empty;

            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    string query = "SELECT Ten_Sach FROM SACH WHERE Ma_Sach = @ma";
                    using (var cmd = new SqlCommand(query, c))
                    {
                        cmd.Parameters.AddWithValue("@ma", maSach);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Có thể ghi log vào file hoặc hiển thị debug theo nhu cầu
                MessageBox.Show("Lỗi khi lấy Tên Sách: " + ex.Message);
            }
            return string.Empty;
        }


        private void btnXoadong_Click(object sender, EventArgs e)
        {
            if (dgvChiTietViPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            if (!isAdding && !isEditing)
            {
                MessageBox.Show("Vui lòng nhấn nút Sửa trước khi xóa chi tiết.");
                return;
            }

            DataGridViewRow selectedRow = dgvChiTietViPham.SelectedRows[0];
            DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

            if (rowView != null)
            {
                rowView.Row.Delete();
                dtChiTiet.Rows.Remove(rowView.Row);
                dtChiTiet.AcceptChanges();
                TinhTongTienPhat();
            }
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTrangthainopphat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayLapPhieu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = txtMaPhieuPhat.Text + ".pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                        iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\times.ttf";
                        if (!File.Exists(fontPath))
                            fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\arial.ttf";

                        BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                        iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);


                        iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("PHIẾU VI PHẠM", fontTitle);
                        title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        title.SpacingAfter = 15f;
                        doc.Add(title);

                        doc.Add(new iTextSharp.text.Paragraph($"Mã Phiếu Phạt: {txtMaPhieuPhat.Text}", fontNormal));
                        doc.Add(new iTextSharp.text.Paragraph($"Mã Phiếu Mượn: {txtMaPhieuMuon.Text}", fontNormal));
                        doc.Add(new iTextSharp.text.Paragraph($"Độc Giả: {txtTenDocGia.Text}", fontNormal));
                        doc.Add(new iTextSharp.text.Paragraph($"Ngày Lập: {dtpNgayLapPhieu.Value.ToShortDateString()}", fontNormal));
                        doc.Add(new iTextSharp.text.Paragraph($"Tổng Tiền Phạt: {txtTongTienPhat.Text}", fontNormal));
                        doc.Add(new iTextSharp.text.Paragraph(" ", fontNormal));

                        iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(dgvChiTietViPham.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible));
                        table.WidthPercentage = 100;
                        table.SpacingBefore = 10f;
                        table.SpacingAfter = 10f;

                        foreach (DataGridViewColumn column in dgvChiTietViPham.Columns)
                        {
                            if (column.Visible)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontHeader));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }

                        foreach (DataGridViewRow row in dgvChiTietViPham.Rows)
                        {
                            if (row.IsNewRow) continue;

                            for (int i = 0; i < dgvChiTietViPham.Columns.Count; i++)
                            {
                                DataGridViewColumn column = dgvChiTietViPham.Columns[i];
                                if (column.Visible)
                                {
                                    table.AddCell(new PdfPCell(new Phrase(row.Cells[i].Value?.ToString() ?? "", fontNormal)));
                                }
                            }
                        }
                        doc.Add(table);

                        doc.Add(new iTextSharp.text.Paragraph(" ", fontNormal));
                        doc.Add(new iTextSharp.text.Paragraph($"Thủ thư lập phiếu: {cboThuThu.Text}", fontNormal));


                        doc.Close();
                        writer.Close();

                        MessageBox.Show("Xuất Phiếu Phạt thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất PDF: " + ex.Message + "\nKiểm tra lại đường dẫn font tiếng Việt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}