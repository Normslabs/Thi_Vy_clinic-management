using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement_proj.UI.AdminDashboard.CustomPanels {
    internal interface IDashboardPanel {

        /// <summary>
        /// Called when the panel becomes visible
        /// </summary>
        void OnShown();

        /// <summary>
        /// Called when the panel is hidden
        /// </summary>
        void OnHidden();

    }
}
