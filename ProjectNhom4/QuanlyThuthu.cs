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
    public partial class QuanlyThuthu : UserControl
    {
        string strCon = @"Data Source=DESKTOP-ST1KSE3\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";

        string maDauSach;
        public QuanlyThuthu()
        {
            InitializeComponent();
        }

      
        private void QuanlyThuthu_Load(object sender, EventArgs e)
        {

        }
    }
}
