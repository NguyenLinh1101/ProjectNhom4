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
            Application.Run(new MainForm());
        }
    }
    public class MainForm : Form
    {
        private QL_DauSach qlSach;

        public MainForm()
        {
            qlSach = new QL_DauSach();
            qlSach.Dock = DockStyle.Fill;
            this.Controls.Add(qlSach);
            this.Text = "Quản Lý Sách";
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
