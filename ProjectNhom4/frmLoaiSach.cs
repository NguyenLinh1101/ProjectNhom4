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
    public partial class frmLoaiSach : Form
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool isAdding = false;
        public frmLoaiSach()
        {
            InitializeComponent();
        }
        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            dgvLoaiSach.ColumnHeadersDefaultCellStyle.Font = new Font(dgvLoaiSach.Font, FontStyle.Bold);
            dgvLoaiSach.AutoGenerateColumns = false; // Tắt tự tạo cột
            ShowData();
            SetControlState("Normal");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dv == null) return;
            string filterText = txtSearch.Text.Replace("'", "''");
            dv.RowFilter = $"TenLoaiSach LIKE '%{filterText}%'";
        }
        private void SetControlState(string state)
        {
            switch (state)
            {
                case "Normal": // Trạng thái xem
                    groupBox1.Enabled = false; // Khóa toàn bộ GroupBox
                    txtMaLoaiSach.ReadOnly = true;

                    btnNew.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case "Editing": // Trạng thái Thêm/Sửa
                    groupBox1.Enabled = true; // Mở khóa GroupBox
                    txtMaLoaiSach.ReadOnly = true; // Nhưng Mã vẫn luôn khóa

                    btnNew.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }
        private void ClearForm()
        {
            txtMaLoaiSach.Text = "";
            txtTenLoaiSach.Text = "";
        }
        private void ShowData() // Đổi tên từ LoadLoaiSach
        {
            try
            {
                this.dgvLoaiSach.SelectionChanged -= new System.EventHandler(this.dgvLoaiSach_SelectionChanged);

                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT Ma_TL AS MaLoaiSach, Ten_TL AS TenLoaiSach FROM THE_LOAI";
                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dv = new DataView(dt);
                    dgvLoaiSach.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.dgvLoaiSach.SelectionChanged += new System.EventHandler(this.dgvLoaiSach_SelectionChanged);
                NapCT();
            }
        }
        private string TaoMaLS() // Đổi tên từ GenerateNewMaLoaiSach
        {
            string nextID = "TL0001"; // Sửa: Mã phải khớp với CSDL (TL)
            string prefix = "TL";    // Sửa: Tiền tố là TL
            int idLength = 4;        // Sửa: Chiều dài số là 4 (ví dụ: TL0001)

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT MAX(Ma_TL) FROM THE_LOAI WHERE Ma_TL LIKE 'TL%'";
                    cmd = new SqlCommand(sql, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string lastID = result.ToString();
                        string numberPart = lastID.Substring(prefix.Length);
                        int lastNumber = int.Parse(numberPart);
                        int nextNumber = lastNumber + 1;

                        nextID = prefix + nextNumber.ToString("D" + idLength);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sinh mã mới: " + ex.Message, "Lỗi",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nextID;
        }
        private void LoadLoaiSach()
        {
            try
            {
                this.dgvLoaiSach.SelectionChanged -= new System.EventHandler(this.dgvLoaiSach_SelectionChanged);

                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT Ma_TL AS MaLoaiSach, Ten_TL AS TenLoaiSach FROM THE_LOAI";
                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dv = new DataView(dt);
                    dgvLoaiSach.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // SỬA: Gắn lại sự kiện sau khi tải xong
                this.dgvLoaiSach.SelectionChanged += new System.EventHandler(this.dgvLoaiSach_SelectionChanged);

                // SỬA: Và gọi NapCT() một lần để hiển thị dòng đầu tiên
                NapCT();
            }
        }
        private string selectedMaLoaiSach;
        private void NapCT()
        {
            if (dgvLoaiSach.CurrentRow != null && dv != null && dgvLoaiSach.CurrentRow.Index < dv.Count)
            {
                try
                {
                    int i = dgvLoaiSach.CurrentRow.Index;
                    DataRowView rowView = dv[i];

                    txtMaLoaiSach.Text = rowView["MaLoaiSach"]?.ToString() ?? "";
                    txtTenLoaiSach.Text = rowView["TenLoaiSach"]?.ToString() ?? "";
                }
                catch (Exception) { /* Bỏ qua lỗi */ }
            }
            else
            {
                ClearForm();
            }
        }

        private void dgvLoaiSach_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                NapCT();
                SetControlState("Normal");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearForm();
            txtMaLoaiSach.Text = TaoMaLS();
            SetControlState("Editing");
            txtTenLoaiSach.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiSach.Text))
            {
                MessageBox.Show("Tên loại sách không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiSach.Focus();
                return;
            }

            string maTL = txtMaLoaiSach.Text;
            string tenTL = txtTenLoaiSach.Text;

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql;

                    if (isAdding) // Logic THÊM MỚI
                    {
                        sql = "INSERT INTO THE_LOAI (Ma_TL, Ten_TL) VALUES (@MaTL, @TenTL)";
                    }
                    else // Logic SỬA
                    {
                        sql = "UPDATE THE_LOAI SET Ten_TL = @TenTL WHERE Ma_TL = @MaTL";
                    }

                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaTL", maTL);
                    cmd.Parameters.AddWithValue("@TenTL", tenTL);
                    cmd.ExecuteNonQuery();

                    string msg = isAdding ? "Thêm loại sách thành công." : "Cập nhật loại sách thành công.";
                    MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData(); // Tải lại lưới
                    SetControlState("Normal"); // Trả về trạng thái xem
                    isAdding = false; // Reset cờ
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi trùng khóa chính
                {
                    MessageBox.Show("Lỗi: Mã loại sách này đã tồn tại!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaLoaiSach.Text = TaoMaLS();
                }
                else
                {
                    MessageBox.Show("Lỗi SQL khi lưu: " + ex.Message, "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rs = MessageBox.Show($"Bạn có chắc chắn muốn xóa {dgvLoaiSach.SelectedRows.Count} bản ghi đã chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                List<string> maDeXoa = new List<string>();
                foreach (DataGridViewRow row in dgvLoaiSach.SelectedRows)
                {
                    maDeXoa.Add(row.Cells["MaLoaiSach"].Value.ToString());
                }

                try
                {
                    using (con = new SqlConnection(strCon))
                    {
                        con.Open();

                        List<string> paramNames = new List<string>();
                        cmd = new SqlCommand();
                        cmd.Connection = con;

                        for (int i = 0; i < maDeXoa.Count; i++)
                        {
                            string paramName = "@p" + i;
                            paramNames.Add(paramName);
                            cmd.Parameters.AddWithValue(paramName, maDeXoa[i]);
                        }

                        // Sửa tên cột CSDL
                        string sql = $"DELETE FROM THE_LOAI WHERE Ma_TL IN ({string.Join(", ", paramNames)})";
                        cmd.CommandText = sql;

                        int kq = cmd.ExecuteNonQuery();

                        MessageBox.Show($"Xóa thành công {kq} bản ghi.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ShowData(); // Sửa: Gọi ShowData() thay vì LoadLoaiSach()
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Lỗi: Không thể xóa vì loại sách này đang được sử dụng ở bảng Đầu Sách.", "Lỗi Ràng Buộc",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL khi xóa: " + ex.Message, "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSach.CurrentRow == null || string.IsNullOrEmpty(txtMaLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng chọn một loại sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetControlState("Editing");
            txtTenLoaiSach.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            NapCT();
            SetControlState("Normal");
        }
    }
}
