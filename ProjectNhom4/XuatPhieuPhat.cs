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
using System.IO;

namespace ProjectNhom4
{
    public partial class XuatPhieuPhat : Form
    {
        string connectionString = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False\r\n";
        private string maPhieuPhat;
        public XuatPhieuPhat(string maPP)
        {
            InitializeComponent();
            maPhieuPhat = maPP;
        }


        private void XuatPhieuPhat_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = @"
SELECT 
    -- Thông tin chung (cho Header)
    PP.Ma_Phieu_Phat,
    PM.Ma_Phieu_Muon,
    DG.Ma_Doc_Gia,
    DG.Ho_Ten AS Ten_Doc_Gia,
    PP.Ngay_Lap_Phieu, 
    CP.Ngay_Nop_Phat,
    TT.Ma_Thu_Thu,
    TT.Ten_Thu_Thu,
    (SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP) AS Tong_Tien_Phat,

    -- Thông tin chi tiết (cho Bảng)
    CP.Ma_Sach,
    DS.Ten_Dau_Sach AS Ten_Sach,
    CP.Ma_Vi_Pham,
    
    -- SỬA 1: Đổi VP.Ten_Vi_Pham thành VP.Ly_Do
    VP.Ten_Vi_Pham AS Ly_Do, 
    
    CP.So_Tien_Phat AS Tien_Phat,
    CP.Trang_Thai_Phieu AS Trang_Thai
FROM 
    PHIEU_PHAT PP
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

-- SỬA 2: THÊM DÒNG JOIN CÒN THIẾU
LEFT JOIN 
    VI_PHAM VP ON CP.Ma_Vi_Pham = VP.Ma_Vi_Pham
    
WHERE 
    PP.Ma_Phieu_Phat = @MaPP";
                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPP", maPhieuPhat);

                    DataTable dtDuLieu = new DataTable();
                    da.Fill(dtDuLieu);

                    if (dtDuLieu.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // === GÁN REPORT ===
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Reports", "rptPhieuPhat.rdlc");


                    // Nếu file nằm trong Folder con:
                    // reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptPhieuPhat.rdlc";

                    // === GÁN DATA SOURCE ===
                    ReportDataSource rds = new ReportDataSource("DataSet1", dtDuLieu);
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // === PARAMETER ===
                    string ngayLap = Convert.ToDateTime(dtDuLieu.Rows[0]["Ngay_Lap_Phieu"]).ToString("dd/MM/yyyy");
                    string ngayNop = "";
                    if (dtDuLieu.Rows[0]["Ngay_Nop_Phat"] != DBNull.Value)
                        ngayNop = Convert.ToDateTime(dtDuLieu.Rows[0]["Ngay_Nop_Phat"]).ToString("dd/MM/yyyy");
                    else
                        ngayNop = "Chưa nộp";
                    reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                    {
                new ReportParameter("p_NgayLap", ngayLap),
                new ReportParameter("p_NgayNop", ngayNop)
                    });

                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    