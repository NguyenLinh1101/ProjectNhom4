using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace ProjectNhom4
{
    public partial class Baocaosachhong : Form
    {
        string connectionString = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        public Baocaosachhong()
        {
            InitializeComponent();
        }

        private void Baocaosachhong_Load_1(object sender, EventArgs e)
        {
            LoadKieuMuonComboBox(); // Tải dữ liệu cho ComboBox

            // Xóa báo cáo cũ và refresh để hiển thị màn hình trống
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. LẤY THAM SỐ TỪ GIAO DIỆN
                DateTime tuNgay = dtpNgayBĐ.Value;
                DateTime denNgay = dtpNgayKT.Value;
                string maKieuMuon = cboKieuMuon.SelectedValue.ToString();

                // 2. LẤY DỮ LIỆU TỪ SQL
                DataTable dt = new DataTable();

                // Câu query này lấy sách trả bị hỏng dựa trên mô tả
                string query = @"
                    SELECT
                        KM.Ten_Kieu_Muon AS KieuMuon,
                        PM.Ma_Phieu_Muon AS MaPhieuMuon,
                        S.Ma_Sach AS MaSach,
                        DS.Ten_Dau_Sach AS TenDauSach,
                        CTPM.Mo_Ta AS TinhTrang,
                        PM.Ngay_Thuc_Tra AS NgayTra
                    FROM
                        PHIEU_MUON AS PM
                    JOIN KIEU_MUON AS KM ON PM.Ma_Kieu_Muon = KM.Ma_Kieu_Muon
                    JOIN CT_PHIEU_MUON AS CTPM ON PM.Ma_Phieu_Muon = CTPM.Ma_Phieu_Muon
                    JOIN SACH AS S ON CTPM.Ma_Sach = S.Ma_Sach
                    JOIN DAU_SACH AS DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                    -- SỬA CÁC JOIN BÊN DƯỚI
                    LEFT JOIN PHIEU_PHAT AS PP ON PM.Ma_Phieu_Muon = PP.Ma_Phieu_Muon
                    LEFT JOIN CT_PHIEU_PHAT AS CTPP ON PP.Ma_Phieu_Phat = CTPP.Ma_Phieu_Phat
                    LEFT JOIN VI_PHAM AS VP ON CTPP.Ma_Vi_Pham = VP.Ma_Vi_Pham -- Sửa tên bảng VI_PHAM
                    WHERE
                        (PM.Ngay_Thuc_Tra BETWEEN @TuNgay AND @DenNgay)

                        AND (@MaKieuMuon = 'TATCA' OR PM.Ma_Kieu_Muon = @MaKieuMuon)
                        -- Sửa VP.Mo_Ta thành VP.Ten_Vi_Pham
                        AND (VP.Ten_Vi_Pham LIKE N'%hỏng%' OR CTPM.Mo_Ta LIKE N'%rách%' OR CTPM.Mo_Ta LIKE N'%ướt%' OR CTPM.Mo_Ta LIKE N'%hư%')
                    ORDER BY
                        KM.Ten_Kieu_Muon"; 

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
                reportViewer2.LocalReport.ReportPath = @"Reports\BCsachhong.rdlc"; // *** THAY BẰNG ĐƯỜNG DẪN ĐÚNG ***

                // BƯỚC B: Nạp tham số (Parameters) cho tiêu đề (nếu có)
                ReportParameter[] param = new ReportParameter[]
                {
                    // *** TÊN "pTuNgay", "pDenNgay" PHẢI KHỚP TÊN TRONG RDLC ***
                    new ReportParameter("pNgayBĐ", tuNgay.ToString("dd/MM/yyyy")),
                    new ReportParameter("pNgayKT", denNgay.ToString("dd/MM/yyyy"))
                };
                reportViewer2.LocalReport.SetParameters(param);

                // BƯỚC C: Nạp nguồn dữ liệu (DataSource) cho bảng
                reportViewer2.LocalReport.DataSources.Clear();
                // *** TÊN "DataSet1" PHẢI KHỚP TÊN DATASET TRONG RDLC ***
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer2.LocalReport.DataSources.Add(rds);

                // 4. HIỂN THỊ
                reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message +
                        "\n\nLỗi Chi Tiết: " + ex.InnerException?.Message,
                        "Lỗi Báo Cáo Chi Tiết");
            }

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

        private void dtpNgayBĐ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
