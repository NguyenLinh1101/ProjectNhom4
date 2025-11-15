using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Types;
using ProjectNhom4.Reports;

namespace ProjectNhom4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDangNhap()); // chạy form đăng nhập đầu tiên
            Application.Run(new frmMenu()); // chạy form menu chính đầu tiên
        }


    }
    
}
