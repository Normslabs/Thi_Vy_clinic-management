using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.Services;
using System;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    public partial class LoginForm : Form
    {

        // TODO: SUGGESTION
        // Added fields for the diverse services that need to be passed to the panel controllers
        private RoleService roleService;
        private UserService userService;
        private PatientService patientService;
        private DoctorService doctorService;
        private AppointmentService appointmentService;

        // TODO: SUGGESTION
        // changed constructor to use the UserService instead of the LoginService and
        // to receive it instead of creating it in-class
        public LoginForm(RoleService roleService, UserService userService, PatientService patientService, 
            DoctorService doctorService, AppointmentService appointmentService) {
            this.roleService = roleService;
            this.userService = userService;
            this.patientService = patientService;
            this.doctorService = doctorService;
            this.appointmentService = appointmentService;
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

            // TODO: SUGGESTION
            // removed on-the-spot creation of the login service and switch to using the
            // constructor-received one.
            //var userService = new LoginService();

            // TODO: SUGGESTION
            // Changed to the new LoginService.LogUserIn method
            var user = userService.LogUserIn(txtUsername.Text, txtPassword.Text);
            //var user = userService.Authenticate(txtUsername.Text, txtPassword.Text);

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
                    dashboard = new AdminDashboard(this.roleService, this.userService, 
                        this.patientService, this.doctorService, this.appointmentService);
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
