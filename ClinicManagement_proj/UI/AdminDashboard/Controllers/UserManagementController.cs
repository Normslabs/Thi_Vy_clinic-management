using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the User Management panel
    /// </summary>
    public class UserManagementController : IPanelController
    {
        private readonly Panel panel;
        private readonly AdminDashboard dashboard;

        public Panel Panel => panel;

        public UserManagementController(Panel panel, AdminDashboard dashboard)
        {
            this.panel = panel;
            this.dashboard = dashboard;
        }

        public void Initialize()
        {
            // Setup initial state, data bindings, etc.
            // This would be called once during dashboard initialization
        }

        public void OnShow()
        {
            // Refresh data when panel becomes visible
            // Implementation delegated to dashboard partial class
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
