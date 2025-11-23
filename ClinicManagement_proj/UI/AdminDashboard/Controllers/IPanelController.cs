using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Interface for dashboard panel controllers to enforce consistent behavior
    /// </summary>
    public interface IPanelController
    {
        /// <summary>
        /// The panel managed by this controller
        /// </summary>
        Panel Panel { get; }

        /// <summary>
        /// Called when the panel becomes visible
        /// </summary>
        void OnShow();

        /// <summary>
        /// Called when the panel is hidden
        /// </summary>
        void OnHide();

        /// <summary>
        /// Initialize the panel and its controls
        /// </summary>
        void Initialize();

        /// <summary>
        /// Cleanup resources when the panel is disposed
        /// </summary>
        void Cleanup();
    }
}
