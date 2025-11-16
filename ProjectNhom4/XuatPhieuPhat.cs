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
using Microsoft.Reporting.WinForms;

namespace ProjectNhom4
{
    public partial class XuatPhieuPhat : Form
    {
        string connectionString = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        private string maPhieuPhat;
        public XuatPhieuPhat(string maPP)
        {
            InitializeComponent();
            maPhieuPhat = maPP;
        }


        private void XuatPhieuPhat_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // === SỬA LỖI: Dùng 1 câu SQL duy nhất ===
                    // Câu SQL này lấy TẤT CẢ dữ liệu (cả chung và chi tiết)
                    // Thông tin chung (PP.Ma_Phieu_Phat, DG.Ho_Ten...) sẽ bị lặp lại 
                    // trên mỗi dòng, điều này là BÌNH THƯỜNG.
                    string sqlQuery = @"
                SELECT 
                    -- Thông tin chung (cho Header)
                    PP.Ma_Phieu_Phat,
                    PM.Ma_Phieu_Muon,
                    DG.Ma_Doc_Gia,
                    DG.Ho_Ten AS Ten_Doc_Gia,
                    PP.Ngay_Lap_Phieu,
                    TT.Ma_Thu_Thu,
                    TT.Ten_Thu_Thu,
                    (SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP) AS Tong_Tien_Phat,

                    -- Thông tin chi tiết (cho Bảng)
                    CP.Ma_Sach,
                    DS.Ten_Dau_Sach AS Ten_Sach,
                    CP.Ma_Vi_Pham,
                    CP.Ly_Do,
                    CP.So_Tien_Phat AS Tien_Phat,
                    CP.Trang_Thai_Phieu AS Trang_Thai
                FROM 
                    PHIEU_PHAT PP
                -- Dùng INNER JOIN để đảm bảo chỉ lấy phiếu phạt có chi tiết
                INNER JOIN 
                    CT_PHIEU_PHAT CP ON PP.Ma_Phieu_Phat = CP.Ma_Phieu_Phat
                LEFT JOIN 
                    PHIEU_MUON PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
                LEFT JOIN 
                    THE_DOC_GIA TDG ON PM.Ma_The = TDG.Ma_The
                LEFT JOIN 
                    DOC_GIA DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
                LEFT JOIN 
                    THU_THU TT ON PP.Ma_Thu_Thu = TT.Ma_Thu_Thu
                LEFT JOIN 
                    SACH S ON CP.Ma_Sach = S.Ma_Sach
                LEFT JOIN 
                    DAU_SACH DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                WHERE 
                    PP.Ma_Phieu_Phat = @MaPP";

                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPP", maPhieuPhat);
                    DataTable dtDuLieu = new DataTable();
                    da.Fill(dtDuLieu);

                    // Gán 1 Nguồn dữ liệu duy nhất
                    ReportDataSource rds = new ReportDataSource("DataSet1", dtDuLieu);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // === THÊM PARAMETER (Theo yêu cầu của bạn) ===
                    // Thêm các Parameter bạn cần (ví dụ: ngày lập và ngày nộp)
                    // (Chúng ta lấy giá trị Ngày Lập từ dòng ĐẦU TIÊN của bảng)
                    string ngayLap = "N/A";
                    if (dtDuLieu.Rows.Count > 0)
                    {
                        ngayLap = Convert.ToDateTime(dtDuLieu.Rows[0]["Ngay_Lap_Phieu"]).ToString("dd/MM/yyyy");
                    }

                    List<ReportParameter> parameters = new List<ReportParameter>();
                    parameters.Add(new ReportParameter("p_NgayLap", ngayLap));
                    // (Thêm các parameter ngày tháng khác mà bạn cần ở đây...)
                    // parameters.Add(new ReportParameter("p_NgayNop", ...));

                    reportViewer1.LocalReport.SetParameters(parameters);
                }

                // 4. CHỈ ĐỊNH ĐƯỜNG DẪN VÀ REFRESH
                reportViewer1.LocalReport.ReportPath = @"Reports\rptPhieuPhat.rdlc";
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    