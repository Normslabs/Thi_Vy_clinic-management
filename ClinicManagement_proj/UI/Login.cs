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
            // Removed non-existent settings
            // txtUsername.Text = Properties.Settings.Default.Username;
            // txtPassword.Text = Properties.Settings.Default.Password;

            // if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            // {
            //     checkRememberPassword.Checked = true;
            // }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Removed BLL logic
            Form dashboard = new AdminDashboard();

            // Removed non-existent settings
            // if (checkRememberPassword.Checked)
            // {
            //     Properties.Settings.Default.Username = txtUsername.Text;
            //     Properties.Settings.Default.Password = txtPassword.Text;
            //     Properties.Settings.Default.Save();
            // }
            // else
            // {
            //     Properties.Settings.Default.Username = "";
            //     Properties.Settings.Default.Password = "";
            //     Properties.Settings.Default.Save();
            // }

            this.Hide();
            dashboard.ShowDialog();
            Close();
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
