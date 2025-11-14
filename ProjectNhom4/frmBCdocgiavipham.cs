using Microsoft.Reporting.WinForms;
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
    public partial class frmBCdocgiavipham : Form
    {
        string connectionString = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        public frmBCdocgiavipham()
        {
            InitializeComponent();
        }

        private void frmBCdocgiavipham_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. LẤY THAM SỐ TỪ GIAO DIỆN
                DateTime tuNgay = dtNgayBĐ.Value;
                DateTime denNgay = dtNgayKT.Value;
                // 2. LẤY DỮ LIỆU TỪ SQL
                DataTable dt = new DataTable();

                // Câu query này lấy sách trả bị hỏng dựa trên mô tả
                string query = @"
                    SELECT
                        DG.Ma_Doc_Gia,
                        DG.Ho_Ten,
                        PP.Ma_Phieu_Phat,
                        VP.Ten_Vi_Pham AS Vi_Pham,
                        CTPP.Ma_Sach,
                        DS.Ten_Dau_Sach AS Dau_Sach,
                        PP.Ngay_Lap_Phieu AS Ngay_Phat,
                        CTPP.So_Tien_Phat AS Tien_Phat,
                        PP.Ma_Thu_Thu
                    FROM
                        CT_PHIEU_PHAT AS CTPP
                    JOIN
                        PHIEU_PHAT AS PP ON CTPP.Ma_Phieu_Phat = PP.Ma_Phieu_Phat
                    JOIN
                        VI_PHAM AS VP ON CTPP.Ma_Vi_Pham = VP.Ma_Vi_Pham
                    LEFT JOIN
                        SACH AS S ON CTPP.Ma_Sach = S.Ma_Sach -- LEFT JOIN phòng khi phạt không liên quan sách (vd: Mất thẻ)
                    LEFT JOIN
                        DAU_SACH AS DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                    LEFT JOIN -- Lấy thông tin độc giả từ PHIEU_MUON (nếu có)
                        PHIEU_MUON AS PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
                    LEFT JOIN
                        THE_DOC_GIA AS TDG ON PM.Ma_The = TDG.Ma_The
                    LEFT JOIN
                        DOC_GIA AS DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
                    WHERE
                        -- Lọc theo ngày lập phiếu phạt
                        PP.Ngay_Lap_Phieu BETWEEN @TuNgay AND @DenNgay
                    ORDER BY
                        DG.Ho_Ten, PP.Ma_Phieu_Phat;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                    cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                // 3. NẠP BÁO CÁO (Thứ tự rất quan trọng)
                //E:\BTL\ProjectNhom4\Reports\BCsachhong.rdlc
                // BƯỚC A: Chỉ định file .rdlc
                // (Đảm bảo file rdlc đã set "Copy to Output Directory" = "Copy if newer")
                reportViewer1.LocalReport.ReportPath = @"Reports\baocaodocgiavipham.rdlc";

                // BƯỚC B: Nạp tham số (Parameters) cho tiêu đề (nếu có)
                ReportParameter[] param = new ReportParameter[]
                {
                    // *** TÊN "pTuNgay", "pDenNgay" PHẢI KHỚP TÊN TRONG RDLC ***
                    new ReportParameter("pNgayBĐ", tuNgay.ToString("dd/MM/yyyy")),
                    new ReportParameter("pNgayKT", denNgay.ToString("dd/MM/yyyy"))
                };
                reportViewer1.LocalReport.SetParameters(param);

                // BƯỚC C: Nạp nguồn dữ liệu (DataSource) cho bảng
                reportViewer1.LocalReport.DataSources.Clear();
                // *** TÊN "DataSet1" PHẢI KHỚP TÊN DATASET TRONG RDLC ***
                ReportDataSource rds = new ReportDataSource("dsdocgiavipham", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 4. HIỂN THỊ
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message +
                        "\n\nLỗi Chi Tiết: " + ex.InnerException?.Message,
                        "Lỗi Báo Cáo Chi Tiết");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
