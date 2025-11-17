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
    public partial class frmBCsachquahan : Form
    {
        string connectionString = "Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        public frmBCsachquahan()
        {
            InitializeComponent();
        }

        private void frmBCsachquahan_Load(object sender, EventArgs e)
        {

            // Xóa báo cáo cũ và refresh để hiển thị màn hình trống
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
                        DG.Ho_Ten AS Ten_Doc_Gia,
                        PM.Ma_Phieu_Muon,
                        S.Ma_Sach,
                        DS.Ten_Dau_Sach,
                        PM.Ngay_Muon,
                        PM.Han_Tra,
                        -- Tính số ngày quá hạn (từ Hạn trả đến Hôm nay)
                        DATEDIFF(day, PM.Han_Tra, GETDATE()) AS So_Ngay_Qua_Han
                    FROM
                        PHIEU_MUON AS PM
                    JOIN
                        THE_DOC_GIA AS TDG ON PM.Ma_The = TDG.Ma_The
                    JOIN
                        DOC_GIA AS DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
                    JOIN
                        CT_PHIEU_MUON AS CTPM ON PM.Ma_Phieu_Muon = CTPM.Ma_Phieu_Muon
                    JOIN
                        SACH AS S ON CTPM.Ma_Sach = S.Ma_Sach
                    JOIN
                        DAU_SACH AS DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                    WHERE
                        -- 1. CHƯA TRẢ SÁCH
                        PM.Ngay_Thuc_Tra IS NULL
        
                        -- 2. ĐÃ QUÁ HẠN (so với ngày hôm nay)
                        AND PM.Han_Tra < GETDATE()
        
                        -- 3. LỌC theo HẠN TRẢ mà người dùng chọn
                        AND PM.Han_Tra BETWEEN @TuNgay AND @DenNgay
                    ORDER BY
                        DG.Ho_Ten, PM.Ma_Phieu_Muon;";

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
                reportViewer1.LocalReport.ReportPath = @"Reports\BCsachquahan.rdlc"; 

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
                ReportDataSource rds = new ReportDataSource("dsBCsachquahan", dt);
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
