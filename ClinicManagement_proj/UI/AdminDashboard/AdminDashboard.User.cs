using ClinicManagement_proj.BLL.Utils;
using System;
using System.Drawing;

namespace ClinicManagement_proj.UI
{
    public partial class AdminDashboard
    {
        /// <summary>
        /// Reset the user management form to initial state
        /// </summary>
        private void ResetUsrForm()
        {
            txtUsrUsername.Text = string.Empty;
            txtUsrPassword.Text = string.Empty;
            comboRoles.SelectedIndex = -1;
            isEditMode = false;
            isPasswordChanged = false;
            btnUsrCancel.Visible = false;
            btnUsrDelete.Visible = false;
            dgvUsers.DataSource = null;
            dgvUsers.ClearSelection();
            btnUsrSubmit.Text = "Create";
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
            btnUsrSubmit.Text = "Update";
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
        /// Handle user selection from grid
        /// </summary>
        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                txtUsrUsername.Text = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
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
        /// Submit user form (create or update)
        /// </summary>
        private void btnUsrSubmit_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("User operation simulated!", NotificationType.Info);
            ResetUsrForm();
        }

        /// <summary>
        /// Delete selected user
        /// </summary>
        private void btnUsrDelete_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("User delete simulated!", NotificationType.Info);
            ResetUsrForm();
        }

        /// <summary>
        /// Generate a random password
        /// </summary>
        private void btnGenPassword_Click(object sender, EventArgs e)
        {
            string generatedPassword = "GeneratedPassword123"; // Simulated
            txtUsrPassword.Text = generatedPassword;
        }
    }
}
