using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using System;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{

    /// <summary>
    /// Controller for the Patient Registration panel
    /// </summary>
    public class PatientRegistrationController : IPanelController
    {
        private readonly PatientService patientService = new PatientService();



        private readonly Panel panel;

        // TODO: SUGGESTION
        // Okay, lets be honest, this is absolutely a mess.
        // The way to go here would have been to create custom 'panel'-like user control classes.
        // Like done here, you have to access the panel's controls the hard way and by using
        // hard-coded strings. One typo, and weird error that doesn't seem to make sense. Refactor
        // the control's name in the panel? It breaks down here too.
        // Its also quite unefficient performance-wise since it adds a sh!tload of dereferencing-execution
        // instructions in the background.
        // So inorder to mitigate the hardcoded string accesses, I added null-coalescing instructions to throw
        // more easily understandable errors than NullDereferenceException
        private DataGridView dgvPatients => (DataGridView)panel.Controls["dgvRegPatients"] 
            ?? throw new Exception("No control named [dgvRegPatients] found in panel controls collection.");
        private GroupBox grpPatientRegistration => (GroupBox)panel.Controls["grpPatientRegistration"]
            ?? throw new Exception("No control named [grpPatientRegistration] found in panel controls collection.");
        private TextBox txtPatientId => (TextBox)grpPatientRegistration.Controls["txtPatientId"]
            ?? throw new Exception("No control named [txtPatientId] found in grpPatientRegistration controls collection.");

        private TextBox txtPFName => (TextBox)grpPatientRegistration.Controls["txtPFName"]
            ?? throw new Exception("No control named [txtPFName] found in grpPatientRegistration controls collection.");
        private TextBox txtPLName => (TextBox)grpPatientRegistration.Controls["txtPLName"]
            ?? throw new Exception("No control named [txtPLName] found in grpPatientRegistration controls collection.");
        private TextBox txtMedicalNumber => (TextBox)grpPatientRegistration.Controls["txtMedicalNumber"]
            ?? throw new Exception("No control named [txtMedicalNumber] found in grpPatientRegistration controls collection.");
        private DateTimePicker dateDoB => (DateTimePicker)grpPatientRegistration.Controls["dateDoB"]
            ?? throw new Exception("No control named [dateDoB] found in grpPatientRegistration controls collection.");
        private TextBox txtPPhone => (TextBox)grpPatientRegistration.Controls["txtPPhone"]
            ?? throw new Exception("No control named [txtPPhone] found in grpPatientRegistration controls collection.");
        private TableLayoutPanel layoutPatientButtons => (TableLayoutPanel)grpPatientRegistration.Controls["layoutPatientButtons"]
            ?? throw new Exception("No control named [layoutPatientButtons] found in grpPatientRegistration controls collection.");
        private Button btnPatientCreate => (Button)layoutPatientButtons.Controls["btnPCreate"]
            ?? throw new Exception("No control named [btnPCreate] found in layoutPatientButtons controls collection.");
        private Button btnPatientUpdate => (Button)layoutPatientButtons.Controls["btnPUpdate"]
            ?? throw new Exception("No control named [btnPUpdate] found in layoutPatientButtons controls collection.");
        private Button btnPatientCancel => (Button)layoutPatientButtons.Controls["btnPCancel"]
            ?? throw new Exception("No control named [btnPCancel] found in layoutPatientButtons controls collection.");
        private Button btnPatientDelete => (Button)layoutPatientButtons.Controls["btnPDelete"]
            ?? throw new Exception("No control named [btnPDelete] found in layoutPatientButtons controls collection.");
        private Button btnPatientDisplay => (Button)layoutPatientButtons.Controls["btnPDisplay"]
            ?? throw new Exception("No control named [btnPDisplay] found in layoutPatientButtons controls collection.");
        private Button btnPatientSearch => (Button)layoutPatientButtons.Controls["btnPSearch"]
            ?? throw new Exception("No control named [btnPSearch] found in layoutPatientButtons controls collection.");
        private Button btnPatientRefresh => (Button)layoutPatientButtons.Controls["btnPRefresh"]
            ?? throw new Exception("No control named [btnPRefresh] found in layoutPatientButtons controls collection.");

        public Panel Panel => panel;

        public PatientRegistrationController(Panel panel)
        {
            this.panel = panel;
        }

        public void Initialize()
        {
            
            btnPatientCreate.Click += new EventHandler(btnPatientCreate_Click);
            btnPatientUpdate.Click += new EventHandler(btnPatientUpdate_Click);
            btnPatientCancel.Click += new EventHandler(btnPatientCancel_Click);
            btnPatientDelete.Click += new EventHandler(btnPatientDelete_Click);
            btnPatientDisplay.Click += new EventHandler(btnPatientDisplay_Click);
            btnPatientSearch.Click += new EventHandler(btnPatientSearch_Click);
            dgvPatients.Click += new EventHandler(dgvPatients_Click);
        }

        public void OnShow()
        {
            LoadPatients();
            ResetPatientForm();

        }

        private void LoadPatients()
        {
            var users = patientService.GetAll();
            dgvPatients.DataSource = users;
            dgvPatients.AutoGenerateColumns = true;
        }


        /// <summary>
        /// Reset the patient registration form to initial state
        /// </summary>
        private void ResetPatientForm()
        {
            txtPatientId.Text = string.Empty;
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
            if (dgvPatients.CurrentRow != null)
            {
                // TODO: SUGGESTION
                // Since the data bound to the DGV is in the form of a List<PatientDTO>, its much more robust
                // and efficient to access directly the underlaying PatientDTO bound to a row when the row is
                // clicked upon.
                // This will also be simpler when updating or deleting a 'selected' row.

                PatientDTO clickedOnPatient = (PatientDTO) dgvPatients.CurrentRow.DataBoundItem;
                txtPatientId.Text = clickedOnPatient.Id.ToString();
                txtPFName.Text = clickedOnPatient.FirstName;
                txtPLName.Text = clickedOnPatient.LastName;
                dateDoB.Value = clickedOnPatient.DateOfBirth;
                txtMedicalNumber.Text = clickedOnPatient.InsuranceNumber;
                txtPPhone.Text = clickedOnPatient.PhoneNumber;

                //int selectedUserId = (int)dgvPatients.CurrentRow.Cells["Id"].Value;
                //txtPatientId.Text = selectedUserId.ToString();
                //var user = patientService.Search(selectedUserId);
                //txtPFName.Text = user.FirstName;
                //txtPLName.Text = user.LastName;
                //dateDoB.Value = user.DateOfBirth;
                //txtMedicalNumber.Text = user.InsuranceNumber;
                //txtPPhone.Text = user.PhoneNumber;

            }
        }

        /// <summary>
        /// Cancel patient form operation
        /// </summary>
        private void btnPatientCancel_Click(object sender, EventArgs e)
        {
            ResetPatientForm();
        }



        private void btnPatientDisplay_Click(object sender, EventArgs e)
        {
            LoadPatients();
            ResetPatientForm();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            ResetPatientForm();
            if (!int.TryParse(txtPatientId.Text, out int id))
            {
                MessageBox.Show("Enter a valid Patient ID.");
                return;
            }

            var result = patientService.Search(id);

            if (result == null)
            {
                MessageBox.Show("Student not found.");

                return;
            }

            txtPatientId.Text = result.Id.ToString();
            txtPFName.Text = result.FirstName;
            txtPLName.Text = result.LastName;
            txtMedicalNumber.Text = result.InsuranceNumber.ToString();
            txtPPhone.Text = result.PhoneNumber;
            dateDoB.Text = result.DateOfBirth.ToString();

            dgvPatients.DataSource = new[] { result };

        }

        /// <summary>
        /// Submit patient form and Create new patient
        /// </summary>
        private void btnPatientCreate_Click(object sender, EventArgs e)
        {

            //if (!int.TryParse(txtPatientId.Text, out int id))
            //{
            //    MessageBox.Show("Patient ID must be a number.");
            //    return;
            //}

            if (/*string.IsNullOrWhiteSpace(txtPatientId.Text) ||*/
                string.IsNullOrWhiteSpace(txtPFName.Text)
                ||
                string.IsNullOrWhiteSpace(txtPLName.Text)
                ||
                string.IsNullOrWhiteSpace(dateDoB.Text)
                ||
                string.IsNullOrWhiteSpace(txtMedicalNumber.Text)
                ||
                string.IsNullOrWhiteSpace(txtPPhone.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            //if (patientService.Exists(id))
            //{
            //    MessageBox.Show("A patient with this ID already exists. Please use a different ID.");
            //    return;
            //}

            var dto = new PatientDTO
            {
                //Id = id,
                FirstName = txtPFName.Text,
                LastName = txtPLName.Text,
                InsuranceNumber = txtMedicalNumber.Text,
                DateOfBirth = dateDoB.Value,
                PhoneNumber = txtPPhone.Text
            };

            patientService.AddPatient(dto);
            LoadPatients();
            ResetPatientForm();
        }
        /// <summary>
        /// Submit patient form and Update existing patient
        /// </summary>
        private void btnPatientUpdate_Click(object sender, EventArgs e)
        {
            // TODO: SUGGESTION
            // As for the DGV row-click, it would be wise to use the underlying PatientDTO
            // object of the selected row than recreate a new one. Recreating a new one could lead
            // to mismatches or duplicates in the DB, depending on the DB system used.
            if (dgvPatients.CurrentRow != null) {

                PatientDTO selectedPatient = (PatientDTO) dgvPatients.CurrentRow.DataBoundItem;
                // Note: Id shouldnt be modifiable so i'm ignoring it here
                selectedPatient.FirstName = txtPFName.Text;
                selectedPatient.LastName = txtPLName.Text;
                selectedPatient.DateOfBirth = dateDoB.Value;
                selectedPatient.InsuranceNumber = txtMedicalNumber.Text;
                selectedPatient.PhoneNumber = txtPPhone.Text;

                patientService.UpdatePatient(selectedPatient);
                dgvPatients.Refresh();

            } else {
                // Error message?
            }


            /*
            if (!int.TryParse(txtPatientId.Text, out int id))
            {
                MessageBox.Show("Enter a valid ID.");
                return;
            }

            if (!patientService.Exists(id))
            {
                MessageBox.Show("This patient ID does not exist. Cannot update.");
                return;
            }

            var dto = new PatientDTO
            {
                Id = id,
                FirstName = txtPFName.Text,
                LastName = txtPLName.Text,
                InsuranceNumber = txtMedicalNumber.Text,
                DateOfBirth = DateTime.Parse(dateDoB.Text),
                PhoneNumber = txtPPhone.Text
            };

            patientService.UpdatePatient(dto);
            LoadPatients();
            */

            //ResetPatientForm();

        }

        /// <summary>
        /// Delete selected patient
        /// </summary>
        private void btnPatientDelete_Click(object sender, EventArgs e)
        {

            // TODO: SUGGESTION
            // As for the DGV row-click, it would be wise to use the underlying PatientDTO
            // object of the selected row. This is consistent with the rest of the service behavior
            // that receives new DTOs or modified DTOs.
            if (dgvPatients.CurrentRow != null) {

                PatientDTO selectedPatient = (PatientDTO) dgvPatients.CurrentRow.DataBoundItem;

                _ = patientService.DeletePatient(selectedPatient);
                dgvPatients.Refresh();
                LoadPatients();
                ResetPatientForm();

            } else {
                // Error message?
            }


            /*
            if (!int.TryParse(txtPatientId.Text, out int id))
            {
                MessageBox.Show("Enter a valid ID.");
                return;
            }

            if (!patientService.Exists(id))
            {
                MessageBox.Show("This patient ID does not exist. Cannot delete.");
                return;
            }

            patientService.DeletePatient(id);
            LoadPatients();
            ResetPatientForm();
            */

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
