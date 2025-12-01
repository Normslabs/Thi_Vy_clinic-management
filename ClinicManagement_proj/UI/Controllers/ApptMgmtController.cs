using ClinicManagement_proj.BLL;
using ClinicManagement_proj.BLL.Services;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System.Linq;

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

        private DoctorDTO selectedDoctor;
        private PatientDTO selectedPatient;
        private TimeSlotDTO selectedTimeSlot;

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
        private TextBox txtApptPhone => (TextBox)(grpApptMgmt.Controls["txtPhone"] ?? throw new Exception("No control named [txtPhone] found in layoutApptMgmt controls collection."));
        private DateTimePicker dtpApptDate => (DateTimePicker)(grpApptMgmt.Controls["dtpApptDate"] ?? throw new Exception("No control named [dtpApptDate] found in layoutApptMgmt controls collection."));
        private FlowLayoutPanel flpApptTimeSlots => (FlowLayoutPanel)(grpApptMgmt.Controls["flpApptTimeSlots"] ?? throw new Exception("No control named [flpApptTimeSlots] found in layoutApptMgmt controls collection."));
        private TextBox txtApptNotes => (TextBox)(grpApptMgmt.Controls["txtApptNotes"] ?? throw new Exception("No control named [txtApptNotes] found in layoutApptMgmt controls collection."));
        private ComboBox cmbApptStatus => (ComboBox)(grpApptMgmt.Controls["cmbApptStatus"] ?? throw new Exception("No control named [cmbStatus] found in layoutApptMgmt controls collection."));

        public Panel Panel => panel;

        public ApptMgmtController(Panel panel)
        {
            this.panel = panel;
            this.appointmentService = ClinicManagementApp.AppointmentService;
            this.doctorService = ClinicManagementApp.DoctorService;
            this.patientService = ClinicManagementApp.PatientService;
        }

        public void Initialize()
        {
            // Populate status cmb
            cmbApptStatus.Items.Clear();
            cmbApptStatus.Items.AddRange(new string[] { "Pending", "Cancelled", "Confirmed", "Completed" });
            cmbApptStatus.SelectedIndex = 0; // Default to Pending

            // Set up autocomplete for doctor and patient fields
            cmbApptDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbApptDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbApptPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbApptPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Wire event handlers (scaffolding, no implementation)
            btnApptCreate.Click += new EventHandler(btnApptCreate_Click);
            btnApptUpdate.Click += new EventHandler(btnApptUpdate_Click);
            btnApptCancel.Click += new EventHandler(btnApptCancel_Click);
            btnApptDisplay.Click += new EventHandler(btnApptDisplay_Click);
            btnApptSearch.Click += new EventHandler(btnApptSearch_Click);
            dgvAppointments.Click += new EventHandler(dgvAppointments_Click);
            dtpApptDate.ValueChanged += new EventHandler(dtpApptDate_ValueChanged);
            cmbApptDoctor.TextChanged += new EventHandler(cmbApptDoctor_TextChanged);
            cmbApptPatient.TextChanged += new EventHandler(cmbApptPatient_TextChanged);
            dgvAppointments.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvAppointments_CellFormatting);
        }

        public void OnShow()
        {
            LoadAppointments();
            ResetAppointmentForm();
        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = appointmentService.GetAllAppointments();

            dgvAppointments.Columns["Id"].Visible = false;
            dgvAppointments.Columns["DoctorId"].Visible = false;
            dgvAppointments.Columns["TimeSlotId"].Visible = false;
            dgvAppointments.Columns["PatientId"].Visible = false;

            dgvAppointments.Columns["ModifiedAt"].HeaderText = "Last Modified";
            dgvAppointments.Columns["CreatedAt"].HeaderText = "Created At";
            dgvAppointments.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvAppointments.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppointments.Columns["TimeSlot"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppointments.AutoResizeColumns();

            dgvAppointments.Columns["Date"].DisplayIndex = 0;
            dgvAppointments.Columns["TimeSlot"].DisplayIndex = 1;
            dgvAppointments.Columns["Doctor"].DisplayIndex = 2;
            dgvAppointments.Columns["Patient"].DisplayIndex = 3;
            dgvAppointments.Columns["Status"].DisplayIndex = 4;
            dgvAppointments.Columns["Notes"].DisplayIndex = 5;
            dgvAppointments.Columns["CreatedAt"].DisplayIndex = 6;
            dgvAppointments.Columns["ModifiedAt"].DisplayIndex = 7;
        }

        private void ResetAppointmentForm()
        {
            cmbApptDoctor.Text = string.Empty;
            cmbApptPatient.Text = string.Empty;
            dtpApptDate.Value = DateTime.Now;
            flpApptTimeSlots.Controls.Clear();
            txtApptNotes.Text = string.Empty;
            cmbApptStatus.SelectedIndex = 0;

            selectedDoctor = null;
            selectedPatient = null;
            selectedTimeSlot = null;

            cmbApptDoctor.BackColor = SystemColors.Window;
            cmbApptPatient.BackColor = SystemColors.Window;
        }

        private void dgvAppointments_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null)
            {
                var appointment = (AppointmentDTO)dgvAppointments.CurrentRow.DataBoundItem;
                cmbApptDoctor.Text = appointment.Doctor?.ToString() ?? "";
                cmbApptPatient.Text = appointment.Patient?.ToString() ?? "";
                dtpApptDate.Value = appointment.Date;
                txtApptNotes.Text = appointment.Notes;
                cmbApptStatus.SelectedItem = appointment.Status;

                selectedDoctor = appointment.Doctor;
                selectedPatient = appointment.Patient;
                selectedTimeSlot = appointment.TimeSlot;

                cmbApptDoctor.BackColor = Color.Green;
                cmbApptPatient.BackColor = Color.Green;

                // Load time slots and select the current one
                dtpApptDate_ValueChanged(null, null);
                foreach (RadioButton rb in flpApptTimeSlots.Controls)
                {
                    if ((TimeSlotDTO)rb.Tag == selectedTimeSlot) rb.Checked = true;
                }
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
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
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
            flpApptTimeSlots.Controls.Clear();
            var slots = appointmentService.GetAvailableTimeSlots(dtpApptDate.Value);
            foreach (var slot in slots)
            {
                var rb = new RadioButton { Text = slot.ToString(), Tag = slot };
                rb.CheckedChanged += (s, args) => { if (rb.Checked) selectedTimeSlot = slot; };
                flpApptTimeSlots.Controls.Add(rb);
            }
        }

        private void cmbApptDoctor_TextChanged(object sender, EventArgs e)
        {
            if (cmbApptDoctor.Text.Length >= 1)
            {
                var doctors = doctorService.Search(cmbApptDoctor.Text);
                var source = new AutoCompleteStringCollection();
                foreach (var d in doctors)
                {
                    source.Add(d.ToString());
                }
                cmbApptDoctor.AutoCompleteCustomSource = source;
                // Check if exact match by name or id
                var exact = doctors.FirstOrDefault(d => d.ToString() == cmbApptDoctor.Text || d.Id.ToString() == cmbApptDoctor.Text);
                if (exact != null)
                {
                    selectedDoctor = exact;
                    cmbApptDoctor.BackColor = Color.LightGreen;
                }
                else
                {
                    selectedDoctor = null;
                    cmbApptDoctor.BackColor = Color.Red;
                }
            }
            else
            {
                cmbApptDoctor.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                selectedDoctor = null;
                cmbApptDoctor.BackColor = SystemColors.Window;
            }
        }

        private void cmbApptPatient_TextChanged(object sender, EventArgs e)
        {
            if (cmbApptPatient.Text.Length >= 1)
            {
                var patients = patientService.GetAll().Where(p => p.FirstName.Contains(cmbApptPatient.Text) || p.LastName.Contains(cmbApptPatient.Text) || p.Id.ToString().Contains(cmbApptPatient.Text)).ToList();
                var source = new AutoCompleteStringCollection();
                foreach (var p in patients)
                {
                    source.Add(p.ToString());
                }
                cmbApptPatient.AutoCompleteCustomSource = source;
                // Check if exact match by name or id
                var exact = patients.FirstOrDefault(p => p.ToString() == cmbApptPatient.Text || p.Id.ToString() == cmbApptPatient.Text);
                if (exact != null)
                {
                    selectedPatient = exact;
                    cmbApptPatient.BackColor = Color.LightGreen;
                }
                else
                {
                    selectedPatient = null;
                    cmbApptPatient.BackColor = Color.Red;
                }
            }
            else
            {
                cmbApptPatient.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                selectedPatient = null;
                cmbApptPatient.BackColor = SystemColors.Window;
            }
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
