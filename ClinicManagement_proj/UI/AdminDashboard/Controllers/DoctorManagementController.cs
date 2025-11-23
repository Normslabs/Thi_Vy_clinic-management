using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Doctor Management panel
    /// </summary>
    public class DoctorManagementController : IPanelController
    {
        private readonly Panel panel;
        private readonly AdminDashboard dashboard;

        public Panel Panel => panel;

        public DoctorManagementController(Panel panel, AdminDashboard dashboard)
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
            // Refresh doctor list when panel becomes visible
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
