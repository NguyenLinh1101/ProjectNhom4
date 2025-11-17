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
    public partial class UC_QuanlyThongTinTacGia : UserControl
    {
        string strCon = "Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool isAdding = false;
        public Size BaseSize;
        public UC_QuanlyThongTinTacGia()
        {
            InitializeComponent();
            BaseSize = this.Size;

        }

        private void lblDauSach_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            NapCT(); // Tải lại dữ liệu của dòng đang chọn
            SetControlState("Normal");
        }
        private void TaoMaTG()
        {
            string newMaTG = "TG0001";
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT MAX(Ma_Tac_Gia) FROM TAC_GIA WHERE Ma_Tac_Gia LIKE 'TG%'";
                    cmd = new SqlCommand(sql, con);
                    var result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        string maxMa = result.ToString(); // "TG0013"
                        int number = int.Parse(maxMa.Substring(2)); // 13
                        number++; // 14
                        newMaTG = "TG" + number.ToString("D4"); // "TG0014"
                    }
                }
                txtMaTacGia.Text = newMaTG;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã tác giả: " + ex.Message);
                txtMaTacGia.Text = newMaTG;
            }
        }
        private void SetupDatePickers()
        {
            // Cài đặt cho dtpNgaySinh (Chọn ngày tháng năm)
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.ShowCheckBox = true; // Cho phép NULL
            dtpNgaySinh.Checked = false;

            // Cài đặt cho dtpNamMat (Chỉ chọn năm)
            dtpNamMat.Format = DateTimePickerFormat.Custom;
            dtpNamMat.CustomFormat = "yyyy";
            dtpNamMat.ShowUpDown = true; // Biến thành nút tăng/giảm năm
            dtpNamMat.ShowCheckBox = true; // Cho phép NULL
            dtpNamMat.Checked = false;
        }
        private void LoadGioiTinh()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Khác");
            cbGioiTinh.SelectedIndex = -1;
        }
        private void LoadQuocTich()
        {
            cboQuocTich.Items.Clear();
            cboQuocTich.Items.Add("Việt Nam");
            cboQuocTich.Items.Add("Mỹ");
            cboQuocTich.Items.Add("Anh");
            cboQuocTich.Items.Add("Pháp");
            cboQuocTich.Items.Add("Nhật Bản");
            cboQuocTich.Items.Add("Hàn Quốc");
            cboQuocTich.Items.Add("Khác");
            cboQuocTich.SelectedIndex = -1;
        }
        private void SetControlState(string state)
        {
            switch (state)
            {
                case "Normal": // Trạng thái xem
                               // 1. KHÓA TOÀN BỘ KHUNG NHẬP LIỆU
                    grbTTTG.Enabled = false; // (Sẽ bị mờ và không cho con trỏ vào)

                    // 2. Ô Mã Tác Giả LUÔN BỊ KHÓA
                    txtMaTacGia.ReadOnly = true;

                    // 3. Bật các nút chức năng
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    // 4. Tắt các nút lưu/hủy
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case "Editing": // Trạng thái Thêm/Sửa
                                // 1. MỞ KHÓA KHUNG NHẬP LIỆU
                    grbTTTG.Enabled = true;

                    // 2. Ô Mã Tác Giả VẪN BỊ KHÓA (Theo yêu cầu của bạn)
                    txtMaTacGia.ReadOnly = true;

                    // 3. Tắt các nút chức năng
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    // 4. Bật các nút lưu/hủy
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }
        private void ClearForm()
        {
            txtMaTacGia.Text = "";
            txtHoTen.Text = "";
            cboQuocTich.SelectedIndex = -1; // (Thêm dòng này)

            dtpNgaySinh.Checked = false;
            dtpNamMat.Checked = false;
            cbGioiTinh.SelectedIndex = -1;
        }
        private void ShowData()
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Lấy các cột mới: Ngay_Sinh, Nam_Mat, Gioi_Tinh, Quoc_Tich
                    string sql = "SELECT Ma_Tac_Gia, Ten_Tac_Gia, Ngay_Sinh, Nam_Mat, Gioi_Tinh, Quoc_Tich FROM TAC_GIA";
                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dv = new DataView(dt);

                    // TẮT TỰ ĐỘNG TẠO CỘT (QUAN TRỌNG)
                    dgvTacGia.AutoGenerateColumns = false;
                    dgvTacGia.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NapCT()
        {
            if (dgvTacGia.CurrentRow != null && dv != null && dgvTacGia.CurrentRow.Index < dv.Count)
            {
                try
                {
                    int i = dgvTacGia.CurrentRow.Index;
                    DataRowView rowView = dv[i];

                    txtMaTacGia.Text = rowView["Ma_Tac_Gia"]?.ToString() ?? "";
                    txtHoTen.Text = rowView["Ten_Tac_Gia"]?.ToString() ?? "";

                    // SỬA LẠI TẠI ĐÂY:
                    // txtQuocTich.Text = rowView["Quoc_Tich"]?.ToString() ?? ""; // (Xóa dòng này)
                    cboQuocTich.SelectedItem = rowView["Quoc_Tich"]?.ToString(); // (Thêm dòng này)

                    cbGioiTinh.SelectedItem = rowView["Gioi_Tinh"]?.ToString();

                    // (Phần code dtpNgaySinh và dtpNamMat giữ nguyên)
                    if (rowView["Ngay_Sinh"] != DBNull.Value)
                    {
                        dtpNgaySinh.Value = (DateTime)rowView["Ngay_Sinh"];
                        dtpNgaySinh.Checked = true;
                    }
                    else
                    {
                        dtpNgaySinh.Checked = false;
                    }

                    if (rowView["Nam_Mat"] != DBNull.Value)
                    {
                        int namMat = (int)rowView["Nam_Mat"];
                        dtpNamMat.Value = new DateTime(namMat, 1, 1);
                        dtpNamMat.Checked = true;
                    }
                    else
                    {
                        dtpNamMat.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UC_QuanlyThongTinTacGia_Load(object sender, EventArgs e)
        {
            SetupDatePickers();
            LoadGioiTinh();
            LoadQuocTich(); // <-- THÊM DÒNG NÀY

            ShowData();
            SetControlState("Normal");
            dgvTacGia.EnableHeadersVisualStyles = false;

            dgvTacGia.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvTacGia.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Regular);

            foreach (DataGridViewColumn col in dgvTacGia.Columns)
            {
                col.DefaultCellStyle.Font =
                    new Font("Segoe UI", 10F, FontStyle.Regular);
            }
        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAdding) // Nếu không phải đang Thêm
            {
                NapCT();
                SetControlState("Normal");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearForm();
            TaoMaTG();
            SetControlState("Editing");
            txtHoTen.Focus();
        }

       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một tác giả để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maTG = txtMaTacGia.Text;
            string tenTG = txtHoTen.Text;

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa tác giả '{tenTG}' ({maTG})?\n" +
                $"LƯU Ý: Mọi liên kết của tác giả này với các đầu sách sẽ bị xóa.\n" +
                $"Không thể xóa nếu tác giả đã có trong các phiếu mượn/phiếu phạt.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (con = new SqlConnection(strCon))
                    {
                        con.Open();
                        // Dùng SQL Parameter để chống SQL Injection
                        // 1. Xóa liên kết trong TG_DAU_SACH
                        // 2. Xóa tác giả trong TAC_GIA
                        string sql = "DELETE FROM TG_DAU_SACH WHERE Ma_Tac_Gia = @MaTG; " +
                                     "DELETE FROM TAC_GIA WHERE Ma_Tac_Gia = @MaTG;";

                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@MaTG", maTG);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tác giả (Có thể do ràng buộc khóa ngoại): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Tên tác giả không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string maTG = txtMaTacGia.Text;
            string tenTG = txtHoTen.Text;

            // Xử lý các giá trị có thể NULL
            object ngaySinh = dtpNgaySinh.Checked ? (object)dtpNgaySinh.Value : DBNull.Value;
            object namMat = dtpNamMat.Checked ? (object)dtpNamMat.Value.Year : DBNull.Value;
            object gioiTinh = cbGioiTinh.SelectedIndex != -1 ? (object)cbGioiTinh.SelectedItem.ToString() : DBNull.Value;
            object quocTich = cboQuocTich.SelectedIndex != -1 ? (object)cboQuocTich.SelectedItem.ToString() : DBNull.Value;

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql;
                    if (isAdding) // Logic THÊM MỚI
                    {
                        sql = @"INSERT INTO TAC_GIA (Ma_Tac_Gia, Ten_Tac_Gia, Ngay_Sinh, Nam_Mat, Gioi_Tinh, Quoc_Tich)
                                VALUES (@MaTG, @TenTG, @NgaySinh, @NamMat, @GioiTinh, @QuocTich)";
                    }
                    else // Logic SỬA
                    {
                        sql = @"UPDATE TAC_GIA 
                                SET Ten_Tac_Gia = @TenTG, 
                                    Ngay_Sinh = @NgaySinh, 
                                    Nam_Mat = @NamMat, 
                                    Gioi_Tinh = @GioiTinh, 
                                    Quoc_Tich = @QuocTich
                                WHERE Ma_Tac_Gia = @MaTG";
                    }

                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaTG", maTG);
                    cmd.Parameters.AddWithValue("@TenTG", tenTG);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@NamMat", namMat);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@QuocTich", quocTich);

                    cmd.ExecuteNonQuery();

                    string msg = isAdding ? "Thêm tác giả thành công." : "Cập nhật tác giả thành công.";
                    MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData(); // Tải lại lưới
                    SetControlState("Normal"); // Trả về trạng thái xem
                    isAdding = false; // Reset cờ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dv != null)
            {
                string filter = string.Format("Ten_Tac_Gia LIKE '%{0}%'", txtSearch.Text.Trim());
                dv.RowFilter = filter;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvTacGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một tác giả để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetControlState("Editing"); // Chuyển sang trạng thái "Sửa"
            txtHoTen.Focus(); // Cho con trỏ vào ô Tên
        }
    }
}
