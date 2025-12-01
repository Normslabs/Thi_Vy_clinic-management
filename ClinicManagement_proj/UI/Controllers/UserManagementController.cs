using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.BLL.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the User Management panel
    /// </summary>
    public class UserManagementController : IPanelController
    {
        private readonly Panel panel;
        private readonly UserService userService;

        private DataGridView dgvUsers => (DataGridView)(panel.Controls["dgvUsers"] 
                ?? throw new Exception("No control named [dgvUsers] found in panel controls collection."));
        private GroupBox grpAdminForm => (GroupBox)(panel.Controls["grpAdminForm"] 
                ?? throw new Exception("No control named [grpAdminForm] found in panel controls collection."));
        private Panel pnlButtons => (Panel)(grpAdminForm.Controls["pnlButtons"] 
                ?? throw new Exception("No control named [pnlButtons] found in grpAdminForm controls collection."));
        private Button btnUsrCreate => (Button)(pnlButtons.Controls["btnUsrCreate"] 
                ?? throw new Exception("No control named [btnUsrCreate] found in pnlButtons controls collection."));
        private Button btnUsrUpdate => (Button)(pnlButtons.Controls["btnUsrUpdate"] 
                ?? throw new Exception("No control named [btnUsrUpdate] found in pnlButtons controls collection."));
        private Button btnUsrCancel => (Button)(pnlButtons.Controls["btnUsrCancel"] 
                ?? throw new Exception("No control named [btnUsrCancel] found in pnlButtons controls collection."));
        private Button btnUsrDelete => (Button)(pnlButtons.Controls["btnUsrDelete"] 
                ?? throw new Exception("No control named [btnUsrDelete] found in pnlButtons controls collection."));
        private Button btnUsrDisplay => (Button)(pnlButtons.Controls["btnUsrDisplay"] 
                ?? throw new Exception("No control named [btnUsrDisplay] found in pnlButtons controls collection."));
        private Button btnUsrSearch => (Button)(pnlButtons.Controls["btnUsrSearch"] 
                ?? throw new Exception("No control named [btnUsrSearch] found in pnlButtons controls collection."));
        private Panel pnlPassword => (Panel)(grpAdminForm.Controls["pnlPassword"] 
                ?? throw new Exception("No control named [pnlPassword] found in grpAdminForm controls collection."));
        private Button btnTogglePassword => (Button)(pnlPassword.Controls["btnTogglePassword"] 
                ?? throw new Exception("No control named [btnTogglePassword] found in pnlPassword controls collection."));
        private Button btnGenPassword => (Button)(pnlButtons.Controls["btnGenPassword"] 
                ?? throw new Exception("No control named [btnGenPassword] found in pnlButtons controls collection."));
        private TextBox txtUsrId => (TextBox)(grpAdminForm.Controls["txtUsrId"] 
                ?? throw new Exception("No control named [txtUsrId] found in grpAdminForm controls collection."));
        private TextBox txtUsrUsername => (TextBox)(grpAdminForm.Controls["txtUsrUsername"] 
                ?? throw new Exception("No control named [txtUsrUsername] found in grpAdminForm controls collection."));
        private TextBox txtUsrPassword => (TextBox)(pnlPassword.Controls["txtUsrPassword"] 
                ?? throw new Exception("No control named [txtUsrPassword] found in pnlPassword controls collection."));
        private ComboBox cmbRoles => (ComboBox)(grpAdminForm.Controls["cmbRoles"] 
                ?? throw new Exception("No control named [cmbRoles] found in grpAdminForm controls collection."));

        private bool isEditMode = false;
        private bool isPasswordChanged = false;

        public Panel Panel => panel;

        public UserManagementController(Panel panel)
        {
            this.panel = panel;
            this.userService = ClinicManagementApp.UserService;
        }

        public void Initialize()
        {
            btnUsrCreate.Click += new EventHandler(btnUsrCreate_Click);
            btnUsrUpdate.Click += new EventHandler(btnUsrUpdate_Click);
            btnUsrCancel.Click += new EventHandler(btnUsrCancel_Click);
            btnUsrDelete.Click += new EventHandler(btnUsrDelete_Click);
            btnUsrDisplay.Click += new EventHandler(btnUsrDisplay_Click);
            btnUsrSearch.Click += new EventHandler(btnUsrSearch_Click);
            btnTogglePassword.Click += new EventHandler(btnTogglePassword_Click);
            btnGenPassword.Click += new EventHandler(btnGenPassword_Click);
            txtUsrPassword.TextChanged += new EventHandler(txtUsrPassword_TextChanged);
            dgvUsers.Click += new EventHandler(dgvUsers_Click);
            dgvUsers.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvUsers_CellFormatting);
        }

        public void OnShow()
        {
            LoadUsers();
            ResetUsrForm();

            cmbRoles.DataSource = userService.GetAllRoles();
        }

        private void LoadUsers()
        {
            var users = userService.GetAllUsers();
            dgvUsers.DataSource = users;

            dgvUsers.Columns["PasswordHash"].Visible = false;

            dgvUsers.Columns["Id"].HeaderText = "User ID";
            dgvUsers.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns["Id"].DisplayIndex = 0;

            dgvUsers.Columns["Username"].HeaderText = "Username";
            dgvUsers.Columns["Username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.Columns["Username"].DisplayIndex = 1;

            dgvUsers.Columns["CreatedAt"].HeaderText = "Created At";
            dgvUsers.Columns["CreatedAt"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            dgvUsers.Columns["CreatedAt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns["CreatedAt"].DisplayIndex = 3;

            dgvUsers.Columns["ModifiedAt"].HeaderText = "Modified At";
            dgvUsers.Columns["ModifiedAt"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            dgvUsers.Columns["ModifiedAt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns["ModifiedAt"].DisplayIndex = 4;

            dgvUsers.Columns["Roles"].HeaderText = "Role";
            dgvUsers.Columns["Roles"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.Columns["Roles"].DisplayIndex = 2;

            dgvUsers.AutoResizeColumns();
        }

        /// <summary>
        /// Reset the user management form to initial state
        /// </summary>
        private void ResetUsrForm()
        {
            txtUsrPassword.Text = string.Empty;
            cmbRoles.SelectedIndex = -1;
            isEditMode = false;
            isPasswordChanged = false;
            btnUsrCancel.Visible = false;
            btnUsrDelete.Visible = false;
            dgvUsers.ClearSelection();
            grpAdminForm.Text = "Create User";
            txtUsrPassword.UseSystemPasswordChar = true;
            btnTogglePassword.Text = "Show";
            txtUsrPassword.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Enter edit mode for user management
        /// </summary>
        private void EnterUsrEditMode()
        {
            isEditMode = true;
            btnUsrCancel.Visible = true;
            btnUsrDelete.Visible = true;
            txtUsrPassword.Text = string.Empty;
            txtUsrPassword.BackColor = SystemColors.ControlDark;
            isPasswordChanged = false;
            grpAdminForm.Text = "Edit User";
        }

        /// <summary>
        /// Handle password text change to track modifications
        /// </summary>
        private void txtUsrPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsrPassword.Text.Length == 0)
            {
                txtUsrPassword.BackColor = SystemColors.ControlDark;
            }
            else
            {
                txtUsrPassword.BackColor = SystemColors.Window;
                if (!isPasswordChanged)
                    isPasswordChanged = true;
            }
        }

        /// <summary>
        /// Handle create user button click
        /// </summary>
        private void btnUsrCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsrUsername.Text.Trim();
            string password = txtUsrPassword.Text.Trim();
            var selectedRole = cmbRoles.SelectedItem as RoleDTO;

            try
            {
                userService.CreateUser(
                    new UserDTO
                    {
                        Username = txtUsrUsername.Text.Trim(),
                        Roles = new List<RoleDTO> { selectedRole }
                    }, password);
                NotificationManager.AddNotification("User created successfully!", NotificationType.Info);
                LoadUsers();
                ResetUsrForm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                NotificationManager.AddNotification($"Error: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Handle update user button click
        /// </summary>
        private void btnUsrUpdate_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                NotificationManager.AddNotification("Not in edit mode!", NotificationType.Error);
                return;
            }

            if (dgvUsers.CurrentRow == null)
            {
                NotificationManager.AddNotification("Please select a user to update!", NotificationType.Error);
                return;
            }

            UserDTO userToUpdate = (UserDTO)dgvUsers.CurrentRow.DataBoundItem;

            userToUpdate.Username = txtUsrUsername.Text.Trim();
            userToUpdate.Roles = new List<RoleDTO> { cmbRoles.SelectedItem as RoleDTO };

            string newPassword = (isPasswordChanged) ? txtUsrPassword.Text.Trim() : null;

            try
            {
                userService.UpdateUser(userToUpdate, newPassword);
            }
            catch (Exception ex)
            {
                NotificationManager.AddNotification($"Error: {ex.Message}", NotificationType.Error);
                return;
            }

            try
            {
                NotificationManager.AddNotification("User updated successfully!", NotificationType.Info);
                LoadUsers();
                ResetUsrForm();
            }
            catch (Exception ex)
            {
                NotificationManager.AddNotification($"Error: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Handle display users button click
        /// </summary>
        private void btnUsrDisplay_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        /// <summary>
        /// Handle search user button click
        /// </summary>
        private void btnUsrSearch_Click(object sender, EventArgs e)
        {
            string idText = txtUsrId.Text.Trim();
            string username = txtUsrUsername.Text.Trim();

            List<UserDTO> users = null;

            if (!string.IsNullOrEmpty(idText))
            {
                if (!int.TryParse(idText, out int userId))
                {
                    NotificationManager.AddNotification("Invalid user id!", NotificationType.Error);
                    return;
                }
                users = userService.Search(userId);
            }
            else if (!string.IsNullOrEmpty(username))
            {
                users = userService.Search(username);
            }
            else
            {
                NotificationManager.AddNotification("Enter user id or username to search!", NotificationType.Error);
                return;
            }

            try
            {
                if (users != null && users.Any())
                {
                    dgvUsers.DataSource = users;
                    if (dgvUsers.RowCount > 0)
                    {
                        UserDTO user = (UserDTO)dgvUsers.Rows[0].DataBoundItem;
                        txtUsrId.Text = user.Id.ToString();
                        txtUsrUsername.Text = user.Username;
                        if (user.Roles.Any())
                        {
                            cmbRoles.SelectedItem = user.Roles.First();
                        }
                        EnterUsrEditMode();
                    }
                }
                else
                {
                    NotificationManager.AddNotification("User not found!", NotificationType.Info);
                }
            }
            catch (Exception ex)
            {
                NotificationManager.AddNotification($"Error: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Handle user selection from grid
        /// </summary>
        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                UserDTO selectedUser = (UserDTO)dgvUsers.CurrentRow.DataBoundItem;
                txtUsrId.Text = selectedUser.Id.ToString();
                txtUsrUsername.Text = selectedUser.Username;
                txtUsrPassword.Text = string.Empty;
                if (selectedUser.Roles.Any())
                {
                    cmbRoles.SelectedItem = selectedUser.Roles.First();
                }
                EnterUsrEditMode();
            }
        }

        /// <summary>
        /// Cancel user form operation
        /// </summary>
        private void btnUsrCancel_Click(object sender, EventArgs e)
        {
            ResetUsrForm();
        }

        /// <summary>
        /// Toggle password visibility
        /// </summary>
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtUsrPassword.UseSystemPasswordChar = !txtUsrPassword.UseSystemPasswordChar;
            if (txtUsrPassword.UseSystemPasswordChar)
            {
                btnTogglePassword.Text = "Show";
            }
            else
            {
                btnTogglePassword.Text = "Hide";
            }
        }

        /// <summary>
        /// Delete selected user
        /// </summary>
        private void btnUsrDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UserDTO user = (UserDTO)dgvUsers.CurrentRow.DataBoundItem;
                userService.DeleteUser(user);
                NotificationManager.AddNotification("User deleted successfully!", NotificationType.Info);
                LoadUsers();
                ResetUsrForm();
            }
            catch (Exception ex)
            {
                NotificationManager.AddNotification($"Error: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Generate a random password
        /// </summary>
        private void btnGenPassword_Click(object sender, EventArgs e)
        {
            string generatedPassword = GeneratePassword();
            txtUsrPassword.Text = generatedPassword;
        }

        public void OnHide()
        {
            // Cleanup when leaving panel
        }

        public void Cleanup()
        {
            // Dispose resources if needed
        }

        private string GeneratePassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digitChars = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";
            const string allChars = upperChars + lowerChars + digitChars + specialChars;

            var random = new Random();
            string password;

            do
            {
                password = "";
                for (int i = 0; i < 15; i++)
                {
                    password += allChars[random.Next(allChars.Length)];
                }
            } while (!IsPasswordValid(password));

            return password;
        }

        private bool IsPasswordValid(string password)
        {
            try
            {
                UserDTO.ValidatePassword(password);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Handle DataGridView cell formatting to display only the first role
        /// </summary>
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["Roles"].Index && e.Value != null)
            {
                var roles = e.Value as ICollection<RoleDTO>;
                if (roles != null && roles.Any())
                {
                    e.Value = roles.First().RoleName;
                }
                else
                {
                    e.Value = string.Empty;
                }
                e.FormattingApplied = true;
            }
        }
    }
}
