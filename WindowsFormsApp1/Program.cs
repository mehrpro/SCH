using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolApp.Views.SystemForm;

namespace SchoolApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new StructureMap.Container(new TypeRegistery());
            var frmlogin = container.GetInstance<LoginForm>();
            var result = frmlogin.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            var mainform = container.GetInstance<MainForm>();
            Application.Run(mainform);
        }
    }
}
