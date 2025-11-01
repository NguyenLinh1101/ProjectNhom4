using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Types;

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
            Application.Run(new frmBaocaosachmat());
        }
    }
    //public class MainForm : Form
    //{
    //    private Baocao qlSach;

    //    public MainForm()
    //    {
    //       qlSach = new Baocao(  );
    //       qlSach.Dock = DockStyle.Fill;
    //       this.Controls.Add(qlSach);
    //       this.Text = "Quản Lý Sách";
    //       this.WindowState = FormWindowState.Maximized;
    //   }
    //}
}
