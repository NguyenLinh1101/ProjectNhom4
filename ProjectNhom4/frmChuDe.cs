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
        string strCon = "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool isAdding = false;
        public frmChuDe()
        {
            InitializeComponent();
        }
            private void SetControlState(string state)
        {
            switch (state)
            {
                case "Normal": // Trạng thái xem
                    groupBox1.Enabled = false; // Khóa toàn bộ GroupBox (Giả sử tên là groupBox1)
                    txtMaChuDe.ReadOnly = true;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case "Editing": // Trạng thái Thêm/Sửa
                    groupBox1.Enabled = true; // Mở khóa GroupBox
                    txtMaChuDe.ReadOnly = true; // Nhưng Mã vẫn luôn khóa

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }
        private void ClearForm()
        {
            txtMaChuDe.Text = "";
            txtTenChuDe.Text = "";
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

            DialogResult rs = MessageBox.Show($"Bạn có chắc chắn muốn xóa {dgvChuDe.SelectedRows.Count} bản ghi đã chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                List<string> maDeXoa = new List<string>();
                foreach (DataGridViewRow row in dgvChuDe.SelectedRows)
                {
                    maDeXoa.Add(row.Cells["MaChuDe"].Value.ToString());
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

                        string sql = $"DELETE FROM CHU_DE WHERE Ma_Chu_De IN ({string.Join(", ", paramNames)})";
                        cmd.CommandText = sql;

                        int kq = cmd.ExecuteNonQuery();

                        MessageBox.Show($"Xóa thành công {kq} bản ghi.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadChuDe();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Lỗi: Không thể xóa vì chủ đề này đang được sử dụng ở bảng Đầu Sách.", "Lỗi Ràng Buộc",
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
            if (dgvChuDe.CurrentRow == null || string.IsNullOrEmpty(txtMaChuDe.Text))
            {
                MessageBox.Show("Vui lòng chọn một chủ đề để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetControlState("Editing");
            txtTenChuDe.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenChuDe.Text))
    {
        MessageBox.Show("Tên chủ đề không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtTenChuDe.Focus();
        return;
    }

    string maCD = txtMaChuDe.Text;
    string tenCD = txtTenChuDe.Text;

    try
    {
        using (con = new SqlConnection(strCon))
        {
            con.Open();
            string sql;
            
            // Kiểm tra cờ isAdding
            if (isAdding) // Logic THÊM MỚI
            {
                sql = "INSERT INTO CHU_DE (Ma_Chu_De, Ten_Chu_De) VALUES (@MaCD, @TenCD)";
            }
            else // Logic SỬA
            {
                sql = "UPDATE CHU_DE SET Ten_Chu_De = @TenCD WHERE Ma_Chu_De = @MaCD";
            }

            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MaCD", maCD);
            cmd.Parameters.AddWithValue("@TenCD", tenCD);
            cmd.ExecuteNonQuery();
            
            string msg = isAdding ? "Thêm chủ đề thành công." : "Cập nhật chủ đề thành công.";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LoadChuDe(); // Tải lại lưới
            SetControlState("Normal"); // Trả về trạng thái xem
            isAdding = false; // Reset cờ
        }
    }
    catch (SqlException ex)
    {
        if (ex.Number == 2627) // Lỗi trùng khóa chính
        {
            MessageBox.Show("Lỗi: Mã chủ đề này đã tồn tại!", "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtMaChuDe.Text = GenerateNewMaChuDe();
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
            int idLength = 3;        // Chiều dài phần số

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

                        // SỬA LỖI CÚ PHÁP TẠI ĐÂY
                        nextID = prefix + nextNumber.ToString("D" + idLength);
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
                // 1. TẮT sự kiện đi
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
                // 2. GẮN LẠI sự kiện
                this.dgvChuDe.SelectionChanged += new System.EventHandler(this.dgvChuDe_SelectionChanged);

                // 3. Nạp dòng đầu tiên
                NapCT();
            }
        }
        private string selectedMaChuDe;
        private void NapCT()
        {
            if (dgvChuDe.CurrentRow != null && dv != null && dgvChuDe.CurrentRow.Index < dv.Count)
            {
                try
                {
                    int i = dgvChuDe.CurrentRow.Index;
                    DataRowView rowView = dv[i];

                    txtMaChuDe.Text = rowView["MaChuDe"]?.ToString() ?? "";
                    txtTenChuDe.Text = rowView["TenChuDe"]?.ToString() ?? "";

                    // Lưu lại mã đang chọn (nếu cần cho logic Sửa)
                    selectedMaChuDe = txtMaChuDe.Text;
                }
                catch (Exception) { /* Bỏ qua lỗi */ }
            }
            else
            {
                ClearForm();
                selectedMaChuDe = null;
            }
        }
        private void txtChuDe_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void frmChuDe_Load(object sender, EventArgs e)
        {
            dgvChuDe.ColumnHeadersDefaultCellStyle.Font = new Font(dgvChuDe.Font, FontStyle.Bold);
            dgvChuDe.AutoGenerateColumns = false; 
            LoadChuDe();
            SetControlState("Normal"); 
        }

        private void dgvChuDe_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                NapCT();
                SetControlState("Normal");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearForm();
            txtMaChuDe.Text = GenerateNewMaChuDe();
            SetControlState("Editing");
            txtTenChuDe.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            NapCT();
            SetControlState("Normal");
        }
    }
}
