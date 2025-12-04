using System;
using System.Windows.Forms;
using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.BLL.DTO;
using System.Drawing;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Reports panel
    /// </summary>
    public class ReportsController : IPanelController
    {
        private readonly Panel panel;
        private ViewsService viewsService;
        private DoctorService doctorService;
        private PatientService patientService;

        private PatientDTO selectedPatient = null;
        private DoctorDTO selectedDoctor = null;

        private bool isUpdatingPatientCombo = false;
        private bool isUpdatingDoctorCombo = false;

        private TabControl tabControlReports => (TabControl)(panel.Controls["tabControlReports"]
                ?? throw new Exception("No control named [tabControlReports] found in panel controls collection."));
        private TabPage tabPatientRecords => (TabPage)(tabControlReports.TabPages["tabPatientRecords"]
                ?? throw new Exception("No tab page named [tabPatientRecords] found in tabControlReports tab pages collection."));
        private DataGridView dgvPatientRecords => (DataGridView)(tabPatientRecords.Controls["dgvPatientRecords"]
                ?? throw new Exception("No control named [dgvPatientRecords] found in tabPatientRecords controls collection."));
        private Panel pnlPatientRecordsTop => (Panel)(tabPatientRecords.Controls["pnlPatientRecordsTop"]
                ?? throw new Exception("No control named [pnlPatientRecordsTop] found in tabPatientRecords controls collection."));
        private ComboBox cmbVwPatientSelect => (ComboBox)(pnlPatientRecordsTop.Controls["cmbVwPatientSelect"]
                ?? throw new Exception("No control named [cmbVwPatientSelect] found in pnlPatientRecordsTop controls collection."));
        private TabPage tabUpcomingAppointments => (TabPage)(tabControlReports.TabPages["tabUpcomingAppointments"]
                ?? throw new Exception("No tab page named [tabUpcomingAppointments] found in tabControlReports tab pages collection."));
        private DataGridView dgvUpcomingAppointments => (DataGridView)(tabUpcomingAppointments.Controls["dgvUpcomingAppointments"]
                ?? throw new Exception("No control named [dgvUpcomingAppointments] found in tabUpcomingAppointments controls collection."));
        private Panel pnlUpcomingApptTop => (Panel)(tabUpcomingAppointments.Controls["pnlUpcomingApptTop"]
                ?? throw new Exception("No control named [pnlUpcomingApptTop] found in tabUpcomingAppointments controls collection."));
        private ComboBox cmbVwDoctorSelect => (ComboBox)(pnlUpcomingApptTop.Controls["cmbVwDoctorSelect"]
                ?? throw new Exception("No control named [cmbVwDoctorSelect] found in pnlUpcomingApptTop controls collection."));

        public Panel Panel => panel;

        public ReportsController(Panel panel)
        {
            this.panel = panel;
            viewsService = ClinicManagementApp.ViewsService;
            doctorService = ClinicManagementApp.DoctorService;
            patientService = ClinicManagementApp.PatientService;
        }

        public void Initialize()
        {
            // Setup initial state
            cmbVwPatientSelect.TextChanged += new EventHandler(cmbVwPatientSelect_TextChanged);
            cmbVwPatientSelect.SelectedIndexChanged += new EventHandler(cmbVwPatientSelect_SelectedIndexChanged);
            cmbVwDoctorSelect.TextChanged += new EventHandler(cmbVwDoctorSelect_TextChanged);
            cmbVwDoctorSelect.SelectedIndexChanged += new EventHandler(cmbVwDoctorSelect_SelectedIndexChanged);
        }

        public void OnShow()
        {
            // Refresh reports when panel becomes visible
            LoadPatientRecords();
            LoadUpcomingAppointments();
            ResetCombos();
        }

        private void LoadPatientRecords(int? patientId = null)
        {
            dgvPatientRecords.DataSource = viewsService.GetPatientRecordsSummary(patientId);

            // Format columns
            if (dgvPatientRecords.Columns.Contains("PatientId")) dgvPatientRecords.Columns["PatientId"].Visible = false;
            if (dgvPatientRecords.Columns.Contains("PatientName")) dgvPatientRecords.Columns["PatientName"].HeaderText = "Patient Name";
            if (dgvPatientRecords.Columns.Contains("InsuranceNumber")) dgvPatientRecords.Columns["InsuranceNumber"].HeaderText = "Insurance Number";
            if (dgvPatientRecords.Columns.Contains("DateOfBirth")) dgvPatientRecords.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            if (dgvPatientRecords.Columns.Contains("PhoneNumber")) dgvPatientRecords.Columns["PhoneNumber"].HeaderText = "Phone Number";
            if (dgvPatientRecords.Columns.Contains("TotalAppointments")) dgvPatientRecords.Columns["TotalAppointments"].HeaderText = "Total Appointments";
            if (dgvPatientRecords.Columns.Contains("LastAppointmentDate")) dgvPatientRecords.Columns["LastAppointmentDate"].HeaderText = "Last Appointment Date";

            dgvPatientRecords.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            if (dgvPatientRecords.Columns.Contains("DateOfBirth")) dgvPatientRecords.Columns["DateOfBirth"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgvPatientRecords.Columns.Contains("Age")) dgvPatientRecords.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgvPatientRecords.Columns.Contains("TotalAppointments")) dgvPatientRecords.Columns["TotalAppointments"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPatientRecords.AutoResizeColumns();
        }

        private void LoadUpcomingAppointments(int? doctorId = null)
        {
            dgvUpcomingAppointments.DataSource = viewsService.GetUpcomingAppointments(doctorId);

            // Format columns
            if (dgvUpcomingAppointments.Columns.Contains("AppointmentId")) dgvUpcomingAppointments.Columns["AppointmentId"].Visible = false;
            if (dgvUpcomingAppointments.Columns.Contains("PatientId")) dgvUpcomingAppointments.Columns["PatientId"].Visible = false;
            if (dgvUpcomingAppointments.Columns.Contains("DoctorId")) dgvUpcomingAppointments.Columns["DoctorId"].Visible = false;
            if (dgvUpcomingAppointments.Columns.Contains("PatientName")) dgvUpcomingAppointments.Columns["PatientName"].HeaderText = "Patient Name";
            if (dgvUpcomingAppointments.Columns.Contains("PhoneNumber")) dgvUpcomingAppointments.Columns["PhoneNumber"].HeaderText = "Phone Number";
            if (dgvUpcomingAppointments.Columns.Contains("DoctorName")) dgvUpcomingAppointments.Columns["DoctorName"].HeaderText = "Doctor Name";
            if (dgvUpcomingAppointments.Columns.Contains("AppointmentDate")) dgvUpcomingAppointments.Columns["AppointmentDate"].HeaderText = "Date";
            if (dgvUpcomingAppointments.Columns.Contains("HourOfDay")) dgvUpcomingAppointments.Columns["HourOfDay"].HeaderText = "Hour";
            if (dgvUpcomingAppointments.Columns.Contains("MinuteOfHour")) dgvUpcomingAppointments.Columns["MinuteOfHour"].HeaderText = "Minute";

            dgvUpcomingAppointments.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            if (dgvUpcomingAppointments.Columns.Contains("AppointmentDate")) dgvUpcomingAppointments.Columns["AppointmentDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgvUpcomingAppointments.Columns.Contains("HourOfDay")) dgvUpcomingAppointments.Columns["HourOfDay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgvUpcomingAppointments.Columns.Contains("MinuteOfHour")) dgvUpcomingAppointments.Columns["MinuteOfHour"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvUpcomingAppointments.AutoResizeColumns();
        }

        private void ResetCombos()
        {
            cmbVwPatientSelect.DataSource = patientService.GetAllPatients();
            cmbVwPatientSelect.DisplayMember = null;
            cmbVwPatientSelect.ValueMember = null;
            cmbVwPatientSelect.SelectedIndex = -1;
            cmbVwPatientSelect.Text = string.Empty;
            cmbVwPatientSelect.DropDownStyle = ComboBoxStyle.DropDown;
            cmbVwPatientSelect.BackColor = SystemColors.Window;

            cmbVwDoctorSelect.DataSource = doctorService.GetAllDoctors();
            cmbVwDoctorSelect.DisplayMember = null;
            cmbVwDoctorSelect.ValueMember = null;
            cmbVwDoctorSelect.SelectedIndex = -1;
            cmbVwDoctorSelect.Text = string.Empty;
            cmbVwDoctorSelect.DropDownStyle = ComboBoxStyle.DropDown;
            cmbVwDoctorSelect.BackColor = SystemColors.Window;

            selectedPatient = null;
            selectedDoctor = null;
        }

        private void cmbVwPatientSelect_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingPatientCombo) return;

            isUpdatingPatientCombo = true;

            string currentText = cmbVwPatientSelect.Text;
            int selStart = cmbVwPatientSelect.SelectionStart;
            int selLen = cmbVwPatientSelect.SelectionLength;
            var trimmed = currentText.Trim();
            var filtered = string.IsNullOrEmpty(trimmed) ? patientService.GetAllPatients() : patientService.Search(trimmed);
            if (filtered.Count == 0) filtered = patientService.GetAllPatients();
            cmbVwPatientSelect.DataSource = filtered;
            cmbVwPatientSelect.SelectedIndex = -1;
            if (cmbVwPatientSelect.Text != trimmed)
            {
                cmbVwPatientSelect.Text = trimmed;
                int newSelStart = Math.Min(selStart, trimmed.Length);
                int newSelLen = Math.Min(selLen, trimmed.Length - newSelStart);
                cmbVwPatientSelect.SelectionStart = newSelStart;
                cmbVwPatientSelect.SelectionLength = newSelLen;
            }
            if (filtered.Count == 1 && !string.IsNullOrEmpty(trimmed))
            {
                cmbVwPatientSelect.SelectedIndex = 0;
                dgvPatientRecords.Focus();
            }

            isUpdatingPatientCombo = false;
        }

        private void cmbVwPatientSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPatient = cmbVwPatientSelect.SelectedIndex != -1 ? (PatientDTO)cmbVwPatientSelect.SelectedItem : null;
            cmbVwPatientSelect.BackColor = selectedPatient != null ? System.Drawing.Color.LightGreen : SystemColors.Window;
            LoadPatientRecords(selectedPatient?.Id);
        }

        private void cmbVwDoctorSelect_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingDoctorCombo) return;

            isUpdatingDoctorCombo = true;

            string currentText = cmbVwDoctorSelect.Text;
            int selStart = cmbVwDoctorSelect.SelectionStart;
            int selLen = cmbVwDoctorSelect.SelectionLength;
            var trimmed = currentText.Trim();
            var filtered = string.IsNullOrEmpty(trimmed) ? doctorService.GetAllDoctors() : doctorService.Search(trimmed);
            if (filtered.Count == 0) filtered = doctorService.GetAllDoctors();
            cmbVwDoctorSelect.DataSource = filtered;
            cmbVwDoctorSelect.SelectedIndex = -1;
            if (cmbVwDoctorSelect.Text != trimmed)
            {
                cmbVwDoctorSelect.Text = trimmed;
                int newSelStart = Math.Min(selStart, trimmed.Length);
                int newSelLen = Math.Min(selLen, trimmed.Length - newSelStart);
                cmbVwDoctorSelect.SelectionStart = newSelStart;
                cmbVwDoctorSelect.SelectionLength = newSelLen;
            }
            if (filtered.Count == 1 && !string.IsNullOrEmpty(trimmed))
            {
                cmbVwDoctorSelect.SelectedIndex = 0;
                dgvUpcomingAppointments.Focus();
            }

            isUpdatingDoctorCombo = false;
        }

        private void cmbVwDoctorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDoctor = cmbVwDoctorSelect.SelectedIndex != -1 ? (DoctorDTO)cmbVwDoctorSelect.SelectedItem : null;
            cmbVwDoctorSelect.BackColor = selectedDoctor != null ? System.Drawing.Color.LightGreen : SystemColors.Window;
            LoadUpcomingAppointments(selectedDoctor?.Id);
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
