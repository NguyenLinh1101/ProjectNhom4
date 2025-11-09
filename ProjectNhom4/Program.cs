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
            Application.Run(new frmMenu());
        }
            Application.Run(new MainForm());
        }
    }
    public class MainForm : Form
    {
        private QLSach_Ribbon qlSach;

        public MainForm()
        {
           qlSach = new QLSach_Ribbon();
           qlSach.Dock = DockStyle.Fill;
           this.Controls.Add(qlSach);
           this.Text = "Quản Lý Sách";
           this.WindowState = FormWindowState.Maximized;
       }
    }
}
