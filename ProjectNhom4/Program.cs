using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new frmChuDe());
        }
    }
    //public class MainForm : Form
    //{
     //   private QL_DauSach qlDauSach;

       // public MainForm()
       // {
         //   qlDauSach = new QL_DauSach();
           // qlDauSach.Dock = DockStyle.Fill;
            //this.Controls.Add(qlDauSach);
            //this.Text = "Quản Lý Đầu Sách";
            //this.WindowState = FormWindowState.Maximized;
       //}
    //}
}
