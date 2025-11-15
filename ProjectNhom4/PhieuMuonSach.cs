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
        string strCon = @"Data Source=LAPTOP-SO78PQJP\MSSQLSERVER01;Initial Catalog=QL_THUVIEN;Integrated Security=True";

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

        private void gbThongTinPhieu_Enter(object sender, EventArgs e)
        {

        }
        // Thêm biến tham chiếu tới UC cha
        private UC_QuanlyPhieuMuonSach parentUC;

        // Constructor nhận dữ liệu và UC cha
        public frmMuonSach(string maPhieuMuon, string maDocGia, UC_QuanlyPhieuMuonSach parent)
        {
            InitializeComponent();
            this.maPhieuMuon = maPhieuMuon;
            this.maDocGia = maDocGia;
            this.parentUC = parent; // lưu reference UC
            this.Load += FrmMuonSach_Load;
        }


    }
}
