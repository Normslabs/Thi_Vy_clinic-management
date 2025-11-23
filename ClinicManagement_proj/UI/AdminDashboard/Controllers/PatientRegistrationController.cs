using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Patient Registration panel
    /// </summary>
    public class PatientRegistrationController : IPanelController
    {
        private readonly Panel panel;
        private readonly AdminDashboard dashboard;

        public Panel Panel => panel;

        public PatientRegistrationController(Panel panel, AdminDashboard dashboard)
        {
            this.panel = panel;
            this.dashboard = dashboard;
        }

        public void Initialize()
        {
            // Setup initial state
        }

        public void OnShow()
        {
            // Refresh patient list when panel becomes visible
        }

        public void OnHide()
        {
            // Cleanup when leaving panel
        }

        public void Cleanup()
        {
            // Dispose resources if needed
        }
    }
}
