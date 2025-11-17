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
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class UC_PhieuViPham: UserControl
    {
        private bool isLoadingData = false;


        string connectionString = "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False\r\n";
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dtPhieuPhat;        // DGV trái
        DataTable dtChiTiet;          // DGV chi tiết
        DataTable dtViPham;
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
            LoadDanhSachViPhamChoComboBox();
            isLoadingData = false;
            dtpNgayLapPhieu.Value = DateTime.Now;
            txtTongTienPhat.Text = "0 VNĐ";

            dgvChiTietViPham.AutoGenerateColumns = false;
            dgvChiTietViPham.DataSource = dtChiTiet;
            this.dgvChiTietViPham.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvChiTietViPham_CurrentCellDirtyStateChanged);
            SetControlState("Normal");
        }
        #region -- Init / Load Helpers --
        private void dgvChiTietViPham_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có phải cột "Lý do" đang được sửa không
            if (dgvChiTietViPham.CurrentCell.ColumnIndex == dgvChiTietViPham.Columns[COL_LY_DO].Index)
            {
                // Commit (chốt) giá trị ComboBox ngay lập tức
                // Điều này sẽ kích hoạt sự kiện CellValueChanged
                if (dgvChiTietViPham.IsCurrentCellDirty)
                {
                    dgvChiTietViPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }
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
                    string lastMa = result.ToString();   
                    int numberPart = int.Parse(lastMa.Substring(2));
                    nextNumber = numberPart + 1;
                }
            }

            return prefix + nextNumber.ToString("D4"); 
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
    PP.Ma_Phieu_Phat AS Ma_Phieu_Phat,
    DG.Ho_Ten AS Doc_Gia,
    PP.Ngay_Lap_Phieu AS Ngay_Lap,
    CASE
        WHEN EXISTS (
            SELECT 1 FROM CT_PHIEU_PHAT CP
            WHERE CP.Ma_Phieu_Phat = PP.Ma_Phieu_Phat 
            AND CP.Trang_Thai_Phieu = N'Chưa nộp'
        ) THEN N'Chưa nộp'
        ELSE N'Đã nộp'
    END AS Trang_Thai
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

                    // Đặt AutoGenerateColumns TRƯỚC khi gán DataSource
                    dgvPhieuViPham.AutoGenerateColumns = false;
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
            
            
        }
        private void LoadChiTietViPham(string maPP)
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // SỬA LỖI SQL: Phải JOIN SACH với DAU_SACH
                    string query = @"
                SELECT 
                    CP.Ma_Sach AS Ma_Sach,
                    DS.Ten_Dau_Sach AS Ten_Sach, 
                    CP.Ma_Vi_Pham AS Ma_Vi_Pham,
                    CP.Ly_Do AS Ly_Do,
                    CP.So_Tien_Phat AS Tien_Phat
                FROM CT_PHIEU_PHAT CP
                LEFT JOIN SACH S ON CP.Ma_Sach = S.Ma_Sach
                LEFT JOIN DAU_SACH DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                LEFT JOIN VI_PHAM VP ON CP.Ma_Vi_Pham = VP.Ma_Vi_Pham
                WHERE CP.Ma_Phieu_Phat = @MaPP";

                    da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPP", maPP);
                    dtChiTiet = new DataTable();
                    da.Fill(dtChiTiet);
                    dgvChiTietViPham.AutoGenerateColumns = false;
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


        private bool LayThongTinDocGiaTuPM(string maPM, out string maDocGia, out string tenDocGia, out string maThuThu, out DateTime? ngayThucTra)
        {
            maDocGia = null;
            tenDocGia = null;
            maThuThu = null;
            ngayThucTra = null;
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT
                TDG.Ma_Doc_Gia, DG.Ho_Ten, PM.Ma_Thu_Thu, PM.Ngay_Thuc_Tra
            FROM PHIEU_MUON PM
            LEFT JOIN THE_DOC_GIA TDG ON PM.Ma_The = TDG.Ma_The
            LEFT JOIN DOC_GIA DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
            WHERE PM.Ma_Phieu_Muon = @MaPM AND PM.Ngay_Thuc_Tra IS NOT NULL"; // Chỉ lấy phiếu đã trả
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPM);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                maDocGia = reader["Ma_Doc_Gia"] != DBNull.Value ? reader["Ma_Doc_Gia"].ToString() : null;
                                tenDocGia = reader["Ho_Ten"] != DBNull.Value ? reader["Ho_Ten"].ToString() : null;
                                maThuThu = reader["Ma_Thu_Thu"] != DBNull.Value ? reader["Ma_Thu_Thu"].ToString() : null;
                                ngayThucTra = reader["Ngay_Thuc_Tra"] != DBNull.Value ? (DateTime?)reader["Ngay_Thuc_Tra"] : null;
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin Độc Giả: " + ex.Message);
                return false;
            }
            return false;
        }

        #endregion
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            txtMaPhieuPhat.Text = SinhMaPhieuPhatMoi();

            // (Code ClearForm và Reset các trường của bạn đã đúng...)
            txtMaPhieuMuon.Clear();
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtTongTienPhat.Text = "0 VNĐ";
            dtpNgayLapPhieu.Value = DateTime.Now;
            cboThuThu.SelectedIndex = -1;
            cboTrangthainopphat.SelectedIndex = 1;
            dtChiTiet.Rows.Clear();
            dgvChiTietViPham.DataSource = dtChiTiet;

            // SỬA LẠI:
            SetControlState("Editing"); // Chuyển sang chế độ "Thêm"

            MessageBox.Show("Sẵn sàng tạo Phiếu Phạt mới.\nVui lòng nhập Mã Phiếu Mượn.");
            txtMaPhieuMuon.Focus();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            isEditing = false;

            // 1. Xóa trắng form
            txtMaPhieuPhat.Clear();
            txtMaPhieuMuon.Clear();
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtTongTienPhat.Text = "0 VNĐ";
            dtpNgayLapPhieu.Value = DateTime.Now;
            cboThuThu.SelectedIndex = -1;
            cboTrangthainopphat.SelectedIndex = 1;

            dtChiTiet.Rows.Clear(); // Chỉ cần Clear Rows

            // 2. Tải lại dữ liệu của dòng đang chọn (nếu có)
            if (dgvPhieuViPham.CurrentRow != null)
            {
                // Tải lại dữ liệu gốc
                string maPP = dgvPhieuViPham.CurrentRow.Cells["Ma_Phieu_Phat"].Value.ToString();
                NapThongTinPhieuPhat(maPP);
                LoadChiTietViPham(maPP);
            }

            // 3. Đặt lại trạng thái
            SetControlState("Normal");
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

            // SỬA LẠI:
            SetControlState("Editing"); // Chuyển sang chế độ "Sửa"

            MessageBox.Show("Đã chuyển sang chế độ Sửa. Bạn có thể thay đổi thông tin chi tiết và nhấn Lưu.");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ====== KIỂM TRA DỮ LIỆU ======
            if (string.IsNullOrWhiteSpace(txtMaPhieuPhat.Text) ||
                string.IsNullOrWhiteSpace(txtMaPhieuMuon.Text) ||
                cboThuThu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đủ Mã Phiếu Phạt, Mã Phiếu Mượn và Thủ Thư.");
                return;
            }

            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu phạt phải có ít nhất 1 chi tiết.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                string maPP = txtMaPhieuPhat.Text.Trim();

                try
                {
                    // ===================================================
                    // 1. THÊM MỚI PHIẾU PHẠT
                    // ===================================================
                    if (isAdding)
                    {
                        string sql = @"
INSERT INTO PHIEU_PHAT (Ma_Phieu_Phat, Ma_Phieu_Muon, Ma_Thu_Thu, Ngay_Lap_Phieu)
VALUES (@MaPP, @MaPM, @MaTT, @NgayLap)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaPP", maPP);
                            cmd.Parameters.AddWithValue("@MaPM", txtMaPhieuMuon.Text.Trim());
                            cmd.Parameters.AddWithValue("@MaTT", cboThuThu.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLapPhieu.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // ===================================================
                    // 2. SỬA PHIẾU PHẠT
                    // ===================================================
                    if (isEditing)
                    {
                        // Update PHIEU_PHAT
                        string sql = @"
UPDATE PHIEU_PHAT SET 
    Ma_Phieu_Muon = @MaPM,
    Ma_Thu_Thu = @MaTT,
    Ngay_Lap_Phieu = @NgayLap
WHERE Ma_Phieu_Phat = @MaPP";

                        using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaPP", maPP);
                            cmd.Parameters.AddWithValue("@MaPM", txtMaPhieuMuon.Text.Trim());
                            cmd.Parameters.AddWithValue("@MaTT", cboThuThu.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLapPhieu.Value);
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa chi tiết cũ
                        using (SqlCommand cmdDel = new SqlCommand(
                            "DELETE FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP", conn, tran))
                        {
                            cmdDel.Parameters.AddWithValue("@MaPP", maPP);
                            cmdDel.ExecuteNonQuery();
                        }
                    }

                    // ===================================================
                    // 3. THÊM CHI TIẾT PHIẾU PHẠT (CẢ THÊM MỚI LẪN SỬA)
                    // ===================================================

                    string insertCT = @"
INSERT INTO CT_PHIEU_PHAT
(Ma_Phieu_Phat, Ma_Sach, Ma_Vi_Pham, Ly_Do, So_Tien_Phat, Trang_Thai_Phieu)
VALUES (@MaPP, @MaSach, @MaVP, @LyDo, @TienPhat, @TrangThai)";

                    string trangThaiChiTiet = cboTrangthainopphat.SelectedItem?.ToString() ?? "Chưa nộp";

                    foreach (DataRow r in dtChiTiet.Rows)
                    {
                        string maSach = r["Ma_Sach"]?.ToString().Trim();
                        string lyDo = r["Ly_Do"]?.ToString().Trim();
                        string maViPham = r["Ma_Vi_Pham"]?.ToString().Trim();

                        // Bỏ qua dòng rỗng
                        if (string.IsNullOrEmpty(maSach) && string.IsNullOrEmpty(lyDo))
                            continue;

                        if (string.IsNullOrEmpty(maSach) || string.IsNullOrEmpty(maViPham))
                        {
                            tran.Rollback();
                            MessageBox.Show($"Dòng chi tiết thiếu dữ liệu (Sách: {maSach}, Vi phạm: {maViPham}).");
                            return;
                        }

                        // ==============================
                        // KIỂM TRA TRÙNG TRƯỚC KHI CHÈN
                        // ==============================
                        string checkDup = @"
SELECT COUNT(*) 
FROM CT_PHIEU_PHAT
WHERE Ma_Phieu_Phat = @MaPP AND Ma_Sach = @MaSach AND Ma_Vi_Pham = @MaVP";

                        using (SqlCommand checkCmd = new SqlCommand(checkDup, conn, tran))
                        {
                            checkCmd.Parameters.AddWithValue("@MaPP", maPP);
                            checkCmd.Parameters.AddWithValue("@MaSach", maSach);
                            checkCmd.Parameters.AddWithValue("@MaVP", maViPham);

                            int exists = (int)checkCmd.ExecuteScalar();
                            if (exists > 0)
                            {
                                // BỎ QUA DÒNG TRÙNG
                                continue;
                            }
                        }

                        // ====== Tính tiền phạt ======
                        decimal tienPhat = 0;
                        if (r.Table.Columns.Contains("Tien_Phat") && r["Tien_Phat"] != DBNull.Value)
                            decimal.TryParse(r["Tien_Phat"].ToString(), out tienPhat);

                        // ====== Insert chi tiết ======
                        using (SqlCommand cmdCT = new SqlCommand(insertCT, conn, tran))
                        {
                            cmdCT.Parameters.AddWithValue("@MaPP", maPP);
                            cmdCT.Parameters.AddWithValue("@MaSach", maSach);
                            cmdCT.Parameters.AddWithValue("@MaVP", maViPham);
                            cmdCT.Parameters.AddWithValue("@LyDo", (object)lyDo ?? DBNull.Value);
                            cmdCT.Parameters.AddWithValue("@TienPhat", tienPhat);
                            cmdCT.Parameters.AddWithValue("@TrangThai", trangThaiChiTiet);

                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    // ===================================================
                    // 4. HOÀN TẤT
                    // ===================================================
                    tran.Commit();
                    MessageBox.Show("Lưu Phiếu Phạt thành công!");

                    isAdding = false;
                    isEditing = false;
                    btnLuu.Enabled = false;
                    SetControlState("Normal");
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

        private void dgvChiTietViPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        // 1) Hàm lấy tên sách an toàn
        private string LayTenSach(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach)) return string.Empty;
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    // SỬA LỖI SQL: Phải JOIN với DAU_SACH
                    string query = @"
                SELECT ds.Ten_Dau_Sach 
                FROM SACH s
                JOIN DAU_SACH ds ON s.Ma_Dau_Sach = ds.Ma_Dau_Sach
                WHERE s.Ma_Sach = @ma";

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
                MessageBox.Show("Lỗi khi lấy Tên Sách: " + ex.Message);
            }
            return "Không tìm thấy";
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

            // HỘP THOẠI XÁC NHẬN XÓA
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return; // Người dùng chọn KHÔNG → dừng lại


            // Xóa dòng
            foreach (DataGridViewRow row in dgvChiTietViPham.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvChiTietViPham.Rows.Remove(row);
                }
            }

            // Sau khi xóa
            // dtChiTiet.AcceptChanges();  // nếu bạn quản lý bằng DataTable thì bật dòng này

            TinhTongTienPhat();
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
            if (string.IsNullOrEmpty(txtMaPhieuPhat.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu phạt từ danh sách bên trái để xuất.", "Chưa chọn phiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy Mã Phiếu Phạt từ TextBox
            string maPP = txtMaPhieuPhat.Text;

            // 3. Mở form báo cáo MỚI (frmInPhieuPhat)
            //    VÀ TRUYỀN maPP vào hàm khởi tạo (constructor)
            try
            {
                // (Nếu form báo cáo của bạn tên là XuatPhieuPhat, hãy đổi tên ở đây)
                XuatPhieuPhat reportForm = new XuatPhieuPhat(maPP);
                reportForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetControlState(string state)
        {
            bool isEditingOrAdding = (state == "Editing");

            // === 1. Bật/tắt các nút chính (Thêm, Sửa, Xóa, Lưu, Hủy) ===
            btnThem.Enabled = !isEditingOrAdding;
            btnSua.Enabled = !isEditingOrAdding;
            btnXoa.Enabled = !isEditingOrAdding;
            btnLuu.Enabled = isEditingOrAdding;
            btnHuy.Enabled = isEditingOrAdding;

            // === 2. Bật/tắt các ô nhập liệu thông tin chung ===
            // (Chúng ta khóa các ô này khi ở chế độ "Normal")
            txtMaPhieuMuon.ReadOnly = !isEditingOrAdding;
            dtpNgayLapPhieu.Enabled = isEditingOrAdding;
            cboThuThu.Enabled = isEditingOrAdding;
            cboTrangthainopphat.Enabled = isEditingOrAdding;

            // Các ô Mã PP, Mã ĐG, Tên ĐG luôn luôn khóa (chỉ để hiển thị)
            txtMaPhieuPhat.ReadOnly = true;
            txtMaDocGia.ReadOnly = true;
            txtTenDocGia.ReadOnly = true;
            txtTongTienPhat.ReadOnly = true;

            // === 3. Bật/tắt khu vực "Chi tiết vi phạm" ===
            dgvChiTietViPham.ReadOnly = !isEditingOrAdding; // Khóa/Mở lưới
            dgvPhieuViPham.ReadOnly = !isEditingOrAdding;
            btnLuu.Enabled = isEditingOrAdding;   // Nút "Thêm sách"
            btnXoadong.Enabled = isEditingOrAdding;      // Nút "Xóa sách"
        }
        private void dgvPhieuViPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuViPham.CurrentRow != null && dgvPhieuViPham.CurrentRow.Index >= 0)
            {
                object maPPValue = dgvPhieuViPham.CurrentRow.Cells["Ma_Phieu_Phat"].Value;
                if (maPPValue == null) return;
                string maPP = maPPValue.ToString();

                NapThongTinPhieuPhat(maPP);
                LoadChiTietViPham(maPP);

                // SỬA LẠI:
                SetControlState("Normal"); // Đặt trạng thái "Chỉ xem"
            }
        }

        private void txtMaPhieuMuon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isLoadingData || !isAdding)
                {
                    return;
                }
                e.SuppressKeyPress = true; // Ngăn tiếng beep mặc định
                string maPM = txtMaPhieuMuon.Text.Trim();
                if (string.IsNullOrEmpty(maPM))
                {
                    return; // Không làm gì nếu empty
                }
                // Clear thông tin cũ chỉ khi có maPM
                txtMaDocGia.Text = "";
                txtTenDocGia.Text = "";
                dtChiTiet?.Clear();
                dgvChiTietViPham.Refresh(); // Optional, nếu bind đúng thì không cần

                if (LayThongTinDocGiaTuPM(maPM, out string maDocGia, out string tenDocGia, out string maThuThu, out DateTime? ngayThucTra))
                {
                    // Không check quá hạn nữa, vì có thể phạt do sách hỏng hoặc lý do khác
                    // Load thông tin độc giả và trạng thái
                    txtMaDocGia.Text = maDocGia ?? "";
                    txtTenDocGia.Text = tenDocGia ?? "";
                    if (!string.IsNullOrEmpty(maThuThu))
                    {
                        cboThuThu.SelectedValue = maThuThu; // Giả định cboThuThu bind Ma_Thu_Thu
                    }
                    if (ngayThucTra.HasValue)
                    {
                        dtpNgayLapPhieu.Value = ngayThucTra.Value; // Ngày lập phiếu = ngày thực trả
                    }
                    // Set trạng thái phiếu phạt mặc định "Chưa nộp"
                    cboTrangthainopphat.SelectedItem = "Chưa nộp";
                    // Load chi tiết sách mượn vào vi phạm (user sẽ nhập Ly_Do như "Sách hỏng" thủ công)
                    LoadChiTietPhieuMuonVaoViPham(maPM); 
                }
                else
                {
                    MessageBox.Show("Mã Phiếu Mượn không tồn tại hoặc Phiếu chưa được trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPhieuMuon.SelectAll();
                    txtMaPhieuMuon.Focus();
                    return;
                }
                SendKeys.Send("{TAB}"); // Nhảy focus tiếp (cẩn thận, có thể dùng SelectNextControl(this.ActiveControl, true, true, true, true); thay thế)
            }
        }
        private void LoadChiTietPhieuMuonVaoViPham(string maPM)
        {
            try
            {
                using (var c = new SqlConnection(connectionString))
                {
                    c.Open();
                    // Lấy Ma_Sach và Ten_Sach (qua 3 bảng)
                    string query = @"
                SELECT 
                    ctpm.Ma_Sach, 
                    ds.Ten_Dau_Sach AS Ten_Sach
                FROM CT_PHIEU_MUON ctpm
                JOIN SACH s ON ctpm.Ma_Sach = s.Ma_Sach
                JOIN DAU_SACH ds ON s.Ma_Dau_Sach = ds.Ma_Dau_Sach
                WHERE ctpm.Ma_Phieu_Muon = @MaPM";

                    using (var cmd = new SqlCommand(query, c))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPM);
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Xóa các chi tiết cũ
                        dtChiTiet.Rows.Clear();

                        while (reader.Read())
                        {
                            // Thêm sách vào DataTable (dtChiTiet)
                            DataRow newRow = dtChiTiet.NewRow();
                            newRow["Ma_Sach"] = reader["Ma_Sach"].ToString();
                            newRow["Ten_Sach"] = reader["Ten_Sach"].ToString();
                            newRow["Ly_Do"] = ""; // Để trống cho người dùng nhập
                            newRow["Tien_Phat"] = 0; // Để trống
                            newRow["Ma_Vi_Pham"] = ""; // Để trống
                            dtChiTiet.Rows.Add(newRow);
                        }
                    }
                }
                // Cập nhật lại tổng tiền (sẽ là 0)
                TinhTongTienPhat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết phiếu mượn: " + ex.Message);
            }
        }
        private void LoadDanhSachViPhamChoComboBox()
        {
            try
            {
                dtViPham = new DataTable(); // Gán vào biến class
                using (conn = new SqlConnection(connectionString))
                {
                    // SỬA: Lấy tất cả các cột
                    string query = "SELECT Ma_Vi_Pham, Ten_Vi_Pham AS Ly_Do FROM VI_PHAM";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(dtViPham);
                }

                // Lấy cột ComboBox "Lý do phạt" (tên đã đặt ở Bước 1)
                DataGridViewComboBoxColumn cboCol = dgvChiTietViPham.Columns[COL_LY_DO] as DataGridViewComboBoxColumn;

                if (cboCol != null)
                {
                    cboCol.DataSource = dtViPham;
                    cboCol.DisplayMember = "Ly_Do"; // Hiển thị Tên/Lý do
                    cboCol.ValueMember = "Ma_Vi_Pham";    // ✔ Giá trị thật của item là mã vi phạm
                    cboCol.DataPropertyName = "Ma_Vi_Pham";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách vi phạm: " + ex.Message);
            }
        }

        private void dgvChiTietViPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoadingData || e.RowIndex < 0) return;

            // --- Logic 1: Tự động điền Tên Sách ---
            if (e.ColumnIndex == dgvChiTietViPham.Columns[COL_MA_SACH].Index)
            {
                var cellValue = dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_MA_SACH].Value;
                string maSach = cellValue?.ToString()?.Trim();

                if (string.IsNullOrEmpty(maSach))
                {
                    dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_TEN_SACH].Value = DBNull.Value;
                    return;
                }
                string tenSach = LayTenSach(maSach); // (Phải sửa hàm LayTenSach)
                dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_TEN_SACH].Value = tenSach;
            }

            // --- Logic 2 (MỚI): Tự động điền Mã Vi Ph phạm và Tiền Phạt ---
            // (Sự kiện này được kích hoạt bởi 'CommitEdit' ở trên)
            if (e.ColumnIndex == dgvChiTietViPham.Columns[COL_LY_DO].Index)
            {
                var cellValue = dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_LY_DO].Value;
                string lyDo = cellValue?.ToString();

                if (string.IsNullOrEmpty(lyDo) || dtViPham == null)
                {
                    dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_MA_VI_PHAM].Value = DBNull.Value;
                    dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_TIEN_PHAT].Value = 0;
                    TinhTongTienPhat(); // Cập nhật tổng tiền
                    return;
                }

                try
                {
                    // Tìm trong dtViPham (bảng đã tải) dựa trên Ly_Do
                    DataRow[] foundRows = dtViPham.Select($"Ly_Do = '{lyDo.Replace("'", "''")}'");

                    if (foundRows.Length > 0)
                    {
                        // Tự động điền
                        dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_MA_VI_PHAM].Value = foundRows[0]["Ma_Vi_Pham"].ToString();
                        dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_TIEN_PHAT].Value = Convert.ToDecimal(foundRows[0]["Tien_Phat_Max"]);
                        TinhTongTienPhat(); // Cập nhật tổng tiền
                    }
                }
                catch (Exception ex)
                {
                    dgvChiTietViPham.Rows[e.RowIndex].Cells[COL_MA_VI_PHAM].Value = DBNull.Value;
                    Console.WriteLine("Lỗi tra cứu mã vi phạm: " + ex.Message);
                }
            }
        }

        private void dgvChiTietViPham_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                // Suppress error dialog
                e.ThrowException = false;
                // Optional: Set value mặc định hoặc log
                MessageBox.Show("Giá trị ComboBox không hợp lệ ở row " + e.RowIndex + ", column " + e.ColumnIndex + ". Vui lòng chọn giá trị đúng.");
            }
        }
        
        
    }

}