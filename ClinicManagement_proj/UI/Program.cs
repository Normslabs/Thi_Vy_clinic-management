using ClinicManagement_proj.BLL;
using ClinicManagement_proj.UI;
using System;
using System.Windows.Forms;

namespace ClinicManagement_proj
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

            // TODO: SUGGESTION
            // Replaced the straight to Form initialization with the
            // ClinicApp bootstrapping & initialization
            new ClinicApp().Run();
            //Application.Run(new LoginForm());
        }
    }
}
