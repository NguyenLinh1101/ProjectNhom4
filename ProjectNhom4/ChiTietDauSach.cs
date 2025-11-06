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
    public partial class ChiTietDauSach : Form
    {
        string strCon = @"Data Source=LAPTOP-SO78PQJP\MSSQLSERVER01;Initial Catalog=QL_THUVIEN;Integrated Security=True";

        string maDauSach;
        public ChiTietDauSach()
        {
            InitializeComponent();
        }

        public ChiTietDauSach(string maDS)
        {
            InitializeComponent();
            maDauSach = maDS;
            SetControlsReadOnly();
            NapDuLieu();
        }
        private void SetControlsReadOnly()
        {
            // Dùng 'ReadOnly = true' sẽ cho phép người dùng copy text
            // và giao diện nhìn rõ ràng hơn là 'Enabled = false' (bị xám đi)
            txtMaDauSach.ReadOnly = true;
            txtTenDauSach.ReadOnly = true;
            txtTenTacGia.ReadOnly = true;
            txtNamXuatBan.ReadOnly = true;
            txtGiaBia.ReadOnly = true;
            txtSoTrang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtLoaiSach.ReadOnly = true;
            txtChuDe.ReadOnly = true;
        }
        private void NapDuLieu()
        {
            try
            {
                // Khai báo và khởi tạo 'con' trực tiếp trong 'using'
                // Nó sẽ tự động được giải phóng khi kết thúc khối 'using'
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = @"
SELECT 
    DS.Ma_Dau_Sach,
    DS.Ten_Dau_Sach,
    STRING_AGG(TG.Ten_Tac_Gia, ', ') AS Ten_Tac_Gia,  -- Gộp nhiều tác giả cùng một đầu sách
    DS.Nam_XB,
    DS.Gia_Bia,
    DS.So_Trang,
    DS.So_Luong,
    TL.Ten_TL AS TenLoaiSach,
    CD.Ten_Chu_De AS TenChuDe
FROM DAU_SACH DS
LEFT JOIN TG_DAU_SACH DSTG ON DS.Ma_Dau_Sach = DSTG.Ma_Dau_Sach
LEFT JOIN TAC_GIA TG ON DSTG.Ma_Tac_Gia = TG.Ma_Tac_Gia
LEFT JOIN THE_LOAI TL ON DS.Ma_TL = TL.Ma_TL
LEFT JOIN CHU_DE CD ON DS.Ma_Chu_De = CD.Ma_Chu_De
WHERE DS.Ma_Dau_Sach = @MaDS
GROUP BY 
    DS.Ma_Dau_Sach, DS.Ten_Dau_Sach, DS.Nam_XB, 
    DS.Gia_Bia, DS.So_Trang, DS.So_Luong,
    TL.Ten_TL, CD.Ten_Chu_De";


                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaDS", maDauSach);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Nạp vào TextBox
                        txtMaDauSach.Text = reader["Ma_Dau_Sach"].ToString();
                        txtTenDauSach.Text = reader["Ten_Dau_Sach"].ToString();
                        txtTenTacGia.Text = reader["Ten_Tac_Gia"].ToString();
                        txtNamXuatBan.Text = reader["Nam_XB"].ToString();

                        txtGiaBia.Text = reader.IsDBNull(reader.GetOrdinal("Gia_Bia")) ? "0" : Convert.ToDecimal(reader["Gia_Bia"]).ToString("N0");
                        txtSoTrang.Text = reader.IsDBNull(reader.GetOrdinal("So_Trang")) ? "0" : Convert.ToInt32(reader["So_Trang"]).ToString("N0");
                        txtSoLuong.Text = reader.IsDBNull(reader.GetOrdinal("So_Luong")) ? "0" : Convert.ToInt32(reader["So_Luong"]).ToString("N0");

                        // Xử lý trường hợp JOIN bị NULL (dù LEFT JOIN đã an toàn)
                        txtLoaiSach.Text = reader.IsDBNull(reader.GetOrdinal("TenLoaiSach")) ? "N/A" : reader["TenLoaiSach"].ToString();
                        txtChuDe.Text = reader.IsDBNull(reader.GetOrdinal("TenChuDe")) ? "N/A" : reader["TenChuDe"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho mã sách này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Cân nhắc đóng form nếu không tìm thấy dữ liệu
                        // this.Close(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string MaDS { get; }

        private void ChiTietDauSach_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
