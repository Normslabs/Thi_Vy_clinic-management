using ClinicManagement_proj.BLL.Utils;
using System;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Patient Registration panel
    /// </summary>
    public class PatientRegistrationController : IPanelController
    {
        private readonly Panel panel;
        private DataGridView dgvPatients => (DataGridView)panel.Controls["dgvRegPatients"];
        private GroupBox grpPatientRegistration => (GroupBox)panel.Controls["grpPatientRegistration"];
        private TextBox txtPFName => (TextBox)grpPatientRegistration.Controls["txtPFName"];
        private TextBox txtPLName => (TextBox)grpPatientRegistration.Controls["txtPLName"];
        private TextBox txtMedicalNumber => (TextBox)grpPatientRegistration.Controls["txtMedicalNumber"];
        private DateTimePicker dateDoB => (DateTimePicker)grpPatientRegistration.Controls["dateDoB"];
        private TextBox txtPPhone => (TextBox)grpPatientRegistration.Controls["txtPPhone"];
        private TableLayoutPanel layoutPatientButtons => (TableLayoutPanel)grpPatientRegistration.Controls["layoutPatientButtons"];
        private Button btnPatientSubmit => (Button)layoutPatientButtons.Controls["btnPCreate"];
        private Button btnPatientCancel => (Button)layoutPatientButtons.Controls["btnPCancel"];
        private Button btnPatientDelete => (Button)layoutPatientButtons.Controls["btnPDelete"];

        public Panel Panel => panel;

        public PatientRegistrationController(Panel panel)
        {
            this.panel = panel;
        }

        public void Initialize()
        {
            btnPatientSubmit.Click += new EventHandler(btnPatientSubmit_Click);
            btnPatientCancel.Click += new EventHandler(btnPatientCancel_Click);
            btnPatientDelete.Click += new EventHandler(btnPatientDelete_Click);
            dgvPatients.Click += new EventHandler(dgvPatients_Click);
        }

        public void OnShow()
        {
            ResetPatientForm();
            LoadPatients();
        }

        private void LoadPatients()
        {
            // var patients = patientService.GetAllPatients();
            // dgvPatients.DataSource = patients;
        }

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
