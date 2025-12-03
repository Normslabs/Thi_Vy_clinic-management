using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Appointment Management panel
    /// </summary>
    public class ApptMgmtController : IPanelController
    {
        AppointmentService appointmentService;
        DoctorService doctorService;
        PatientService patientService;

        private DoctorDTO selectedDoctor = null;
        private PatientDTO selectedPatient = null;
        private TimeSlotDTO selectedTimeSlot = null;

        private bool isUpdatingDoctorCombo = false;
        private bool isUpdatingPatientCombo = false;

        private readonly Panel panel;

        // Access to existing controls
        private GroupBox grpApptMgmt => (GroupBox)(panel.Controls["grpApptMgmt"] ?? throw new Exception("No control named [grpApptMgmt] found in panel controls collection."));
        private DataGridView dgvAppointments => (DataGridView)(panel.Controls["dgvAppointments"] ?? throw new Exception("No control named [dgvAppointments] found in layoutApptMgmt controls collection."));
        private TableLayoutPanel layoutApptButtons => (TableLayoutPanel)(grpApptMgmt.Controls["layoutApptButtons"] ?? throw new Exception("No control named [layoutApptButtons] found in layoutApptMgmt controls collection."));
        private Button btnApptCreate => (Button)(layoutApptButtons.Controls["btnApptCreate"] ?? throw new Exception("No control named [btnApptCreate] found in layoutApptButtons controls collection."));
        private Button btnApptUpdate => (Button)(layoutApptButtons.Controls["btnApptUpdate"] ?? throw new Exception("No control named [btnApptUpdate] found in layoutApptButtons controls collection."));
        private Button btnApptCancel => (Button)(layoutApptButtons.Controls["btnApptCancel"] ?? throw new Exception("No control named [btnApptCancel] found in layoutApptButtons controls collection."));
        private Button btnApptDisplay => (Button)(layoutApptButtons.Controls["btnApptDisplay"] ?? throw new Exception("No control named [btnApptDisplay] found in layoutApptButtons controls collection."));
        private Button btnApptSearch => (Button)(layoutApptButtons.Controls["btnApptSearch"] ?? throw new Exception("No control named [btnApptSearch] found in layoutApptButtons controls collection."));
        private ComboBox cmbApptDoctor => (ComboBox)(grpApptMgmt.Controls["cmbApptDoctor"] ?? throw new Exception("No control named [txtDoctor] found in layoutApptMgmt controls collection."));
        private ComboBox cmbApptPatient => (ComboBox)(grpApptMgmt.Controls["cmbApptPatient"] ?? throw new Exception("No control named [txtPatient] found in layoutApptMgmt controls collection."));
        private DateTimePicker dtpApptDate => (DateTimePicker)(grpApptMgmt.Controls["dtpApptDate"] ?? throw new Exception("No control named [dtpApptDate] found in layoutApptMgmt controls collection."));
        private ComboBox cmbApptTimeSlots => (ComboBox)(grpApptMgmt.Controls["cmbApptTimeSlots"] ?? throw new Exception("No control named [cmbApptTimeSlots] found in layoutApptMgmt controls collection."));
        private TextBox txtApptNotes => (TextBox)(grpApptMgmt.Controls["txtApptNotes"] ?? throw new Exception("No control named [txtApptNotes] found in layoutApptMgmt controls collection."));
        private ComboBox cmbApptStatus => (ComboBox)(grpApptMgmt.Controls["cmbApptStatus"] ?? throw new Exception("No control named [cmbStatus] found in layoutApptMgmt controls collection."));

        public Panel Panel => panel;

        public ApptMgmtController(Panel panel)
        {
            this.panel = panel;
            appointmentService = ClinicManagementApp.AppointmentService;
            doctorService = ClinicManagementApp.DoctorService;
            patientService = ClinicManagementApp.PatientService;
        }

        public void Initialize()
        {
            // Populate status cmb
            cmbApptStatus.Items.Clear();
            cmbApptStatus.Items.AddRange(new string[] { "Pending", "Cancelled", "Confirmed", "Completed" });
            cmbApptStatus.SelectedIndex = 0; // Default to Pending

            // Wire event handlers (scaffolding, no implementation)
            btnApptCreate.Click += new EventHandler(btnApptCreate_Click);
            btnApptUpdate.Click += new EventHandler(btnApptUpdate_Click);
            btnApptCancel.Click += new EventHandler(btnApptCancel_Click);
            btnApptDisplay.Click += new EventHandler(btnApptDisplay_Click);
            btnApptSearch.Click += new EventHandler(btnApptSearch_Click);
            dgvAppointments.Click += new EventHandler(dgvAppointments_Click);
            dtpApptDate.ValueChanged += new EventHandler(dtpApptDate_ValueChanged);
            cmbApptDoctor.SelectedIndexChanged += new EventHandler(cmbApptDoctor_SelectedIndexChanged);
            cmbApptPatient.SelectedIndexChanged += new EventHandler(cmbApptPatient_SelectedIndexChanged);
            cmbApptPatient.TextChanged += new EventHandler(cmbApptPatient_TextChanged);
            cmbApptDoctor.TextChanged += new EventHandler(cmbApptDoctor_TextChanged);
            dgvAppointments.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvAppointments_CellFormatting);
            cmbApptTimeSlots.SelectedIndexChanged += new EventHandler(cmbApptTimeSlots_SelectedIndexChanged);
        }

        public void OnShow()
        {
            LoadAppointments();
            ResetAppointmentForm();
        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = appointmentService.GetAllAppointments();

            dgvAppointments.Columns["DoctorId"].Visible = false;
            dgvAppointments.Columns["TimeSlotId"].Visible = false;
            dgvAppointments.Columns["PatientId"].Visible = false;

            dgvAppointments.Columns["ModifiedAt"].HeaderText = "Last Modified";
            dgvAppointments.Columns["CreatedAt"].HeaderText = "Created At";
            dgvAppointments.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvAppointments.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppointments.Columns["TimeSlot"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppointments.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppointments.AutoResizeColumns();

            dgvAppointments.Columns["Id"].DisplayIndex = 0;
            dgvAppointments.Columns["Date"].DisplayIndex = 1;
            dgvAppointments.Columns["TimeSlot"].DisplayIndex = 2;
            dgvAppointments.Columns["Doctor"].DisplayIndex = 3;
            dgvAppointments.Columns["Patient"].DisplayIndex = 4;
            dgvAppointments.Columns["Status"].DisplayIndex = 5;
            dgvAppointments.Columns["Notes"].DisplayIndex = 6;
            dgvAppointments.Columns["CreatedAt"].DisplayIndex = 7;
            dgvAppointments.Columns["ModifiedAt"].DisplayIndex = 8;
        }

        private void ResetAppointmentForm()
        {
            cmbApptDoctor.Text = string.Empty;
            cmbApptPatient.Text = string.Empty;
            dtpApptDate.Value = DateTime.Now;
            txtApptNotes.Text = string.Empty;
            cmbApptStatus.SelectedIndex = 0;

            selectedDoctor = null;
            selectedPatient = null;
            selectedTimeSlot = null;

            cmbApptDoctor.BackColor = SystemColors.Window;
            cmbApptPatient.BackColor = SystemColors.Window;

            cmbApptDoctor.DataSource = doctorService.GetAllDoctors();
            cmbApptDoctor.DisplayMember = null;
            cmbApptDoctor.ValueMember = null;
            cmbApptDoctor.SelectedIndex = -1;

            cmbApptPatient.DataSource = patientService.GetAllPatients();
            cmbApptPatient.DisplayMember = null;
            cmbApptPatient.ValueMember = null;
            cmbApptPatient.SelectedIndex = -1;

            cmbApptTimeSlots.DataSource = null;
            cmbApptTimeSlots.Items.Clear();
            cmbApptTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbApptTimeSlots.SelectedIndex = -1;
        }

        private void dgvAppointments_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null)
            {
                var appointment = (AppointmentDTO)dgvAppointments.CurrentRow.DataBoundItem;
                cmbApptDoctor.SelectedItem = appointment.Doctor;
                cmbApptPatient.SelectedItem = appointment.Patient;
                dtpApptDate.Value = appointment.Date;
                txtApptNotes.Text = appointment.Notes;
                cmbApptStatus.SelectedItem = appointment.Status;

                selectedDoctor = appointment.Doctor;
                selectedPatient = appointment.Patient;
                selectedTimeSlot = appointment.TimeSlot;

                // Load time slots and select the current one
                dtpApptDate_ValueChanged(null, null);
                cmbApptTimeSlots.SelectedItem = selectedTimeSlot;
            }
        }

        private void btnApptCancel_Click(object sender, EventArgs e)
        {
            ResetAppointmentForm();
        }

        private void btnApptDisplay_Click(object sender, EventArgs e)
        {
            LoadAppointments();
            ResetAppointmentForm();
        }

        private void btnApptSearch_Click(object sender, EventArgs e)
        {
            var results = appointmentService.Search(dtpApptDate.Value);
            dgvAppointments.DataSource = results;
        }

        private void btnApptCreate_Click(object sender, EventArgs e)
        {
            if (selectedDoctor == null || selectedPatient == null || selectedTimeSlot == null)
            {
                MessageBox.Show("Please select valid doctor, patient, and time slot.");
                return;
            }

            var dto = new AppointmentDTO
            {
                Date = dtpApptDate.Value,
                Notes = txtApptNotes.Text,
                Status = cmbApptStatus.SelectedItem?.ToString() ?? "Pending",
                DoctorId = selectedDoctor.Id,
                PatientId = selectedPatient.Id,
                TimeSlotId = selectedTimeSlot.Id,
            };

            appointmentService.CreateAppointment(dto);
            LoadAppointments();
            ResetAppointmentForm();
        }

        private void btnApptUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to update.");
                return;
            }

            var appointment = (AppointmentDTO)dgvAppointments.CurrentRow.DataBoundItem;
            appointment.Date = dtpApptDate.Value;
            appointment.Notes = txtApptNotes.Text;
            appointment.Status = cmbApptStatus.SelectedItem?.ToString() ?? "Pending";
            appointment.DoctorId = selectedDoctor?.Id ?? appointment.DoctorId;
            appointment.PatientId = selectedPatient?.Id ?? appointment.PatientId;
            appointment.TimeSlotId = selectedTimeSlot?.Id ?? appointment.TimeSlotId;

            appointmentService.UpdateAppointment(appointment);
            LoadAppointments();
            ResetAppointmentForm();
        }

        private void dtpApptDate_ValueChanged(object sender, EventArgs e)
        {
            LoadTimeSlots();
        }

        private void LoadTimeSlots()
        {
            cmbApptTimeSlots.DataSource = null;
            cmbApptTimeSlots.Items.Clear();
            if (selectedDoctor != null)
            {
                var slots = appointmentService.GetAvailableTimeSlots(selectedDoctor.Id, dtpApptDate.Value);
                if (selectedTimeSlot != null && !slots.Contains(selectedTimeSlot))
                {
                    slots.Add(selectedTimeSlot);
                }
                cmbApptTimeSlots.DataSource = slots;
            }
            cmbApptTimeSlots.SelectedIndex = -1;
        }

        private void cmbApptDoctor_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingDoctorCombo) return;

            isUpdatingDoctorCombo = true;

            string currentText = cmbApptDoctor.Text;
            int selStart = cmbApptDoctor.SelectionStart;
            int selLen = cmbApptDoctor.SelectionLength;
            var trimmed = currentText.Trim();
            List<DoctorDTO> filtered;
            if (string.IsNullOrEmpty(trimmed))
            {
                filtered = doctorService.GetAllDoctors();
            }
            else
            {
                filtered = doctorService.Search(trimmed);
                if (filtered.Count == 0)
                {
                    filtered = doctorService.GetAllDoctors();
                }
            }
            cmbApptDoctor.DataSource = filtered;
            cmbApptDoctor.SelectedIndex = -1;
            if (cmbApptDoctor.Text != trimmed)
            {
                cmbApptDoctor.Text = trimmed;
                int newSelStart = Math.Min(selStart, trimmed.Length);
                int newSelLen = Math.Min(selLen, trimmed.Length - newSelStart);
                cmbApptDoctor.SelectionStart = newSelStart;
                cmbApptDoctor.SelectionLength = newSelLen;
            }
            if (filtered.Count == 1 && !string.IsNullOrEmpty(trimmed))
            {
                cmbApptDoctor.SelectedIndex = 0;
                cmbApptPatient.Focus();
            }

            isUpdatingDoctorCombo = false;
        }

        private void cmbApptPatient_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingPatientCombo) return;

            isUpdatingPatientCombo = true;

            string currentText = cmbApptPatient.Text;
            int selStart = cmbApptPatient.SelectionStart;
            int selLen = cmbApptPatient.SelectionLength;
            var trimmed = currentText.Trim();
            List<PatientDTO> filtered;
            if (string.IsNullOrEmpty(trimmed))
            {
                filtered = patientService.GetAllPatients();
            }
            else
            {
                filtered = patientService.Search(trimmed);
                if (filtered.Count == 0)
                {
                    filtered = patientService.GetAllPatients();
                }
            }
            cmbApptPatient.DataSource = filtered;
            cmbApptPatient.SelectedIndex = -1;
            if (cmbApptPatient.Text != trimmed)
            {
                cmbApptPatient.Text = trimmed;
                int newSelStart = Math.Min(selStart, trimmed.Length);
                int newSelLen = Math.Min(selLen, trimmed.Length - newSelStart);
                cmbApptPatient.SelectionStart = newSelStart;
                cmbApptPatient.SelectionLength = newSelLen;
            }
            if (filtered.Count == 1 && !string.IsNullOrEmpty(trimmed))
            {
                cmbApptPatient.SelectedIndex = 0;
                dtpApptDate.Focus();
            }

            isUpdatingPatientCombo = false;
        }

        private void cmbApptDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDoctor = cmbApptDoctor.SelectedIndex != -1 ? (DoctorDTO)cmbApptDoctor.SelectedItem : null;
            cmbApptDoctor.BackColor = selectedDoctor != null ? Color.LightGreen : SystemColors.Window;
            LoadTimeSlots(); // Load time slots when doctor is selected
        }

        private void cmbApptPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPatient = cmbApptPatient.SelectedIndex != -1 ? (PatientDTO)cmbApptPatient.SelectedItem : null;
            cmbApptPatient.BackColor = selectedPatient != null ? Color.LightGreen : SystemColors.Window;
        }

        private void cmbApptTimeSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTimeSlot = cmbApptTimeSlots.SelectedIndex != -1 ? (TimeSlotDTO)cmbApptTimeSlots.SelectedItem : null;
        }

        private void dgvAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvAppointments.Columns["Status"].Index && e.Value != null)
            {
                string status = e.Value.ToString().ToUpper();
                if (status == "CONFIRMED")
                    e.CellStyle.BackColor = Color.LightGreen;
                else if (status == "CANCELLED")
                    e.CellStyle.BackColor = Color.LightCoral;
                else if (status == "COMPLETED")
                    e.CellStyle.BackColor = Color.LightBlue;
                else if (status == "PENDING")
                    e.CellStyle.BackColor = Color.LightYellow;
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
