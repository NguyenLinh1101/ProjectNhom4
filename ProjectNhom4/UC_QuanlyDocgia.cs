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
        string strCon = @"Data Source=LANNHI\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        string selectedMa_Doc_Gia; // Di chuyển lên đây để dùng chung

        public UC_QuanlyDocGia()
        {
            InitializeComponent();
        }

        private void UC_QuanlyDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGia(); // Tải dữ liệu khi UserControl được load
            NapCT();      // Nạp chi tiết cho dòng đầu tiên
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

        private void NapCT()
        {
            if (dgvDocGia.CurrentCell != null && dgvDocGia.CurrentCell.RowIndex >= 0)
            {
                int i = dgvDocGia.CurrentRow.Index;
                DataRowView rowView = dv[i]; 

                selectedMa_Doc_Gia = rowView["Ma_Doc_Gia"]?.ToString() ?? string.Empty;

                // Gán dữ liệu vào textbox
                txtMaDocGia.Text = selectedMa_Doc_Gia;
                txtMaDocGia.Enabled = false; // Mã độc giả không nên cho sửa
                txtMaTheMuon.Text = rowView["Ma_The"]?.ToString() ?? string.Empty;
                txtMaTheMuon.Enabled = false; // Mã thẻ mượn không nên cho sửa
                txtHoTen.Text = rowView["Ho_Ten"]?.ToString() ?? string.Empty;
                txtEmail.Text = rowView["Email"]?.ToString() ?? string.Empty;
                txtSDT.Text = rowView["SDT"]?.ToString() ?? string.Empty;

                txtNgheNghiep.Text = rowView["Loai_Doc_Gia"]?.ToString() ?? string.Empty;


                object ngayCap = rowView["Ngay_Cap"];
                object ngayHetHan = rowView["Ngay_Het_Han"];
                dtpNgaySinh.Value = Convert.ToDateTime(rowView["Ngay_Sinh"] ?? DateTime.Now);
                dtpNgayCapThe.Value = (ngayCap == DBNull.Value || ngayCap == null) ? DateTime.Now : Convert.ToDateTime(ngayCap);
                dtpNgayHetHan.Value = (ngayHetHan == DBNull.Value || ngayHetHan == null) ? DateTime.Now : Convert.ToDateTime(ngayHetHan);

                LoadImageFromPath(rowView["Anh_Chan_Dung"]);
            }
            else
            {
                // Xóa trắng form nếu không có dòng nào được chọn
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
            txtMaTheMuon.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtNgheNghiep.Text = "";
            dtpNgayCapThe.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;
            picDocGia.Image = Properties.Resources.user;
            picDocGia.ImageLocation = null;
            selectedMa_Doc_Gia = null;
            txtMaTheMuon.Enabled = true;
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm(); // Xóa trắng form

            // Tạo mã độc giả mới
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT MAX(Ma_Doc_Gia) FROM DocGia";
                    cmd = new SqlCommand(sql, con);
                    object rs = cmd.ExecuteScalar();
                    if (rs != DBNull.Value && rs != null)
                    {
                        string maTheMuon = rs.ToString();
                        // Lấy phần số (ví dụ: 'DG0019' -> '0019')
                        int number = int.Parse(maTheMuon.Substring(2));
                        ++number;
                        // Định dạng D4 cho 4 chữ số (ví dụ: DG0020)
                        txtMaTheMuon.Text = "DG" + number.ToString("D4");
                    }
                    else
                    {
                        txtMaTheMuon.Text = "DG0001"; // Nếu là bản ghi đầu tiên
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã độc giả mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTheMuon.Text = "DG"; // Cho phép người dùng tự nhập
            }

            txtMaTheMuon.Enabled = true; // Cho phép nhập mã nếu muốn
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTheMuon.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
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
                        // Lấy đường dẫn ảnh từ ImageLocation
                        string anhChanDungPath = picDocGia.ImageLocation;
                        string ngayCap = dtpNgayCapThe.Value.ToString("yyyy-MM-dd");
                        string ngayHan = dtpNgayHetHan.Value.ToString("yyyy-MM-dd");

                        // Thêm vào bảng DocGia
                        // Đã sửa lại tên cột cho đúng schema: Anh_Chan_Dung, SDT, Loai_Doc_Gia
                        string sqlDocGia = @"INSERT INTO DOC_GIA 
                            (Ma_Doc_Gia, Ho_Ten, Anh_Chan_Dung, Email, SDT, Loai_Doc_Gia)
                            VALUES (@Ma_Doc_Gia, @HoTen, @Anh_Chan_Dung, @Email, @SDT, @Loai_Doc_Gia)";

                        using (SqlCommand cmdDocGia = new SqlCommand(sqlDocGia, con, trans))
                        {
                            cmdDocGia.Parameters.AddWithValue("@Ma_Doc_Gia", txtMaTheMuon.Text.Trim());
                            cmdDocGia.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                            cmdDocGia.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmdDocGia.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                            // Giả định: txtNgheNghiep là control để nhập Loai_Doc_Gia
                            cmdDocGia.Parameters.AddWithValue("@Loai_Doc_Gia", txtNgheNghiep.Text.Trim());
                            // Lưu đường dẫn (string), nếu không có ảnh thì lưu DBNull
                            cmdDocGia.Parameters.AddWithValue("@Anh_Chan_Dung", (object)anhChanDungPath ?? DBNull.Value);

                            cmdDocGia.ExecuteNonQuery();
                        }

                        // Thêm vào bảng TheDocGia
                        // Đã sửa lại tên cột: Ngay_Cap, Ngay_Het_Han
                        string sqlThe = @"INSERT INTO THE_DOC_GIA (Ma_Doc_Gia, Ngay_Cap, Ngay_Het_Han, Trang_Thai_The)
                                          VALUES (@Ma_Doc_Gia, @Ngay_Cap, @Ngay_Het_Han, @TrangThai)";

                        using (SqlCommand cmdThe = new SqlCommand(sqlThe, con, trans))
                        {
                            cmdThe.Parameters.AddWithValue("@Ma_Doc_Gia", txtMaTheMuon.Text.Trim());
                            cmdThe.Parameters.AddWithValue("@Ngay_Cap", ngayCap);
                            cmdThe.Parameters.AddWithValue("@Ngay_Het_Han", ngayHan);
                            cmdThe.Parameters.AddWithValue("@TrangThai", "Còn hạn"); // Mặc định khi tạo mới

                            cmdThe.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Thêm mới độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Tải lại dữ liệu và chọn dòng vừa thêm
                LoadDocGia();
                int lastRowIndex = dgvDocGia.RowCount - 1;
                if (lastRowIndex >= 0)
                {
                    dgvDocGia.ClearSelection();
                    dgvDocGia.CurrentCell = dgvDocGia.Rows[lastRowIndex].Cells[0];
                    dgvDocGia.FirstDisplayedScrollingRowIndex = lastRowIndex;
                }
                NapCT();
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

            int currentIndex = dgvDocGia.CurrentRow.Index;

            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // ====== 1. Cập nhật bảng DOC_GIA ======
                    // Lấy đường dẫn ảnh (string) từ ImageLocation
                    string anhChanDungPath = picDocGia.ImageLocation;

                    // Sửa tên cột: Loai_Doc_Gia, Anh_Chan_Dung
                    string sqlDocGia = @"UPDATE DOC_GIA 
                                       SET Ho_Ten = @HoTen, Email = @Email, SDT = @SDT, 
                                           Loai_Doc_Gia = @LoaiDocGia, Anh_Chan_Dung = @AnhChanDung 
                                       WHERE Ma_Doc_Gia = @MaDocGia";

                    using (SqlCommand cmdDG = new SqlCommand(sqlDocGia, con, transaction))
                    {
                        cmdDG.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmdDG.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmdDG.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        // Giả định: txtNgheNghiep là control để nhập Loai_Doc_Gia
                        cmdDG.Parameters.AddWithValue("@LoaiDocGia", txtNgheNghiep.Text);
                        cmdDG.Parameters.AddWithValue("@AnhChanDung", (object)anhChanDungPath ?? DBNull.Value);
                        cmdDG.Parameters.AddWithValue("@MaDocGia", selectedMa_Doc_Gia);
                        cmdDG.ExecuteNonQuery();
                    }

                    // ====== 2. Cập nhật bảng THE_DOC_GIA ======
                    string ngayCap = dtpNgayCapThe.Value.ToString("yyyy-MM-dd");
                    string ngayHetHan = dtpNgayHetHan.Value.ToString("yyyy-MM-dd");

                    // Tên cột Ngay_Cap, Ngay_Het_Han đã đúng
                    string sqlThe = @"UPDATE THE_DOC_GIA 
                                    SET Ngay_Cap = @NgayCap, Ngay_Het_Han = @NgayHetHan 
                                    WHERE Ma_Doc_Gia = @MaDocGia";

                    using (SqlCommand cmdThe = new SqlCommand(sqlThe, con, transaction))
                    {
                        cmdThe.Parameters.AddWithValue("@NgayCap", ngayCap);
                        cmdThe.Parameters.AddWithValue("@NgayHetHan", ngayHetHan);
                        cmdThe.Parameters.AddWithValue("@MaDocGia", selectedMa_Doc_Gia);

                        // Kiểm tra xem bản ghi THE_DOC_GIA đã tồn tại chưa
                        int rowsAffected = cmdThe.ExecuteNonQuery();

                        // Nếu chưa tồn tại (rowsAffected = 0) thì tạo mới
                        if (rowsAffected == 0)
                        {
                            string sqlInsertThe = @"INSERT INTO THE_DOC_GIA (Ma_Doc_Gia, Ngay_Cap, Ngay_Het_Han, Trang_Thai_The)
                                                    VALUES (@Ma_Doc_Gia, @Ngay_Cap, @Ngay_Het_Han, @TrangThai)";
                            using (SqlCommand cmdInsertThe = new SqlCommand(sqlInsertThe, con, transaction))
                            {
                                cmdInsertThe.Parameters.AddWithValue("@Ma_Doc_Gia", selectedMa_Doc_Gia);
                                cmdInsertThe.Parameters.AddWithValue("@Ngay_Cap", ngayCap);
                                cmdInsertThe.Parameters.AddWithValue("@Ngay_Het_Han", ngayHetHan);
                                cmdInsertThe.Parameters.AddWithValue("@TrangThai", "Còn hạn");
                                cmdInsertThe.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDocGia();
            if (currentIndex >= 0 && currentIndex < dgvDocGia.RowCount)
            {
                dgvDocGia.ClearSelection();
                dgvDocGia.CurrentCell = dgvDocGia.Rows[currentIndex].Cells[0];
                dgvDocGia.FirstDisplayedScrollingRowIndex = currentIndex;
            }
            NapCT();
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
    }
}