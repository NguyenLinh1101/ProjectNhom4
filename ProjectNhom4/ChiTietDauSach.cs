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
        string strCon = "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";

        string maDauSach;
        bool isEditing = false;

        public ChiTietDauSach(string maDS)
        {
            InitializeComponent();
            this.maDauSach = maDS;
            NapDuLieu();



            SetControlsState(false);
        }
        private void SetControlsState(bool editing)
        {
            this.isEditing = editing;

            // --- Khóa/Mở Control Tác Giả ---
            // Dùng ReadOnly = true, control sẽ "sáng" nhưng không cho sửa

            // --- Khóa các ô Text khác ---
            txtMaDauSach.ReadOnly = true;
            txtTenDauSach.ReadOnly = true;
            txtNamXuatBan.ReadOnly = true;
            txtGiaBia.ReadOnly = true;
            txtSoTrang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtLoaiSach.ReadOnly = true;
            txtChuDe.ReadOnly = true;
            txtTen_Tac_Gia.ReadOnly = true;

            
        }


        private void NapDuLieu()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    // SỬA SQL: PHẢI JOIN VÀ STRING_AGG TÁC GIẢ
                    string sql = @"
                SELECT 
                    DS.Ma_Dau_Sach, DS.Ten_Dau_Sach, DS.Nam_XB, DS.Gia_Bia, DS.So_Trang, DS.So_Luong,
                    TL.Ten_TL AS TenLoaiSach, CD.Ten_Chu_De AS TenChuDe,
                    ISNULL(STRING_AGG(TG.Ten_Tac_Gia, ', '), N'Chưa có tác giả') AS TenCacTacGia
                FROM DAU_SACH DS
                LEFT JOIN THE_LOAI TL ON DS.Ma_TL = TL.Ma_TL
                LEFT JOIN CHU_DE CD ON DS.Ma_Chu_De = CD.Ma_Chu_De
                LEFT JOIN TG_DAU_SACH DSTG ON DS.Ma_Dau_Sach = DSTG.Ma_Dau_Sach
                LEFT JOIN TAC_GIA TG ON DSTG.Ma_Tac_Gia = TG.Ma_Tac_Gia
                WHERE DS.Ma_Dau_Sach = @MaDS
                GROUP BY 
                    DS.Ma_Dau_Sach, DS.Ten_Dau_Sach, DS.Nam_XB, DS.Gia_Bia, 
                    DS.So_Trang, DS.So_Luong, TL.Ten_TL, CD.Ten_Chu_De";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaDS", maDauSach);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtMaDauSach.Text = reader["Ma_Dau_Sach"].ToString();
                        txtTenDauSach.Text = reader["Ten_Dau_Sach"].ToString();
                        txtNamXuatBan.Text = reader["Nam_XB"].ToString();
                        txtGiaBia.Text = reader.IsDBNull(reader.GetOrdinal("Gia_Bia")) ? "0" : Convert.ToDecimal(reader["Gia_Bia"]).ToString("N0");
                        txtSoTrang.Text = reader.IsDBNull(reader.GetOrdinal("So_Trang")) ? "0" : Convert.ToInt32(reader["So_Trang"]).ToString("N0");
                        txtSoLuong.Text = reader.IsDBNull(reader.GetOrdinal("So_Luong")) ? "0" : Convert.ToInt32(reader["So_Luong"]).ToString("N0");
                        txtLoaiSach.Text = reader.IsDBNull(reader.GetOrdinal("TenLoaiSach")) ? "N/A" : reader["TenLoaiSach"].ToString();
                        txtChuDe.Text = reader.IsDBNull(reader.GetOrdinal("TenChuDe")) ? "N/A" : reader["TenChuDe"].ToString();
                        txtTen_Tac_Gia.Text = reader["TenCacTacGia"].ToString();
                        // SỬA: NẠP CHUỖI TÁC GIẢ VÀO Ô cceTacGia
                        // (Control này sẽ tự động hiển thị text khi ReadOnly = true)
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp thông tin sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetControlsState(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControlsState(false); // Quay về chế độ Xem
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void cceTacGia_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
