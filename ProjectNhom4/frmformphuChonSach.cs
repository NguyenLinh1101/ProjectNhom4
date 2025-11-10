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
    public partial class frmformphuChonSach : Form
    {
        string strCon = @"Data Source=LANNHI\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True"; // <-- khai báo chuỗi kết nối
        public frmformphuChonSach()
        {
            InitializeComponent();
            this.Load += FrmformphuChonSach_Load;
        }
        private void FrmformphuChonSach_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach();
            dgvDanhSachSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSach.MultiSelect = true; // Cho phép chọn nhiều dòng
        }
        // Hàm load tất cả sách từ bảng SACH
        private void LoadDanhSachSach()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    // SQL JOIN SACH và DAU_SACH theo Ma_Dau_Sach
                    string sql = @"
                SELECT 
                    S.Ma_Sach, 
                    S.Ma_Dau_Sach, 
                    S.Tinh_Trang, 
                    S.Lib_Only, 
                    S.Mo_Ta,
                    D.Ten_Dau_Sach,
                    D.Gia_Bia,
                    D.So_Trang,
                    D.So_Luong
                FROM SACH S
                INNER JOIN DAU_SACH D ON S.Ma_Dau_Sach = D.Ma_Dau_Sach";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachSach.DataSource = dt;

                    // Tuỳ chỉnh tiêu đề cột
                    if (dgvDanhSachSach.Columns.Count > 0)
                    {
                        dgvDanhSachSach.Columns["Ma_Sach"].HeaderText = "Mã Sách";
                        dgvDanhSachSach.Columns["Ma_Dau_Sach"].HeaderText = "Mã Đầu Sách";
                        dgvDanhSachSach.Columns["Tinh_Trang"].HeaderText = "Tình Trạng";
                        dgvDanhSachSach.Columns["Lib_Only"].HeaderText = "Lib Only";
                        dgvDanhSachSach.Columns["Mo_Ta"].HeaderText = "Mô Tả";
                        dgvDanhSachSach.Columns["Ten_Dau_Sach"].HeaderText = "Tên Đầu Sách";
                        dgvDanhSachSach.Columns["Gia_Bia"].HeaderText = "Giá Bìa";
                        dgvDanhSachSach.Columns["So_Trang"].HeaderText = "Số Trang";
                        dgvDanhSachSach.Columns["So_Luong"].HeaderText = "Số Lượng";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách sách: " + ex.Message);
            }
        }
        private void dgvDanhSachSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                // Danh sách sách được chọn
                List<DataRowView> selectedBooks = new List<DataRowView>();

                foreach (DataGridViewRow row in dgvDanhSachSach.SelectedRows)
                {
                    if (row.DataBoundItem != null)
                    {
                        selectedBooks.Add((DataRowView)row.DataBoundItem);
                    }
                }

                if (selectedBooks.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một cuốn sách!", "Thông báo");
                    return;
                }

                // Tìm form frmMuonSach đang mở
                Form f = Application.OpenForms.Cast<Form>()
                             .FirstOrDefault(x => x is frmMuonSach);

                if (f is frmMuonSach frm)
                {
                    // Gửi danh sách sách sang form cha
                    frm.NhanDanhSachSachDuocChon(selectedBooks);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy form Mượn Sách để nhận dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn sách: " + ex.Message);
            }
        }


    }
}
