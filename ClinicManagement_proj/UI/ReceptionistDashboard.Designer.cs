using System.Drawing;

namespace ClinicManagement_proj.UI
{
    partial class ReceptionistDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistDashboard));
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnAppointmentManagement = new System.Windows.Forms.Button();
            this.btnPatientRegistration = new System.Windows.Forms.Button();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlAppointmentManagement = new System.Windows.Forms.Panel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.grpApptMgmt = new System.Windows.Forms.GroupBox();
            this.layoutApptButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnApptCreate = new System.Windows.Forms.Button();
            this.btnApptUpdate = new System.Windows.Forms.Button();
            this.btnApptSearch = new System.Windows.Forms.Button();
            this.btnApptDisplay = new System.Windows.Forms.Button();
            this.btnApptCancel = new System.Windows.Forms.Button();
            this.cmbApptDoctor = new System.Windows.Forms.ComboBox();
            this.lblApptPatient = new System.Windows.Forms.Label();
            this.cmbApptPatient = new System.Windows.Forms.ComboBox();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.dtpApptDate = new System.Windows.Forms.DateTimePicker();
            this.lblApptTimeSlot = new System.Windows.Forms.Label();
            this.flpApptTimeSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.lblApptNotes = new System.Windows.Forms.Label();
            this.txtApptNotes = new System.Windows.Forms.TextBox();
            this.lblApptStatus = new System.Windows.Forms.Label();
            this.cmbApptStatus = new System.Windows.Forms.ComboBox();
            this.txtApptId = new System.Windows.Forms.TextBox();
            this.lblApptDoctor = new System.Windows.Forms.Label();
            this.lblApptId = new System.Windows.Forms.Label();
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.dgvRegPatients = new System.Windows.Forms.DataGridView();
            this.grpPatientRegistration = new System.Windows.Forms.GroupBox();
            this.layoutPatientButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPCreate = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPSearch = new System.Windows.Forms.Button();
            this.btnPDisplay = new System.Windows.Forms.Button();
            this.btnPCancel = new System.Windows.Forms.Button();
            this.txtPPhone = new System.Windows.Forms.TextBox();
            this.lblPPhone = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.txtMedicalNumber = new System.Windows.Forms.TextBox();
            this.lblMedicalNumber = new System.Windows.Forms.Label();
            this.txtPLName = new System.Windows.Forms.TextBox();
            this.lblPLName = new System.Windows.Forms.Label();
            this.txtPFName = new System.Windows.Forms.TextBox();
            this.lblPFName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.grpNotifications = new System.Windows.Forms.GroupBox();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.lblToast = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lbNotifications = new System.Windows.Forms.ListBox();
            this.timerToast = new System.Windows.Forms.Timer(this.components);
            this.grpAppointmentForm = new System.Windows.Forms.GroupBox();
            this.lblAppointmentPlaceholder = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlAppointmentManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.grpApptMgmt.SuspendLayout();
            this.layoutApptButtons.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPatients)).BeginInit();
            this.grpPatientRegistration.SuspendLayout();
            this.layoutPatientButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.grpNotifications.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(280, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(1676, 125);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Receptionist Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSidebar.Controls.Add(this.btnAppointmentManagement);
            this.pnlSidebar.Controls.Add(this.btnPatientRegistration);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 125);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(298, 925);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnAppointmentManagement
            // 
            this.btnAppointmentManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAppointmentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointmentManagement.FlatAppearance.BorderSize = 0;
            this.btnAppointmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentManagement.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentManagement.Image = global::ClinicManagement_proj.Properties.Resources.appointment_icon;
            this.btnAppointmentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointmentManagement.Location = new System.Drawing.Point(0, 120);
            this.btnAppointmentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointmentManagement.Name = "btnAppointmentManagement";
            this.btnAppointmentManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAppointmentManagement.Size = new System.Drawing.Size(298, 70);
            this.btnAppointmentManagement.TabIndex = 6;
            this.btnAppointmentManagement.Text = "    Appointments";
            this.btnAppointmentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointmentManagement.UseVisualStyleBackColor = false;
            this.btnAppointmentManagement.Click += new System.EventHandler(this.btnAppointmentManagement_Click);
            // 
            // btnPatientRegistration
            // 
            this.btnPatientRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPatientRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientRegistration.FlatAppearance.BorderSize = 0;
            this.btnPatientRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegistration.ForeColor = System.Drawing.Color.White;
            this.btnPatientRegistration.Image = global::ClinicManagement_proj.Properties.Resources.patient_icon;
            this.btnPatientRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientRegistration.Location = new System.Drawing.Point(0, 50);
            this.btnPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientRegistration.Name = "btnPatientRegistration";
            this.btnPatientRegistration.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPatientRegistration.Size = new System.Drawing.Size(298, 70);
            this.btnPatientRegistration.TabIndex = 4;
            this.btnPatientRegistration.Text = "    Patient Registration";
            this.btnPatientRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientRegistration.UseVisualStyleBackColor = false;
            this.btnPatientRegistration.Click += new System.EventHandler(this.btnPatientRegistration_Click);
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(298, 50);
            this.pnlSidebarHeader.TabIndex = 0;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSidebarTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(298, 50);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "NAVIGATION";
            this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlMainContent.Controls.Add(this.pnlAppointmentManagement);
            this.pnlMainContent.Controls.Add(this.pnlPatientRegistration);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(298, 125);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(1378, 925);
            this.pnlMainContent.TabIndex = 3;
            // 
            // pnlAppointmentManagement
            // 
            this.pnlAppointmentManagement.Controls.Add(this.dgvAppointments);
            this.pnlAppointmentManagement.Controls.Add(this.grpApptMgmt);
            this.pnlAppointmentManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppointmentManagement.Location = new System.Drawing.Point(20, 20);
            this.pnlAppointmentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAppointmentManagement.Name = "pnlAppointmentManagement";
            this.pnlAppointmentManagement.Size = new System.Drawing.Size(1338, 885);
            this.pnlAppointmentManagement.TabIndex = 6;
            this.pnlAppointmentManagement.Visible = false;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAppointments.Location = new System.Drawing.Point(616, 2);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(721, 895);
            this.dgvAppointments.TabIndex = 8;
            // 
            // grpApptMgmt
            // 
            this.grpApptMgmt.Controls.Add(this.layoutApptButtons);
            this.grpApptMgmt.Controls.Add(this.cmbApptDoctor);
            this.grpApptMgmt.Controls.Add(this.lblApptPatient);
            this.grpApptMgmt.Controls.Add(this.cmbApptPatient);
            this.grpApptMgmt.Controls.Add(this.lblApptDate);
            this.grpApptMgmt.Controls.Add(this.dtpApptDate);
            this.grpApptMgmt.Controls.Add(this.lblApptTimeSlot);
            this.grpApptMgmt.Controls.Add(this.flpApptTimeSlots);
            this.grpApptMgmt.Controls.Add(this.lblApptNotes);
            this.grpApptMgmt.Controls.Add(this.txtApptNotes);
            this.grpApptMgmt.Controls.Add(this.lblApptStatus);
            this.grpApptMgmt.Controls.Add(this.cmbApptStatus);
            this.grpApptMgmt.Controls.Add(this.txtApptId);
            this.grpApptMgmt.Controls.Add(this.lblApptDoctor);
            this.grpApptMgmt.Controls.Add(this.lblApptId);
            this.grpApptMgmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpApptMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApptMgmt.Location = new System.Drawing.Point(0, 0);
            this.grpApptMgmt.Margin = new System.Windows.Forms.Padding(2);
            this.grpApptMgmt.Name = "grpApptMgmt";
            this.grpApptMgmt.Padding = new System.Windows.Forms.Padding(25);
            this.grpApptMgmt.Size = new System.Drawing.Size(610, 885);
            this.grpApptMgmt.TabIndex = 7;
            this.grpApptMgmt.TabStop = false;
            this.grpApptMgmt.Text = "Appointment Management";
            // 
            // layoutApptButtons
            // 
            this.layoutApptButtons.ColumnCount = 4;
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutApptButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutApptButtons.Controls.Add(this.btnApptCreate, 0, 0);
            this.layoutApptButtons.Controls.Add(this.btnApptUpdate, 1, 0);
            this.layoutApptButtons.Controls.Add(this.btnApptSearch, 2, 0);
            this.layoutApptButtons.Controls.Add(this.btnApptDisplay, 0, 1);
            this.layoutApptButtons.Controls.Add(this.btnApptCancel, 3, 0);
            this.layoutApptButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutApptButtons.Location = new System.Drawing.Point(28, 750);
            this.layoutApptButtons.Margin = new System.Windows.Forms.Padding(2);
            this.layoutApptButtons.Name = "layoutApptButtons";
            this.layoutApptButtons.RowCount = 2;
            this.layoutApptButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutApptButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutApptButtons.Size = new System.Drawing.Size(560, 116);
            this.layoutApptButtons.TabIndex = 10;
            // 
            // btnApptCreate
            // 
            this.btnApptCreate.AutoSize = true;
            this.btnApptCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnApptCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptCreate.ForeColor = System.Drawing.Color.White;
            this.btnApptCreate.Location = new System.Drawing.Point(2, 2);
            this.btnApptCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptCreate.Name = "btnApptCreate";
            this.btnApptCreate.Size = new System.Drawing.Size(136, 54);
            this.btnApptCreate.TabIndex = 5;
            this.btnApptCreate.Text = "Create";
            this.btnApptCreate.UseVisualStyleBackColor = false;
            // 
            // btnApptUpdate
            // 
            this.btnApptUpdate.AutoSize = true;
            this.btnApptUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnApptUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptUpdate.ForeColor = System.Drawing.Color.White;
            this.btnApptUpdate.Location = new System.Drawing.Point(142, 2);
            this.btnApptUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptUpdate.Name = "btnApptUpdate";
            this.btnApptUpdate.Size = new System.Drawing.Size(136, 54);
            this.btnApptUpdate.TabIndex = 11;
            this.btnApptUpdate.Text = "Update";
            this.btnApptUpdate.UseVisualStyleBackColor = false;
            // 
            // btnApptSearch
            // 
            this.btnApptSearch.AutoSize = true;
            this.btnApptSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApptSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptSearch.ForeColor = System.Drawing.Color.White;
            this.btnApptSearch.Location = new System.Drawing.Point(282, 2);
            this.btnApptSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptSearch.Name = "btnApptSearch";
            this.btnApptSearch.Size = new System.Drawing.Size(136, 54);
            this.btnApptSearch.TabIndex = 4;
            this.btnApptSearch.Text = "Search";
            this.btnApptSearch.UseVisualStyleBackColor = false;
            // 
            // btnApptDisplay
            // 
            this.btnApptDisplay.AutoSize = true;
            this.btnApptDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnApptDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptDisplay.ForeColor = System.Drawing.Color.White;
            this.btnApptDisplay.Location = new System.Drawing.Point(2, 60);
            this.btnApptDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptDisplay.Name = "btnApptDisplay";
            this.btnApptDisplay.Size = new System.Drawing.Size(136, 54);
            this.btnApptDisplay.TabIndex = 10;
            this.btnApptDisplay.Text = "Display";
            this.btnApptDisplay.UseVisualStyleBackColor = false;
            // 
            // btnApptCancel
            // 
            this.btnApptCancel.AutoSize = true;
            this.btnApptCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnApptCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApptCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptCancel.ForeColor = System.Drawing.Color.White;
            this.btnApptCancel.Location = new System.Drawing.Point(422, 2);
            this.btnApptCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnApptCancel.Name = "btnApptCancel";
            this.btnApptCancel.Size = new System.Drawing.Size(136, 54);
            this.btnApptCancel.TabIndex = 9;
            this.btnApptCancel.Text = "Cancel";
            this.btnApptCancel.UseVisualStyleBackColor = false;
            // 
            // cmbApptDoctor
            // 
            this.cmbApptDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApptDoctor.Location = new System.Drawing.Point(25, 162);
            this.cmbApptDoctor.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.cmbApptDoctor.Name = "cmbApptDoctor";
            this.cmbApptDoctor.Size = new System.Drawing.Size(560, 30);
            this.cmbApptDoctor.TabIndex = 13;
            // 
            // lblApptPatient
            // 
            this.lblApptPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptPatient.Location = new System.Drawing.Point(25, 208);
            this.lblApptPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptPatient.Name = "lblApptPatient";
            this.lblApptPatient.Size = new System.Drawing.Size(560, 35);
            this.lblApptPatient.TabIndex = 14;
            this.lblApptPatient.Text = "Patient";
            this.lblApptPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbApptPatient
            // 
            this.cmbApptPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApptPatient.Location = new System.Drawing.Point(25, 248);
            this.cmbApptPatient.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.cmbApptPatient.Name = "cmbApptPatient";
            this.cmbApptPatient.Size = new System.Drawing.Size(560, 30);
            this.cmbApptPatient.TabIndex = 15;
            // 
            // lblApptDate
            // 
            this.lblApptDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptDate.Location = new System.Drawing.Point(25, 294);
            this.lblApptDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(560, 35);
            this.lblApptDate.TabIndex = 16;
            this.lblApptDate.Text = "Appointment Date";
            this.lblApptDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpApptDate
            // 
            this.dtpApptDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpApptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpApptDate.Location = new System.Drawing.Point(25, 334);
            this.dtpApptDate.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.dtpApptDate.Name = "dtpApptDate";
            this.dtpApptDate.Size = new System.Drawing.Size(560, 30);
            this.dtpApptDate.TabIndex = 17;
            // 
            // lblApptTimeSlot
            // 
            this.lblApptTimeSlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptTimeSlot.Location = new System.Drawing.Point(25, 380);
            this.lblApptTimeSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptTimeSlot.Name = "lblApptTimeSlot";
            this.lblApptTimeSlot.Size = new System.Drawing.Size(560, 35);
            this.lblApptTimeSlot.TabIndex = 18;
            this.lblApptTimeSlot.Text = "Time Slot";
            this.lblApptTimeSlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpApptTimeSlots
            // 
            this.flpApptTimeSlots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpApptTimeSlots.AutoScroll = true;
            this.flpApptTimeSlots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpApptTimeSlots.Location = new System.Drawing.Point(25, 420);
            this.flpApptTimeSlots.Margin = new System.Windows.Forms.Padding(2);
            this.flpApptTimeSlots.Name = "flpApptTimeSlots";
            this.flpApptTimeSlots.Size = new System.Drawing.Size(560, 60);
            this.flpApptTimeSlots.TabIndex = 19;
            // 
            // lblApptNotes
            // 
            this.lblApptNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptNotes.Location = new System.Drawing.Point(28, 574);
            this.lblApptNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptNotes.Name = "lblApptNotes";
            this.lblApptNotes.Size = new System.Drawing.Size(290, 35);
            this.lblApptNotes.TabIndex = 20;
            this.lblApptNotes.Text = "Notes";
            this.lblApptNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApptNotes
            // 
            this.txtApptNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApptNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApptNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptNotes.Location = new System.Drawing.Point(28, 618);
            this.txtApptNotes.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtApptNotes.Multiline = true;
            this.txtApptNotes.Name = "txtApptNotes";
            this.txtApptNotes.Size = new System.Drawing.Size(560, 126);
            this.txtApptNotes.TabIndex = 21;
            // 
            // lblApptStatus
            // 
            this.lblApptStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptStatus.Location = new System.Drawing.Point(25, 490);
            this.lblApptStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptStatus.Name = "lblApptStatus";
            this.lblApptStatus.Size = new System.Drawing.Size(245, 35);
            this.lblApptStatus.TabIndex = 22;
            this.lblApptStatus.Text = "Status";
            this.lblApptStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbApptStatus
            // 
            this.cmbApptStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApptStatus.FormattingEnabled = true;
            this.cmbApptStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Cancelled",
            "No Show"});
            this.cmbApptStatus.Location = new System.Drawing.Point(25, 525);
            this.cmbApptStatus.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.cmbApptStatus.Name = "cmbApptStatus";
            this.cmbApptStatus.Size = new System.Drawing.Size(560, 33);
            this.cmbApptStatus.TabIndex = 23;
            // 
            // txtApptId
            // 
            this.txtApptId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApptId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptId.Location = new System.Drawing.Point(25, 76);
            this.txtApptId.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtApptId.Name = "txtApptId";
            this.txtApptId.Size = new System.Drawing.Size(560, 30);
            this.txtApptId.TabIndex = 25;
            // 
            // lblApptDoctor
            // 
            this.lblApptDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptDoctor.Location = new System.Drawing.Point(25, 121);
            this.lblApptDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptDoctor.Name = "lblApptDoctor";
            this.lblApptDoctor.Size = new System.Drawing.Size(560, 35);
            this.lblApptDoctor.TabIndex = 12;
            this.lblApptDoctor.Text = "Doctor";
            this.lblApptDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApptId
            // 
            this.lblApptId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptId.Location = new System.Drawing.Point(25, 30);
            this.lblApptId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptId.Name = "lblApptId";
            this.lblApptId.Size = new System.Drawing.Size(560, 35);
            this.lblApptId.TabIndex = 24;
            this.lblApptId.Text = "Appointment ID";
            this.lblApptId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.Controls.Add(this.dgvRegPatients);
            this.pnlPatientRegistration.Controls.Add(this.grpPatientRegistration);
            this.pnlPatientRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientRegistration.Location = new System.Drawing.Point(20, 20);
            this.pnlPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(1338, 885);
            this.pnlPatientRegistration.TabIndex = 3;
            this.pnlPatientRegistration.Visible = false;
            // 
            // dgvRegPatients
            // 
            this.dgvRegPatients.AllowUserToAddRows = false;
            this.dgvRegPatients.AllowUserToDeleteRows = false;
            this.dgvRegPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegPatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRegPatients.Location = new System.Drawing.Point(616, 2);
            this.dgvRegPatients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegPatients.MultiSelect = false;
            this.dgvRegPatients.Name = "dgvRegPatients";
            this.dgvRegPatients.ReadOnly = true;
            this.dgvRegPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRegPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRegPatients.RowTemplate.Height = 24;
            this.dgvRegPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegPatients.Size = new System.Drawing.Size(721, 895);
            this.dgvRegPatients.TabIndex = 7;
            // 
            // grpPatientRegistration
            // 
            this.grpPatientRegistration.Controls.Add(this.layoutPatientButtons);
            this.grpPatientRegistration.Controls.Add(this.txtPPhone);
            this.grpPatientRegistration.Controls.Add(this.lblPPhone);
            this.grpPatientRegistration.Controls.Add(this.dtpDoB);
            this.grpPatientRegistration.Controls.Add(this.lblDoB);
            this.grpPatientRegistration.Controls.Add(this.txtPatientId);
            this.grpPatientRegistration.Controls.Add(this.lblPatientId);
            this.grpPatientRegistration.Controls.Add(this.txtMedicalNumber);
            this.grpPatientRegistration.Controls.Add(this.lblMedicalNumber);
            this.grpPatientRegistration.Controls.Add(this.txtPLName);
            this.grpPatientRegistration.Controls.Add(this.lblPLName);
            this.grpPatientRegistration.Controls.Add(this.txtPFName);
            this.grpPatientRegistration.Controls.Add(this.lblPFName);
            this.grpPatientRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPatientRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientRegistration.Location = new System.Drawing.Point(0, 0);
            this.grpPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatientRegistration.Name = "grpPatientRegistration";
            this.grpPatientRegistration.Padding = new System.Windows.Forms.Padding(25);
            this.grpPatientRegistration.Size = new System.Drawing.Size(610, 885);
            this.grpPatientRegistration.TabIndex = 6;
            this.grpPatientRegistration.TabStop = false;
            this.grpPatientRegistration.Text = "Register Patient";
            // 
            // layoutPatientButtons
            // 
            this.layoutPatientButtons.ColumnCount = 4;
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPatientButtons.Controls.Add(this.btnPCreate, 0, 0);
            this.layoutPatientButtons.Controls.Add(this.btnPUpdate, 1, 0);
            this.layoutPatientButtons.Controls.Add(this.btnPSearch, 2, 0);
            this.layoutPatientButtons.Controls.Add(this.btnPDisplay, 0, 1);
            this.layoutPatientButtons.Controls.Add(this.btnPCancel, 3, 0);
            this.layoutPatientButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutPatientButtons.Location = new System.Drawing.Point(25, 499);
            this.layoutPatientButtons.Margin = new System.Windows.Forms.Padding(2);
            this.layoutPatientButtons.Name = "layoutPatientButtons";
            this.layoutPatientButtons.RowCount = 2;
            this.layoutPatientButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPatientButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPatientButtons.Size = new System.Drawing.Size(560, 116);
            this.layoutPatientButtons.TabIndex = 10;
            // 
            // btnPCreate
            // 
            this.btnPCreate.AutoSize = true;
            this.btnPCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCreate.ForeColor = System.Drawing.Color.White;
            this.btnPCreate.Location = new System.Drawing.Point(2, 2);
            this.btnPCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCreate.Name = "btnPCreate";
            this.btnPCreate.Size = new System.Drawing.Size(136, 54);
            this.btnPCreate.TabIndex = 5;
            this.btnPCreate.Text = "Create";
            this.btnPCreate.UseVisualStyleBackColor = false;
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.AutoSize = true;
            this.btnPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPUpdate.Location = new System.Drawing.Point(142, 2);
            this.btnPUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(136, 54);
            this.btnPUpdate.TabIndex = 11;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPSearch
            // 
            this.btnPSearch.AutoSize = true;
            this.btnPSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSearch.ForeColor = System.Drawing.Color.White;
            this.btnPSearch.Location = new System.Drawing.Point(282, 2);
            this.btnPSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(136, 54);
            this.btnPSearch.TabIndex = 4;
            this.btnPSearch.Text = "Search";
            this.btnPSearch.UseVisualStyleBackColor = false;
            // 
            // btnPDisplay
            // 
            this.btnPDisplay.AutoSize = true;
            this.btnPDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDisplay.ForeColor = System.Drawing.Color.White;
            this.btnPDisplay.Location = new System.Drawing.Point(2, 60);
            this.btnPDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDisplay.Name = "btnPDisplay";
            this.btnPDisplay.Size = new System.Drawing.Size(136, 54);
            this.btnPDisplay.TabIndex = 10;
            this.btnPDisplay.Text = "Display";
            this.btnPDisplay.UseVisualStyleBackColor = false;
            // 
            // btnPCancel
            // 
            this.btnPCancel.AutoSize = true;
            this.btnPCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnPCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCancel.ForeColor = System.Drawing.Color.White;
            this.btnPCancel.Location = new System.Drawing.Point(422, 2);
            this.btnPCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCancel.Name = "btnPCancel";
            this.btnPCancel.Size = new System.Drawing.Size(136, 54);
            this.btnPCancel.TabIndex = 9;
            this.btnPCancel.Text = "Cancel";
            this.btnPCancel.UseVisualStyleBackColor = false;
            // 
            // txtPPhone
            // 
            this.txtPPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPhone.Location = new System.Drawing.Point(24, 422);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.Size = new System.Drawing.Size(560, 30);
            this.txtPPhone.TabIndex = 5;
            // 
            // lblPPhone
            // 
            this.lblPPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPhone.Location = new System.Drawing.Point(24, 382);
            this.lblPPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPPhone.Name = "lblPPhone";
            this.lblPPhone.Size = new System.Drawing.Size(560, 35);
            this.lblPPhone.TabIndex = 4;
            this.lblPPhone.Text = "Phone Number";
            this.lblPPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDoB
            // 
            this.dtpDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Location = new System.Drawing.Point(24, 248);
            this.dtpDoB.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(559, 30);
            this.dtpDoB.TabIndex = 5;
            // 
            // lblDoB
            // 
            this.lblDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(24, 208);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(560, 35);
            this.lblDoB.TabIndex = 4;
            this.lblDoB.Text = "Date of Birth";
            this.lblDoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(25, 75);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(560, 30);
            this.txtPatientId.TabIndex = 5;
            // 
            // lblPatientId
            // 
            this.lblPatientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.Location = new System.Drawing.Point(25, 35);
            this.lblPatientId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(560, 35);
            this.lblPatientId.TabIndex = 4;
            this.lblPatientId.Text = "Patient Id";
            this.lblPatientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedicalNumber
            // 
            this.txtMedicalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalNumber.Location = new System.Drawing.Point(24, 335);
            this.txtMedicalNumber.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtMedicalNumber.Name = "txtMedicalNumber";
            this.txtMedicalNumber.Size = new System.Drawing.Size(560, 30);
            this.txtMedicalNumber.TabIndex = 5;
            // 
            // lblMedicalNumber
            // 
            this.lblMedicalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedicalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalNumber.Location = new System.Drawing.Point(24, 295);
            this.lblMedicalNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicalNumber.Name = "lblMedicalNumber";
            this.lblMedicalNumber.Size = new System.Drawing.Size(560, 35);
            this.lblMedicalNumber.TabIndex = 4;
            this.lblMedicalNumber.Text = "Health Card Number";
            this.lblMedicalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPLName
            // 
            this.txtPLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLName.Location = new System.Drawing.Point(318, 162);
            this.txtPLName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPLName.Name = "txtPLName";
            this.txtPLName.Size = new System.Drawing.Size(267, 30);
            this.txtPLName.TabIndex = 5;
            // 
            // lblPLName
            // 
            this.lblPLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLName.Location = new System.Drawing.Point(318, 121);
            this.lblPLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPLName.Name = "lblPLName";
            this.lblPLName.Size = new System.Drawing.Size(268, 35);
            this.lblPLName.TabIndex = 4;
            this.lblPLName.Text = "Last Name";
            this.lblPLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPFName
            // 
            this.txtPFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPFName.Location = new System.Drawing.Point(25, 162);
            this.txtPFName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPFName.Name = "txtPFName";
            this.txtPFName.Size = new System.Drawing.Size(268, 30);
            this.txtPFName.TabIndex = 5;
            // 
            // lblPFName
            // 
            this.lblPFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFName.Location = new System.Drawing.Point(25, 121);
            this.lblPFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPFName.Name = "lblPFName";
            this.lblPFName.Size = new System.Drawing.Size(269, 35);
            this.lblPFName.TabIndex = 4;
            this.lblPFName.Text = "First Name";
            this.lblPFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.grpNotifications);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1676, 125);
            this.pnlHeader.TabIndex = 4;
            // 
            // grpNotifications
            // 
            this.grpNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpNotifications.Controls.Add(this.btnNotifications);
            this.grpNotifications.Controls.Add(this.lblToast);
            this.grpNotifications.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNotifications.ForeColor = System.Drawing.Color.White;
            this.grpNotifications.Location = new System.Drawing.Point(854, 0);
            this.grpNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.grpNotifications.Name = "grpNotifications";
            this.grpNotifications.Padding = new System.Windows.Forms.Padding(30, 20, 30, 30);
            this.grpNotifications.Size = new System.Drawing.Size(822, 125);
            this.grpNotifications.TabIndex = 2;
            this.grpNotifications.TabStop = false;
            this.grpNotifications.Text = "Notifications";
            // 
            // btnNotifications
            // 
            this.btnNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Image = global::ClinicManagement_proj.Properties.Resources.notifications_icon;
            this.btnNotifications.Location = new System.Drawing.Point(737, 39);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(55, 56);
            this.btnNotifications.TabIndex = 0;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // lblToast
            // 
            this.lblToast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblToast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToast.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblToast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToast.ForeColor = System.Drawing.Color.White;
            this.lblToast.Location = new System.Drawing.Point(30, 39);
            this.lblToast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToast.Name = "lblToast";
            this.lblToast.Padding = new System.Windows.Forms.Padding(5);
            this.lblToast.Size = new System.Drawing.Size(701, 56);
            this.lblToast.TabIndex = 2;
            this.lblToast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblToast.Visible = false;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BackColor = System.Drawing.Color.White;
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.lbNotifications);
            this.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotifications.Location = new System.Drawing.Point(1675, 125);
            this.pnlNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(1, 925);
            this.pnlNotifications.TabIndex = 1;
            this.pnlNotifications.Visible = false;
            // 
            // lbNotifications
            // 
            this.lbNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.ItemHeight = 18;
            this.lbNotifications.Location = new System.Drawing.Point(0, 0);
            this.lbNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.Size = new System.Drawing.Size(0, 810);
            this.lbNotifications.TabIndex = 0;
            // 
            // timerToast
            // 
            this.timerToast.Interval = 5000;
            this.timerToast.Tick += new System.EventHandler(this.timerToast_Tick);
            // 
            // grpAppointmentForm
            // 
            this.grpAppointmentForm.Location = new System.Drawing.Point(0, 0);
            this.grpAppointmentForm.Name = "grpAppointmentForm";
            this.grpAppointmentForm.Size = new System.Drawing.Size(200, 100);
            this.grpAppointmentForm.TabIndex = 0;
            this.grpAppointmentForm.TabStop = false;
            // 
            // lblAppointmentPlaceholder
            // 
            this.lblAppointmentPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblAppointmentPlaceholder.Name = "lblAppointmentPlaceholder";
            this.lblAppointmentPlaceholder.Size = new System.Drawing.Size(100, 23);
            this.lblAppointmentPlaceholder.TabIndex = 0;
            // 
            // ReceptionistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1676, 1050);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1692, 1028);
            this.Name = "ReceptionistDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlAppointmentManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.grpApptMgmt.ResumeLayout(false);
            this.grpApptMgmt.PerformLayout();
            this.layoutApptButtons.ResumeLayout(false);
            this.layoutApptButtons.PerformLayout();
            this.pnlPatientRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPatients)).EndInit();
            this.grpPatientRegistration.ResumeLayout(false);
            this.grpPatientRegistration.PerformLayout();
            this.layoutPatientButtons.ResumeLayout(false);
            this.layoutPatientButtons.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.grpNotifications.ResumeLayout(false);
            this.pnlNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnPatientRegistration;
        private System.Windows.Forms.Button btnAppointmentManagement;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.DataGridView dgvRegPatients;
        private System.Windows.Forms.GroupBox grpPatientRegistration;
        private System.Windows.Forms.TableLayoutPanel layoutPatientButtons;
        private System.Windows.Forms.Button btnPCreate;
        private System.Windows.Forms.Button btnPSearch;
        private System.Windows.Forms.TextBox txtPPhone;
        private System.Windows.Forms.Label lblPPhone;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtMedicalNumber;
        private System.Windows.Forms.Label lblMedicalNumber;
        private System.Windows.Forms.TextBox txtPLName;
        private System.Windows.Forms.Label lblPLName;
        private System.Windows.Forms.TextBox txtPFName;
        private System.Windows.Forms.Label lblPFName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox grpNotifications;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Label lblToast;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.ListBox lbNotifications;
        private System.Windows.Forms.Timer timerToast;
        private System.Windows.Forms.GroupBox grpAppointmentForm;
        private System.Windows.Forms.Label lblAppointmentPlaceholder;
        private System.Windows.Forms.Button btnPCancel;
        private System.Windows.Forms.Button btnPDisplay;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Panel pnlAppointmentManagement;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.GroupBox grpApptMgmt;
        private System.Windows.Forms.TableLayoutPanel layoutApptButtons;
        private System.Windows.Forms.Button btnApptCreate;
        private System.Windows.Forms.Button btnApptUpdate;
        private System.Windows.Forms.Button btnApptSearch;
        private System.Windows.Forms.Button btnApptDisplay;
        private System.Windows.Forms.Button btnApptCancel;
        private System.Windows.Forms.Label lblApptDoctor;
        private System.Windows.Forms.ComboBox cmbApptDoctor;
        private System.Windows.Forms.Label lblApptPatient;
        private System.Windows.Forms.ComboBox cmbApptPatient;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.DateTimePicker dtpApptDate;
        private System.Windows.Forms.Label lblApptTimeSlot;
        private System.Windows.Forms.FlowLayoutPanel flpApptTimeSlots;
        private System.Windows.Forms.Label lblApptNotes;
        private System.Windows.Forms.TextBox txtApptNotes;
        private System.Windows.Forms.Label lblApptStatus;
        private System.Windows.Forms.ComboBox cmbApptStatus;
        private System.Windows.Forms.Label lblApptId;
        private System.Windows.Forms.TextBox txtApptId;
    }
}