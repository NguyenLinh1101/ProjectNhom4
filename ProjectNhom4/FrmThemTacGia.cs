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
    public partial class FrmThemTacGia : Form
    {
        string strCon = "Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        public FrmThemTacGia()
        {
            InitializeComponent();
        }

        private void FrmThemTacGia_Load(object sender, EventArgs e)
        {
            txtMaTacGia.Text = TaoMaTacGiaTuDong();
            LoadQuocTich();
            LoadGioiTinh();
        }
        private void LoadGioiTinh()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Khác");
            cbGioiTinh.SelectedIndex = -1;
        }
        private string TaoMaTacGiaTuDong()
        {
            string maMoi = "TG001";
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(Ma_Tac_Gia) FROM TAC_GIA", con);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        string maCu = result.ToString(); // VD: TG012
                        int so = int.Parse(maCu.Substring(2)); // 12
                        maMoi = "TG" + (so + 1).ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã tự động: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return maMoi;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"
                        INSERT INTO TAC_GIA (Ma_Tac_Gia, Ten_Tac_Gia, Ngay_Sinh, Nam_Mat, Gioi_Tinh, Quoc_Tich)
                        VALUES (@MaTG, @TenTG, @NgaySinh, @NamMat, @GioiTinh, @QuocTich)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaTG", txtMaTacGia.Text);
                    cmd.Parameters.AddWithValue("@TenTG", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@NamMat", dtpNamMat.Checked ? dtpNamMat.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@QuocTich", cboQuocTich.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tác giả mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void grbTTTG_Enter(object sender, EventArgs e)
        {

        }
    }
}
