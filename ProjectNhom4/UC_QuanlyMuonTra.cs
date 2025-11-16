using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectNhom4
{
    public partial class UC_QuanlyMuonTra : UserControl
    {
        // DataTable toàn cục cho dgvCTSach
        DataTable dtCTSach = new DataTable();


        // 🔹 Biến đánh dấu đang thêm mới
        private bool addnewFlag = false;

        // 🔹 Chuỗi kết nối tới SQL Server
        string connectionString = "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True";

        // 🔹 Hàm thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        private void ExecuteSQL(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm lấy dữ liệu (SELECT)
        private DataTable GetData(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public UC_QuanlyMuonTra()
        {
            InitializeComponent();

        }

        private void UC_QuanlyMuonTra_Load(object sender, EventArgs e)
        {
            InitializeCTSachGrid();

            try
            {

                // 🔹 Câu truy vấn SQL
                string sql = @"SELECT 
                                  Ma_Phieu_Muon, 
                                  Ma_The, 
                                  Ma_Thu_thu, 
                                  Ngay_Muon, 
                                  Han_Tra, 
                                  Ngay_Thuc_Tra, 
                                  Trang_Thai_Muon
                               FROM PHIEU_MUON";
                // 🔹 Lấy dữ liệu
                DataTable dt = GetData(sql);

                // 🔹 Hiển thị lên DataGridView
                dgvDauSach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);

            }
            dgvDauSach.SelectionChanged += dgvPhieuMuon_SelectionChanged;
            LoadPhieuMuonData();

            LoadComboTenDauSach();
            // --- Nạp giá trị cho comTruong ---
            comTruong.Items.Clear();
            comTruong.Items.Add("Ma_Phieu_Muon");
            comTruong.Items.Add("Trang_Thai_Muon");
            comTruong.SelectedIndex = 0; // Mặc định chọn "Ma_Phieu_Muon"

        }
        private void dgvPhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.Rows.Count > 0)
            {
                dgvDauSach.ClearSelection();
                dgvDauSach.CurrentCell = dgvDauSach[0, 0];
                NapCT();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow != null)
            {
                int i = dgvDauSach.CurrentRow.Index;
                if (i > 0)
                {
                    dgvDauSach.ClearSelection();
                    dgvDauSach.CurrentCell = dgvDauSach[0, i - 1];
                    NapCT();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow != null)
            {
                int i = dgvDauSach.CurrentRow.Index;
                if (i < dgvDauSach.Rows.Count - 1)
                {
                    dgvDauSach.ClearSelection();
                    dgvDauSach.CurrentCell = dgvDauSach[0, i + 1];
                    NapCT();
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.Rows.Count > 0)
            {
                int lastRow = dgvDauSach.Rows.Count - 1;
                dgvDauSach.ClearSelection();
                dgvDauSach.CurrentCell = dgvDauSach[0, lastRow];
                NapCT();
            }
        }
        private void NapCT()
        {
            if (dgvDauSach.CurrentRow != null)
            {
                DataGridViewRow row = dgvDauSach.CurrentRow;
                string maPhieuMuon = row.Cells["Ma_Phieu_Muon"].Value?.ToString();
                string maThe = row.Cells["Ma_The"].Value?.ToString();

                // Gán dữ liệu cơ bản
                txtMaPhieuMuon.Text = maPhieuMuon;
                txtMaThe.Text = maThe;
                txtMaThuThu.Text = row.Cells["Ma_Thu_thu"].Value?.ToString();
                txtTrangThaiMuon.Text = row.Cells["Trang_Thai_Muon"].Value?.ToString();

                DateTime ngayMuon, hanTra;
                if (DateTime.TryParse(row.Cells["Ngay_Muon"].Value?.ToString(), out ngayMuon))
                    dtpNgayMuon.Value = ngayMuon;
                if (DateTime.TryParse(row.Cells["Han_Tra"].Value?.ToString(), out hanTra))
                    dtpHanTra.Value = hanTra;

                // Xử lý Ngay_Thuc_Tra
                object ngayThucTraObj = row.Cells["Ngay_Thuc_Tra"].Value;
                if (ngayThucTraObj == null || ngayThucTraObj == DBNull.Value || string.IsNullOrEmpty(ngayThucTraObj.ToString()))
                {
                    // Xóa dữ liệu trong DateTimePicker
                    dtpNgayThucTra.Format = DateTimePickerFormat.Custom;
                    dtpNgayThucTra.CustomFormat = " "; // hiển thị rỗng
                }
                else
                {
                    // Có dữ liệu, hiển thị bình thường
                    if (DateTime.TryParse(ngayThucTraObj.ToString(), out DateTime dtTra))
                    {
                        dtpNgayThucTra.Format = DateTimePickerFormat.Short;
                        dtpNgayThucTra.Value = dtTra;
                    }
                }

                // --- Chỉ chạy truy vấn khi có mã thẻ ---
                if (!string.IsNullOrEmpty(maThe))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // 🔹 Lấy Ma_Doc_Gia + Ho_Ten từ THE_DOC_GIA + DOC_GIA
                        string sqlDocGia = @"SELECT tdg.Ma_Doc_Gia, dg.Ho_Ten 
                                     FROM THE_DOC_GIA tdg
                                     INNER JOIN DOC_GIA dg ON tdg.Ma_Doc_Gia = dg.Ma_Doc_Gia
                                     WHERE tdg.Ma_The = @MaThe";

                        using (SqlCommand cmdDG = new SqlCommand(sqlDocGia, conn))
                        {
                            cmdDG.Parameters.AddWithValue("@MaThe", maThe);
                            using (SqlDataReader reader = cmdDG.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtMaDocGia.Text = reader["Ma_Doc_Gia"].ToString();
                                    txtTenDocGia.Text = reader["Ho_Ten"].ToString();
                                }
                            }
                        }

                        // 🔹 Lấy Kiểu mượn + Tiền cọc
                        string sqlPM = @"SELECT km.Ten_Kieu_Muon, pm.Tien_Coc 
                                 FROM PHIEU_MUON pm
                                 INNER JOIN KIEU_MUON km ON pm.Ma_Kieu_Muon = km.Ma_Kieu_Muon
                                 WHERE pm.Ma_Phieu_Muon = @MaPM";


                        using (SqlCommand cmdPM = new SqlCommand(sqlPM, conn))
                        {
                            cmdPM.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                            using (SqlDataReader reader = cmdPM.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtMaKieuMuon.Text = reader["Ten_Kieu_Muon"].ToString();
                                    txtTienCoc.Text = reader["Tien_Coc"].ToString();
                                }
                            }
                        }
                        // --- Nạp thông tin đầu sách vào dgvDauSach ---
                        using (SqlConnection connDS = new SqlConnection(connectionString))
                        {
                            connDS.Open();
                            string sqlDauSach = @"
        SELECT ds.Ma_Dau_Sach, ds.Ten_Dau_Sach, ds.Nam_XB, ds.Gia_Bia, s.Trang_Thai_Sach_Muon
    FROM PHIEU_MUON pm
    INNER JOIN CT_PHIEU_MUON ctp ON pm.Ma_Phieu_Muon = ctp.Ma_Phieu_Muon
    INNER JOIN SACH s ON ctp.Ma_Sach = s.Ma_Sach
    INNER JOIN DAU_SACH ds ON s.Ma_Dau_Sach = ds.Ma_Dau_Sach
    WHERE pm.Ma_Phieu_Muon = @MaPM
    ";

                            using (SqlCommand cmdDS = new SqlCommand(sqlDauSach, conn))
                            {
                                cmdDS.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                                SqlDataAdapter da = new SqlDataAdapter(cmdDS);
                                DataTable dtDS = new DataTable();
                                da.Fill(dtDS);

                                dgvCTSach.DataSource = dtDS; // dgvDauSach nằm trong grbDauSach
                            }
                        }

                    }
                }
            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chưa chọn trường thì thoát, tránh lỗi cú pháp SQL
            if (comTruong.SelectedIndex == -1 || string.IsNullOrEmpty(comTruong.Text))
                return;

            try
            {
                string selectedField = comTruong.Text;
                string sql = $"SELECT DISTINCT {selectedField} FROM PHIEU_MUON";

                DataTable comtb = GetData(sql);
                comGT.DataSource = comtb;
                comGT.DisplayMember = selectedField;
                comGT.ValueMember = selectedField;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp dữ liệu cho combobox: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa TextBox và DateTimePicker
                txtMaPhieuMuon.Text = "";
                txtMaThe.Text = "";
                txtMaThuThu.Text = "";
                txtTrangThaiMuon.Text = "";
                txtMaDocGia.Text = "";
                txtTenDocGia.Text = "";
                txtMaKieuMuon.Text = "";
                txtTienCoc.Text = "";

                dtpNgayMuon.Value = DateTime.Now;
                dtpHanTra.Value = DateTime.Now;

                dtpNgayMuon.Value = DateTime.Now;
                dtpHanTra.Value = DateTime.Now;

                // Hiển thị rỗng cho Ngay_Thuc_Tra
                dtpNgayThucTra.Format = DateTimePickerFormat.Custom;
                dtpNgayThucTra.CustomFormat = " ";


                // 🔹 Xóa dữ liệu trong dgvCTSach dựa trên DataSource
                if (dgvCTSach.DataSource != null)
                {
                    DataTable dtCT = dgvCTSach.DataSource as DataTable;
                    if (dtCT != null)
                    {
                        dtCT.Clear();  // chỉ xóa dữ liệu, giữ lại cột
                    }
                }
                // --- Hiển thị ComboBox thay TextBox ---
                cmbMaThuThu.Visible = true;
                txtMaThuThu.Visible = false;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 🔹 Nạp dữ liệu THU_THU
                    string sqlThuThu = "SELECT Ma_Thu_Thu, Ten_Thu_Thu FROM THU_THU ORDER BY Ten_Thu_Thu";
                    SqlDataAdapter daThuThu = new SqlDataAdapter(sqlThuThu, conn);
                    DataTable dtThuThu = new DataTable();
                    daThuThu.Fill(dtThuThu);

                    cmbMaThuThu.DataSource = dtThuThu;
                    cmbMaThuThu.DisplayMember = "Ten_Thu_Thu";
                    cmbMaThuThu.ValueMember = "Ma_Thu_Thu";
                    cmbMaThuThu.DropDownStyle = ComboBoxStyle.DropDownList;

                    // 🔹 Nạp dữ liệu KIEU_MUON
                    string sqlKieuMuon = "SELECT Ma_Kieu_Muon, Ten_Kieu_Muon FROM KIEU_MUON ORDER BY Ten_Kieu_Muon";
                    SqlDataAdapter daKieuMuon = new SqlDataAdapter(sqlKieuMuon, conn);
                    DataTable dtKieuMuon = new DataTable();
                    daKieuMuon.Fill(dtKieuMuon);

                    cmbMaKieuMuon.Visible = true;
                    txtMaKieuMuon.Visible = false;

                    cmbMaKieuMuon.DataSource = dtKieuMuon;
                    cmbMaKieuMuon.DisplayMember = "Ten_Kieu_Muon";
                    cmbMaKieuMuon.ValueMember = "Ma_Kieu_Muon";
                    cmbMaKieuMuon.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                // Focus vào txt đầu tiên
                txtMaPhieuMuon.Focus();

                addnewFlag = true;

                MessageBox.Show("Đã sẵn sàng tạo phiếu mượn mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadComboTenSach()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT Ten_Dau_Sach FROM DAU_SACH ORDER BY Ten_Dau_Sach";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboTenSach.Items.Clear();
                    while (reader.Read())
                    {
                        comboTenSach.Items.Add(reader["Ten_Dau_Sach"].ToString());
                    }
                }

                comboTenSach.DropDownStyle = ComboBoxStyle.DropDownList; // chỉ cho chọn từ danh sách
                comboTenSach.AutoCompleteMode = AutoCompleteMode.None;   // tắt gợi ý
                comboTenSach.AutoCompleteSource = AutoCompleteSource.None; // tắt nguồn gợi ý

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách sách: " + ex.Message);
            }
        }

        private void InitializeCTSachGrid()
        {
            dtCTSach.Columns.Clear();
            dtCTSach.Columns.Add("Ma_Dau_Sach");
            dtCTSach.Columns.Add("Ten_Dau_Sach");
            dtCTSach.Columns.Add("Nam_XB");
            dtCTSach.Columns.Add("Gia_Bia");
            dtCTSach.Columns.Add("Trang_Thai_Sach_Muon");

            dgvCTSach.DataSource = dtCTSach;

            dgvCTSach.AllowUserToAddRows = false; // tắt dòng trống cuối
        }

        private void LoadComboTenDauSach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Ten_Dau_Sach FROM DAU_SACH ORDER BY Ten_Dau_Sach";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboTenSach.DataSource = dt;
                comboTenSach.DisplayMember = "Ten_Dau_Sach";
                comboTenSach.ValueMember = "Ten_Dau_Sach"; // giá trị cũng là tên sách
                comboTenSach.DropDownStyle = ComboBoxStyle.DropDownList; // chỉ chọn từ danh sách
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboTenSach.Text))
            {
                MessageBox.Show("Vui lòng chọn tên sách!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlCheck = @"
    SELECT TOP 1 ds.So_Luong 
    FROM DAU_SACH ds
    WHERE ds.Ten_Dau_Sach = @TenSach
";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@TenSach", comboTenSach.Text);

                    object result = cmdCheck.ExecuteScalar();

                    int soLuong = 0;
                    if (result == null || !int.TryParse(result.ToString(), out soLuong))
                    {
                        MessageBox.Show("Không tìm thấy đầu sách hoặc dữ liệu số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (soLuong <= 0)
                    {
                        MessageBox.Show("Sách không còn để mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    // 🔹 Truy vấn trực tiếp ra các cột, nhưng bỏ giá trị cột trạng thái
                    string sql = @"
                SELECT ds.Ma_Dau_Sach, ds.Ten_Dau_Sach, ds.Nam_XB, ds.Gia_Bia, '' AS Trang_Thai_Sach_Muon
                FROM DAU_SACH ds
                INNER JOIN SACH s ON ds.Ma_Dau_Sach = s.Ma_Dau_Sach
                WHERE ds.Ten_Dau_Sach = @TenSach
            ";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@TenSach", comboTenSach.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 🔹 Nếu dgvCTSach chưa có dữ liệu, gán trực tiếp DataTable
                    if (dgvCTSach.DataSource == null)
                    {
                        dgvCTSach.DataSource = dt;
                    }
                    else
                    {
                        // 🔹 Merge mà không bị duplicate, dựa vào Ma_Dau_Sach
                        DataTable dtCurrent = dgvCTSach.DataSource as DataTable;
                        // Sau khi thêm vào dgvCTSach thành công:
                        string sqlUpdate = "UPDATE DAU_SACH SET So_Luong = So_Luong - 1 WHERE Ten_Dau_Sach = @TenSach";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@TenSach", comboTenSach.Text);
                        cmdUpdate.ExecuteNonQuery();

                        foreach (DataRow row in dt.Rows)
                        {
                            // kiểm tra xem Ma_Dau_Sach đã có chưa
                            bool exists = dtCurrent.AsEnumerable().Any(r => r.Field<string>("Ma_Dau_Sach") == row.Field<string>("Ma_Dau_Sach"));
                            if (!exists)
                                dtCurrent.ImportRow(row);
                        }
                    }
                }

                comboTenSach.Text = ""; // Xóa combo sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message);
            }
        }

        private void txtMaPhieuMuon_Leave(object sender, EventArgs e)
        {

        }

        private void txtMaThe_Leave(object sender, EventArgs e)
        {

            string maThe = txtMaThe.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                txtMaPhieuMuon.Text = "";
                return;
            }

            // Kiểm tra nếu Mã Thẻ đang có phiếu chưa trả
            if (KiemTraMaTheDangMuonChuaTra(maThe))
            {
                MessageBox.Show("Thẻ này đang có phiếu mượn chưa trả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhieuMuon.Text = "";
                return;
            }

            // Sinh Mã Phiếu Mượn mới
            txtMaPhieuMuon.Text = SinhMaPhieuMuonMoi();
            txtMaPhieuMuon.ReadOnly = true; // khóa không cho chỉnh

            // Lấy Ma_Doc_Gia từ Ma_The
            txtMaDocGia.Text = LayMaDocGia(maThe);

            // Lấy Ho_Ten từ Ma_Doc_Gia
            if (!string.IsNullOrEmpty(txtMaDocGia.Text))
                txtTenDocGia.Text = LayTenDocGia(txtMaDocGia.Text);
        }
        private bool KiemTraMaTheDangMuonChuaTra(string maThe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM PHIEU_MUON WHERE Ma_The = @MaThe AND Trang_Thai_Muon = N'Chưa Trả'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaThe", maThe);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private string SinhMaPhieuMuonMoi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Ma_Phieu_Muon FROM PHIEU_MUON";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int maxSo = 0;
                while (reader.Read())
                {
                    string ma = reader["Ma_Phieu_Muon"].ToString(); // ví dụ PM005
                    string so = new string(ma.Where(c => char.IsDigit(c)).ToArray());
                    if (int.TryParse(so, out int num))
                    {
                        if (num > maxSo) maxSo = num;
                    }
                }
                reader.Close();

                return "PM" + (maxSo + 1).ToString("D3"); // PM006
            }
        }
        private string LayMaDocGia(string maThe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Ma_Doc_Gia FROM THE_DOC_GIA WHERE Ma_The = @MaThe";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaThe", maThe);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }
        private string LayTenDocGia(string maDocGia)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Ho_Ten FROM DOC_GIA WHERE Ma_Doc_Gia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maPM = txtMaPhieuMuon.Text.Trim();
                string maThe = txtMaThe.Text.Trim();
                string maKieuMuon = cmbMaKieuMuon.SelectedValue?.ToString();
                string maThuThu = cmbMaThuThu.SelectedValue?.ToString();
                DateTime ngayMuon = dtpNgayMuon.Value;
                DateTime hanTra = dtpHanTra.Value;
                DateTime? ngayThucTra = (dtpNgayThucTra.CustomFormat == " ") ? (DateTime?)null : dtpNgayThucTra.Value;

                decimal tienCoc = 0;
                decimal.TryParse(txtTienCoc.Text, out tienCoc);

                if (string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(maKieuMuon) || string.IsNullOrEmpty(maThuThu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        // 🔹 Kiểm tra THE_DOC_GIA
                        string sqlCheckDG = "SELECT COUNT(*) FROM THE_DOC_GIA WHERE Ma_The = @MaThe";
                        using (SqlCommand cmdCheckDG = new SqlCommand(sqlCheckDG, conn, trans))
                        {
                            cmdCheckDG.Parameters.AddWithValue("@MaThe", maThe);
                            int count = (int)cmdCheckDG.ExecuteScalar();

                            if (count == 0)
                            {
                                string sqlInsertDG = "INSERT INTO THE_DOC_GIA (Ma_The, Ho_Ten) VALUES (@MaThe, @HoTen)";
                                using (SqlCommand cmdInsertDG = new SqlCommand(sqlInsertDG, conn, trans))
                                {
                                    cmdInsertDG.Parameters.AddWithValue("@MaThe", maThe);
                                    cmdInsertDG.Parameters.AddWithValue("@HoTen", txtTenDocGia.Text.Trim());
                                    cmdInsertDG.ExecuteNonQuery();
                                }
                            }
                        }

                        if (addnewFlag) // 🔹 Thêm mới phiếu mượn
                        {
                            string sqlPM = @"
                    INSERT INTO PHIEU_MUON (Ma_Phieu_Muon, Ma_The, Ma_Kieu_Muon, Ma_Thu_Thu, Ngay_Muon, Han_Tra, Ngay_Thuc_Tra, Tien_Coc, Trang_Thai_Muon)
                    VALUES (@MaPM, @MaThe, @MaKieuMuon, @MaThuThu, @NgayMuon, @HanTra, @NgayThucTra, @TienCoc, N'Đang Mượn')";

                            using (SqlCommand cmdPM = new SqlCommand(sqlPM, conn, trans))
                            {
                                cmdPM.Parameters.AddWithValue("@MaPM", maPM);
                                cmdPM.Parameters.AddWithValue("@MaThe", maThe);
                                cmdPM.Parameters.AddWithValue("@MaKieuMuon", maKieuMuon);
                                cmdPM.Parameters.AddWithValue("@MaThuThu", maThuThu);
                                cmdPM.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                                cmdPM.Parameters.AddWithValue("@HanTra", hanTra);
                                cmdPM.Parameters.AddWithValue("@TienCoc", tienCoc);
                                if (ngayThucTra.HasValue)
                                    cmdPM.Parameters.AddWithValue("@NgayThucTra", ngayThucTra.Value);
                                else
                                    cmdPM.Parameters.AddWithValue("@NgayThucTra", DBNull.Value);
                                cmdPM.ExecuteNonQuery();
                            }
                        }
                        else // 🔹 Cập nhật phiếu mượn đã tồn tại
                        {
                            string sqlUpdatePM = @"
                        UPDATE PHIEU_MUON
                        SET Ma_Kieu_Muon = @MaKieuMuon,
                            Ma_Thu_Thu = @MaThuThu,
                            Ngay_Muon = @NgayMuon,
                            Han_Tra = @HanTra,
                            Ngay_Thuc_Tra = @NgayThucTra,
                            Tien_Coc = @TienCoc,
                            Trang_Thai_Muon = @TrangThai
                        WHERE Ma_Phieu_Muon = @MaPM";

                            using (SqlCommand cmd = new SqlCommand(sqlUpdatePM, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@MaKieuMuon", maKieuMuon);
                                cmd.Parameters.AddWithValue("@MaThuThu", maThuThu);
                                cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                                cmd.Parameters.AddWithValue("@HanTra", hanTra);
                                if (ngayThucTra.HasValue)
                                    cmd.Parameters.AddWithValue("@NgayThucTra", ngayThucTra.Value);
                                else
                                    cmd.Parameters.AddWithValue("@NgayThucTra", DBNull.Value);
                                cmd.Parameters.AddWithValue("@TienCoc", tienCoc);
                                cmd.Parameters.AddWithValue("@TrangThai", txtTrangThaiMuon.Text.Trim());
                                cmd.Parameters.AddWithValue("@MaPM", maPM);
                                cmd.ExecuteNonQuery();
                            }

                            // Xóa chi tiết cũ
                            string sqlDelCT = "DELETE FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                            using (SqlCommand cmdDel = new SqlCommand(sqlDelCT, conn, trans))
                            {
                                cmdDel.Parameters.AddWithValue("@MaPM", maPM);
                                cmdDel.ExecuteNonQuery();
                            }
                        }

                        // 🔹 Duyệt qua từng dòng trong dgvCTSach để thêm CT_PHIEU_MUON & cập nhật SACH, DAU_SACH
                        foreach (DataGridViewRow row in dgvCTSach.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string maDauSach = row.Cells["Ma_Dau_Sach"].Value?.ToString();
                            if (string.IsNullOrEmpty(maDauSach)) continue;

                            string sqlSach_1 = @"SELECT TOP 1 Ma_Sach FROM SACH WHERE Ma_Dau_Sach = @MaDauSach";
                            string maSach = "";
                            using (SqlCommand cmdS = new SqlCommand(sqlSach_1, conn, trans))
                            {
                                cmdS.Parameters.AddWithValue("@MaDauSach", maDauSach);
                                object kq = cmdS.ExecuteScalar();
                                if (kq != null) maSach = kq.ToString();
                            }

                            string sqlCT = @"INSERT INTO CT_PHIEU_MUON (Ma_Phieu_Muon, Ma_Sach) VALUES (@MaPM, @MaSach)";
                            using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans))
                            {
                                cmdCT.Parameters.AddWithValue("@MaPM", maPM);
                                cmdCT.Parameters.AddWithValue("@MaSach", maSach);
                                cmdCT.ExecuteNonQuery();
                            }

                            // Cập nhật trạng thái sách & trừ số lượng
                            string sqlUpdateSach = "UPDATE SACH SET Trang_Thai_Sach_Muon = N'Đang Mượn' WHERE Ma_Sach = @MaSach";
                            using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdateSach, conn, trans))
                            {
                                cmdUpdate.Parameters.AddWithValue("@MaSach", maSach);
                                cmdUpdate.ExecuteNonQuery();
                            }

                            string sqlUpdateSL = "UPDATE DAU_SACH SET So_Luong = So_Luong - 1 WHERE Ma_Dau_Sach = @MaDauSach";
                            using (SqlCommand cmdUpdateSL = new SqlCommand(sqlUpdateSL, conn, trans))
                            {
                                cmdUpdateSL.Parameters.AddWithValue("@MaDauSach", maDauSach);
                                cmdUpdateSL.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        MessageBox.Show(addnewFlag ? "Thêm phiếu mượn thành công!" : "Cập nhật phiếu mượn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addnewFlag = false;
                        UC_QuanlyMuonTra_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi lưu phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn
            if (dgvDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy Ma_Phieu_Muon của dòng đang chọn
            string maPM = dgvDauSach.CurrentRow.Cells["Ma_Phieu_Muon"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu mượn {maPM}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        // 1️⃣ Xóa các sách liên quan trong CT_PHIEU_MUON
                        string sqlCT = "DELETE FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                        using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaPM", maPM);
                            cmdCT.ExecuteNonQuery();
                        }

                        // 2️⃣ Xóa phiếu mượn trong PHIEU_MUON
                        string sqlPM = "DELETE FROM PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                        using (SqlCommand cmdPM = new SqlCommand(sqlPM, conn, trans))
                        {
                            cmdPM.Parameters.AddWithValue("@MaPM", maPM);
                            cmdPM.ExecuteNonQuery();
                        }

                        trans.Commit();

                        MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload lại DataGridView
                        UC_QuanlyMuonTra_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi xóa phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieuMuon = dgvDauSach.CurrentRow.Cells["Ma_Phieu_Muon"].Value?.ToString();
            if (string.IsNullOrEmpty(maPhieuMuon))
            {
                MessageBox.Show("Phiếu mượn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngayTra = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 🔹 Lấy Han_Tra từ PHIEU_MUON
                    DateTime hanTra;
                    string sqlGetHanTra = "SELECT Han_Tra FROM PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                    using (SqlCommand cmd = new SqlCommand(sqlGetHanTra, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                            throw new Exception("Không tìm thấy phiếu mượn.");
                        hanTra = Convert.ToDateTime(result);
                    }

                    // 🔹 Kiểm tra xem trả muộn hay đúng hạn
                    string trangThai = (ngayTra > hanTra) ? "Trả muộn" : "Đã Trả";

                    // 🔹 Cập nhật PHIEU_MUON
                    string sqlUpdatePM = @"
                UPDATE PHIEU_MUON 
                SET Ngay_Thuc_Tra = @NgayThucTra, Trang_Thai_Muon = @TrangThai
                WHERE Ma_Phieu_Muon = @MaPM";
                    using (SqlCommand cmd = new SqlCommand(sqlUpdatePM, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@NgayThucTra", ngayTra);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                        cmd.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                        cmd.ExecuteNonQuery();
                    }

                    // 🔹 Cập nhật trạng thái sách trong CT_PHIEU_MUON & DAU_SACH
                    string sqlSelectSach = @"SELECT Ma_Sach FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                    List<string> listMaSach = new List<string>();
                    using (SqlCommand cmd = new SqlCommand(sqlSelectSach, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                listMaSach.Add(reader["Ma_Sach"].ToString());
                        }
                    }

                    foreach (string maSach in listMaSach)
                    {
                        // Cập nhật trạng thái sách về "Có Sẵn"
                        string sqlUpdateSach = @"UPDATE SACH SET Trang_Thai_Sach_Muon = N'Có Sẵn' WHERE Ma_Sach = @MaSach";
                        using (SqlCommand cmd = new SqlCommand(sqlUpdateSach, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaSach", maSach);
                            cmd.ExecuteNonQuery();
                        }

                        // Tăng lại số lượng trong DAU_SACH
                        string sqlUpdateSL = @"UPDATE DAU_SACH 
                                SET So_Luong = So_Luong + 1 
                                WHERE Ma_Dau_Sach = (SELECT Ma_Dau_Sach FROM SACH WHERE Ma_Sach = @MaSach)";
                        using (SqlCommand cmd = new SqlCommand(sqlUpdateSL, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaSach", maSach);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    MessageBox.Show("Trả sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật dtpNgayThucTra trên form
                    dtpNgayThucTra.Value = ngayTra;

                    // Reload dữ liệu
                    UC_QuanlyMuonTra_Load(sender, e);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi khi trả sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvCTSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvCTSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDauSach = dgvCTSach.CurrentRow.Cells["Ma_Dau_Sach"].Value?.ToString();
            string maPhieuMuon = txtMaPhieuMuon.Text.Trim();

            if (string.IsNullOrEmpty(maDauSach) || string.IsNullOrEmpty(maPhieuMuon))
            {
                MessageBox.Show("Dữ liệu phiếu mượn hoặc đầu sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sách '{dgvCTSach.CurrentRow.Cells["Ten_Dau_Sach"].Value}' khỏi phiếu mượn?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr != DialogResult.OK) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        // Lấy Ma_Sach liên kết với Ma_Phieu_Muon và Ma_Dau_Sach
                        string sqlGetMaSach = @"
                    SELECT Ma_Sach 
                    FROM CT_PHIEU_MUON 
                    WHERE Ma_Phieu_Muon = @MaPM 
                    AND Ma_Sach IN (SELECT Ma_Sach FROM SACH WHERE Ma_Dau_Sach = @MaDS)
                ";

                        List<string> maSachList = new List<string>();
                        using (SqlCommand cmd = new SqlCommand(sqlGetMaSach, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                            cmd.Parameters.AddWithValue("@MaDS", maDauSach);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    maSachList.Add(reader["Ma_Sach"].ToString());
                                }
                            }
                        }

                        // Xóa từng Ma_Sach khỏi CT_PHIEU_MUON
                        foreach (string maSach in maSachList)
                        {
                            string sqlDelCT = "DELETE FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM AND Ma_Sach = @MaSach";
                            using (SqlCommand cmdDel = new SqlCommand(sqlDelCT, conn, trans))
                            {
                                cmdDel.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                                cmdDel.Parameters.AddWithValue("@MaSach", maSach);
                                cmdDel.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();

                        // ❌ Sửa lại phần này: xóa từ DataTable
                        DataTable dt = dgvCTSach.DataSource as DataTable;
                        if (dt != null)
                        {
                            DataRow[] rowsToDelete = dt.Select("Ma_Dau_Sach = '" + maDauSach + "'");
                            foreach (DataRow r in rowsToDelete)
                                dt.Rows.Remove(r);
                        }

                        MessageBox.Show("Xóa sách khỏi phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string field = comTruong.Text;
                    string value = comGT.Text;

                    string sql = $"SELECT Ma_Phieu_Muon, Ma_The, Ma_Thu_thu, Ngay_Muon, Han_Tra, Ngay_Thuc_Tra, Trang_Thai_Muon FROM PHIEU_MUON";

                    // Nếu người dùng có chọn điều kiện lọc
                    if (!string.IsNullOrEmpty(field) && !string.IsNullOrEmpty(value))
                    {
                        sql += $" WHERE {field} = @Value";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Value", value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDauSach.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPhieuMuonData()
        {
            try
            {
                string sql = @"SELECT 
                          Ma_Phieu_Muon, 
                          Ma_The, 
                          Ma_Thu_thu, 
                          Ngay_Muon, 
                          Han_Tra, 
                          Ngay_Thuc_Tra, 
                          Trang_Thai_Muon
                       FROM PHIEU_MUON";

                DataTable dt = GetData(sql);
                dgvDauSach.DataSource = dt;

                // Xóa chọn dòng cũ
                dgvDauSach.ClearSelection();

                // Reset combobox filter
                comTruong.SelectedIndex = -1;
                comGT.DataSource = null;
                comGT.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPhieuMuonData();
            MessageBox.Show("Dữ liệu đã được tải lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy Ma_Phieu_Muon từ cột DataPropertyName "Ma_Phieu_Muon"
            string maPhieuMuon = dgvDauSach.CurrentRow.Cells["Ma_Phieu_Muon"].Value?.ToString()?.Trim();

            if (string.IsNullOrEmpty(maPhieuMuon))
            {
                MessageBox.Show("Phiếu mượn này chưa có mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Debug: kiểm tra giá trị
            // MessageBox.Show($"Ma_Phieu_Muon: {maPhieuMuon}");

            // Lấy dữ liệu phiếu mượn từ database
            DataSet dsPhieuMuon = LayDuLieuPhieuMuon(maPhieuMuon);

            if (dsPhieuMuon == null || dsPhieuMuon.Tables.Count == 0 || dsPhieuMuon.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở form in báo cáo
            frmPhieuMuon frm = new frmPhieuMuon(dsPhieuMuon);
            frm.ShowDialog();
        }


        private DataSet LayDuLieuPhieuMuon(string maPhieuMuon)
        {
            string connectionString = @"Data Source=LANNHI\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True";

            string query = @"
     SELECT 
    PM.Ma_Phieu_Muon, PM.Ma_The, PM.Ma_Thu_Thu, PM.Ma_Kieu_Muon,
    PM.Ngay_Muon, PM.Han_Tra, PM.Ngay_Thuc_Tra,
    PM.Trang_Thai_Muon, PM.Tien_Coc,

    CT.Ma_Sach,
    S.Ma_Dau_Sach,
    S.Trang_Thai_Sach_Muon,

    DS.Ten_Dau_Sach,
    DS.Nam_XB,

    DG.Ma_Doc_Gia,
    DG.Ho_Ten,

    TT.Ten_Thu_Thu,
    KM.Ten_Kieu_Muon AS TenKieuMuon
FROM PHIEU_MUON PM
LEFT JOIN CT_PHIEU_MUON CT ON PM.Ma_Phieu_Muon = CT.Ma_Phieu_Muon
LEFT JOIN SACH S ON CT.Ma_Sach = S.Ma_Sach
LEFT JOIN DAU_SACH DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
LEFT JOIN THE_DOC_GIA TDG ON PM.Ma_The = TDG.Ma_The
LEFT JOIN DOC_GIA DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
LEFT JOIN THU_THU TT ON PM.Ma_Thu_Thu = TT.Ma_Thu_Thu
LEFT JOIN KIEU_MUON KM ON PM.Ma_Kieu_Muon = KM.Ma_Kieu_Muon
WHERE PM.Ma_Phieu_Muon = @MaPhieuMuon


    ";

            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dsPhieuMuon"); // Lấy bảng đầu tiên trong dataset
            }

            return ds;
        }



    }
}
