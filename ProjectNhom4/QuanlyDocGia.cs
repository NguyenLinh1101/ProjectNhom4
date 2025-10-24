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
    public partial class UC_QuanlyDocGia : UserControl
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        public UC_QuanlyDocGia()
        {
            InitializeComponent();
        }
        private void LoadDocGia()
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select * from DocGia";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
                dv = new DataView(dt);
                dgvDocGia.DataSource = dv;
                dgvDocGia.Columns["HinhAnh"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //DB chưa có ảnh thì để ảnh mặc định
                foreach (DataGridViewRow row in dgvDocGia.Rows)
                {
                    if (row.Cells["HinhAnh"].Value == DBNull.Value)
                    {
                        row.Cells["HinhAnh"].Value = Properties.Resources.user;
                    }
                }
                ((DataGridViewImageColumn)dgvDocGia.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_QuanlyDocGia_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            openFile.Title = "Chọn ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picDocGia.Image = Image.FromFile(openFile.FileName);
            }
        }
        private void NapCT()
        {
            
        }
        private void dgvDocGia_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }
    }
}
