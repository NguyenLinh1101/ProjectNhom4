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
    public partial class frmBCviphamtheoloai : Form
    {
        string connectionString = "Data Source=DESKTOP-ST1KSE3\\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        public frmBCviphamtheoloai()
        {
            InitializeComponent();
        }

        private void frmBCviphamtheoloai_Load(object sender, EventArgs e)
        {
            LoadLoaiViPhamComboBox();
            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }
        private void LoadLoaiViPhamComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Ma_Vi_Pham, Ten_Vi_Pham FROM VI_PHAM";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.Fill(dt);
                }

                DataRow tatCaRow = dt.NewRow();
                tatCaRow["Ma_Vi_Pham"] = "TATCA"; 
                dt.Rows.InsertAt(tatCaRow, 0);

                // Gán dữ liệu vào ComboBox
                cboVP.DataSource = dt;
                cboVP.DisplayMember = "Ten_Vi_Pham";
                cboVP.ValueMember = "Ma_Vi_Pham";
                cboVP.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại vi phạm: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. LẤY THAM SỐ TỪ GIAO DIỆN
                DateTime tuNgay = dtNgayBĐ.Value;
                DateTime denNgay = dtNgayKT.Value;
                string maViPham = cboVP.SelectedValue.ToString();
                // 2. LẤY DỮ LIỆU TỪ SQL
                DataTable dt = new DataTable();

                // Câu query này lấy sách trả bị hỏng dựa trên mô tả
                string query = @"
                    SELECT
                        VP.Ma_Vi_Pham, VP.Ten_Vi_Pham, VP.Hinh_Thuc_Phat,
                        COUNT(DISTINCT DG.Ma_Doc_Gia) AS So_Nguoi_VP, 
                        COUNT(CTPP.Ma_Phieu_Phat) AS So_Lan_VP, 
                        SUM(CTPP.So_Tien_Phat) AS Tong_Tien_Phat
                    FROM
                        CT_PHIEU_PHAT AS CTPP
                    JOIN
                        PHIEU_PHAT AS PP ON CTPP.Ma_Phieu_Phat = PP.Ma_Phieu_Phat
                    JOIN
                        VI_PHAM AS VP ON CTPP.Ma_Vi_Pham = VP.Ma_Vi_Pham
                    LEFT JOIN
                        PHIEU_MUON AS PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
                    LEFT JOIN
                        THE_DOC_GIA AS TDG ON PM.Ma_The = TDG.Ma_The
                    LEFT JOIN
                        DOC_GIA AS DG ON TDG.Ma_Doc_Gia = DG.Ma_Doc_Gia
                    WHERE
                        PP.Ngay_Lap_Phieu BETWEEN @TuNgay AND @DenNgay"; 

        
                if (maViPham != "TATCA")
                {
                    query += " AND VP.Ma_Vi_Pham = @MaViPham ";
                }

                // Thêm phần GROUP BY (luôn luôn có)
                query += @"
                    GROUP BY
                        VP.Ma_Vi_Pham, VP.Ten_Vi_Pham, VP.Hinh_Thuc_Phat
                    ORDER BY
                        VP.Ma_Vi_Pham;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                    cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                    cmd.Parameters.AddWithValue("@MaViPham", maViPham);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                // 3. NẠP BÁO CÁO (Thứ tự rất quan trọng)
                //E:\BTL\ProjectNhom4\Reports\BCsachhong.rdlc
                // BƯỚC A: Chỉ định file .rdlc
                // (Đảm bảo file rdlc đã set "Copy to Output Directory" = "Copy if newer")
                reportViewer1.LocalReport.ReportPath = @"Reports\BCviphamtheoloai.rdlc";

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
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
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
    }
}
