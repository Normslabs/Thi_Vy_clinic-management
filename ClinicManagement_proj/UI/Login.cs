using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.Services;
using System;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Load remembered credentials
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                checkRememberPassword.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            var user = loginService.Authenticate(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                // Set the current user
                CurrentUser.User = user;

                // Save or clear settings based on remember checkbox
                if (checkRememberPassword.Checked)
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                Form dashboard = null;

                // Determine dashboard based on role
                if (UserService.CurrentUserHasRole(UserService.UserRoles.Administrator))
                {
                    dashboard = new AdminDashboard();
                }
                else if (UserService.CurrentUserHasRole(UserService.UserRoles.Doctor))
                {
                    dashboard = new DoctorDashboard();
                }
                else if (UserService.CurrentUserHasRole(UserService.UserRoles.Receptionist))
                {
                    dashboard = new ReceptionistDashboard();
                }
                else
                {
                    MessageBox.Show("No dashboard available for your role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
                dashboard.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnLogin.PerformClick(); }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnLogin.PerformClick(); }
        }
    }
}
