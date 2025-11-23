using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Manages navigation between different panels in the dashboard
    /// </summary>
    public class NavigationManager
    {
        private readonly Dictionary<Button, IPanelController> navigationMap;
        private readonly Color defaultColor;
        private readonly Color activeColor;
        private Button activeButton;
        private IPanelController activePanel;

        public NavigationManager(Color defaultColor, Color activeColor)
        {
            this.navigationMap = new Dictionary<Button, IPanelController>();
            this.defaultColor = defaultColor;
            this.activeColor = activeColor;
        }

        /// <summary>
        /// Register a button-panel pair for navigation
        /// </summary>
        public void RegisterPanel(Button button, IPanelController panelController)
        {
            navigationMap[button] = panelController;
            button.Click += (s, e) => NavigateTo(button);
            button.BackColor = defaultColor;
        }

        /// <summary>
        /// Navigate to the panel associated with the given button
        /// </summary>
        public void NavigateTo(Button button)
        {
            if (!navigationMap.ContainsKey(button)) return;

            // Hide current panel
            if (activePanel != null)
            {
                activePanel.Panel.Visible = false;
                activePanel.OnHide();
            }

            // Reset previous button
            if (activeButton != null)
            {
                activeButton.BackColor = defaultColor;
            }

            // Show new panel
            var panelController = navigationMap[button];
            panelController.OnShow();
            panelController.Panel.Visible = true;
            panelController.Panel.BringToFront();

            // Set active button
            button.BackColor = activeColor;
            activeButton = button;
            activePanel = panelController;
        }

        /// <summary>
        /// Initialize all registered panels
        /// </summary>
        public void InitializeAll()
        {
            foreach (var controller in navigationMap.Values)
            {
                controller.Initialize();
            }
        }

        /// <summary>
        /// Cleanup all registered panels
        /// </summary>
        public void CleanupAll()
        {
            foreach (var controller in navigationMap.Values)
            {
                controller.Cleanup();
            }
        }
    }
}