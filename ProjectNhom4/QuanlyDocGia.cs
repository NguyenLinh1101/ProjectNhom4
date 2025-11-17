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
    public partial class UC_QuanlyDocGia : UserControl
    {
        // Đảm bảo chuỗi kết nối của bạn là chính xác
        string strCon = "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        string selectedMa_Doc_Gia; 
        private bool isAdding = false;
        public UC_QuanlyDocGia()
        {
            InitializeComponent();
        }

        private void UC_QuanlyDocGia_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadDocGia(); // Tải dữ liệu khi UserControl được load
            NapCT();      // Nạp chi tiết cho dòng đầu tiên
            SetControlState("Normal");
        }

        private void LoadDocGia()
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();

                    string sql = @"
                        SELECT 
                            dg.Ma_Doc_Gia, dg.Ho_Ten, dg.Ngay_Sinh, dg.Loai_Doc_Gia, 
                            dg.Ma_Lop, dg.Ma_Khoa_Vien, dg.SDT, dg.Email, 
                            dg.Dia_Chi, dg.CCCD, dg.Anh_Chan_Dung,
                            tdg.Ma_The, tdg.Ngay_Cap, tdg.Ngay_Het_Han, tdg.Trang_Thai_The
                        FROM 
                            DOC_GIA dg
                        LEFT JOIN 
                            THE_DOC_GIA tdg ON dg.Ma_Doc_Gia = tdg.Ma_Doc_Gia";

                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dv = new DataView(dt);
                    dgvDocGia.AutoGenerateColumns = false;
                    dgvDocGia.DataSource = dv;
                    

                    if (dgvDocGia.Columns["Anh_Chan_Dung"] is DataGridViewImageColumn imageCol)
                    {
                        imageCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetTextBoxReadOnly(bool readOnly)
        {
            // Các mã này LUÔN LUÔN chỉ đọc
            txtMaDocGia.ReadOnly = true;
            txtMaTheMuon.ReadOnly = true;

            // Các ô này có thể thay đổi
            txtHoTen.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtSDT.ReadOnly = readOnly;
            txtNgheNghiep.ReadOnly = readOnly;

            // Lưu ý: DateTimePicker không có .ReadOnly, chúng ta phải dùng .Enabled
            dtpNgaySinh.Enabled = !readOnly;
            dtpNgayCapThe.Enabled = !readOnly;
            dtpNgayHetHan.Enabled = !readOnly;

            // Nút chọn ảnh cũng vậy
            btnChonAnh.Enabled = !readOnly;
        }
        private void NapCT()
        {
            if (dgvDocGia.CurrentCell != null && dgvDocGia.CurrentCell.RowIndex >= 0)
            {
                int i = dgvDocGia.CurrentRow.Index;

                // SỬA LỖI Ở ĐÂY: Thêm điều kiện kiểm tra xem 'i' có nằm trong phạm vi của 'dv' không
                if (dv != null && i < dv.Count)
                {
                    DataRowView rowView = dv[i]; // This line is now safe

                    selectedMa_Doc_Gia = rowView["Ma_Doc_Gia"]?.ToString() ?? string.Empty;

                    // Gán dữ liệu vào textbox
                    txtMaDocGia.Text = selectedMa_Doc_Gia;
                    txtMaTheMuon.Text = rowView["Ma_The"]?.ToString() ?? string.Empty;
                    txtHoTen.Text = rowView["Ho_Ten"]?.ToString() ?? string.Empty;
                    txtEmail.Text = rowView["Email"]?.ToString() ?? string.Empty;
                    txtSDT.Text = rowView["SDT"]?.ToString() ?? string.Empty;
                    txtNgheNghiep.Text = rowView["Loai_Doc_Gia"]?.ToString() ?? string.Empty;

                    // Sửa logic kiểm tra DBNull cho an toàn hơn
                    object ngaySinh = rowView["Ngay_Sinh"];
                    object ngayCap = rowView["Ngay_Cap"];
                    object ngayHetHan = rowView["Ngay_Het_Han"];

                    dtpNgaySinh.Value = (ngaySinh == DBNull.Value || ngaySinh == null) ? DateTime.Now : Convert.ToDateTime(ngaySinh);
                    dtpNgayCapThe.Value = (ngayCap == DBNull.Value || ngayCap == null) ? DateTime.Now : Convert.ToDateTime(ngayCap);
                    dtpNgayHetHan.Value = (ngayHetHan == DBNull.Value || ngayHetHan == null) ? DateTime.Now : Convert.ToDateTime(ngayHetHan);

                    LoadImageFromPath(rowView["Anh_Chan_Dung"]);

                    SetTextBoxReadOnly(true);
                }
                else
                {
                    // Nếu chỉ số không hợp lệ (ví dụ: vừa bị xóa), thì xóa trắng form
                    ClearForm();
                }
            }
            else
            {
                // Không có ô nào được chọn, xóa trắng form
                ClearForm();
            }
        }

        private void LoadImageFromPath(object pathData)
        {
            try
            {
                if (pathData != null && pathData != DBNull.Value)
                {
                    string path = pathData.ToString();
                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        // Tải ảnh từ file và lưu đường dẫn
                        picDocGia.Image = Image.FromFile(path);
                        picDocGia.ImageLocation = path;
                    }
                    else
                    {
                        // Đường dẫn không hợp lệ hoặc file không tồn tại
                        picDocGia.Image = Properties.Resources.user;
                        picDocGia.ImageLocation = null;
                    }
                }
                else
                {
                    // Giá trị là NULL
                    picDocGia.Image = Properties.Resources.user;
                    picDocGia.ImageLocation = null;
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu file ảnh bị hỏng hoặc không đọc được
                picDocGia.Image = Properties.Resources.user;
                picDocGia.ImageLocation = null;
            }
        }

        private void ClearForm()
        {
            txtMaDocGia.Text = "";
            txtMaTheMuon.Text = "";

            // Xóa các ô Text
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtNgheNghiep.Text = "";

            // Đặt lại ngày
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayCapThe.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;

            // Đặt lại ảnh
            picDocGia.Image = Properties.Resources.user;
            picDocGia.ImageLocation = null;

            selectedMa_Doc_Gia = null;

            // Luôn khóa các ô mã, ngay cả trong ClearForm
            txtMaDocGia.Enabled = false;
            txtMaTheMuon.Enabled = false;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            openFile.Title = "Chọn ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Tải ảnh vào PictureBox và LƯU LẠI ĐƯỜNG DẪN
                picDocGia.Image = Image.FromFile(openFile.FileName);
                picDocGia.ImageLocation = openFile.FileName;
            }
        }

        private void dgvDocGia_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();

            SetControlState("Normal");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true; // Báo cho chương trình biết là đang Thêm
            ClearForm();     // Gọi hàm ClearForm() (đã sửa ở trên)

            string newMaDocGia = "";
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT MAX(Ma_Doc_Gia) FROM DOC_GIA";
                    cmd = new SqlCommand(sql, con);
                    object rs = cmd.ExecuteScalar();
                    if (rs != DBNull.Value && rs != null)
                    {
                        string maHienTai = rs.ToString();
                        int number = int.Parse(maHienTai.Substring(2));
                        ++number;
                        newMaDocGia = "DG" + number.ToString("D4");
                    }
                    else
                    {
                        newMaDocGia = "DG0001";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã độc giả mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gán mã mới vào ô Mã Độc Giả (ô này đã bị khóa)
            txtMaDocGia.Text = newMaDocGia;

            SetControlState("Editing"); // Chuyển sang trạng thái "Sửa" (các ô sáng lên)
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã độc giả và Họ tên không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();

                    try
                    {
                        string anhChanDungPath = picDocGia.ImageLocation;
                        string ngayCap = dtpNgayCapThe.Value.ToString("yyyy-MM-dd");
                        string ngayHan = dtpNgayHetHan.Value.ToString("yyyy-MM-dd");
                        string maDocGia = txtMaDocGia.Text.Trim();

                        if (isAdding) // === NẾU LÀ THÊM MỚI ===
                        {
                            // 1. Thêm vào bảng DocGia
                            string sqlDocGia = @"INSERT INTO DOC_GIA 
                                (Ma_Doc_Gia, Ho_Ten, Ngay_Sinh, Anh_Chan_Dung, Email, SDT, Loai_Doc_Gia)
                                VALUES (@Ma_Doc_Gia, @HoTen, @NgaySinh, @Anh_Chan_Dung, @Email, @SDT, @Loai_Doc_Gia)";

                            using (SqlCommand cmdDocGia = new SqlCommand(sqlDocGia, con, trans))
                            {
                                cmdDocGia.Parameters.AddWithValue("@Ma_Doc_Gia", maDocGia);
                                cmdDocGia.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                                cmdDocGia.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                                cmdDocGia.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                cmdDocGia.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                                cmdDocGia.Parameters.AddWithValue("@Loai_Doc_Gia", txtNgheNghiep.Text.Trim());
                                cmdDocGia.Parameters.AddWithValue("@Anh_Chan_Dung", (object)anhChanDungPath ?? DBNull.Value);
                                cmdDocGia.ExecuteNonQuery();
                            }

                            // 2. Thêm vào bảng TheDocGia
                            string newMaThe = "T" + maDocGia.Substring(2); // Tạo mã thẻ mới (T0020)
                            txtMaTheMuon.Text = newMaThe;

                            string sqlThe = @"INSERT INTO THE_DOC_GIA (Ma_The, Ma_Doc_Gia, Ngay_Cap, Ngay_Het_Han, Trang_Thai_The)
                                    VALUES (@Ma_The, @Ma_Doc_Gia, @Ngay_Cap, @Ngay_Het_Han, @TrangThai)";

                            using (SqlCommand cmdThe = new SqlCommand(sqlThe, con, trans))
                            {
                                cmdThe.Parameters.AddWithValue("@Ma_The", newMaThe);
                                cmdThe.Parameters.AddWithValue("@Ma_Doc_Gia", maDocGia);
                                cmdThe.Parameters.AddWithValue("@Ngay_Cap", ngayCap);
                                cmdThe.Parameters.AddWithValue("@Ngay_Het_Han", ngayHan);
                                cmdThe.Parameters.AddWithValue("@TrangThai", "Còn hạn");
                                cmdThe.ExecuteNonQuery();
                            }
                            MessageBox.Show("Thêm mới độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // === NẾU LÀ SỬA ===
                        {
                            // 1. Cập nhật bảng DOC_GIA
                            string sqlDocGia = @"UPDATE DOC_GIA 
                                       SET Ho_Ten = @HoTen, Ngay_Sinh = @NgaySinh, Email = @Email, SDT = @SDT, 
                                           Loai_Doc_Gia = @LoaiDocGia, Anh_Chan_Dung = @AnhChanDung 
                                       WHERE Ma_Doc_Gia = @MaDocGia";

                            using (SqlCommand cmdDG = new SqlCommand(sqlDocGia, con, trans))
                            {
                                cmdDG.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                                cmdDG.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                                cmdDG.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                                cmdDG.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                                cmdDG.Parameters.AddWithValue("@LoaiDocGia", txtNgheNghiep.Text.Trim());
                                cmdDG.Parameters.AddWithValue("@AnhChanDung", (object)anhChanDungPath ?? DBNull.Value);
                                cmdDG.Parameters.AddWithValue("@MaDocGia", maDocGia);
                                cmdDG.ExecuteNonQuery();
                            }

                            // 2. Cập nhật bảng THE_DOC_GIA
                            string sqlThe = @"UPDATE THE_DOC_GIA 
                                    SET Ngay_Cap = @NgayCap, Ngay_Het_Han = @NgayHetHan 
                                    WHERE Ma_The = @MaThe";

                            using (SqlCommand cmdThe = new SqlCommand(sqlThe, con, trans))
                            {
                                cmdThe.Parameters.AddWithValue("@NgayCap", ngayCap);
                                cmdThe.Parameters.AddWithValue("@NgayHetHan", ngayHan);
                                cmdThe.Parameters.AddWithValue("@MaThe", txtMaTheMuon.Text.Trim());
                                cmdThe.ExecuteNonQuery();
                            }
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        if (ex.Message.Contains("PRIMARY KEY constraint"))
                        {
                            MessageBox.Show("Lỗi: Mã độc giả hoặc Mã thẻ đã tồn tại.", "Lỗi Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Tải lại dữ liệu và trả về trạng thái "Normal"
                LoadDocGia();
                NapCT();
                SetControlState("Normal");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMa_Doc_Gia))
            {
                MessageBox.Show("Chưa chọn độc giả để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chỉ cần set cờ và trạng thái. Mọi logic UPDATE phải nằm trong btnLuu_Click
            isAdding = false; // Đặt cờ là đang Sửa
            SetControlState("Editing");
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMa_Doc_Gia))
            {
                MessageBox.Show("Chưa chọn bản ghi để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra ràng buộc khóa ngoại (ví dụ: trong PHIEU_MUON)
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Độc giả có thể liên kết với THE_DOC_GIA, PHIEU_MUON. 
                    // Cần kiểm tra PHIEU_MUON trước
                    string sqlCheck = "SELECT COUNT(*) FROM PHIEU_MUON pm JOIN THE_DOC_GIA tdg ON pm.Ma_The = tdg.Ma_The WHERE tdg.Ma_Doc_Gia = @MaDocGia";
                    cmd = new SqlCommand(sqlCheck, con);
                    cmd.Parameters.AddWithValue("@MaDocGia", selectedMa_Doc_Gia);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Không thể xóa độc giả này vì đã có lịch sử mượn sách. Vui lòng xóa các phiếu mượn liên quan trước.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra ràng buộc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu không có ràng buộc, tiến hành xóa
            int currentIndex = dgvDocGia.CurrentRow.Index;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?\nMọi thông tin về thẻ độc giả cũng sẽ bị xóa.",
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();
                    try
                    {
                        // 1. Xóa trong bảng Thẻ độc giả trước
                        string sqlThe = "DELETE FROM THE_DOC_GIA WHERE Ma_Doc_Gia = @MaDocGia";
                        using (SqlCommand cmdThe = new SqlCommand(sqlThe, con, trans))
                        {
                            cmdThe.Parameters.AddWithValue("@MaDocGia", selectedMa_Doc_Gia);
                            cmdThe.ExecuteNonQuery();
                        }

                        // 2. Sau đó xóa trong bảng Độc giả
                        string sqlDocGia = "DELETE FROM DOC_GIA WHERE Ma_Doc_Gia = @MaDocGia";
                        using (SqlCommand cmdDG = new SqlCommand(sqlDocGia, con, trans))
                        {
                            cmdDG.Parameters.AddWithValue("@MaDocGia", selectedMa_Doc_Gia);
                            int kq = cmdDG.ExecuteNonQuery();

                            if (kq > 0)
                            {
                                trans.Commit();
                                MessageBox.Show("Xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                trans.Rollback();
                                MessageBox.Show("Xóa bản ghi thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }

            LoadDocGia();
            int beforeRowIndex = Math.Max(0, currentIndex - 1);
            if (dgvDocGia.RowCount > 0)
            {
                dgvDocGia.ClearSelection();
                dgvDocGia.CurrentCell = dgvDocGia.Rows[beforeRowIndex].Cells[0];
                dgvDocGia.FirstDisplayedScrollingRowIndex = beforeRowIndex;
            }
            NapCT();
        }

        // ====== Các hàm còn lại (Validation, Search) ======

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dv != null)
            {
                // Lọc trên nhiều cột: Mã độc giả HOẶC Họ tên
                // Đảm bảo tên cột khớp với CSDL: Ma_Doc_Gia, Ho_Ten
                try
                {
                    dv.RowFilter = string.Format("Ma_Doc_Gia LIKE '%{0}%' OR Ho_Ten LIKE '%{0}%'", txtSearch.Text.Trim());
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu người dùng nhập ký tự đặc biệt của RowFilter
                    Console.WriteLine("Search error: " + ex.Message);
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không hợp lệ
                errorDocGia.SetError((Control)sender, "Chỉ được nhập số!");
            }
            else
            {
                errorDocGia.SetError((Control)sender, ""); // Xóa thông báo lỗi nếu nhập đúng
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                errorDocGia.SetError(txtSDT, "Số điện thoại phải có 10-11 chữ số!");
            }
            else
            {
                errorDocGia.SetError(txtSDT, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                // Dùng cách kiểm tra email nghiêm ngặt hơn
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                if (addr.Address == txtEmail.Text)
                    errorDocGia.SetError(txtEmail, ""); // Xóa lỗi nếu hợp lệ
            }
            catch
            {
                errorDocGia.SetError(txtEmail, "Email không hợp lệ! Vui lòng nhập đúng định dạng.");
            }
        }

        // Các hàm trống (label click) có thể xóa đi nếu không dùng
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblSDT_Click(object sender, EventArgs e) { }

        // Bổ sung: Xử lý khi ảnh trong DataGridView không tải được
        private void dgvDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Giả sử cột ảnh của bạn có tên là "Anh_Chan_Dung"
            if (dgvDocGia.Columns[e.ColumnIndex].Name == "Anh_Chan_Dung")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    string path = e.Value.ToString();
                    if (File.Exists(path))
                    {
                        // Tải ảnh từ đường dẫn
                        e.Value = Image.FromFile(path);
                    }
                    else
                    {
                        // Nếu file không tồn tại, dùng ảnh mặc định
                        e.Value = Properties.Resources.user;
                    }
                }
                else
                {
                    // Nếu giá trị là NULL, dùng ảnh mặc định
                    e.Value = Properties.Resources.user;
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetControlState(string state)
        {
            grbTTDG.Enabled = true;

            switch (state)
            {
                case "Normal":
                    // 1. Bật nút chức năng
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    // 2. Tắt nút lưu/hủy
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;

                    // 3. Đặt các ô text về "Chỉ Đọc"
                    SetTextBoxReadOnly(true);
                    break;

                case "Editing":
                    // 1. Tắt nút chức năng
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    // 2. Bật nút lưu/hủy
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;

                    // 3. Tắt "Chỉ Đọc" để cho phép nhập
                    SetTextBoxReadOnly(false);
                    break;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            NapCT();
            errorDocGia.Clear();
            SetControlState("Normal");
        }

        private void grbTTDG_Enter(object sender, EventArgs e)
        {

        }

        private void lblQLDG_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayHetHan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTheMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayCapThe_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}