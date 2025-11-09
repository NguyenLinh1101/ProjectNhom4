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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoaiSach());
        }
    }
    //public class MainForm : Form
    //{
    //    private UC_QuanlyThongTinTacGia qlSach;

    //    public MainForm()
    //    {
    //        qlSach = new UC_QuanlyThongTinTacGia();
    //        qlSach.Dock = DockStyle.Fill;
    //        this.Controls.Add(qlSach);
    //        this.Text = "Quản Lý Sách";
    //        this.WindowState = FormWindowState.Maximized;
    //    }
    //}
}
