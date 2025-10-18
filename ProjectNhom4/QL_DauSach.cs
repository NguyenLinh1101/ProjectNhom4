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
    public partial class QL_DauSach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool addNewFlag = false;
        public QL_DauSach() => InitializeComponent();

        private void grbTTDS_Enter(object sender, EventArgs e)
        {

        }

        private void QL_DauSach_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            dv.RowFilter = $"TenDauSach like '%{searchText}%'";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        // Add this method to handle the SelectedIndexChanged event for cboLoaiSach
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboLoaiSach.SelectedItem as DataRowView;
        }
    }
}
