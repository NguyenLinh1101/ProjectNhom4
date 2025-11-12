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

        public ChiTietDauSach(string maDS)
        {
            InitializeComponent();
            this.maDauSach = maDS;
            NapDuLieu();


            LoadTatCaTacGiaVaoDropDown();


            LoadTacGiaCuaSach();

            SetControlsState(false);
        }
        private void SetControlsState(bool editing)
        {
            this.isEditing = editing;

            // --- Khóa/Mở Control Tác Giả ---
            // Dùng ReadOnly = true, control sẽ "sáng" nhưng không cho sửa
            cceTacGia.ReadOnly = !editing;

            // --- Khóa các ô Text khác ---
            txtMaDauSach.ReadOnly = true;
            txtTenDauSach.ReadOnly = true;
            txtNamXuatBan.ReadOnly = true;
            txtGiaBia.ReadOnly = true;
            txtSoTrang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtLoaiSach.ReadOnly = true;
            txtChuDe.ReadOnly = true;

            // --- Quản lý các nút ---
            btnSua.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            btnSua.Visible = !editing;
            btnLuu.Visible = editing;
            btnHuy.Visible = editing;
            var plusButton = cceTacGia.Properties.Buttons
    .FirstOrDefault(b => b.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus);

            if (editing)
            {
                // Nếu chưa có nút + thì thêm
                if (plusButton == null)
                {
                    cceTacGia.Properties.Buttons.Add(
                        new DevExpress.XtraEditors.Controls.EditorButton(
                            DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
                        )
                    );

                    // Gắn sự kiện click cho nút +
                    cceTacGia.ButtonClick += (s, e) =>
                    {
                        if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                        {
                            using (var frm = new FrmThemTacGia())
                            {
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    LoadTatCaTacGiaVaoDropDown();
                                }
                            }
                        }
                    };
                }
            }
            else
            {
                // Nếu đang ở chế độ xem thì xóa nút +
                if (plusButton != null)
                {
                    cceTacGia.Properties.Buttons.Remove(plusButton);
                }
            }
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
                        // Nạp vào TextBox
                        txtMaDauSach.Text = reader["Ma_Dau_Sach"].ToString();
                        txtTenDauSach.Text = reader["Ten_Dau_Sach"].ToString();
                        txtTenTacGia.Text = reader["Tac_Gia"].ToString();
                        txtNamXuatBan.Text = reader["Nam_XB"].ToString();

                        txtGiaBia.Text = reader.IsDBNull(reader.GetOrdinal("Gia_Bia")) ? "0" : Convert.ToDecimal(reader["Gia_Bia"]).ToString("N0");
                        txtSoTrang.Text = reader.IsDBNull(reader.GetOrdinal("So_Trang")) ? "0" : Convert.ToInt32(reader["So_Trang"]).ToString("N0");
                        txtSoLuong.Text = reader.IsDBNull(reader.GetOrdinal("So_Luong")) ? "0" : Convert.ToInt32(reader["So_Luong"]).ToString("N0");

                        // Xử lý trường hợp JOIN bị NULL (dù LEFT JOIN đã an toàn)
                        txtLoaiSach.Text = reader.IsDBNull(reader.GetOrdinal("TenLoaiSach")) ? "N/A" : reader["TenLoaiSach"].ToString();
                        txtChuDe.Text = reader.IsDBNull(reader.GetOrdinal("TenChuDe")) ? "N/A" : reader["TenChuDe"].ToString();

                        // SỬA: NẠP CHUỖI TÁC GIẢ VÀO Ô cceTacGia
                        // (Control này sẽ tự động hiển thị text khi ReadOnly = true)
                        cceTacGia.Text = reader["TenCacTacGia"].ToString();
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
        private void LoadTatCaTacGiaVaoDropDown()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Ma_Tac_Gia, Ten_Tac_Gia FROM TAC_GIA", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Thêm cột hiển thị kết hợp mã + tên
                    dt.Columns.Add("DisplayText", typeof(string), "[Ma_Tac_Gia] + ' - ' + [Ten_Tac_Gia]");

                    cceTacGia.Properties.DataSource = dt;
                    cceTacGia.Properties.DisplayMember = "DisplayText";
                    cceTacGia.Properties.ValueMember = "Ma_Tac_Gia";
                    cceTacGia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    cceTacGia.Properties.IncrementalSearch = true;

                    // Hiển thị autocomplete filter trong popup
                    cceTacGia.Properties.IncrementalSearch = true;
                    // Thêm nút "+"
                    //if (!cceTacGia.Properties.Buttons.Any(b => b.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus))
                    //{
                    //    cceTacGia.Properties.Buttons.Add(
                    //        new DevExpress.XtraEditors.Controls.EditorButton(
                    //            DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
                    //        )
                    //    );

                    //    cceTacGia.ButtonClick += (s, e) =>
                    //    {
                    //        if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                    //        {
                    //            using (var frm = new FrmThemTacGia())
                    //            {
                    //                if (frm.ShowDialog() == DialogResult.OK)
                    //                {
                    //                    LoadTatCaTacGiaVaoDropDown();
                    //                }
                    //            }
                    //        }
                    //    };
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tác giả: " + ex.Message);
            }
        }
        private void ChiTietDauSach_Load(object sender, EventArgs e)
        {

        }
        private void LoadTacGiaCuaSach()
        {
            // Dùng List<object> để giữ các Mã Tác Giả
            List<object> maTacGiaCuaSach = new List<object>();
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Ma_Tac_Gia FROM TG_DAU_SACH WHERE Ma_Dau_Sach = @MaDS", con);
                    cmd.Parameters.AddWithValue("@MaDS", maDauSach);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // SỬA: Đọc Ma_Tac_Gia trực tiếp
                        maTacGiaCuaSach.Add(reader["Ma_Tac_Gia"]);
                    }
                    reader.Close();
                }
                string checkedValues = string.Join(",", maTacGiaCuaSach);

                // Set giá trị cho CheckedComboBoxEdit
                cceTacGia.SetEditValue(checkedValues);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tác giả của sách: " + ex.Message);
            }
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
            LoadTacGiaCuaSach(); // Tải lại (Reset) các check
            SetControlsState(false); // Quay về chế độ Xem
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();

                    // 1. Xóa TẤT CẢ liên kết tác giả cũ
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM TG_DAU_SACH WHERE Ma_Dau_Sach = @MaDS", con, trans);
                    cmdDelete.Parameters.AddWithValue("@MaDS", maDauSach);
                    cmdDelete.ExecuteNonQuery();

                    // SỬA: Lấy danh sách MÃ TÁC GIẢ mới (đã được check)
                    List<object> listChecked = cceTacGia.Properties.Items.GetCheckedValues();

                    // 2. Thêm lại các liên kết MỚI
                    foreach (object maTG_obj in listChecked)
                    {
                        string maTG = maTG_obj.ToString(); // Chuyển sang string

                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO TG_DAU_SACH (Ma_Dau_Sach, Ma_Tac_Gia) VALUES (@MaDS, @MaTG)", con, trans);
                        cmdInsert.Parameters.AddWithValue("@MaDS", maDauSach);
                        cmdInsert.Parameters.AddWithValue("@MaTG", maTG);
                        cmdInsert.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Cập nhật tác giả thành công!");

                    SetControlsState(false); // Quay về trạng thái xem

                    // (Tải lại dữ liệu cơ bản không cần thiết
                    // trừ khi bạn cho phép sửa Tên sách)
                    // NapThongTinCoBan(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void cceTacGia_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
