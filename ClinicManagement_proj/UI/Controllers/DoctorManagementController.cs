using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.BLL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Doctor Management panel
    /// </summary>
    public class DoctorManagementController : IPanelController
    {
        private readonly Panel panel;
        private readonly DoctorService doctorService;
        private DataGridView dgvDoctors => (DataGridView)(panel.Controls["dgvDoctors"]
                ?? throw new Exception("No control named [dgvDoctors] found in panel controls collection."));
        private GroupBox grpDoctorMgmt => (GroupBox)(panel.Controls["grpDoctorMgmt"]
                ?? throw new Exception("No control named [grpDoctorMgmt] found in panel controls collection."));
        private TableLayoutPanel actionsLayout => (TableLayoutPanel)(grpDoctorMgmt.Controls["layoutDoctorActions"]
                ?? throw new Exception("No control named [layoutDoctorActions] found in grpDoctorMgmt controls collection."));
        private TextBox txtDoctorId => (TextBox)(grpDoctorMgmt.Controls["txtDoctorId"]
                ?? throw new Exception("No control named [txtDoctorId] found in grpDoctorMgmt controls collection"));
        private TextBox txtDoctorFName => (TextBox)(grpDoctorMgmt.Controls["txtDoctorFName"]
                ?? throw new Exception("No control named [txtDoctorFName] found in grpDoctorMgmt controls collection."));
        private TextBox txtDoctorLName => (TextBox)(grpDoctorMgmt.Controls["txtDoctorLName"]
                ?? throw new Exception("No control named [txtDoctorLName] found in grpDoctorMgmt controls collection."));
        private TextBox txtDoctorLicense => (TextBox)(grpDoctorMgmt.Controls["txtDoctorLicense"]
                ?? throw new Exception("No control named [txtDoctorLicense] found in grpDoctorMgmt controls collection."));
        private ComboBox cmbSpecialization => (ComboBox)(grpDoctorMgmt.Controls["cmbSpecialization"]
                ?? throw new Exception("No control named [cmbSpecialization] found in grpDoctorMgmt controls collection."));
        private Button btnDoctorCreate => (Button)(actionsLayout.Controls["btnDoctorCreate"]
                ?? throw new Exception("No control named [btnDoctorCreate] found in actionsLayout controls collection."));
        private Button btnDoctorUpdate => (Button)(actionsLayout.Controls["btnDoctorUpdate"]
                ?? throw new Exception("No control named [btnDoctorUpdate] found in actionsLayout controls collection."));
        private Button btnDoctorSearch => (Button)(actionsLayout.Controls["btnDoctorSearch"]
                ?? throw new Exception("No control named [btnDoctorSearch] found in actionsLayout controls collection."));
        private Button btnDoctorCancel => (Button)(actionsLayout.Controls["btnDoctorCancel"]
                ?? throw new Exception("No control named [btnDoctorCancel] found in actionsLayout controls collection."));
        private Button btnDoctorDelete => (Button)(actionsLayout.Controls["btnDoctorDelete"]
                ?? throw new Exception("No control named [btnDoctorDelete] found in actionsLayout controls collection."));

        private bool isEditMode = false;

        public Panel Panel => panel;

        public DoctorManagementController(Panel panel)
        {
            this.doctorService = ClinicManagementApp.DoctorService;
            this.panel = panel;
        }

        public void Initialize()
        {
            btnDoctorCreate.Click += new EventHandler(btnDoctorCreate_Click);
            btnDoctorUpdate.Click += new EventHandler(btnDoctorUpdate_Click);
            btnDoctorSearch.Click += new EventHandler(btnDoctorSearch_Click);
            btnDoctorCancel.Click += new EventHandler(btnDoctorCancel_Click);
            btnDoctorDelete.Click += new EventHandler(btnDoctorDelete_Click);
            dgvDoctors.Click += new EventHandler(dgvDoctors_Click);
            dgvDoctors.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvDoctors_CellFormatting);

            // Ensure scrollbars are enabled
            dgvDoctors.ScrollBars = ScrollBars.Both;
        }

        public void OnShow()
        {
            ResetDoctorForm();
            LoadDoctors();

            cmbSpecialization.DataSource = doctorService.GetAllSpecialties();
        }

        private void LoadDoctors()
        {
            var doctors = doctorService.GetAllDoctors();
            dgvDoctors.DataSource = doctors;

            dgvDoctors.Columns["Id"].HeaderText = "Doctor ID";
            dgvDoctors.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDoctors.Columns["Id"].DisplayIndex = 0;

            dgvDoctors.Columns["FirstName"].HeaderText = "First Name";
            dgvDoctors.Columns["FirstName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDoctors.Columns["FirstName"].DisplayIndex = 1;

            dgvDoctors.Columns["LastName"].HeaderText = "Last Name";
            dgvDoctors.Columns["LastName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDoctors.Columns["LastName"].DisplayIndex = 2;

            dgvDoctors.Columns["LicenseNumber"].HeaderText = "License Number";
            dgvDoctors.Columns["LicenseNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDoctors.Columns["LicenseNumber"].DisplayIndex = 3;

            dgvDoctors.Columns["CreatedAt"].HeaderText = "Created At";
            dgvDoctors.Columns["CreatedAt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDoctors.Columns["CreatedAt"].DisplayIndex = 4;

            dgvDoctors.Columns["ModifiedAt"].HeaderText = "Modified At";
            dgvDoctors.Columns["ModifiedAt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDoctors.Columns["ModifiedAt"].DisplayIndex = 5;

            dgvDoctors.Columns["Appointments"].Visible = false;
            dgvDoctors.Columns["DoctorSchedules"].Visible = false;

            dgvDoctors.Columns["Specialties"].HeaderText = "Specialties";
            dgvDoctors.Columns["Specialties"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDoctors.Columns["Specialties"].DisplayIndex = 8;

            dgvDoctors.AutoResizeColumns();
            ResetDoctorForm();
        }

        private void dgvDoctors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvDoctors.Columns["Specialties"].Index && e.Value != null)
            {
                var specialties = (List<SpecialtyDTO>)e.Value;
                e.Value = string.Join(", ", specialties.Select(s => s.Name));
            }
        }

        /// <summary>
        /// Reset the doctor management form to initial state
        /// </summary>
        private void ResetDoctorForm()
        {
            dgvDoctors.ClearSelection();

            txtDoctorId.Text = string.Empty;
            txtDoctorFName.Text = string.Empty;
            txtDoctorLName.Text = string.Empty;
            txtDoctorLicense.Text = string.Empty;
            cmbSpecialization.SelectedIndex = -1;
            isEditMode = false;

            btnDoctorCreate.Visible = true;
            btnDoctorCancel.Visible = false;
            btnDoctorDelete.Visible = false;

            grpDoctorMgmt.Text = "Create New Doctor";
        }

        /// <summary>
        /// Enter edit mode for doctor form
        /// </summary>
        private void EnterDoctorEditMode()
        {
            isEditMode = true;
            btnDoctorCreate.Visible = false;
            btnDoctorCancel.Visible = true;
            btnDoctorDelete.Visible = true;
            grpDoctorMgmt.Text = "Edit Doctor";
        }

        /// <summary>
        /// Handle doctor selection from grid
        /// </summary>
        private void dgvDoctors_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null)
            {
                DoctorDTO selectedDoctor = (DoctorDTO)dgvDoctors.CurrentRow.DataBoundItem;
                txtDoctorId.Text = selectedDoctor.Id.ToString();
                txtDoctorFName.Text = selectedDoctor.FirstName;
                txtDoctorLName.Text = selectedDoctor.LastName;
                txtDoctorLicense.Text = selectedDoctor.LicenseNumber;
                
                if (selectedDoctor.Specialties.Any())
                {
                    cmbSpecialization.SelectedItem = selectedDoctor.Specialties.First();
                }
                EnterDoctorEditMode();
            }
        }

        /// <summary>
        /// Cancel doctor form operation
        /// </summary>
        private void btnDoctorCancel_Click(object sender, EventArgs e)
        {
            LoadDoctors();
            ResetDoctorForm();
        }

        /// <summary>
        /// Submit doctor form and Create or doctor
        /// </summary>
        private void btnDoctorCreate_Click(object sender, EventArgs e)
        {
            string name = txtDoctorFName.Text.Trim();
            string lastName = txtDoctorLName.Text.Trim();
            string licenseNumber = txtDoctorLicense.Text.Trim();
            var specialization = cmbSpecialization.SelectedItem as SpecialtyDTO;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName))
            {
                ClinicManagementApp.NotificationService.AddNotification("First Name and Last Name are required.", NotificationType.Warning);
                return;
            }

            if(string.IsNullOrEmpty(licenseNumber))
            {
                ClinicManagementApp.NotificationService.AddNotification("License Number is required.", NotificationType.Warning);
                return;
            }

            try
            {
                DoctorDTO newDoctor = new DoctorDTO
                {
                    Id = 0, // ID will be set by the database
                    FirstName = name,
                    LastName = lastName,
                    LicenseNumber = licenseNumber,
                    Specialties = specialization != null ? new List<SpecialtyDTO> { specialization } : new List<SpecialtyDTO>()
                };
                doctorService.CreateDoctor(newDoctor);
                ClinicManagementApp.NotificationService.AddNotification("Doctor created successfully.", NotificationType.Info);
                LoadDoctors();
                ResetDoctorForm();
            }
            catch (Exception ex)
            {
                ClinicManagementApp.NotificationService.AddNotification($"Error creating doctor: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Submit doctor form and Update existing doctor
        /// </summary>
        private void btnDoctorUpdate_Click(object sender, EventArgs e)
        {
            if (!isEditMode || dgvDoctors.CurrentRow == null)
            {
                ClinicManagementApp.NotificationService.AddNotification("Not in edit mode. Please select a doctor to edit.", NotificationType.Warning);
                return;
            }

            string idTxt = txtDoctorId.Text.Trim();
            string name = txtDoctorFName.Text.Trim();
            string lastName = txtDoctorLName.Text.Trim();
            string licenseNumber = txtDoctorLicense.Text.Trim();
            List<SpecialtyDTO> selectedSpecialties = new List<SpecialtyDTO> { cmbSpecialization.SelectedItem as SpecialtyDTO};

            DoctorDTO updatedDoctor = (DoctorDTO)dgvDoctors.CurrentRow.DataBoundItem;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrEmpty(licenseNumber))
            {
                ClinicManagementApp.NotificationService.AddNotification("Please fill out the required fields", NotificationType.Warning);
                return;
            }

            if (idTxt != updatedDoctor.Id.ToString())
            {
                ClinicManagementApp.NotificationService.AddNotification("Doctor ID cannot be changed.", NotificationType.Warning);
            }

            try
            {
                updatedDoctor.FirstName = name;
                updatedDoctor.LastName = lastName;
                updatedDoctor.LicenseNumber = licenseNumber;
                updatedDoctor.Specialties = selectedSpecialties.Where(s => s != null).ToList();
                doctorService.UpdateDoctor(updatedDoctor);
                ClinicManagementApp.NotificationService.AddNotification("Doctor updated successfully.", NotificationType.Info);
                LoadDoctors();
                ResetDoctorForm();
            }
            catch (Exception ex)
            {
                ClinicManagementApp.NotificationService.AddNotification($"Error updating doctor: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Search for doctor
        /// </summary>
        private void btnDoctorSearch_Click(object sender, EventArgs e)
        {
            string idText = txtDoctorId.Text.Trim();
            string firstName = txtDoctorFName.Text.Trim();
            string lastName = txtDoctorLName.Text.Trim();
            string licenseNumber = txtDoctorLicense.Text.Trim();

            List<DoctorDTO> doctors = null;

            if (!string.IsNullOrEmpty(idText))
            {
                if (!int.TryParse(idText, out int doctorId))
                {
                    ClinicManagementApp.NotificationService.AddNotification("Invalid Doctor ID format.", NotificationType.Error);
                    return;
                }
                doctors = doctorService.Search(doctorId);
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                doctors = doctorService.Search(firstName);
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                doctors = doctorService.Search(lastName);
            }
            else if (!string.IsNullOrEmpty(licenseNumber))
            {
                doctors = doctorService.SearchByLicense(licenseNumber);
            }
            else
            {
                ClinicManagementApp.NotificationService.AddNotification("Enter doctor id, first name, last name, or license number to search!", NotificationType.Warning);
                return;
            }

            if (doctors.Count == 0)
            {
                ClinicManagementApp.NotificationService.AddNotification("No doctors found matching the criteria.", NotificationType.Info);
                return;
            }

            try
            {
                dgvDoctors.DataSource = doctors;
                DoctorDTO doctor = (DoctorDTO)dgvDoctors.Rows[0].DataBoundItem;
                txtDoctorId.Text = doctor.Id.ToString();
                txtDoctorFName.Text = doctor.FirstName;
                txtDoctorLName.Text = doctor.LastName;
                txtDoctorLicense.Text = doctor.LicenseNumber;
                if (doctor.Specialties.Any())
                {
                    cmbSpecialization.SelectedItem = doctor.Specialties.First();
                }
                dgvDoctors.SelectedRows[0].Selected = true;
                EnterDoctorEditMode();
            }
            catch (Exception ex)
            {
                ClinicManagementApp.NotificationService.AddNotification($"Error during doctor search: {ex.Message}", NotificationType.Error);
            }
        }

        /// <summary>
        /// Delete selected doctor
        /// </summary>
        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorDTO doctor = (DoctorDTO)dgvDoctors.CurrentRow.DataBoundItem;
                doctorService.DeleteDoctor(doctor.Id);
                ClinicManagementApp.NotificationService.AddNotification("Doctor deleted successfully.", NotificationType.Info);
                LoadDoctors();
                ResetDoctorForm();
            }
            catch (Exception ex)
            {
                ClinicManagementApp.NotificationService.AddNotification($"Error deleting doctor: {ex.Message}", NotificationType.Error);
            }
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
