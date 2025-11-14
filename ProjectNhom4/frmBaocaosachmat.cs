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
    public partial class frmBaocaosachmat : Form
    {
        string connectionString = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False";
        public frmBaocaosachmat()
        {
            InitializeComponent();
        }

        private void frmBaocaosachmat_Load(object sender, EventArgs e)
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
                        DS.Ten_Dau_Sach AS DauSach,
                        S.Ma_Sach AS MaSach,
                        DS.Gia_Bia AS GiaBia,
                        PM.Ma_Phieu_Muon AS MaPhieuMuon,
                        KM.Ten_Kieu_Muon AS KieuMuon,
                        PM.Ngay_Thuc_Tra AS NgayThucTra
                    FROM
                        CT_PHIEU_PHAT AS CTPP
                    JOIN
                        VI_PHAM AS VP ON CTPP.Ma_Vi_Pham = VP.Ma_Vi_Pham  
                    JOIN
                        PHIEU_PHAT AS PP ON CTPP.Ma_Phieu_Phat = PP.Ma_Phieu_Phat
                    JOIN
                        PHIEU_MUON AS PM ON PP.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
                    JOIN
                        KIEU_MUON AS KM ON PM.Ma_Kieu_Muon = KM.Ma_Kieu_Muon
                    JOIN
                        SACH AS S ON CTPP.Ma_Sach = S.Ma_Sach
                    JOIN
                        DAU_SACH AS DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                    WHERE
                        -- Logic cốt lõi: Lấy bất kỳ vi phạm nào có chữ ""Mất sách""
                        VP.Ten_Vi_Pham LIKE N'%Mất sách%'  -- << SỬA DÒNG NÀY
        
                        -- Lọc theo ngày lập phiếu phạt (ngày ghi nhận sách bị mất)
                        AND PP.Ngay_Lap_Phieu BETWEEN @TuNgay AND @DenNgay
        
                        -- Lọc theo ComboBox ""Kiểu mượn""
                        AND (@MaKieuMuon = 'TATCA' OR PM.Ma_Kieu_Muon = @MaKieuMuon)
                    ORDER BY
                        DS.Ten_Dau_Sach;";

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
                reportViewer1.LocalReport.ReportPath = @"Reports\BCsachmat.rdlc"; // *** THAY BẰNG ĐƯỜNG DẪN ĐÚNG ***

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
                ReportDataSource rds = new ReportDataSource("dsBCsachmat", dt);
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
