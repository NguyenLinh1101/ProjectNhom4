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
    public partial class frmChuDe : Form
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        public frmChuDe()
        {
            InitializeComponent();
        }

        private void lblChuDe_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvChuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChuDe.SelectedRows.Count == 0)
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

                        string sql = "DELETE FROM CHU_DE WHERE Ma_CD = @MaChuDe";

                        foreach (DataGridViewRow row in dgvChuDe.SelectedRows)
                        {
                            string maChuDe = row.Cells["MaChuDe"].Value.ToString();

                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@MaChuDe", maChuDe);

                            int kq = cmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                successCount++;
                            }
                        }

                        MessageBox.Show($"Xóa thành công {successCount} bản ghi.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadChuDe();
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
            if (string.IsNullOrEmpty(selectedMaChuDe))
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
                    string sql = "UPDATE CHU_DE SET Ten_CD = @TenChuDe WHERE Ma_CD = @MaChuDe";

                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@TenChuDe", txtTenChuDe.Text);
                    cmd.Parameters.AddWithValue("@MaChuDe", selectedMaChuDe);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChuDe();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChuDe.Text))
            {
                MessageBox.Show("Vui lòng nhấn 'Làm mới' để tạo mã trước khi thêm.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có phải mã đang chọn (đã tồn tại) không
            if (txtMaChuDe.Text == selectedMaChuDe)
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
                    string sql = "INSERT INTO CHU_DE (Ma_Chu_De, Ten_Chu_De) VALUES (@MaCD, @TenCD)";
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@MaCD", txtMaChuDe.Text);
                    cmd.Parameters.AddWithValue("@TenCD", txtTenChuDe.Text);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công bản ghi", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadChuDe();
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
                    txtMaChuDe.Text = GenerateNewMaChuDe();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dv == null) return;
            string filterText = txtSearch.Text.Replace("'", "''");
            dv.RowFilter = $"TenChuDe LIKE '%{filterText}%'";
        }
        private string GenerateNewMaChuDe()
        {
            string nextID = "CD001"; // ID mặc định nếu bảng trống
            string prefix = "CD";    // Tiền tố của mã
            int idLength = 3;      // Chiều dài phần số

            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    // Tìm mã lớn nhất hiện tại
                    string sql = "SELECT MAX(Ma_Chu_De) FROM CHU_DE";
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
        private void LoadChuDe()
        {
            try
            {
                this.dgvChuDe.SelectionChanged -= new System.EventHandler(this.dgvChuDe_SelectionChanged);

                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT Ma_Chu_De AS MaChuDe, Ten_Chu_De AS TenChuDe FROM CHU_DE";
                    adapter = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dv = new DataView(dt);
                    dgvChuDe.DataSource = dv;
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
                this.dgvChuDe.SelectionChanged += new System.EventHandler(this.dgvChuDe_SelectionChanged);

                // SỬA: Và gọi NapCT() một lần để hiển thị dòng đầu tiên
                NapCT();
            }
        }
        private string selectedMaChuDe;
        private void NapCT()
        {
            if (dgvChuDe.CurrentRow != null &&
        dgvChuDe.CurrentRow.Index >= 0 &&
        !dgvChuDe.CurrentRow.IsNewRow)
            {
                int i = dgvChuDe.CurrentRow.Index;

                // SỬA: Lấy giá trị ra biến object trước để kiểm tra null
                object maValue = dgvChuDe.Rows[i].Cells["MaChuDe"].Value;
                object tenValue = dgvChuDe.Rows[i].Cells["TenChuDe"].Value;

                // SỬA: Chỉ gán giá trị nếu nó không null
                if (maValue != null && maValue != DBNull.Value)
                {
                    selectedMaChuDe = maValue.ToString();
                    txtMaChuDe.Text = selectedMaChuDe;

                    // (Textbox Mã của bạn nên được set ReadOnly=true trong hàm Form_Load)

                    txtTenChuDe.Text = (tenValue != null) ? tenValue.ToString() : "";
                }
            }
            else
            {
                // Nếu người dùng chọn hàng mới hoặc mất focus,
                // chúng ta nên xóa các trường nhập liệu
                selectedMaChuDe = null;
                txtMaChuDe.Text = "";
                txtTenChuDe.Text = "";
            }
        }
        private void txtChuDe_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void frmChuDe_Load(object sender, EventArgs e)
        {
            dgvChuDe.ColumnHeadersDefaultCellStyle.Font = new Font(dgvChuDe.Font, FontStyle.Bold);

            txtMaChuDe.ReadOnly = true;
            txtMaChuDe.BackColor = System.Drawing.Color.Gainsboro; // Cho người dùng biết là bị khóa

            LoadChuDe();
        }

        private void dgvChuDe_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtMaChuDe.Text = GenerateNewMaChuDe();


            txtTenChuDe.Text = "";
            selectedMaChuDe = null;
            txtTenChuDe.Focus();
        }
    }
}
