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
        string strCon = "Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool addNewFlag = false;
        public Size BaseSize;
        public bool V { get; private set; }

        public QL_DauSach()
        { InitializeComponent();
            BaseSize = this.Size;

        }
        private void SetControls(bool status)
        {
            txtMaDauSach.Enabled = false;
            cceTacGia.Properties.ReadOnly = !status;
            txtTenDauSach.ReadOnly = !status;
            txtNamXB.ReadOnly = !status;
            txtGiaBia.ReadOnly = !status;
            txtSoTrang.ReadOnly = !status;
            cboLoaiSach.Enabled = status;
            cboChuDe.Enabled = status;

            // Xử lý nút thêm (+)
            var plusButton = cceTacGia.Properties.Buttons.FirstOrDefault(b => b.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus);
            if (status) // Chế độ edit: Thêm nút + nếu chưa có
            {
                if (plusButton == null)
                {
                    cceTacGia.Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus));
                    cceTacGia.ButtonClick += CceTacGia_ButtonClick; // Gán event chung cho ButtonClick
                }

                // Thêm nút sửa (...) nếu chưa có
                var editButton = cceTacGia.Properties.Buttons.FirstOrDefault(b => b.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis);
                if (editButton == null)
                {
                    cceTacGia.Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis));
                    // Event đã gán chung ở trên
                }
            }
            else // Chế độ read-only: Remove nút + và nút sửa
            {
                if (plusButton != null) cceTacGia.Properties.Buttons.Remove(plusButton);
                var editButton = cceTacGia.Properties.Buttons.FirstOrDefault(b => b.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis);
                if (editButton != null) cceTacGia.Properties.Buttons.Remove(editButton);
            }
        }
        private void ShowDauSach()
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();

                    string sql = @"
                SELECT 
                    ds.Ma_Dau_Sach AS MaDauSach, 
                    ds.Ten_Dau_Sach AS TenDauSach, 
                    ds.Nam_XB AS NamXB, 
                    ds.Ma_Chu_De AS MaChuDe, 
                    ds.Ma_TL,
                    ds.Gia_Bia AS GiaBia, 
                    ds.So_Trang AS SoTrang, 
                    ds.So_Luong AS SoLuong,
                    ISNULL(STRING_AGG(tg.Ten_Tac_Gia, ', '), N'Chưa có tác giả') AS TenCacTacGia
                FROM 
                    DAU_SACH ds
                LEFT JOIN 
                    TG_DAU_SACH tds ON ds.Ma_Dau_Sach = tds.Ma_Dau_Sach
                LEFT JOIN 
                    TAC_GIA tg ON tds.Ma_Tac_Gia = tg.Ma_Tac_Gia
                GROUP BY 
                    ds.Ma_Dau_Sach, ds.Ten_Dau_Sach, ds.Nam_XB, ds.Ma_Chu_De, 
                    ds.Ma_TL, ds.Gia_Bia, ds.So_Trang, ds.So_Luong";

                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                }
                dv = new DataView(dt);

                dgvDSDauSach.AutoGenerateColumns = false;

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
                    string sql = $"SELECT * FROM {tableName} ORDER BY {TenMa} ASC";
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
            if (dgvDSDauSach.CurrentRow != null && dv != null && dgvDSDauSach.CurrentRow.Index < dv.Count)
            {
                try
                {
                    int i = dgvDSDauSach.CurrentRow.Index;
                    DataRowView rowView = dv[i];
                    txtMaDauSach.Text = rowView["MaDauSach"]?.ToString() ?? "";
                    txtTenDauSach.Text = rowView["TenDauSach"]?.ToString() ?? "";
                    txtNamXB.Text = rowView["NamXB"]?.ToString() ?? "";
                    txtGiaBia.Text = rowView["GiaBia"]?.ToString() ?? "";
                    txtSoTrang.Text = rowView["SoTrang"]?.ToString() ?? "";
                    if (rowView["Ma_TL"] != DBNull.Value && rowView["Ma_TL"] != null)
                    {
                        cboLoaiSach.SelectedValue = rowView["Ma_TL"].ToString();
                    }
                    else
                    {
                        cboLoaiSach.SelectedIndex = -1;
                    }
                    if (rowView["MaChuDe"] != DBNull.Value && rowView["MaChuDe"] != null)
                    {
                        cboChuDe.SelectedValue = rowView["MaChuDe"].ToString();
                    }
                    else
                    {
                        cboChuDe.SelectedIndex = -1;
                    }
                    LoadTacGiaCuaSach(); // Thêm dòng này để load và set EditValue với mã tác giả
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
            LoadTatCaTacGiaVaoDropDown();
            // Loại bỏ LoadTacGiaCuaSach(); vì sẽ gọi trong NapCT()
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
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addNewFlag = true;
            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            cceTacGia.EditValue = null; // Reset để trống
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";
            cboLoaiSach.SelectedIndex = -1;
            cboChuDe.SelectedIndex = -1;
            SetControls(true);
            TaoMaDS();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            btnSua.Text = "Lưu";
            btnHuy.Visible = true;
            txtTenDauSach.Focus();
            MessageBox.Show("Đã sẵn sàng thêm bản ghi mới");

        }
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
                cceTacGia.Text = "";
                txtNamXB.Text = "";
                txtGiaBia.Text = "";
                txtSoTrang.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa") //Trạng thái 1: Nhấn "Sửa"
            {
                if (dgvDSDauSach.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn một bản ghi trong bảng trước!");
                    return;
                }

                addNewFlag = false;
                SetControls(true); // Mở khóa controls

                btnSua.Text = "Lưu";
                btnHuy.Visible = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

                txtTenDauSach.Focus();
            }
            // Trạng thái 2: Nhấn "Lưu" (sau khi Thêm hoặc Sửa)
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

                // === SỬA LỖI SQL INJECTION: Dùng DBNull.Value cho các giá trị NULL ===
                object maChuDe = (cboChuDe.SelectedValue != null) ? cboChuDe.SelectedValue : DBNull.Value;

                object namXB_sql;
                if (string.IsNullOrWhiteSpace(txtNamXB.Text))
                {
                    namXB_sql = DBNull.Value;
                }
                else if (int.TryParse(txtNamXB.Text, out int namXB_num))
                {
                    namXB_sql = namXB_num;
                }
                else
                {
                    MessageBox.Show("Năm xuất bản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNamXB.Focus();
                    return;
                }

                object giaBia_sql;
                if (string.IsNullOrWhiteSpace(txtGiaBia.Text))
                {
                    giaBia_sql = DBNull.Value;
                }
                else if (decimal.TryParse(txtGiaBia.Text.Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal giaBia_num))
                {
                    giaBia_sql = giaBia_num;
                }
                else
                {
                    MessageBox.Show("Giá bìa không hợp lệ! (Ví dụ: 120000.50)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiaBia.Focus();
                    return;
                }

                object soTrang_sql;
                if (string.IsNullOrWhiteSpace(txtSoTrang.Text))
                {
                    soTrang_sql = DBNull.Value;
                }
                else if (int.TryParse(txtSoTrang.Text, out int soTrang_num))
                {
                    soTrang_sql = soTrang_num;
                }
                else
                {
                    MessageBox.Show("Số trang không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTrang.Focus();
                    return;
                }
                try
                {
                    using (con = new SqlConnection(strCon))
                    {
                        con.Open();
                        string sql;
                        if (addNewFlag)
                        {
                            // SỬA SQL: Xóa [Tac_Gia]
                            sql = @"INSERT INTO DAU_SACH([Ma_Dau_Sach], [Ten_Dau_Sach], [Nam_XB], [Ma_Chu_De], [Ma_TL], [Gia_Bia], [So_Trang]) 
                            VALUES (@MaDS, @TenDS, @NamXB, @MaChuDe, @MaLoai, @GiaBia, @SoTrang)";
                        }
                        else // CẬP NHẬT
                        {
                            // SỬA SQL: Xóa [Tac_Gia]
                            sql = @"UPDATE DAU_SACH SET 
                                [Ten_Dau_Sach] = @TenDS, 
                                [Nam_XB] = @NamXB, 
                                [Ma_Chu_De] = @MaChuDe, 
                                [Ma_TL] = @MaLoai, 
                                [Gia_Bia] = @GiaBia, 
                                [So_Trang] = @SoTrang 
                            WHERE [Ma_Dau_Sach] = @MaDS";
                        }

                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@MaDS", maDS);
                        cmd.Parameters.AddWithValue("@TenDS", tenDS);
                        cmd.Parameters.AddWithValue("@NamXB", namXB_sql);
                        cmd.Parameters.AddWithValue("@MaChuDe", maChuDe);
                        cmd.Parameters.AddWithValue("@MaLoai", cboLoaiSach.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@GiaBia", giaBia_sql);
                        cmd.Parameters.AddWithValue("@SoTrang", soTrang_sql);

                        cmd.ExecuteNonQuery();
                        try
                        {
                            // Xóa tác giả cũ
                            using (SqlCommand delCmd = new SqlCommand("DELETE FROM TG_DAU_SACH WHERE Ma_Dau_Sach = @MaDS", con))
                            {
                                delCmd.Parameters.AddWithValue("@MaDS", maDS);
                                delCmd.ExecuteNonQuery();
                            }
                            // Lưu tác giả mới
                            if (cceTacGia.EditValue != null && !string.IsNullOrEmpty(cceTacGia.EditValue.ToString()))
                            {
                                string[] selectedAuthors = cceTacGia.EditValue.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => s.Trim()).ToArray(); // Thêm trim
                                foreach (string maTG in selectedAuthors)
                                {
                                    using (SqlCommand addCmd = new SqlCommand("INSERT INTO TG_DAU_SACH(Ma_Dau_Sach, Ma_Tac_Gia) VALUES (@MaDS, @MaTG)", con))
                                    {
                                        addCmd.Parameters.AddWithValue("@MaDS", maDS);
                                        addCmd.Parameters.AddWithValue("@MaTG", maTG);
                                        addCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu tác giả: " + ex.Message);
                        }

                        string message = addNewFlag ? "Thêm mới thành công!" : "Cập nhật thành công!";
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng lại nếu lỗi
                }

                // === Reset lại form ===
                ShowDauSach();
                SetControls(false); // Khóa controls

                txtMaDauSach.Text = "";
                txtTenDauSach.Text = "";
                cceTacGia.Text = "";
                txtNamXB.Text = "";
                txtGiaBia.Text = "";
                txtSoTrang.Text = "";
                cboLoaiSach.SelectedIndex = -1;
                cboChuDe.SelectedIndex = -1;

                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnHuy.Visible = false;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void LoadTatCaTacGiaVaoDropDown()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Ma_Tac_Gia, Ten_Tac_Gia FROM TAC_GIA", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Thêm cột hiển thị kết hợp mã + tên
                    dt.Columns.Add("DisplayText", typeof(string), "[Ma_Tac_Gia] + ' - ' + [Ten_Tac_Gia]");

                    cceTacGia.Properties.DataSource = dt;
                    cceTacGia.Properties.DisplayMember = "DisplayText";
                    cceTacGia.Properties.ValueMember = "Ma_Tac_Gia";
                    cceTacGia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    cceTacGia.Properties.IncrementalSearch = true;

                    // Hiển thị autocomplete filter trong popup
                    cceTacGia.Properties.IncrementalSearch = true;
                    // Thêm nút "+"
                    //if (!cceTacGia.Properties.Buttons.Any(b => b.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus))
                    //{
                    //    cceTacGia.Properties.Buttons.Add(
                    //        new DevExpress.XtraEditors.Controls.EditorButton(
                    //            DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
                    //        )
                    //    );

                    //    cceTacGia.ButtonClick += (s, e) =>
                    //    {
                    //        if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                    //        {
                    //            using (var frm = new FrmThemTacGia())
                    //            {
                    //                if (frm.ShowDialog() == DialogResult.OK)
                    //                {
                    //                    LoadTatCaTacGiaVaoDropDown();
                    //                }
                    //            }
                    //        }
                    //    };
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tác giả: " + ex.Message);
            }
        }
        private void LoadTacGiaCuaSach()
        {
            // Dùng List<object> để giữ các Mã Tác Giả
            List<object> maTacGiaCuaSach = new List<object>();
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Ma_Tac_Gia FROM TG_DAU_SACH WHERE Ma_Dau_Sach = @MaDS", con);
                    cmd.Parameters.AddWithValue("@MaDS", txtMaDauSach.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // SỬA: Đọc Ma_Tac_Gia trực tiếp
                        maTacGiaCuaSach.Add(reader["Ma_Tac_Gia"]);
                    }
                    reader.Close();
                }
                string checkedValues = string.Join(",", maTacGiaCuaSach);

                // Set giá trị cho CheckedComboBoxEdit
                cceTacGia.SetEditValue(checkedValues);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tác giả của sách: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một bản ghi để xóa!");
                return;
            }

            // Lấy mã từ DataGridView (tên cột "MaDauSach" từ câu SQL)
            string maDS = dgvDSDauSach.CurrentRow.Cells["MaDauSach"].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa đầu sách '{maDS}' không?\n" +
                                             $"(Lưu ý: Mọi liên kết tác giả sẽ bị xóa. " +
                                             $"Không thể xóa nếu sách đã có trong thư viện)",
                                             "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (con = new SqlConnection(strCon))
                    {
                        con.Open();
                        // Phải xóa ở bảng TG_DAU_SACH trước (quan hệ nhiều-nhiều)
                        // Sau đó mới xóa ở bảng DAU_SACH (bảng chính)
                        string sql = "DELETE FROM TG_DAU_SACH WHERE [Ma_Dau_Sach]=@MaDS; " +
                                     "DELETE FROM DAU_SACH WHERE [Ma_Dau_Sach]=@MaDS;";

                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@MaDS", maDS);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa thành công!");
                    ShowDauSach();

                    // Xóa trắng các ô
                    txtMaDauSach.Text = "";
                    txtTenDauSach.Text = "";
                    cceTacGia.Text = "";
                    txtNamXB.Text = "";
                    txtGiaBia.Text = "";
                    txtSoTrang.Text = "";
                    cboLoaiSach.SelectedIndex = -1;
                    cboChuDe.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa (Có thể do ràng buộc khóa ngoại): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            cceTacGia.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";
            cboLoaiSach.SelectedIndex = -1;
            cboChuDe.SelectedIndex = -1;
            cceTacGia.EditValue = null;
            btnHuy.Visible = false;

            btnSua.Text = "Sửa";
            btnThem.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            MessageBox.Show("Đã hủy thao tác Thêm/Sửa");
        }
        private void CceTacGia_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (var frm = new FrmThemTacGia()) // Giả sử form này để thêm mới
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTatCaTacGiaVaoDropDown(); // Reload DataSource
                    }
                }
            }
            
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
                ShowDauSach(); // load lại dữ liệu mới từ SQL
                if (dgvDSDauSach.Rows.Count > 0)
                {
                    dgvDSDauSach.CurrentCell = dgvDSDauSach.Rows[0].Cells[0];
                    NapCT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            dv.RowFilter = $"[TenDauSach] like '%{searchText}%'";
        }

        private void lblDauSach_Click(object sender, EventArgs e)
        {

        }

        private void panelRoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cceTacGia_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
