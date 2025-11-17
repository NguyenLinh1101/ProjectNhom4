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

namespace ProjectNhom4.Reports
{
    public partial class frmSachmuonnhieunhat : Form
    {
        string connectionString = "Data Source=LAPTOP-31TAL89T\\SQLEXPRESS03;Initial Catalog=dataThuvien2;Integrated Security=True;Encrypt=False\r\n";
        public frmSachmuonnhieunhat()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSachmuonnhieunhat_Load(object sender, EventArgs e)
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
                    SELECT TOP 10
                        DS.Ten_Dau_Sach AS TenDauSach,
                        DS.Nam_XB AS NXB,         
                        DS.Ma_Chu_De AS MaChuDe,      
                        DS.Gia_Bia AS GiaBia,
                        COUNT(CTPM.Ma_Sach) AS SoLuotMuon
                    FROM
                        CT_PHIEU_MUON AS CTPM
                    JOIN
                        PHIEU_MUON AS PM ON CTPM.Ma_Phieu_Muon = PM.Ma_Phieu_Muon
                    JOIN
                        SACH AS S ON CTPM.Ma_Sach = S.Ma_Sach
                    JOIN
                        DAU_SACH AS DS ON S.Ma_Dau_Sach = DS.Ma_Dau_Sach
                    WHERE
                        PM.Ngay_Muon BETWEEN @TuNgay AND @DenNgay
                    GROUP BY
                        DS.Ma_Dau_Sach, 
                        DS.Ten_Dau_Sach, 
                        DS.Gia_Bia,
                        DS.Nam_XB,         -- << PHẢI THÊM VÀO GROUP BY
                        DS.Ma_Chu_De       -- << PHẢI THÊM VÀO GROUP BY
                    ORDER BY
                        SoLuotMuon DESC;";

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
                reportViewer1.LocalReport.ReportPath = @"Reports\BCsachmuonnhieunhat.rdlc"; // *** THAY BẰNG ĐƯỜNG DẪN ĐÚNG ***

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
                ReportDataSource rds = new ReportDataSource("dssachmuonnhieunhat", dt);
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
