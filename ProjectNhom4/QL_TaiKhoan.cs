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
    public partial class QL_TaiKhoan : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True");
        bool isAdding = false;
        bool isEditing = false; // thêm biến này để kiểm soát chế độ sửa

        public QL_TaiKhoan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var drv = dgvTaiKhoan.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;

            // Dùng tên cột như trong SQL SELECT
            cboThuThu.Text = drv["Ten_Thu_Thu"]?.ToString();
            txtTenDN.Text = drv["TenDN"]?.ToString();
            txtMatKhau.Text = drv["MatKhau"]?.ToString();
            txtEmail.Text = drv["Email"]?.ToString();
            cboQuyen.Text = drv["Quyen"]?.ToString();
        }

        // 🔹 Load dữ liệu từ bảng THU_THU
        void LoadTaiKhoan()
        {
            try
            {
                string sql = "SELECT Ma_Thu_Thu, Ten_Thu_Thu, TenDN, MatKhau, Email, SDT, Quyen FROM THU_THU";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTaiKhoan.DataSource = dt;

                // Thêm đoạn này để gán STT (ID hiển thị)
                for (int i = 0; i < dgvTaiKhoan.Rows.Count; i++)
                {
                    dgvTaiKhoan.Rows[i].Cells["ID"].Value = i + 1;
                }

                // (nếu cần đổi tiêu đề cột)
                dgvTaiKhoan.Columns["TenDN"].HeaderText = "Tên đăng nhập";
                dgvTaiKhoan.Columns["Email"].HeaderText = "Email";
                dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
                dgvTaiKhoan.Columns["MaThuThu"].HeaderText = "Mã thủ thư";
                dgvTaiKhoan.Columns["Quyen"].HeaderText = "Quyền";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message);
            }
        }

        // 🔹 Khi chọn dòng trong DataGridView -> hiển thị lên textbox
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                // Cập nhật các textbox và combobox tương ứng
                cboThuThu.Text = row.Cells["Ten_Thu_Thu"].Value.ToString();
                txtTenDN.Text = row.Cells["TenDN"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cboQuyen.Text = row.Cells["Quyen"].Value.ToString();
            }
        }

        // 🔹 Load dữ liệu lên ComboBox Quyen
        void LoadQuyen()
        {
            cboQuyen.Items.Clear();
            cboQuyen.Items.Add("admin");
            cboQuyen.Items.Add("thuthu");
            cboQuyen.SelectedIndex = 0;
        }

        // 🔹 Load dữ liệu lên ComboBox ThuThu
        void LoadThuThu()
        {
            try
            {
                conn.Open();
                string sql = "SELECT Ma_Thu_Thu, Ten_Thu_Thu FROM THU_THU";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboThuThu.DataSource = dt;
                cboThuThu.DisplayMember = "Ten_Thu_Thu";
                cboThuThu.ValueMember = "Ma_Thu_Thu";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thủ thư: " + ex.Message);
            }
        }
        private void QL_TaiKhoan_Load(object sender, EventArgs e)
        {
            if (UserSession.Quyen != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập mục này!",
                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Parent.Controls.Remove(this);
            }
            //FixLayout();          // <<--- thêm dòng này
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadTaiKhoan();
            LoadThuThu();
            LoadQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa các ô nhập
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            cboQuyen.SelectedIndex = -1;
            cboThuThu.SelectedIndex = -1;

            // Bật chế độ THÊM
            isAdding = true;
            isEditing = false;

            MessageBox.Show("Bạn đang ở chế độ THÊM mới.");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cboThuThu.SelectedIndex == -1 ||
        string.IsNullOrWhiteSpace(txtTenDN.Text) ||
        string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd;

                // ---------------------------
                // 1) THÊM TÀI KHOẢN
                // ---------------------------
                if (isAdding)
                {
                    string sqlInsert = @"UPDATE THU_THU
                                 SET TenDN=@TenDN, MatKhau=@MatKhau, Email=@Email, Quyen=@Quyen
                                 WHERE Ma_Thu_Thu=@Ma_Thu_Thu";

                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@Ma_Thu_Thu", cboThuThu.SelectedValue);
                    cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm tài khoản!");
                }

                // ---------------------------
                // 2) SỬA TÀI KHOẢN
                // ---------------------------
                else if (isEditing)
                {
                    string sqlUpdate = @"UPDATE THU_THU
                                 SET TenDN=@TenDN, MatKhau=@MatKhau, Email=@Email, Quyen=@Quyen
                                 WHERE Ma_Thu_Thu=@Ma_Thu_Thu";

                    cmd = new SqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@Ma_Thu_Thu", cboThuThu.SelectedValue);
                    cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật tài khoản!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadTaiKhoan();

                // Reset chế độ
                isAdding = false;
                isEditing = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboThuThu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE THU_THU SET TenDN=NULL, MatKhau=NULL, Email=NULL, Quyen=NULL WHERE Ma_Thu_Thu=@Ma_Thu_Thu";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ma_Thu_Thu", cboThuThu.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã xóa tài khoản thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadTaiKhoan();
                }
            }
    }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboThuThu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bản ghi để sửa!");
                return;
            }

            isAdding = false;
            isEditing = true;

            MessageBox.Show("Bạn đang ở chế độ SỬA.\nHãy chỉnh thông tin rồi nhấn LƯU.");
        }

        private void grbTTTT_Enter(object sender, EventArgs e)
        {

        }

        private void panelRoot_Paint(object sender, PaintEventArgs e)
        {

        }

       //private void FixLayout()
       // {
       //     // ---- Panel gốc chiếm toàn màn hình ----
       //     panelRoot.Dock = DockStyle.Fill;

       //     // ---- Label tiêu đề đặt trên cùng ----
       //     lblTaiKhoan.Dock = DockStyle.Top;
       //     lblTaiKhoan.Height = 40;

       //     // ---- GroupBox chứa thông tin tài khoản ----
       //     grbTTTT.Dock = DockStyle.Top;
       //     grbTTTT.Height = 180;

       //     // ---- Panel chứa nút (tạo nếu chưa có) ----
       //     Panel panelButtons = new Panel();
       //     panelButtons.Height = 55;
       //     panelButtons.Dock = DockStyle.Top;
       //     panelButtons.BackColor = Color.Transparent;

       //     // Nếu panelButtons chưa có trong panelRoot thì thêm:
       //     if (!panelRoot.Controls.Contains(panelButtons))
       //     {
       //         panelRoot.Controls.Add(panelButtons);
       //         panelButtons.BringToFront();
       //     }

       //     // ---- Anchor cho các nút ----
       //     btnThem.Anchor = AnchorStyles.Left | AnchorStyles.Top;
       //     btnSua.Anchor = AnchorStyles.Left | AnchorStyles.Top;
       //     btnXoa.Anchor = AnchorStyles.Left | AnchorStyles.Top;
       //     btnTaomoi.Anchor = AnchorStyles.Left | AnchorStyles.Top;

       //     // Đặt lên panelButtons
       //     panelButtons.Controls.Add(btnThem);
       //     panelButtons.Controls.Add(btnSua);
       //     panelButtons.Controls.Add(btnXoa);
       //     panelButtons.Controls.Add(btnTaomoi);

       //     // Tự canh vị trí nút
       //     int x = 10;
       //     foreach (Control btn in panelButtons.Controls)
       //     {
       //         btn.Left = x;
       //         btn.Top = 10;
       //         x += btn.Width + 15;
       //     }

       //     // ---- DataGridView tự chiếm toàn phần còn lại ----
       //     dgvTaiKhoan.Dock = DockStyle.Fill;

       //     // ---- Tự điều chỉnh cột DGV ----
       //     dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
       //     dgvTaiKhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
       //     dgvTaiKhoan.RowHeadersVisible = false; // gọn hơn
       // }


    }
}
