using CreativeWorkshop.Services;
using CreativeWorkshop.View;
using System;
using System.Windows.Forms;

namespace CreativeWorkshop
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            DatabaseService.Init();
            Application.Run(new MainForm());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            DatabaseService.CloseConnection();
        }
    }
}
