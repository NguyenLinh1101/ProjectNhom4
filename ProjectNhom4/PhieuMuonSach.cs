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
    public partial class frmMuonSach : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=LANNHI\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True";

        private string maPhieuMuon;
        private string maDocGia;
       


        public frmMuonSach()
        {
            InitializeComponent();
        }
        // Constructor nhận dữ liệu từ UC_QuanlyPhieuMuon
        public frmMuonSach(string maPhieuMuon, string maDocGia)
        {
            InitializeComponent();
            this.maPhieuMuon = maPhieuMuon;
            this.maDocGia = maDocGia;

            this.Load += FrmMuonSach_Load;
        }

        // Khi Form load
        private void FrmMuonSach_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu sang TextBox
            txtMaPhieuMuon.Text = maPhieuMuon;
            txtMaDocGia.Text = maDocGia;

            // Nếu MaDocGia có thì lấy tên từ DB
            if (!string.IsNullOrEmpty(maDocGia))
            {
                txtTenDocGia.Text = LayTenDocGiaTheoMaThe(maDocGia);
            }
            else
            {
                txtTenDocGia.Text = ""; // để người dùng nhập thủ công
            }
        }
        // Hàm lấy tên độc giả từ bảng THE_DOC_GIA dựa vào Ma_The
        private string LayTenDocGiaTheoMaThe(string maThe)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"
                SELECT Ten_Doc_Gia 
                FROM THE_DOC_GIA 
                WHERE Ma_The = @MaThe";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaThe", maThe);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy tên độc giả: " + ex.Message);
            }
            return "";
        }


        private void btnChonSach_Click(object sender, EventArgs e)
        {
            
            // Tạo instance form phụ
            frmformphuChonSach frmPhu = new frmformphuChonSach();

            // Tùy chọn: mở giữa màn hình hoặc trung tâm form chính
            frmPhu.StartPosition = FormStartPosition.CenterParent;

            // Show form phụ theo kiểu modal (phải đóng mới về form chính)
            frmPhu.ShowDialog(this);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void NhanDanhSachSachDuocChon(List<DataRowView> selectedBooks)
        {
            foreach (var book in selectedBooks)
            {
                string maSach = book["Ma_Sach"].ToString();
                string maDauSach = book["Ma_Dau_Sach"].ToString();
                string tenDauSach = book["Ten_Dau_Sach"].ToString();
                string giaBia = book["Gia_Bia"].ToString();
                string tinhTrang = book["Tinh_Trang"].ToString();

                // Thêm vào DataGridView dgvSachMuon
                dgvSachMuon.Rows.Add(maSach, maDauSach, tenDauSach, giaBia, tinhTrang);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Tìm Form chính
                Form mainForm = Application.OpenForms
                                    .OfType<Form>()
                                    .FirstOrDefault();
                if (mainForm == null)
                {
                    MessageBox.Show("Không tìm thấy Form chính!");
                    return;
                }

                // 2. Tìm UC_QuanlyMuonTra_Ribbon trong Form chính
                UC_QuanlyMuonTra_Ribbon ucRibbon = FindControlRecursive<UC_QuanlyMuonTra_Ribbon>(mainForm);
                if (ucRibbon == null)
                {
                    MessageBox.Show("Không tìm thấy UC_QuanlyMuonTra_Ribbon!");
                    return;
                }

                // 3. Tìm UC_QuanlyPhieuMuonSach trong panelContainer của Ribbon
                // Lưu ý: panelContainer phải là public trong UC_QuanlyMuonTra_Ribbon
                UC_QuanlyPhieuMuonSach ucPhieuMuon = FindControlRecursive<UC_QuanlyPhieuMuonSach>(ucRibbon.panelContainer);
                if (ucPhieuMuon == null)
                {
                    MessageBox.Show("Không tìm thấy UC_QuanlyPhieuMuonSach!");
                    return;
                }

                // 4. Lấy DataGridView bên UC
                DataGridView dgvDangMuon = ucPhieuMuon.DgvSachDangMuon; // DgvSachDangMuon phải là public property trong UC

                // 5. Chuyển dữ liệu từ dgvSachMuon sang dgvDangMuon
                dgvDangMuon.Rows.Clear();
                foreach (DataGridViewRow row in dgvSachMuon.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int idx = dgvDangMuon.Rows.Add();
                        DataGridViewRow newRow = dgvDangMuon.Rows[idx];

                        foreach (DataGridViewColumn col in dgvDangMuon.Columns)
                        {
                            if (row.Cells[col.Name] != null)
                                newRow.Cells[col.Name].Value = row.Cells[col.Name].Value;
                        }
                    }
                }

                MessageBox.Show("Chuyển dữ liệu thành công!");
                this.Close(); // đóng form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        // Hàm đệ quy tìm Control
        private T FindControlRecursive<T>(Control parent) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c is T)
                    return (T)c;
                T found = FindControlRecursive<T>(c);
                if (found != null)
                    return found;
            }
            return null;
        }


    }
}
