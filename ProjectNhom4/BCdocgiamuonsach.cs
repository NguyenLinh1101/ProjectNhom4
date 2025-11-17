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
    public partial class BCdocgiamuonsach : Form
    {
        string connectionString = "Data Source=LANNHI\\SQLEXPRESS;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        public BCdocgiamuonsach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BCdocgiamuonsach_Load(object sender, EventArgs e)
        {
            LoadKieuMuonComboBox(); // Tải dữ liệu cho ComboBox

            // Xóa báo cáo cũ và refresh để hiển thị màn hình trống
            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }
        private void LoadKieuMuonComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Ma_Kieu_Muon, Ten_Kieu_Muon FROM KIEU_MUON";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.Fill(dt);
                }

                // Thêm một dòng "Tất cả"
                DataRow tatCaRow = dt.NewRow();
                tatCaRow["Ma_Kieu_Muon"] = "TATCA"; // Giá trị đặc biệt để xử lý trong SQL
                tatCaRow["Ten_Kieu_Muon"] = "Tất cả";
                dt.Rows.InsertAt(tatCaRow, 0);

                // Gán dữ liệu vào ComboBox
                cboKieuMuon.DataSource = dt;
                cboKieuMuon.DisplayMember = "Ten_Kieu_Muon";
                cboKieuMuon.ValueMember = "Ma_Kieu_Muon";
                cboKieuMuon.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải kiểu mượn: " + ex.Message);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. LẤY THAM SỐ TỪ GIAO DIỆN
                DateTime tuNgay = dtNgayBĐ.Value;
                DateTime denNgay = dtNgayKT.Value;
                string maKieuMuon = cboKieuMuon.SelectedValue.ToString();

                // 2. LẤY DỮ LIỆU TỪ SQL
                DataTable dt = new DataTable();

                // Câu query này lấy sách trả bị hỏng dựa trên mô tả
                string query = @"
                    SELECT
                        DG.Ma_Doc_Gia AS Ma_Doc_Gia,
                        DG.Ho_Ten AS Ho_Ten,
                        PM.Ma_Phieu_Muon AS Ma_Phieu_Muon,
                        KM.Ten_Kieu_Muon AS Kieu_Muon,
                        DS.Ten_Dau_Sach AS Ten_Dau_Sach,
                        PM.Tien_Coc AS Tien_Coc,      
                        S.Ma_Sach AS Ma_Sach,
                        DS.Ma_Dau_Sach AS Ma_Dau_Sach,
                        DS.Gia_Bia AS Gia_Bia,      
                        PM.Ngay_Muon AS Ngay_Muon,
                        PM.Han_Tra AS Han_Tra
                    FROM
                        DOC_GIA AS DG
                    JOIN
                        THE_DOC_GIA AS TDG ON DG.Ma_Doc_Gia = TDG.Ma_Doc_Gia
                    JOIN
                        PHIEU_MUON AS PM ON TDG.Ma_The = PM.Ma_The
                    JOIN
                        KIEU_MUON AS KM ON PM.Ma_Kieu_Muon = KM.Ma_Kieu_Muon
                    JOIN
                        CT_PHIEU_MUON AS CTPM ON PM.Ma_Phieu_Muon = CTPM.Ma_Phieu_Muon
                    JOIN
                        SACH AS S ON CTPM.Ma_Sach = S.Ma_Sach
                    JOIN
                        DAU_SACH AS DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                    WHERE
                        PM.Ngay_Muon BETWEEN @TuNgay AND @DenNgay
                        AND (@MaKieuMuon = 'TATCA' OR PM.Ma_Kieu_Muon = @MaKieuMuon)
                    ORDER BY
                        DG.Ho_Ten, PM.Ngay_Muon;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                    cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                    cmd.Parameters.AddWithValue("@MaKieuMuon", maKieuMuon);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                // 3. NẠP BÁO CÁO (Thứ tự rất quan trọng)
                //E:\BTL\ProjectNhom4\Reports\BCsachhong.rdlc
                // BƯỚC A: Chỉ định file .rdlc
                // (Đảm bảo file rdlc đã set "Copy to Output Directory" = "Copy if newer")
                reportViewer1.LocalReport.ReportPath = @"Reports\BCdocgiamuonsach.rdlc"; // *** THAY BẰNG ĐƯỜNG DẪN ĐÚNG ***

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
                ReportDataSource rds = new ReportDataSource("dsbaocaodocgiamuonsach", dt);
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
