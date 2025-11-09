using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom4
{
    public partial class QL_DauSach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool addNewFlag = false;

        public bool V { get; private set; }

        public QL_DauSach() => InitializeComponent();
        private void SetControls(bool status)
        {
            // Mã đầu sách sẽ được tạo tự động, không cho sửa
            txtMaDauSach.Enabled = false;

            txtTenDauSach.Enabled = status;
            txtNamXB.Enabled = status;
            txtGiaBia.Enabled = status;
            txtSoTrang.Enabled = status;
            txtTacGia.Enabled = status; // Thêm TextBox Tác giả
            cboLoaiSach.Enabled = status;
            cboChuDe.Enabled = status;
        }
        private void ShowDauSach()
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Đổi tên bảng thành DAU_SACH
                    string sql = "SELECT * FROM DAU_SACH";
                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                }
                dv = new DataView(dt);
                dgvDSDauSach.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadComboBox(ComboBox cbo, string tableName, string Ma, string TenMa)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = $"SELECT * FROM {tableName}";
                    adapter = new SqlDataAdapter(sql, con);
                    DataTable dtCbo = new DataTable();
                    adapter.Fill(dtCbo);

                    cbo.DataSource = dtCbo;
                    cbo.ValueMember = Ma;
                    cbo.DisplayMember = TenMa;
                    cbo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải ComboBox ({tableName}): {ex.Message}");
            }
        }
        private void NapCT()
        {
            if (dgvDSDauSach.CurrentRow != null)
            {
                try
                {
                    int i = dgvDSDauSach.CurrentRow.Index;

                    // Sử dụng tên cột chính xác với khoảng trắng từ DB
                    txtMaDauSach.Text = dgvDSDauSach.Rows[i].Cells["MaDauSach"].Value?.ToString() ?? "";
                    txtTenDauSach.Text = dgvDSDauSach.Rows[i].Cells["TenDauSach"].Value?.ToString() ?? "";
                    txtTacGia.Text = dgvDSDauSach.Rows[i].Cells["TacGia"].Value?.ToString() ?? "";
                    txtNamXB.Text = dgvDSDauSach.Rows[i].Cells["NamXB"].Value?.ToString() ?? "";
                    txtGiaBia.Text = dgvDSDauSach.Rows[i].Cells["GiaBia"].Value?.ToString() ?? "";
                    txtSoTrang.Text = dgvDSDauSach.Rows[i].Cells["SoTrang"].Value?.ToString() ?? "";

                    // ComboBox với kiểm tra NULL
                    if (dgvDSDauSach.Rows[i].Cells["Ma_TL"].Value != DBNull.Value && dgvDSDauSach.Rows[i].Cells["Ma_TL"].Value != null)
                    {
                        cboLoaiSach.SelectedValue = dgvDSDauSach.Rows[i].Cells["Ma_TL"].Value.ToString();
                    }
                    else
                    {
                        cboLoaiSach.SelectedIndex = -1;
                    }

                    if (dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value != DBNull.Value && dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value != null)
                    {
                        cboChuDe.SelectedValue = dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value.ToString();
                    }
                    else
                    {
                        cboChuDe.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp chi tiết: " + ex.Message);
                }
            }
        }
        void DoSQL(string sql)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi SQL: " + ex.Message);
            }
        }
        private void TaoMaDS()
        {
            string newMaDS = "DS0001"; // Mã mặc định nếu chưa có mã nào
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Tìm mã lớn nhất có dạng 'DS' + số
                    string sql  = "SELECT MAX([Ma_Dau_Sach]) FROM DAU_SACH WHERE [Ma_Dau_Sach] LIKE 'DS%'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    var result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        string maxMaDauSach = result.ToString(); // Ví dụ: "DS0020"
                        string prefix = "DS";

                        // Lấy phần số (ví dụ "0020") và chuyển thành số nguyên (20)
                        int number = int.Parse(maxMaDauSach.Substring(prefix.Length));

                        number++; // Tăng lên 1 (21)

                        // Định dạng lại thành "DS0021" (giả sử dùng 4 chữ số)
                        newMaDS = prefix + number.ToString("D4");
                    }
                }
                txtMaDauSach.Text = newMaDS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã: " + ex.Message);
                txtMaDauSach.Text = newMaDS; // Đặt mã mặc định nếu lỗi
            }
        }

        private void grbTTDS_Enter(object sender, EventArgs e)
        {

        }

        private void QL_DauSach_Load(object sender, EventArgs e)
        {
            
            ShowDauSach();

            
            LoadComboBox(cboLoaiSach, "THE_LOAI", "Ma_TL", "Ten_TL");
            LoadComboBox(cboChuDe, "CHU_DE", "Ma_Chu_De", "Ten_Chu_De");

            
            SetControls(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (dgvDSDauSach.Rows.Count > 0)
            {
                dgvDSDauSach.CurrentCell = dgvDSDauSach.Rows[0].Cells[0];
                NapCT();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            dv.RowFilter = $"[Ten_Dau_Sach] like '%{searchText}%'";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addNewFlag = true;

            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtTacGia.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";
            cboLoaiSach.SelectedIndex = -1;
            cboChuDe.SelectedIndex = -1;

            SetControls(true);

            TaoMaDS();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "Lưu";  
            btnHuy.Visible = true;
            txtTenDauSach.Focus();
        }
        // Add this method to handle the SelectedIndexChanged event for cboLoaiSach
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboLoaiSach.SelectedItem as DataRowView;
        }

        private void dgvDSDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow != null)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                NapCT();  // Thêm dòng này để nạp dữ liệu ngay khi chọn hàng
                SetControls(false);  // Đảm bảo controls ở chế độ read-only sau khi nạp
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                // Tùy chọn: Xóa trắng các ô nếu không có hàng nào được chọn
                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                txtTacGia.Text = "";
                txtNamXB.Text = "";
                txtGiaBia.Text = "";
                txtSoTrang.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                if (dgvDSDauSach.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn một bản ghi trong bảng trước!");
                    return;
                }

                addNewFlag = false;
                SetControls(true); // Mở khóa controls

                // Quản lý trạng thái nút
                btnSua.Text = "Lưu";
                btnHuy.Visible = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

                txtTenDauSach.Focus();
            }
            // Trường hợp 2: Nút đang là "Lưu" (Hoàn tất Thêm hoặc Sửa)
            else
            {
                if (string.IsNullOrWhiteSpace(txtTenDauSach.Text))
                {
                    MessageBox.Show("Tên đầu sách không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDauSach.Focus();
                    return;
                }
                if (cboLoaiSach.SelectedValue == null)
                {
                    MessageBox.Show("Bạn phải chọn một Thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboLoaiSach.Focus();
                    return;
                }

                string maDS = txtMaDauSach.Text;
                string tenDS = txtTenDauSach.Text;
                string tacGia = txtTacGia.Text;
                
                string maLoai = cboLoaiSach.SelectedValue.ToString();
                string maChuDe_sql = (cboChuDe.SelectedValue != null) ? $"'{cboChuDe.SelectedValue}'" : "NULL";
                string tacGia_sql = !string.IsNullOrWhiteSpace(tacGia) ? $"N'{tacGia}'" : "NULL";

                int namXB_num;
                if (!int.TryParse(txtNamXB.Text, out namXB_num) && !string.IsNullOrWhiteSpace(txtNamXB.Text))
                {
                    MessageBox.Show("Năm xuất bản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNamXB.Focus();
                    return;
                }
                string namXB_sql = !string.IsNullOrWhiteSpace(txtNamXB.Text) ? namXB_num.ToString() : "NULL";

                decimal giaBia_num;
                if (!decimal.TryParse(txtGiaBia.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out giaBia_num) && !string.IsNullOrWhiteSpace(txtGiaBia.Text))
                {
                    MessageBox.Show("Giá bìa không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiaBia.Focus();
                    return;
                }
                string giaBia_sql = !string.IsNullOrWhiteSpace(txtGiaBia.Text) ? giaBia_num.ToString(CultureInfo.InvariantCulture) : "NULL";


                int soTrang_num;
                if (!int.TryParse(txtSoTrang.Text, out soTrang_num) && !string.IsNullOrWhiteSpace(txtSoTrang.Text))
                {
                    MessageBox.Show("Số trang không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTrang.Focus();
                    return;
                }
                string soTrang_sql = !string.IsNullOrWhiteSpace(txtSoTrang.Text) ? soTrang_num.ToString() : "NULL";

                string sql;
                if (addNewFlag) // THÊM MỚI
                {
                    sql = $"INSERT INTO DAU_SACH([Ma_Dau_Sach], [Ten_Dau_Sach], [Tac_Gia], [Nam_XB], [Ma_Chu_De], [Ma_TL], [Gia_Bia], [So_Trang]) " +
                    $"VALUES ('{maDS}', N'{tenDS}', {tacGia_sql}, {namXB_sql}, {maChuDe_sql}, '{maLoai}', {giaBia_sql}, {soTrang_sql})";
                    DoSQL(sql);
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    sql = $"UPDATE DAU_SACH SET " +
                          $"[Ten_Dau_Sach] = N'{tenDS}', " +
                          $"[Tac_Gia] = {tacGia_sql}, " +
                          $"[Nam_XB] = {namXB_sql}, " +
                          $"[Ma_Chu_De] = {maChuDe_sql}, " +
                          $"[Ma_TL] = '{maLoai}', " +
                          $"[Gia_Bia] = {giaBia_sql}, " +
                          $"[So_Trang] = {soTrang_sql} " +
                          $"WHERE [Ma_Dau_Sach] = '{maDS}'";
                    DoSQL(sql);
                    MessageBox.Show("Cập nhật thành công!");
                }

                ShowDauSach();
                SetControls(false); // Khóa controls

                // Xóa trắng các ô sau khi lưu
                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                txtTacGia.Text = "";
                txtNamXB.Text = "";
                txtGiaBia.Text = "";
                txtSoTrang.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;

                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnHuy.Visible = false;

                // Tắt nút Sửa/Xóa vì chưa chọn gì
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một bản ghi để xóa!");
                return;
            }

            // Lấy mã TRỰC TIẾP từ bảng
            string maDS = dgvDSDauSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa đầu sách '{maDS}' không?\n" +
                                     $"(Lưu ý: Bạn không thể xóa nếu đầu sách này đã có trong bảng SACH)",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM DAU_SACH WHERE [Ma_Dau_Sach]='{maDS}'";
                DoSQL(sql);

                MessageBox.Show("Xóa thành công!"); 
                ShowDauSach();

                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;
            }
        }

        private void Fill(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControls(false);

            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtTacGia.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";
            cboLoaiSach.SelectedIndex = -1;
            cboChuDe.SelectedIndex = -1;

            btnHuy.Visible = false;

            btnSua.Text = "Sửa";
            btnThem.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow == null)
            {
                MessageBox.Show("Chọn sách muốn xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDS = dgvDSDauSach.CurrentRow.Cells["MaDauSach"].Value?.ToString();
            if (string.IsNullOrEmpty(maDS))
            {
                MessageBox.Show("Mã đầu sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ChiTietDauSach formChiTiet = new ChiTietDauSach(maDS);
                formChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool addNewFlag = false;

        public bool V { get; private set; }

        public QL_DauSach() => InitializeComponent();
        private void SetControls(bool status)
        {
            // Mã đầu sách sẽ được tạo tự động, không cho sửa
            txtMaDauSach.Enabled = false;

            txtTenDauSach.Enabled = status;
            txtNamXB.Enabled = status;
            txtGiaBia.Enabled = status;
            txtSoTrang.Enabled = status;
            txtTacGia.Enabled = status; // Thêm TextBox Tác giả
            cboLoaiSach.Enabled = status;
            cboChuDe.Enabled = status;
        }
        private void ShowDauSach()
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Đổi tên bảng thành DAU_SACH
                    string sql = "SELECT * FROM DAU_SACH";
                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                }
                dv = new DataView(dt);
                dgvDSDauSach.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadComboBox(ComboBox cbo, string tableName, string Ma, string TenMa)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = $"SELECT * FROM {tableName}";
                    adapter = new SqlDataAdapter(sql, con);
                    DataTable dtCbo = new DataTable();
                    adapter.Fill(dtCbo);

                    cbo.DataSource = dtCbo;
                    cbo.ValueMember = Ma;
                    cbo.DisplayMember = TenMa;
                    cbo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải ComboBox ({tableName}): {ex.Message}");
            }
        }
        private void NapCT()
        {
            if (dgvDSDauSach.CurrentRow != null)
            {
                try
                {
                    int i = dgvDSDauSach.CurrentRow.Index;

                    // Sử dụng tên cột chính xác với khoảng trắng từ DB
                    txtMaDauSach.Text = dgvDSDauSach.Rows[i].Cells["MaDauSach"].Value?.ToString() ?? "";
                    txtTenDauSach.Text = dgvDSDauSach.Rows[i].Cells["TenDauSach"].Value?.ToString() ?? "";
                    txtTacGia.Text = dgvDSDauSach.Rows[i].Cells["TacGia"].Value?.ToString() ?? "";
                    txtNamXB.Text = dgvDSDauSach.Rows[i].Cells["NamXB"].Value?.ToString() ?? "";
                    txtGiaBia.Text = dgvDSDauSach.Rows[i].Cells["GiaBia"].Value?.ToString() ?? "";
                    txtSoTrang.Text = dgvDSDauSach.Rows[i].Cells["SoTrang"].Value?.ToString() ?? "";

                    // ComboBox với kiểm tra NULL
                    if (dgvDSDauSach.Rows[i].Cells["Ma_TL"].Value != DBNull.Value && dgvDSDauSach.Rows[i].Cells["Ma_TL"].Value != null)
                    {
                        cboLoaiSach.SelectedValue = dgvDSDauSach.Rows[i].Cells["Ma_TL"].Value.ToString();
                    }
                    else
                    {
                        cboLoaiSach.SelectedIndex = -1;
                    }

                    if (dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value != DBNull.Value && dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value != null)
                    {
                        cboChuDe.SelectedValue = dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value.ToString();
                    }
                    else
                    {
                        cboChuDe.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp chi tiết: " + ex.Message);
                }
            }
        }
        void DoSQL(string sql)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi SQL: " + ex.Message);
            }
        }
        private void TaoMaDS()
        {
            string newMaDS = "DS0001"; // Mã mặc định nếu chưa có mã nào
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Tìm mã lớn nhất có dạng 'DS' + số
                    string sql  = "SELECT MAX([Ma_Dau_Sach]) FROM DAU_SACH WHERE [Ma_Dau_Sach] LIKE 'DS%'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    var result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        string maxMaDauSach = result.ToString(); // Ví dụ: "DS0020"
                        string prefix = "DS";

                        // Lấy phần số (ví dụ "0020") và chuyển thành số nguyên (20)
                        int number = int.Parse(maxMaDauSach.Substring(prefix.Length));

                        number++; // Tăng lên 1 (21)

                        // Định dạng lại thành "DS0021" (giả sử dùng 4 chữ số)
                        newMaDS = prefix + number.ToString("D4");
                    }
                }
                txtMaDauSach.Text = newMaDS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã: " + ex.Message);
                txtMaDauSach.Text = newMaDS; // Đặt mã mặc định nếu lỗi
            }
        }

        private void grbTTDS_Enter(object sender, EventArgs e)
        {

        }

        private void QL_DauSach_Load(object sender, EventArgs e)
        {
            // 1. Tải danh sách Đầu sách
            ShowDauSach();

            // 2. Tải dữ liệu cho các ComboBox (với tên bảng và cột chính xác)
            LoadComboBox(cboLoaiSach, "THE_LOAI", "Ma_TL", "Ten_TL");
            LoadComboBox(cboChuDe, "CHU_DE", "Ma_Chu_De", "Ten_Chu_De");

            // 3. Đặt trạng thái ban đầu
            SetControls(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (dgvDSDauSach.Rows.Count > 0)
            {
                dgvDSDauSach.CurrentCell = dgvDSDauSach.Rows[0].Cells[0];
                NapCT();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            dv.RowFilter = $"[TenDauSach] like '%{searchText}%'";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addNewFlag = true;

            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtTacGia.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";
            cboLoaiSach.SelectedIndex = -1;
            cboChuDe.SelectedIndex = -1;

            SetControls(true);

            TaoMaDS();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Text = "Lưu";  
            btnHuy.Visible = true;
            txtTenDauSach.Focus();
        }
        // Add this method to handle the SelectedIndexChanged event for cboLoaiSach
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboLoaiSach.SelectedItem as DataRowView;
        }

        private void dgvDSDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow != null)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                NapCT();  // Thêm dòng này để nạp dữ liệu ngay khi chọn hàng
                SetControls(false);  // Đảm bảo controls ở chế độ read-only sau khi nạp
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                // Tùy chọn: Xóa trắng các ô nếu không có hàng nào được chọn
                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                txtTacGia.Text = "";
                txtNamXB.Text = "";
                txtGiaBia.Text = "";
                txtSoTrang.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                if (dgvDSDauSach.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn một bản ghi trong bảng trước!");
                    return;
                }

                addNewFlag = false;
                SetControls(true); // Mở khóa controls

                // Quản lý trạng thái nút
                btnSua.Text = "Lưu";
                btnHuy.Visible = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

                txtTenDauSach.Focus();
            }
            // Trường hợp 2: Nút đang là "Lưu" (Hoàn tất Thêm hoặc Sửa)
            else
            {
                if (string.IsNullOrWhiteSpace(txtTenDauSach.Text))
                {
                    MessageBox.Show("Tên đầu sách không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDauSach.Focus();
                    return;
                }
                if (cboLoaiSach.SelectedValue == null)
                {
                    MessageBox.Show("Bạn phải chọn một Thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboLoaiSach.Focus();
                    return;
                }

                string maDS = txtMaDauSach.Text;
                string tenDS = txtTenDauSach.Text;
                string tacGia = txtTacGia.Text;
                
                string maLoai = cboLoaiSach.SelectedValue.ToString();
                string maChuDe_sql = (cboChuDe.SelectedValue != null) ? $"'{cboChuDe.SelectedValue}'" : "NULL";
                string tacGia_sql = !string.IsNullOrWhiteSpace(tacGia) ? $"N'{tacGia}'" : "NULL";

                int namXB_num;
                if (!int.TryParse(txtNamXB.Text, out namXB_num) && !string.IsNullOrWhiteSpace(txtNamXB.Text))
                {
                    MessageBox.Show("Năm xuất bản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNamXB.Focus();
                    return;
                }
                string namXB_sql = !string.IsNullOrWhiteSpace(txtNamXB.Text) ? namXB_num.ToString() : "NULL";

                decimal giaBia_num;
                if (!decimal.TryParse(txtGiaBia.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out giaBia_num) && !string.IsNullOrWhiteSpace(txtGiaBia.Text))
                {
                    MessageBox.Show("Giá bìa không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiaBia.Focus();
                    return;
                }
                string giaBia_sql = !string.IsNullOrWhiteSpace(txtGiaBia.Text) ? giaBia_num.ToString(CultureInfo.InvariantCulture) : "NULL";


                int soTrang_num;
                if (!int.TryParse(txtSoTrang.Text, out soTrang_num) && !string.IsNullOrWhiteSpace(txtSoTrang.Text))
                {
                    MessageBox.Show("Số trang không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTrang.Focus();
                    return;
                }
                string soTrang_sql = !string.IsNullOrWhiteSpace(txtSoTrang.Text) ? soTrang_num.ToString() : "NULL";

                string sql;
                if (addNewFlag) // THÊM MỚI
                {
                    sql = $"INSERT INTO DAU_SACH([Ma_Dau_Sach], [Ten_Dau_Sach], [Tac_Gia], [Nam_XB], [Ma_Chu_De], [Ma_TL], [Gia_Bia], [So_Trang]) " +
                    $"VALUES ('{maDS}', N'{tenDS}', {tacGia_sql}, {namXB_sql}, {maChuDe_sql}, '{maLoai}', {giaBia_sql}, {soTrang_sql})";
                    DoSQL(sql);
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    sql = $"UPDATE DAU_SACH SET " +
                          $"[Ten_Dau_Sach] = N'{tenDS}', " +
                          $"[Tac_Gia] = {tacGia_sql}, " +
                          $"[Nam_XB] = {namXB_sql}, " +
                          $"[Ma_Chu_De] = {maChuDe_sql}, " +
                          $"[Ma_TL] = '{maLoai}', " +
                          $"[Gia_Bia] = {giaBia_sql}, " +
                          $"[So_Trang] = {soTrang_sql} " +
                          $"WHERE [Ma_Dau_Sach] = '{maDS}'";
                    DoSQL(sql);
                    MessageBox.Show("Cập nhật thành công!");
                }

                ShowDauSach();
                SetControls(false); // Khóa controls

                // Xóa trắng các ô sau khi lưu
                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                txtTacGia.Text = "";
                txtNamXB.Text = "";
                txtGiaBia.Text = "";
                txtSoTrang.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;

                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnHuy.Visible = false;

                // Tắt nút Sửa/Xóa vì chưa chọn gì
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một bản ghi để xóa!");
                return;
            }

            // Lấy mã TRỰC TIẾP từ bảng
            string maDS = dgvDSDauSach.CurrentRow.Cells["Ma_Dau_Sach"].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa đầu sách '{maDS}' không?\n" +
                                     $"(Lưu ý: Bạn không thể xóa nếu đầu sách này đã có trong bảng SACH)",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM DAU_SACH WHERE [Ma_Dau_Sach]='{maDS}'";
                DoSQL(sql);

                MessageBox.Show("Xóa thành công!"); 
                ShowDauSach();

                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;
            }
        }

        private void Fill(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControls(false);

            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtTacGia.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";
            cboLoaiSach.SelectedIndex = -1;
            cboChuDe.SelectedIndex = -1;

            btnHuy.Visible = false;

            btnSua.Text = "Sửa";
            btnThem.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow == null)
            {
                MessageBox.Show("Chọn sách muốn xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDS = dgvDSDauSach.CurrentRow.Cells["MaDauSach"].Value?.ToString();
            if (string.IsNullOrEmpty(maDS))
            {
                MessageBox.Show("Mã đầu sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ChiTietDauSach formChiTiet = new ChiTietDauSach(maDS);
                formChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // QL_DauSach
            // 
            this.Name = "QL_DauSach";
            this.Load += new System.EventHandler(this.QL_DauSach_Load_1);
            this.ResumeLayout(false);

        }

        private void QL_DauSach_Load_1(object sender, EventArgs e)
        {

        }
    }
}
