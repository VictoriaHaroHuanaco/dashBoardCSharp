using DashBoard.View;
using System;
using System.Windows.Forms;

namespace DashBoard
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm f = new LoginForm();
            f.Show();
            Application.Run();
        }
    }
}