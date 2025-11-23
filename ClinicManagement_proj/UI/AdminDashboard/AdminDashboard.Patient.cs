using ClinicManagement_proj.BLL.Utils;
using System;

namespace ClinicManagement_proj.UI
{
    public partial class AdminDashboard
    {
        /// <summary>
        /// Reset the patient registration form to initial state
        /// </summary>
        private void ResetPatientForm()
        {
            // TODO: Implementation pending
            txtPFName.Text = string.Empty;
            txtPLName.Text = string.Empty;
            txtMedicalNumber.Text = string.Empty;
            dateDoB.Value = DateTime.Now;
            txtPPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        /// <summary>
        /// Enter edit mode for patient registration
        /// </summary>
        private void EnterPatientEditMode()
        {
            // TODO: Implementation pending
        }

        /// <summary>
        /// Handle patient selection from grid
        /// </summary>
        private void dgvPatients_Click(object sender, EventArgs e)
        {
            // TODO: Implementation pending
        }

        /// <summary>
        /// Cancel patient form operation
        /// </summary>
        private void btnPatientCancel_Click(object sender, EventArgs e)
        {
            ResetPatientForm();
        }

        /// <summary>
        /// Submit patient form (create or update)
        /// </summary>
        private void btnPatientSubmit_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("Patient operation simulated!", NotificationType.Info);
            ResetPatientForm();
        }

        /// <summary>
        /// Delete selected patient
        /// </summary>
        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            NotificationManager.AddNotification("Patient delete simulated!", NotificationType.Info);
            ResetPatientForm();
        }
    }
}