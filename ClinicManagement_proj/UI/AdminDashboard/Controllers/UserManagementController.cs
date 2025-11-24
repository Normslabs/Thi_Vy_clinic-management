using ClinicManagement_proj.BLL.Services;
using System.Windows.Forms;
using System;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the User Management panel
    /// </summary>
    public class UserManagementController : IPanelController
    {
        private readonly Panel panel;
        private readonly UserService userService;
        private DataGridView dgvUsers => (DataGridView)panel.Controls["dgvUsers"];

        public Panel Panel => panel;

        public UserManagementController(Panel panel)
        {
            this.panel = panel;
            this.userService = new UserService();
        }

        public void Initialize()
        {
            // Setup initial state, data bindings, etc.
            // This would be called once during dashboard initialization
            Button btnUsrSubmit = (Button)panel.Controls["btnUsrSubmit"];
            btnUsrSubmit.Click += BtnUsrSubmit_Click;
        }

        public void OnShow()
        {
            LoadUsers();
            ComboBox comboRoles = (ComboBox)panel.Controls["comboRoles"];
            // comboRoles.DataSource = userService.GetRoleNames();
        }

        private void LoadUsers()
        {
            var users = userService.GetAllUsers();
            dgvUsers.DataSource = users;
        }

        private void BtnUsrSubmit_Click(object sender, EventArgs e)
        {
            TextBox txtUsername = (TextBox)panel.Controls["txtUsrUsername"];
            TextBox txtPassword = (TextBox)panel.Controls["txtUsrPassword"];
            ComboBox comboRoles = (ComboBox)panel.Controls["comboRoles"];

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = comboRoles.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                // TODO: Show validation message
                return;
            }

            try
            {
                // userService.CreateUser(username, password, role);
                LoadUsers();
                ResetForm();
            }
            catch (Exception ex)
            {
                // TODO: Handle error, show message
            }
        }

        private void ResetForm()
        {
            ((TextBox)panel.Controls["txtUsrUsername"]).Text = "";
            ((TextBox)panel.Controls["txtUsrPassword"]).Text = "";
            ((ComboBox)panel.Controls["comboRoles"]).SelectedIndex = -1;
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
