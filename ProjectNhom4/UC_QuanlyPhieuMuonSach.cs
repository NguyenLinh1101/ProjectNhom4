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
    public partial class UC_QuanlyPhieuMuonSach : UserControl
    {
        // Chuỗi kết nối SQL Server
        string strCon = @"Data Source=LANNHI\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        // Biến lưu mã phiếu mượn đang chọn
        private string selectedMaPM;

        public UC_QuanlyPhieuMuonSach()
        {
            InitializeComponent();
            this.Load += UC_QuanlyPhieuMuonSach_Load; // gắn event Load
            dgvPhieuMuon.CellClick += dgvPhieuMuon_CellClick;
            // Gắn event cho txtMaThe
            txtMaThe.Leave += txtMaThe_Leave;
            cmbMaKieuMuon.SelectedIndexChanged += cmbMaKieuMuon_SelectedIndexChanged;


        }

        private void UC_QuanlyPhieuMuonSach_Load(object sender, EventArgs e)
        {
            LoadPhieuMuon(); // Load dữ liệu khi UserControl được load
        }
        private void LoadPhieuMuon()
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"
                        SELECT 
                            Ma_Phieu_Muon, Ma_The, Ma_Thu_Thu, Ngay_Muon, 
                            Han_Tra, Ngay_Thuc_Tra, Trang_Thai_Muon
                        FROM 
                            PHIEU_MUON";

                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dv = new DataView(dt);

                    // Chỉ gán cho dgvPhieuMuon thôi
                    dgvPhieuMuon.AutoGenerateColumns = false; // nếu bạn tạo cột sẵn trong Designer
                    dgvPhieuMuon.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }
        // Khi click vào một dòng trong dgv   
        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        string maPM = dgvPhieuMuon.Rows[e.RowIndex].Cells["Ma_Phieu_Muon"].Value.ToString();
        NapChiTietPhieuMuon(maPM); // gọi hàm, lấy toàn bộ dữ liệu từ SQL
    }
}

        // 4Hàm nạp chi tiết sang GroupBox
        // ==============================
        private void NapChiTietPhieuMuon(string maPhieuMuon)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"SELECT * FROM PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtMaPhieuMuon.Text = reader["Ma_Phieu_Muon"].ToString();
                            txtMaThe.Text = reader["Ma_The"].ToString();
                            txtMaThuThu.Text = reader["Ma_Thu_Thu"].ToString();
                            txtTrangThai.Text = reader["Trang_Thai_Muon"].ToString();
                            txtMaKieuMuon.Text = reader["Ma_Kieu_Muon"].ToString();
                            txtTienCoc.Text = reader["Tien_Coc"].ToString();

                            if (reader["Ngay_Muon"] != DBNull.Value)
                                dtpNgayMuon.Value = Convert.ToDateTime(reader["Ngay_Muon"]);
                            if (reader["Han_Tra"] != DBNull.Value)
                                dtpHanTra.Value = Convert.ToDateTime(reader["Han_Tra"]);
                            if (reader["Ngay_Thuc_Tra"] != DBNull.Value)
                                dtpNgayThucTra.Value = Convert.ToDateTime(reader["Ngay_Thuc_Tra"]);
                            else
                                dtpNgayThucTra.Value = DateTime.Now;
                           
                            // Lấy Ma_Doc_Gia từ bảng THE_DOC_GIA dựa vào Ma_The
                            string maThe = reader["Ma_The"].ToString();
                            txtMaDocGia.Text = LayMaDocGia(maThe);
                        }
                    }
                }
                //  THÊM DÒNG NÀY Ở CUỐI HÀM 
                LoadChiTietSachDangMuon(maPhieuMuon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chi tiết: " + ex.Message);
            }
        }
        // Hàm lấy Ma_Doc_Gia từ Ma_The
        private string LayMaDocGia(string maThe)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"SELECT Ma_Doc_Gia FROM THE_DOC_GIA WHERE Ma_The = @MaThe";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaThe", maThe);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy Mã Độc Giả: " + ex.Message);
            }
            return "";
        }
        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvSachDangMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDSPhieuMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            
            string maPhieuMuon = txtMaPhieuMuon.Text.Trim();
            string maDocGia = txtMaDocGia.Text.Trim();

            frmMuonSach muonSachForm = new frmMuonSach(maPhieuMuon, maDocGia);
            muonSachForm.StartPosition = FormStartPosition.CenterParent;
            muonSachForm.ShowDialog();
        

        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // =====================================
        // Hàm load danh sách sách đang mượn
        // =====================================
        private void LoadChiTietSachDangMuon(string maPhieuMuon)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"SELECT Ma_Sach, Mo_Ta 
                                   FROM CT_PHIEU_MUON 
                                   WHERE Ma_Phieu_Muon = @MaPM";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSachDangMuon.DataSource = dt;
                    }
                }

                // Đặt tiêu đề cột cho đẹp (tùy chọn)
                if (dgvSachDangMuon.Columns.Count > 0)
                {
                    dgvSachDangMuon.Columns["Ma_Sach"].HeaderText = "Mã Sách";
                    dgvSachDangMuon.Columns["Mo_Ta"].HeaderText = "Mô Tả";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách đang mượn: " + ex.Message);
            }
        }
        
        private void txtMaThe_Leave(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();

            if (string.IsNullOrEmpty(maThe))
            {
                txtMaPhieuMuon.Text = "";
                return;
            }

            // Kiểm tra Thẻ có phiếu "Chưa Trả" không
            if (KiemTraMaTheDangMuonChuaTra(maThe))
            {
                MessageBox.Show("Thẻ này đang có phiếu mượn chưa trả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhieuMuon.Text = "";
                return;
            }

            // Nếu hợp lệ → sinh Mã Phiếu Mượn mới
            txtMaPhieuMuon.Text = SinhMaPhieuMuonMoi();
            txtMaPhieuMuon.ReadOnly = true; // khóa không cho chỉnh
                                            // Lấy Ma_Doc_Gia tương ứng với Ma_The
            txtMaDocGia.Text = LayMaDocGia(maThe);
        }
        // Sinh Mã Phiếu Mượn mới
        private string SinhMaPhieuMuonMoi()
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query = "SELECT Ma_Phieu_Muon FROM PHIEU_MUON";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int maxSo = 0;
                while (reader.Read())
                {
                    string ma = reader["Ma_Phieu_Muon"].ToString();
                    // Giả sử mã kiểu "PM123" -> lấy phần số
                    string so = new string(ma.Where(c => char.IsDigit(c)).ToArray());
                    if (int.TryParse(so, out int num))
                    {
                        if (num > maxSo) maxSo = num;
                    }
                }
                reader.Close();

                // Sinh mã mới, giữ prefix "PM"
                return "PM" + (maxSo + 1).ToString("D3"); // D3 để 001, 002, …
            }
        }


        // Kiểm tra Mã Thẻ đang có phiếu "Chưa Trả"
        private bool KiemTraMaTheDangMuonChuaTra(string maThe)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PHIEU_MUON WHERE Ma_The = @Ma_The AND Trang_Thai_Muon = N'Chưa Trả'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma_The", maThe);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            // --- Xóa trắng các TextBox trong grbThongTinPhieuMuon ---
            txtMaThe.Text = "";
            txtMaPhieuMuon.Text = "";
            txtMaPhieuMuon.ReadOnly = true; // khóa luôn, người dùng không sửa
            txtMaThuThu.Text = "";
            txtMaDocGia.Text = "";
            txtTrangThai.Text = "";
            txtMaKieuMuon.Text = "";
            txtTienCoc.Text = "";
            dtpNgayMuon.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now.AddDays(7);
            dtpNgayThucTra.Value = DateTime.Now;
            
            // Xóa dtpNgayThucTra (hiển thị trống)
            dtpNgayThucTra.Format = DateTimePickerFormat.Custom;
            dtpNgayThucTra.CustomFormat = " ";
            dtpNgayThucTra.Enabled = false; // không cho sửa

            // --- Xóa trắng DataGridView dgvSachDangMuon ---
            dgvSachDangMuon.DataSource = null;
            dgvSachDangMuon.Rows.Clear();
            // Hiện ComboBox để chọn khi thêm mới
            cmbMaThuThu.Visible = true;
            cmbMaKieuMuon.Visible = true;
            txtMaThuThu.Visible = false;
            txtMaKieuMuon.Visible = false;

            // Load dữ liệu vào ComboBox
            LoadThuThu();
            LoadKieuMuon();
           
            // Gán trạng thái mặc định cho phiếu mới
            txtTrangThai.Text = "Đang mượn";
            // --- Đặt focus vào txtMaThe để người dùng nhập ---
            txtMaThe.Focus();
        

    }
        private void LoadThuThu()
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query = "SELECT Ma_Thu_Thu FROM THU_THU";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMaThuThu.DataSource = dt;
                cmbMaThuThu.DisplayMember = "Ma_Thu_Thu";
                cmbMaThuThu.ValueMember = "Ma_Thu_Thu";
                cmbMaThuThu.SelectedIndex = -1; // chưa chọn gì
            }
        }

        private void LoadKieuMuon()
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string query = "SELECT Ma_Kieu_Muon FROM KIEU_MUON";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMaKieuMuon.DataSource = dt;
                cmbMaKieuMuon.DisplayMember = "Ma_Kieu_Muon";
                cmbMaKieuMuon.ValueMember = "Ma_Kieu_Muon";
                cmbMaKieuMuon.SelectedIndex = -1;
            }
        }

        private void cmbMaKieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKieuMuon.SelectedValue == null)
                return;

            // Lấy Ma_Kieu_Muon từ ComboBox
            string maKieu = cmbMaKieuMuon.SelectedValue.ToString();
            DateTime ngayMuon = dtpNgayMuon.Value;
            DateTime hanTra;

            switch (maKieu)
            {
                case "KM0001":
                    hanTra = ngayMuon.AddDays(7);
                    break;
                case "KM0002":
                    // Hạn trả trong cùng ngày, trước 22h
                    hanTra = new DateTime(ngayMuon.Year, ngayMuon.Month, ngayMuon.Day, 22, 0, 0);
                    break;
                case "KM0003":
                    hanTra = ngayMuon.AddDays(3);
                    break;
                default:
                    hanTra = ngayMuon.AddDays(7); // default nếu có thêm loại
                    break;
            }

            // Gán lại giá trị cho dtpHanTra
            dtpHanTra.Value = hanTra;
        }
        // Trong UC_QuanlyPhieuMuonSach
        public DataGridView DgvSachDangMuon
        {
            get { return dgvSachDangMuon; }
        }

        private void UC_QuanlyPhieuMuonSach_Load_1(object sender, EventArgs e)
        {

        }
    }

}
