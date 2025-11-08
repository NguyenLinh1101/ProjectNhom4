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
        public frmLoaiSach()
        {
            InitializeComponent();
        }
        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            dgvLoaiSach.ColumnHeadersDefaultCellStyle.Font = new Font(dgvLoaiSach.Font, FontStyle.Bold);

            txtMaLoaiSach.ReadOnly = true;
            txtMaLoaiSach.BackColor = System.Drawing.Color.Gainsboro; // Cho người dùng biết là bị khóa

            LoadLoaiSach();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dv == null) return; 
            string filterText = txtSearch.Text.Replace("'", "''");
            dv.RowFilter = $"TenLoaiSach LIKE '%{filterText}%'";
        }

        
        private string GenerateNewMaLoaiSach()
        {
            string nextID = "LS001"; // ID mặc định nếu bảng trống
            string prefix = "LS";    // Tiền tố của mã
            int idLength = 3;      // Chiều dài phần số

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Tìm mã lớn nhất hiện tại
                    string sql = "SELECT MAX(Ma_TL) FROM THE_LOAI";
                    cmd = new SqlCommand(sql, con);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string lastID = result.ToString(); 

                        string numberPart = lastID.Substring(prefix.Length);
                        int lastNumber = int.Parse(numberPart);

                        int nextNumber = lastNumber + 1;

                        nextID = prefix + nextNumber.ToString($"D{idLength}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sinh mã mới: " + ex.Message, "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Trả về null nếu có lỗi
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
            if (dgvLoaiSach.CurrentRow != null &&
        dgvLoaiSach.CurrentRow.Index >= 0 &&
        !dgvLoaiSach.CurrentRow.IsNewRow)
            {
                int i = dgvLoaiSach.CurrentRow.Index;

                // SỬA: Lấy giá trị ra biến object trước để kiểm tra null
                object maValue = dgvLoaiSach.Rows[i].Cells["MaLoaiSach"].Value;
                object tenValue = dgvLoaiSach.Rows[i].Cells["TenLoaiSach"].Value;

                // SỬA: Chỉ gán giá trị nếu nó không null
                if (maValue != null && maValue != DBNull.Value)
                {
                    selectedMaLoaiSach = maValue.ToString();
                    txtMaLoaiSach.Text = selectedMaLoaiSach;

                    // (Textbox Mã của bạn nên được set ReadOnly=true trong hàm Form_Load)

                    txtTenLoaiSach.Text = (tenValue != null) ? tenValue.ToString() : "";
                }
            }
            else
            {
                // Nếu người dùng chọn hàng mới hoặc mất focus,
                // chúng ta nên xóa các trường nhập liệu
                selectedMaLoaiSach = null;
                txtMaLoaiSach.Text = "";
                txtTenLoaiSach.Text = "";
            }
        }

        private void dgvLoaiSach_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaLoaiSach.Text = GenerateNewMaLoaiSach();
           

            txtTenLoaiSach.Text = "";
            selectedMaLoaiSach = null; 
            txtTenLoaiSach.Focus(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng nhấn 'Làm mới' để tạo mã trước khi thêm.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có phải mã đang chọn (đã tồn tại) không
            if (txtMaLoaiSach.Text == selectedMaLoaiSach)
            {
                MessageBox.Show("Mã này đã tồn tại, vui lòng nhấn 'Làm mới' để tạo mã mới.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "INSERT INTO THE_LOAI (Ma_TL, Ten_TL) VALUES (@MaTL, @TenTL)";
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@MaTL", txtMaLoaiSach.Text);
                    cmd.Parameters.AddWithValue("@TenTL", txtTenLoaiSach.Text);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công bản ghi", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadLoaiSach();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công bản ghi", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) 
                {
                    MessageBox.Show("Lỗi: Mã loại sách này đã tồn tại! (Có thể ai đó vừa thêm).", "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaLoaiSach.Text = GenerateNewMaLoaiSach();
                }
                else
                {
                    MessageBox.Show("Lỗi SQL khi thêm: " + ex.Message, "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
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

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa các bản ghi đã chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    using (con = new SqlConnection(strCon))
                    {
                        con.Open();
                        int successCount = 0;

                        string sql = "DELETE FROM THE_LOAI WHERE Ma_TL = @MaLoaiSach";

                        foreach (DataGridViewRow row in dgvLoaiSach.SelectedRows)
                        {
                            string maLoaiSach = row.Cells["MaLoaiSach"].Value.ToString();

                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@MaLoaiSach", maLoaiSach);

                            int kq = cmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                successCount++;
                            }
                        }

                        MessageBox.Show($"Xóa thành công {successCount} bản ghi.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadLoaiSach(); 
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Lỗi: Không thể xóa vì loại sách này đang được sử dụng ở bảng khác.", "Lỗi Ràng Buộc",
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
            if(string.IsNullOrEmpty(selectedMaLoaiSach))
            {
                MessageBox.Show("Chưa chọn bản ghi", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "UPDATE THE_LOAI SET Ten_TL = @TenLoaiSach WHERE Ma_TL = @MaLoaiSach";

                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@TenLoaiSach", txtTenLoaiSach.Text);
                    cmd.Parameters.AddWithValue("@MaLoaiSach", selectedMaLoaiSach);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLoaiSach();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công (Không tìm thấy mã)", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
