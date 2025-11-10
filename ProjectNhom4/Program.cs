using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🔹 B1: Hiển thị form đăng nhập trước
            frmDangNhap dangNhap = new frmDangNhap();

            // Nếu đăng nhập thành công (form trả về DialogResult.OK)
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                // 🔹 B2: Mở form menu chính
                Application.Run(new frmMenu());
            }
        }


    }
    
}
