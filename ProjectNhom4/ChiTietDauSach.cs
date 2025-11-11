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
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";

        string maDauSach;
        bool isEditing = false;
        public ChiTietDauSach()
        {
            InitializeComponent();
        }

        public ChiTietDauSach(string maDS)
        {
            InitializeComponent();
            maDauSach = maDS;
            // SỬA DÒNG NÀY:
            // SetControlsReadOnly();
            SetControlsState(false); // <-- Sửa thành hàm mới

            NapDuLieu();
        }
        private void SetControlsState(bool editing)
        {
            this.isEditing = editing;

            // --- Ẩn/Hiện Control Tác Giả ---
            txtTenTacGia.Visible = !editing; // Ẩn TextBox
            cblTacGia.Visible = editing;     // Hiện CheckedListBox

            // --- Khóa các ô Text khác ---
            txtMaDauSach.ReadOnly = true;
            txtTenDauSach.ReadOnly = true;
            txtNamXuatBan.ReadOnly = true;
            txtGiaBia.ReadOnly = true;
            txtSoTrang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtLoaiSach.ReadOnly = true;
            txtChuDe.ReadOnly = true;

            //(Hoặc dùng.Visible nếu bạn muốn ẩn / hiện nút)
             btnSua.Visible = !editing;
            btnLuu.Visible = editing;
            btnHuy.Visible = editing;

            // Chỉ tải CSDL cho CheckedListBox KHI NHẤN SỬA
            if (editing)
            {
                LoadVaCheckTacGia();
            }
        }
        private void LoadVaCheckTacGia()
        {
            cblTacGia.Items.Clear(); // Xóa danh sách cũ

            DataTable dtAllTacGia = new DataTable();
            List<string> maTacGiaCuaSach = new List<string>();

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    // 1. Lấy TẤT CẢ tác giả
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Ma_Tac_Gia, Ten_Tac_Gia FROM TAC_GIA", con);
                    da.Fill(dtAllTacGia);

                    // 2. Lấy danh sách mã tác giả ĐÃ CÓ của sách này
                    SqlCommand cmd = new SqlCommand("SELECT Ma_Tac_Gia FROM TG_DAU_SACH WHERE Ma_Dau_Sach = @MaDS", con);
                    cmd.Parameters.AddWithValue("@MaDS", maDauSach);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        maTacGiaCuaSach.Add(reader["Ma_Tac_Gia"].ToString());
                    }
                    reader.Close();
                }

                // 3. Đổ vào CheckedListBox
                cblTacGia.DataSource = dtAllTacGia;
                cblTacGia.ValueMember = "Ma_Tac_Gia";
                cblTacGia.DisplayMember = "Ten_Tac_Gia";

                // 4. Check vào các tác giả đã có
                for (int i = 0; i < cblTacGia.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)cblTacGia.Items[i];
                    string maTG = drv["Ma_Tac_Gia"].ToString();
                    if (maTacGiaCuaSach.Contains(maTG))
                    {
                        cblTacGia.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tác giả: " + ex.Message);
            }
        }
        private void NapDuLieu()
        {
            try
            {
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

                        txtLoaiSach.Text = reader.IsDBNull(reader.GetOrdinal("TenLoaiSach")) ? "N/A" : reader["TenLoaiSach"].ToString();
                        txtChuDe.Text = reader.IsDBNull(reader.GetOrdinal("TenChuDe")) ? "N/A" : reader["TenChuDe"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho mã sách này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetControlsState(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControlsState(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();

                    // 1. Xóa TẤT CẢ liên kết tác giả cũ của sách này
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM TG_DAU_SACH WHERE Ma_Dau_Sach = @MaDS", con, trans);
                    cmdDelete.Parameters.AddWithValue("@MaDS", maDauSach);
                    cmdDelete.ExecuteNonQuery();

                    // 2. Thêm lại các liên kết MỚI (những cái được check)
                    foreach (var item in cblTacGia.CheckedItems)
                    {
                        DataRowView drv = (DataRowView)item;
                        string maTG = drv["Ma_Tac_Gia"].ToString();

                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO TG_DAU_SACH (Ma_Dau_Sach, Ma_Tac_Gia) VALUES (@MaDS, @MaTG)", con, trans);
                        cmdInsert.Parameters.AddWithValue("@MaDS", maDauSach);
                        cmdInsert.Parameters.AddWithValue("@MaTG", maTG);
                        cmdInsert.ExecuteNonQuery();
                    }

                    trans.Commit(); // Hoàn tất
                    MessageBox.Show("Cập nhật tác giả thành công!");

                    // Tải lại dữ liệu (để cập nhật txtTenTacGia với chuỗi mới)
                    NapDuLieu();

                    // Quay về trạng thái xem
                    SetControlsState(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
    }
}
