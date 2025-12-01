using System.Drawing;

namespace ClinicManagement_proj.UI
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnAppointmentManagement = new System.Windows.Forms.Button();
            this.btnPatientRegistration = new System.Windows.Forms.Button();
            this.btnDoctorScheduling = new System.Windows.Forms.Button();
            this.btnDoctorManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
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
            this.pnlDoctorScheduling = new System.Windows.Forms.Panel();
            this.grpDoctorScheduling = new System.Windows.Forms.GroupBox();
            this.layoutSchedulingContent = new System.Windows.Forms.TableLayoutPanel();
            this.layoutHours = new System.Windows.Forms.TableLayoutPanel();
            this.lblHour12 = new System.Windows.Forms.Label();
            this.lblHour11 = new System.Windows.Forms.Label();
            this.lblHour10 = new System.Windows.Forms.Label();
            this.lblHour9 = new System.Windows.Forms.Label();
            this.lblHour8 = new System.Windows.Forms.Label();
            this.lblHour7 = new System.Windows.Forms.Label();
            this.lblHour6 = new System.Windows.Forms.Label();
            this.lblHour5 = new System.Windows.Forms.Label();
            this.lblHour4 = new System.Windows.Forms.Label();
            this.lblHour3 = new System.Windows.Forms.Label();
            this.lblHour2 = new System.Windows.Forms.Label();
            this.lblHour1 = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lbSunday = new System.Windows.Forms.ListBox();
            this.lbMonday = new System.Windows.Forms.ListBox();
            this.lbTuesday = new System.Windows.Forms.ListBox();
            this.lbWednesday = new System.Windows.Forms.ListBox();
            this.lbThursday = new System.Windows.Forms.ListBox();
            this.lbFriday = new System.Windows.Forms.ListBox();
            this.lbSaturday = new System.Windows.Forms.ListBox();
            this.layoutSchedulingHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDoctorPicker = new System.Windows.Forms.Panel();
            this.cmbDoctorSelect = new System.Windows.Forms.ComboBox();
            this.lblDoctorSelect = new System.Windows.Forms.Label();
            this.layoutSchedulingActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSchedulingUpdate = new System.Windows.Forms.Button();
            this.btnScheduleSave = new System.Windows.Forms.Button();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpAdminForm = new System.Windows.Forms.GroupBox();
            this.txtUsrId = new System.Windows.Forms.TextBox();
            this.lblUsrId = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenPassword = new System.Windows.Forms.Button();
            this.btnUsrCreate = new System.Windows.Forms.Button();
            this.btnUsrUpdate = new System.Windows.Forms.Button();
            this.btnUsrSearch = new System.Windows.Forms.Button();
            this.btnUsrCancel = new System.Windows.Forms.Button();
            this.btnUsrDisplay = new System.Windows.Forms.Button();
            this.btnUsrDelete = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.TableLayoutPanel();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.txtUsrPassword = new System.Windows.Forms.TextBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsrUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlDoctorManagement = new System.Windows.Forms.Panel();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.grpDoctorMgmt = new System.Windows.Forms.GroupBox();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtDoctorLName = new System.Windows.Forms.TextBox();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblDoctorLName = new System.Windows.Forms.Label();
            this.txtDoctorFName = new System.Windows.Forms.TextBox();
            this.lblDoctorFName = new System.Windows.Forms.Label();
            this.layoutDoctorActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoctorCreate = new System.Windows.Forms.Button();
            this.btnDoctorUpdate = new System.Windows.Forms.Button();
            this.btnDoctorSearch = new System.Windows.Forms.Button();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            this.btnDoctorDisplay = new System.Windows.Forms.Button();
            this.btnDoctorCancel = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReportsPlaceholder = new System.Windows.Forms.Label();
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
            this.pnlDoctorScheduling.SuspendLayout();
            this.grpDoctorScheduling.SuspendLayout();
            this.layoutSchedulingContent.SuspendLayout();
            this.layoutHours.SuspendLayout();
            this.layoutSchedulingHeader.SuspendLayout();
            this.pnlDoctorPicker.SuspendLayout();
            this.layoutSchedulingActions.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpAdminForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlDoctorManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.grpDoctorMgmt.SuspendLayout();
            this.layoutDoctorActions.SuspendLayout();
            this.pnlReports.SuspendLayout();
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
            this.lblHeader.Text = "Admin Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSidebar.Controls.Add(this.btnAppointmentManagement);
            this.pnlSidebar.Controls.Add(this.btnPatientRegistration);
            this.pnlSidebar.Controls.Add(this.btnDoctorScheduling);
            this.pnlSidebar.Controls.Add(this.btnDoctorManagement);
            this.pnlSidebar.Controls.Add(this.btnUserManagement);
            this.pnlSidebar.Controls.Add(this.btnReports);
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
            this.btnAppointmentManagement.Location = new System.Drawing.Point(0, 400);
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
            this.btnPatientRegistration.Location = new System.Drawing.Point(0, 330);
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
            // btnDoctorScheduling
            // 
            this.btnDoctorScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorScheduling.FlatAppearance.BorderSize = 0;
            this.btnDoctorScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorScheduling.ForeColor = System.Drawing.Color.White;
            this.btnDoctorScheduling.Image = global::ClinicManagement_proj.Properties.Resources.schedule_icon;
            this.btnDoctorScheduling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorScheduling.Location = new System.Drawing.Point(0, 260);
            this.btnDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorScheduling.Name = "btnDoctorScheduling";
            this.btnDoctorScheduling.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDoctorScheduling.Size = new System.Drawing.Size(298, 70);
            this.btnDoctorScheduling.TabIndex = 5;
            this.btnDoctorScheduling.Text = "    Doctor Scheduling";
            this.btnDoctorScheduling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorScheduling.UseVisualStyleBackColor = false;
            this.btnDoctorScheduling.Click += new System.EventHandler(this.btnDoctorScheduling_Click);
            // 
            // btnDoctorManagement
            // 
            this.btnDoctorManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDoctorManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorManagement.FlatAppearance.BorderSize = 0;
            this.btnDoctorManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorManagement.ForeColor = System.Drawing.Color.White;
            this.btnDoctorManagement.Image = global::ClinicManagement_proj.Properties.Resources.doctor_icon;
            this.btnDoctorManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorManagement.Location = new System.Drawing.Point(0, 190);
            this.btnDoctorManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorManagement.Name = "btnDoctorManagement";
            this.btnDoctorManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDoctorManagement.Size = new System.Drawing.Size(298, 70);
            this.btnDoctorManagement.TabIndex = 3;
            this.btnDoctorManagement.Text = "    Doctor Management";
            this.btnDoctorManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorManagement.UseVisualStyleBackColor = false;
            this.btnDoctorManagement.Click += new System.EventHandler(this.btnDoctorManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Image = global::ClinicManagement_proj.Properties.Resources.users_icon;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 120);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(298, 70);
            this.btnUserManagement.TabIndex = 2;
            this.btnUserManagement.Text = "    User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::ClinicManagement_proj.Properties.Resources.reports_icon;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 50);
            this.btnReports.Margin = new System.Windows.Forms.Padding(1);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(298, 70);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "    Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
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
            this.pnlMainContent.Controls.Add(this.pnlDoctorScheduling);
            this.pnlMainContent.Controls.Add(this.pnlUserManagement);
            this.pnlMainContent.Controls.Add(this.pnlDoctorManagement);
            this.pnlMainContent.Controls.Add(this.pnlReports);
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
            this.cmbApptDoctor.Size = new System.Drawing.Size(560, 33);
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
            this.cmbApptPatient.Size = new System.Drawing.Size(560, 33);
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
            // pnlDoctorScheduling
            // 
            this.pnlDoctorScheduling.Controls.Add(this.grpDoctorScheduling);
            this.pnlDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorScheduling.Location = new System.Drawing.Point(20, 20);
            this.pnlDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorScheduling.Name = "pnlDoctorScheduling";
            this.pnlDoctorScheduling.Size = new System.Drawing.Size(1338, 885);
            this.pnlDoctorScheduling.TabIndex = 4;
            this.pnlDoctorScheduling.Visible = false;
            // 
            // grpDoctorScheduling
            // 
            this.grpDoctorScheduling.Controls.Add(this.layoutSchedulingContent);
            this.grpDoctorScheduling.Controls.Add(this.layoutSchedulingHeader);
            this.grpDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDoctorScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctorScheduling.Location = new System.Drawing.Point(0, 0);
            this.grpDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.grpDoctorScheduling.Name = "grpDoctorScheduling";
            this.grpDoctorScheduling.Padding = new System.Windows.Forms.Padding(25);
            this.grpDoctorScheduling.Size = new System.Drawing.Size(1338, 885);
            this.grpDoctorScheduling.TabIndex = 6;
            this.grpDoctorScheduling.TabStop = false;
            this.grpDoctorScheduling.Text = "Adjust a Doctor\'s Schedule";
            // 
            // layoutSchedulingContent
            // 
            this.layoutSchedulingContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutSchedulingContent.ColumnCount = 8;
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layoutSchedulingContent.Controls.Add(this.layoutHours, 0, 1);
            this.layoutSchedulingContent.Controls.Add(this.lblDay1, 1, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay2, 2, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay3, 3, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay4, 4, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay5, 5, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay6, 6, 0);
            this.layoutSchedulingContent.Controls.Add(this.lblDay7, 7, 0);
            this.layoutSchedulingContent.Controls.Add(this.lbSunday, 1, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbMonday, 2, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbTuesday, 3, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbWednesday, 4, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbThursday, 5, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbFriday, 6, 1);
            this.layoutSchedulingContent.Controls.Add(this.lbSaturday, 7, 1);
            this.layoutSchedulingContent.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutSchedulingContent.Location = new System.Drawing.Point(25, 131);
            this.layoutSchedulingContent.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingContent.Name = "layoutSchedulingContent";
            this.layoutSchedulingContent.RowCount = 2;
            this.layoutSchedulingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutSchedulingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingContent.Size = new System.Drawing.Size(1288, 728);
            this.layoutSchedulingContent.TabIndex = 10;
            // 
            // layoutHours
            // 
            this.layoutHours.ColumnCount = 1;
            this.layoutHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutHours.Controls.Add(this.lblHour12, 0, 23);
            this.layoutHours.Controls.Add(this.lblHour11, 0, 21);
            this.layoutHours.Controls.Add(this.lblHour10, 0, 19);
            this.layoutHours.Controls.Add(this.lblHour9, 0, 17);
            this.layoutHours.Controls.Add(this.lblHour8, 0, 15);
            this.layoutHours.Controls.Add(this.lblHour7, 0, 13);
            this.layoutHours.Controls.Add(this.lblHour6, 0, 11);
            this.layoutHours.Controls.Add(this.lblHour5, 0, 9);
            this.layoutHours.Controls.Add(this.lblHour4, 0, 7);
            this.layoutHours.Controls.Add(this.lblHour3, 0, 5);
            this.layoutHours.Controls.Add(this.lblHour2, 0, 3);
            this.layoutHours.Controls.Add(this.lblHour1, 0, 1);
            this.layoutHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutHours.Location = new System.Drawing.Point(2, 47);
            this.layoutHours.Margin = new System.Windows.Forms.Padding(2);
            this.layoutHours.Name = "layoutHours";
            this.layoutHours.RowCount = 24;
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.030012F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.030012F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.03001201F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303322F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutHours.Size = new System.Drawing.Size(76, 679);
            this.layoutHours.TabIndex = 1;
            // 
            // lblHour12
            // 
            this.lblHour12.AutoSize = true;
            this.lblHour12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour12.Location = new System.Drawing.Point(2, 647);
            this.lblHour12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour12.Name = "lblHour12";
            this.lblHour12.Size = new System.Drawing.Size(72, 32);
            this.lblHour12.TabIndex = 11;
            this.lblHour12.Text = "22:00";
            this.lblHour12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour11
            // 
            this.lblHour11.AutoSize = true;
            this.lblHour11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour11.Location = new System.Drawing.Point(2, 570);
            this.lblHour11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour11.Name = "lblHour11";
            this.lblHour11.Size = new System.Drawing.Size(72, 57);
            this.lblHour11.TabIndex = 10;
            this.lblHour11.Text = "20:00";
            this.lblHour11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour10
            // 
            this.lblHour10.AutoSize = true;
            this.lblHour10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour10.Location = new System.Drawing.Point(2, 513);
            this.lblHour10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour10.Name = "lblHour10";
            this.lblHour10.Size = new System.Drawing.Size(72, 57);
            this.lblHour10.TabIndex = 9;
            this.lblHour10.Text = "18:00";
            this.lblHour10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour9
            // 
            this.lblHour9.AutoSize = true;
            this.lblHour9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour9.Location = new System.Drawing.Point(2, 456);
            this.lblHour9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour9.Name = "lblHour9";
            this.lblHour9.Size = new System.Drawing.Size(72, 57);
            this.lblHour9.TabIndex = 8;
            this.lblHour9.Text = "16:00";
            this.lblHour9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour8
            // 
            this.lblHour8.AutoSize = true;
            this.lblHour8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour8.Location = new System.Drawing.Point(2, 399);
            this.lblHour8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour8.Name = "lblHour8";
            this.lblHour8.Size = new System.Drawing.Size(72, 57);
            this.lblHour8.TabIndex = 7;
            this.lblHour8.Text = "14:00";
            this.lblHour8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour7
            // 
            this.lblHour7.AutoSize = true;
            this.lblHour7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour7.Location = new System.Drawing.Point(2, 342);
            this.lblHour7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour7.Name = "lblHour7";
            this.lblHour7.Size = new System.Drawing.Size(72, 57);
            this.lblHour7.TabIndex = 6;
            this.lblHour7.Text = "12:00";
            this.lblHour7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour6
            // 
            this.lblHour6.AutoSize = true;
            this.lblHour6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour6.Location = new System.Drawing.Point(2, 285);
            this.lblHour6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour6.Name = "lblHour6";
            this.lblHour6.Size = new System.Drawing.Size(72, 57);
            this.lblHour6.TabIndex = 5;
            this.lblHour6.Text = "10:00";
            this.lblHour6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour5
            // 
            this.lblHour5.AutoSize = true;
            this.lblHour5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour5.Location = new System.Drawing.Point(2, 228);
            this.lblHour5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour5.Name = "lblHour5";
            this.lblHour5.Size = new System.Drawing.Size(72, 57);
            this.lblHour5.TabIndex = 4;
            this.lblHour5.Text = "08:00";
            this.lblHour5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour4
            // 
            this.lblHour4.AutoSize = true;
            this.lblHour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour4.Location = new System.Drawing.Point(2, 171);
            this.lblHour4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour4.Name = "lblHour4";
            this.lblHour4.Size = new System.Drawing.Size(72, 57);
            this.lblHour4.TabIndex = 3;
            this.lblHour4.Text = "06:00";
            this.lblHour4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour3
            // 
            this.lblHour3.AutoSize = true;
            this.lblHour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour3.Location = new System.Drawing.Point(2, 114);
            this.lblHour3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour3.Name = "lblHour3";
            this.lblHour3.Size = new System.Drawing.Size(72, 57);
            this.lblHour3.TabIndex = 2;
            this.lblHour3.Text = "04:00";
            this.lblHour3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour2
            // 
            this.lblHour2.AutoSize = true;
            this.lblHour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour2.Location = new System.Drawing.Point(2, 57);
            this.lblHour2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour2.Name = "lblHour2";
            this.lblHour2.Size = new System.Drawing.Size(72, 57);
            this.lblHour2.TabIndex = 1;
            this.lblHour2.Text = "02:00";
            this.lblHour2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour1
            // 
            this.lblHour1.AutoSize = true;
            this.lblHour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour1.Location = new System.Drawing.Point(2, 0);
            this.lblHour1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour1.Name = "lblHour1";
            this.lblHour1.Size = new System.Drawing.Size(72, 57);
            this.lblHour1.TabIndex = 0;
            this.lblHour1.Text = "00:00";
            this.lblHour1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay1.Location = new System.Drawing.Point(82, 0);
            this.lblDay1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(168, 45);
            this.lblDay1.TabIndex = 2;
            this.lblDay1.Text = "Sunday";
            this.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay2.Location = new System.Drawing.Point(254, 0);
            this.lblDay2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(168, 45);
            this.lblDay2.TabIndex = 15;
            this.lblDay2.Text = "Monday";
            this.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay3.Location = new System.Drawing.Point(426, 0);
            this.lblDay3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(168, 45);
            this.lblDay3.TabIndex = 16;
            this.lblDay3.Text = "Tuesday";
            this.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay4.Location = new System.Drawing.Point(598, 0);
            this.lblDay4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(168, 45);
            this.lblDay4.TabIndex = 17;
            this.lblDay4.Text = "Wednesday";
            this.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay5.Location = new System.Drawing.Point(770, 0);
            this.lblDay5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(168, 45);
            this.lblDay5.TabIndex = 16;
            this.lblDay5.Text = "Thursday";
            this.lblDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay6.Location = new System.Drawing.Point(942, 0);
            this.lblDay6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(168, 45);
            this.lblDay6.TabIndex = 16;
            this.lblDay6.Text = "Friday";
            this.lblDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay7.Location = new System.Drawing.Point(1114, 0);
            this.lblDay7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(172, 45);
            this.lblDay7.TabIndex = 16;
            this.lblDay7.Text = "Saturday";
            this.lblDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSunday
            // 
            this.lbSunday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSunday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSunday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunday.ItemHeight = 25;
            this.lbSunday.Location = new System.Drawing.Point(82, 47);
            this.lbSunday.Margin = new System.Windows.Forms.Padding(2);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSunday.Size = new System.Drawing.Size(168, 675);
            this.lbSunday.TabIndex = 18;
            // 
            // lbMonday
            // 
            this.lbMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMonday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonday.ItemHeight = 25;
            this.lbMonday.Location = new System.Drawing.Point(254, 47);
            this.lbMonday.Margin = new System.Windows.Forms.Padding(2);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMonday.Size = new System.Drawing.Size(168, 675);
            this.lbMonday.TabIndex = 19;
            // 
            // lbTuesday
            // 
            this.lbTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTuesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuesday.ItemHeight = 25;
            this.lbTuesday.Location = new System.Drawing.Point(426, 47);
            this.lbTuesday.Margin = new System.Windows.Forms.Padding(2);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTuesday.Size = new System.Drawing.Size(168, 675);
            this.lbTuesday.TabIndex = 19;
            // 
            // lbWednesday
            // 
            this.lbWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWednesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWednesday.ItemHeight = 25;
            this.lbWednesday.Location = new System.Drawing.Point(598, 47);
            this.lbWednesday.Margin = new System.Windows.Forms.Padding(2);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbWednesday.Size = new System.Drawing.Size(168, 675);
            this.lbWednesday.TabIndex = 19;
            // 
            // lbThursday
            // 
            this.lbThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbThursday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThursday.ItemHeight = 25;
            this.lbThursday.Location = new System.Drawing.Point(770, 47);
            this.lbThursday.Margin = new System.Windows.Forms.Padding(2);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbThursday.Size = new System.Drawing.Size(168, 675);
            this.lbThursday.TabIndex = 19;
            // 
            // lbFriday
            // 
            this.lbFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFriday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriday.ItemHeight = 25;
            this.lbFriday.Location = new System.Drawing.Point(942, 47);
            this.lbFriday.Margin = new System.Windows.Forms.Padding(2);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFriday.Size = new System.Drawing.Size(168, 675);
            this.lbFriday.TabIndex = 20;
            // 
            // lbSaturday
            // 
            this.lbSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSaturday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturday.ItemHeight = 25;
            this.lbSaturday.Location = new System.Drawing.Point(1114, 47);
            this.lbSaturday.Margin = new System.Windows.Forms.Padding(2);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSaturday.Size = new System.Drawing.Size(172, 675);
            this.lbSaturday.TabIndex = 19;
            // 
            // layoutSchedulingHeader
            // 
            this.layoutSchedulingHeader.ColumnCount = 2;
            this.layoutSchedulingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutSchedulingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutSchedulingHeader.Controls.Add(this.pnlDoctorPicker, 0, 0);
            this.layoutSchedulingHeader.Controls.Add(this.layoutSchedulingActions, 1, 0);
            this.layoutSchedulingHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutSchedulingHeader.Location = new System.Drawing.Point(25, 48);
            this.layoutSchedulingHeader.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingHeader.Name = "layoutSchedulingHeader";
            this.layoutSchedulingHeader.RowCount = 1;
            this.layoutSchedulingHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingHeader.Size = new System.Drawing.Size(1288, 78);
            this.layoutSchedulingHeader.TabIndex = 17;
            // 
            // pnlDoctorPicker
            // 
            this.pnlDoctorPicker.Controls.Add(this.cmbDoctorSelect);
            this.pnlDoctorPicker.Controls.Add(this.lblDoctorSelect);
            this.pnlDoctorPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorPicker.Location = new System.Drawing.Point(2, 2);
            this.pnlDoctorPicker.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorPicker.Name = "pnlDoctorPicker";
            this.pnlDoctorPicker.Size = new System.Drawing.Size(768, 74);
            this.pnlDoctorPicker.TabIndex = 0;
            // 
            // cmbDoctorSelect
            // 
            this.cmbDoctorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDoctorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorSelect.FormattingEnabled = true;
            this.cmbDoctorSelect.Location = new System.Drawing.Point(15, 34);
            this.cmbDoctorSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoctorSelect.Name = "cmbDoctorSelect";
            this.cmbDoctorSelect.Size = new System.Drawing.Size(750, 33);
            this.cmbDoctorSelect.TabIndex = 14;
            // 
            // lblDoctorSelect
            // 
            this.lblDoctorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSelect.Location = new System.Drawing.Point(11, 0);
            this.lblDoctorSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorSelect.Name = "lblDoctorSelect";
            this.lblDoctorSelect.Size = new System.Drawing.Size(240, 32);
            this.lblDoctorSelect.TabIndex = 13;
            this.lblDoctorSelect.Text = "Doctor";
            this.lblDoctorSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutSchedulingActions
            // 
            this.layoutSchedulingActions.ColumnCount = 2;
            this.layoutSchedulingActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutSchedulingActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutSchedulingActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutSchedulingActions.Controls.Add(this.btnSchedulingUpdate, 1, 0);
            this.layoutSchedulingActions.Controls.Add(this.btnScheduleSave, 0, 0);
            this.layoutSchedulingActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSchedulingActions.Location = new System.Drawing.Point(774, 2);
            this.layoutSchedulingActions.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingActions.Name = "layoutSchedulingActions";
            this.layoutSchedulingActions.Padding = new System.Windows.Forms.Padding(10);
            this.layoutSchedulingActions.RowCount = 1;
            this.layoutSchedulingActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingActions.Size = new System.Drawing.Size(512, 74);
            this.layoutSchedulingActions.TabIndex = 2;
            // 
            // btnSchedulingUpdate
            // 
            this.btnSchedulingUpdate.AutoSize = true;
            this.btnSchedulingUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSchedulingUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSchedulingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedulingUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedulingUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSchedulingUpdate.Location = new System.Drawing.Point(258, 12);
            this.btnSchedulingUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedulingUpdate.Name = "btnSchedulingUpdate";
            this.btnSchedulingUpdate.Size = new System.Drawing.Size(242, 50);
            this.btnSchedulingUpdate.TabIndex = 7;
            this.btnSchedulingUpdate.Text = "Revert";
            this.btnSchedulingUpdate.UseVisualStyleBackColor = false;
            // 
            // btnScheduleSave
            // 
            this.btnScheduleSave.AutoSize = true;
            this.btnScheduleSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnScheduleSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScheduleSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleSave.ForeColor = System.Drawing.Color.White;
            this.btnScheduleSave.Location = new System.Drawing.Point(12, 12);
            this.btnScheduleSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnScheduleSave.Name = "btnScheduleSave";
            this.btnScheduleSave.Size = new System.Drawing.Size(242, 50);
            this.btnScheduleSave.TabIndex = 6;
            this.btnScheduleSave.Text = "Save";
            this.btnScheduleSave.UseVisualStyleBackColor = false;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.dgvUsers);
            this.pnlUserManagement.Controls.Add(this.grpAdminForm);
            this.pnlUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserManagement.Location = new System.Drawing.Point(20, 20);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1338, 885);
            this.pnlUserManagement.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.Location = new System.Drawing.Point(644, 2);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(707, 880);
            this.dgvUsers.TabIndex = 4;
            // 
            // grpAdminForm
            // 
            this.grpAdminForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAdminForm.Controls.Add(this.txtUsrId);
            this.grpAdminForm.Controls.Add(this.lblUsrId);
            this.grpAdminForm.Controls.Add(this.pnlButtons);
            this.grpAdminForm.Controls.Add(this.pnlPassword);
            this.grpAdminForm.Controls.Add(this.cmbRoles);
            this.grpAdminForm.Controls.Add(this.lblRole);
            this.grpAdminForm.Controls.Add(this.lblPassword);
            this.grpAdminForm.Controls.Add(this.txtUsrUsername);
            this.grpAdminForm.Controls.Add(this.lblUsername);
            this.grpAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdminForm.Location = new System.Drawing.Point(2, 2);
            this.grpAdminForm.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdminForm.Name = "grpAdminForm";
            this.grpAdminForm.Padding = new System.Windows.Forms.Padding(25);
            this.grpAdminForm.Size = new System.Drawing.Size(635, 880);
            this.grpAdminForm.TabIndex = 5;
            this.grpAdminForm.TabStop = false;
            this.grpAdminForm.Text = "Create User";
            // 
            // txtUsrId
            // 
            this.txtUsrId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrId.Location = new System.Drawing.Point(20, 79);
            this.txtUsrId.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtUsrId.Name = "txtUsrId";
            this.txtUsrId.Size = new System.Drawing.Size(584, 30);
            this.txtUsrId.TabIndex = 13;
            // 
            // lblUsrId
            // 
            this.lblUsrId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrId.Location = new System.Drawing.Point(20, 38);
            this.lblUsrId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrId.Name = "lblUsrId";
            this.lblUsrId.Size = new System.Drawing.Size(585, 35);
            this.lblUsrId.TabIndex = 12;
            this.lblUsrId.Text = "User Id";
            this.lblUsrId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 4;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.Controls.Add(this.btnGenPassword, 2, 1);
            this.pnlButtons.Controls.Add(this.btnUsrCreate, 0, 0);
            this.pnlButtons.Controls.Add(this.btnUsrUpdate, 1, 0);
            this.pnlButtons.Controls.Add(this.btnUsrSearch, 2, 0);
            this.pnlButtons.Controls.Add(this.btnUsrCancel, 1, 1);
            this.pnlButtons.Controls.Add(this.btnUsrDisplay, 3, 0);
            this.pnlButtons.Controls.Add(this.btnUsrDelete, 0, 1);
            this.pnlButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnlButtons.Location = new System.Drawing.Point(20, 488);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Size = new System.Drawing.Size(585, 111);
            this.pnlButtons.TabIndex = 16;
            // 
            // btnGenPassword
            // 
            this.btnGenPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenPassword.AutoSize = true;
            this.btnGenPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlButtons.SetColumnSpan(this.btnGenPassword, 2);
            this.btnGenPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPassword.ForeColor = System.Drawing.Color.White;
            this.btnGenPassword.Location = new System.Drawing.Point(294, 57);
            this.btnGenPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenPassword.Name = "btnGenPassword";
            this.btnGenPassword.Size = new System.Drawing.Size(289, 52);
            this.btnGenPassword.TabIndex = 6;
            this.btnGenPassword.Text = "Generate Password";
            this.btnGenPassword.UseVisualStyleBackColor = false;
            // 
            // btnUsrCreate
            // 
            this.btnUsrCreate.AutoSize = true;
            this.btnUsrCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUsrCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrCreate.ForeColor = System.Drawing.Color.White;
            this.btnUsrCreate.Location = new System.Drawing.Point(2, 2);
            this.btnUsrCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrCreate.Name = "btnUsrCreate";
            this.btnUsrCreate.Size = new System.Drawing.Size(142, 51);
            this.btnUsrCreate.TabIndex = 5;
            this.btnUsrCreate.Text = "Create";
            this.btnUsrCreate.UseVisualStyleBackColor = false;
            // 
            // btnUsrUpdate
            // 
            this.btnUsrUpdate.AutoSize = true;
            this.btnUsrUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUsrUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUsrUpdate.Location = new System.Drawing.Point(148, 2);
            this.btnUsrUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrUpdate.Name = "btnUsrUpdate";
            this.btnUsrUpdate.Size = new System.Drawing.Size(142, 51);
            this.btnUsrUpdate.TabIndex = 11;
            this.btnUsrUpdate.Text = "Update";
            this.btnUsrUpdate.UseVisualStyleBackColor = false;
            // 
            // btnUsrSearch
            // 
            this.btnUsrSearch.AutoSize = true;
            this.btnUsrSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUsrSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrSearch.ForeColor = System.Drawing.Color.White;
            this.btnUsrSearch.Location = new System.Drawing.Point(294, 2);
            this.btnUsrSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrSearch.Name = "btnUsrSearch";
            this.btnUsrSearch.Size = new System.Drawing.Size(142, 51);
            this.btnUsrSearch.TabIndex = 4;
            this.btnUsrSearch.Text = "Search";
            this.btnUsrSearch.UseVisualStyleBackColor = false;
            // 
            // btnUsrCancel
            // 
            this.btnUsrCancel.AutoSize = true;
            this.btnUsrCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnUsrCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrCancel.ForeColor = System.Drawing.Color.White;
            this.btnUsrCancel.Location = new System.Drawing.Point(148, 57);
            this.btnUsrCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrCancel.Name = "btnUsrCancel";
            this.btnUsrCancel.Size = new System.Drawing.Size(142, 52);
            this.btnUsrCancel.TabIndex = 9;
            this.btnUsrCancel.Text = "Cancel";
            this.btnUsrCancel.UseVisualStyleBackColor = false;
            // 
            // btnUsrDisplay
            // 
            this.btnUsrDisplay.AutoSize = true;
            this.btnUsrDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUsrDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrDisplay.ForeColor = System.Drawing.Color.White;
            this.btnUsrDisplay.Location = new System.Drawing.Point(440, 2);
            this.btnUsrDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrDisplay.Name = "btnUsrDisplay";
            this.btnUsrDisplay.Size = new System.Drawing.Size(143, 51);
            this.btnUsrDisplay.TabIndex = 10;
            this.btnUsrDisplay.Text = "Display";
            this.btnUsrDisplay.UseVisualStyleBackColor = false;
            // 
            // btnUsrDelete
            // 
            this.btnUsrDelete.AutoSize = true;
            this.btnUsrDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUsrDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrDelete.ForeColor = System.Drawing.Color.White;
            this.btnUsrDelete.Location = new System.Drawing.Point(2, 57);
            this.btnUsrDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrDelete.Name = "btnUsrDelete";
            this.btnUsrDelete.Size = new System.Drawing.Size(142, 52);
            this.btnUsrDelete.TabIndex = 7;
            this.btnUsrDelete.Text = "Delete";
            this.btnUsrDelete.UseVisualStyleBackColor = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPassword.ColumnCount = 2;
            this.pnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.01681F));
            this.pnlPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.98319F));
            this.pnlPassword.Controls.Add(this.btnTogglePassword, 1, 0);
            this.pnlPassword.Controls.Add(this.txtUsrPassword, 0, 0);
            this.pnlPassword.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnlPassword.Location = new System.Drawing.Point(18, 252);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.RowCount = 1;
            this.pnlPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlPassword.Size = new System.Drawing.Size(588, 38);
            this.pnlPassword.TabIndex = 11;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTogglePassword.AutoSize = true;
            this.btnTogglePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.Location = new System.Drawing.Point(484, 2);
            this.btnTogglePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(102, 34);
            this.btnTogglePassword.TabIndex = 8;
            this.btnTogglePassword.Text = "Show";
            this.btnTogglePassword.UseVisualStyleBackColor = false;
            // 
            // txtUsrPassword
            // 
            this.txtUsrPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrPassword.BackColor = System.Drawing.Color.White;
            this.txtUsrPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrPassword.Location = new System.Drawing.Point(5, 2);
            this.txtUsrPassword.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtUsrPassword.Name = "txtUsrPassword";
            this.txtUsrPassword.Size = new System.Drawing.Size(475, 30);
            this.txtUsrPassword.TabIndex = 7;
            this.txtUsrPassword.UseSystemPasswordChar = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(21, 348);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(585, 33);
            this.cmbRoles.TabIndex = 9;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(21, 304);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(585, 35);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(21, 215);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(585, 35);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsrUsername
            // 
            this.txtUsrUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrUsername.Location = new System.Drawing.Point(21, 166);
            this.txtUsrUsername.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtUsrUsername.Name = "txtUsrUsername";
            this.txtUsrUsername.Size = new System.Drawing.Size(584, 30);
            this.txtUsrUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(21, 126);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(585, 35);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDoctorManagement
            // 
            this.pnlDoctorManagement.Controls.Add(this.dgvDoctors);
            this.pnlDoctorManagement.Controls.Add(this.grpDoctorMgmt);
            this.pnlDoctorManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorManagement.Location = new System.Drawing.Point(20, 20);
            this.pnlDoctorManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorManagement.Name = "pnlDoctorManagement";
            this.pnlDoctorManagement.Size = new System.Drawing.Size(1338, 885);
            this.pnlDoctorManagement.TabIndex = 2;
            this.pnlDoctorManagement.Visible = false;
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDoctors.Location = new System.Drawing.Point(544, 0);
            this.dgvDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDoctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(810, 885);
            this.dgvDoctors.TabIndex = 7;
            // 
            // grpDoctorMgmt
            // 
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorId);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorId);
            this.grpDoctorMgmt.Controls.Add(this.lblNotice);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorLName);
            this.grpDoctorMgmt.Controls.Add(this.cmbSpecialization);
            this.grpDoctorMgmt.Controls.Add(this.lblSpecialization);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorLName);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorFName);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorFName);
            this.grpDoctorMgmt.Controls.Add(this.layoutDoctorActions);
            this.grpDoctorMgmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDoctorMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctorMgmt.Location = new System.Drawing.Point(0, 0);
            this.grpDoctorMgmt.Margin = new System.Windows.Forms.Padding(2);
            this.grpDoctorMgmt.Name = "grpDoctorMgmt";
            this.grpDoctorMgmt.Padding = new System.Windows.Forms.Padding(25);
            this.grpDoctorMgmt.Size = new System.Drawing.Size(539, 885);
            this.grpDoctorMgmt.TabIndex = 6;
            this.grpDoctorMgmt.TabStop = false;
            this.grpDoctorMgmt.Text = "Create Doctor";
            // 
            // lblDoctorId
            // 
            this.lblDoctorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorId.Location = new System.Drawing.Point(24, 39);
            this.lblDoctorId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(489, 35);
            this.lblDoctorId.TabIndex = 13;
            this.lblDoctorId.Text = "Doctor Id";
            this.lblDoctorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorId.Location = new System.Drawing.Point(24, 85);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(488, 30);
            this.txtDoctorId.TabIndex = 16;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(28, 448);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(489, 51);
            this.lblNotice.TabIndex = 12;
            this.lblNotice.Text = "Please set the availability in the Doctor Scheduling tab and make sure there is a" +
    "n existing User for this Doctor";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorLName
            // 
            this.txtDoctorLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorLName.Location = new System.Drawing.Point(24, 262);
            this.txtDoctorLName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtDoctorLName.Name = "txtDoctorLName";
            this.txtDoctorLName.Size = new System.Drawing.Size(488, 30);
            this.txtDoctorLName.TabIndex = 11;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Location = new System.Drawing.Point(24, 352);
            this.cmbSpecialization.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(489, 33);
            this.cmbSpecialization.TabIndex = 9;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(22, 309);
            this.lblSpecialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(489, 35);
            this.lblSpecialization.TabIndex = 8;
            this.lblSpecialization.Text = "Specialization";
            this.lblSpecialization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoctorLName
            // 
            this.lblDoctorLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorLName.Location = new System.Drawing.Point(24, 219);
            this.lblDoctorLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorLName.Name = "lblDoctorLName";
            this.lblDoctorLName.Size = new System.Drawing.Size(489, 35);
            this.lblDoctorLName.TabIndex = 6;
            this.lblDoctorLName.Text = "Last Name";
            this.lblDoctorLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorFName
            // 
            this.txtDoctorFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorFName.Location = new System.Drawing.Point(24, 174);
            this.txtDoctorFName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtDoctorFName.Name = "txtDoctorFName";
            this.txtDoctorFName.Size = new System.Drawing.Size(488, 30);
            this.txtDoctorFName.TabIndex = 5;
            // 
            // lblDoctorFName
            // 
            this.lblDoctorFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorFName.Location = new System.Drawing.Point(24, 129);
            this.lblDoctorFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorFName.Name = "lblDoctorFName";
            this.lblDoctorFName.Size = new System.Drawing.Size(489, 35);
            this.lblDoctorFName.TabIndex = 4;
            this.lblDoctorFName.Text = "First Name";
            this.lblDoctorFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutDoctorActions
            // 
            this.layoutDoctorActions.ColumnCount = 4;
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutDoctorActions.Controls.Add(this.btnDoctorCreate, 0, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorUpdate, 1, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorSearch, 2, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorDelete, 3, 0);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorDisplay, 0, 1);
            this.layoutDoctorActions.Controls.Add(this.btnDoctorCancel, 1, 1);
            this.layoutDoctorActions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutDoctorActions.Location = new System.Drawing.Point(24, 519);
            this.layoutDoctorActions.Margin = new System.Windows.Forms.Padding(2);
            this.layoutDoctorActions.Name = "layoutDoctorActions";
            this.layoutDoctorActions.RowCount = 2;
            this.layoutDoctorActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDoctorActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDoctorActions.Size = new System.Drawing.Size(488, 111);
            this.layoutDoctorActions.TabIndex = 15;
            // 
            // btnDoctorCreate
            // 
            this.btnDoctorCreate.AutoSize = true;
            this.btnDoctorCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDoctorCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorCreate.ForeColor = System.Drawing.Color.White;
            this.btnDoctorCreate.Location = new System.Drawing.Point(2, 2);
            this.btnDoctorCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorCreate.Name = "btnDoctorCreate";
            this.btnDoctorCreate.Size = new System.Drawing.Size(118, 51);
            this.btnDoctorCreate.TabIndex = 5;
            this.btnDoctorCreate.Text = "Create";
            this.btnDoctorCreate.UseVisualStyleBackColor = false;
            // 
            // btnDoctorUpdate
            // 
            this.btnDoctorUpdate.AutoSize = true;
            this.btnDoctorUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDoctorUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDoctorUpdate.Location = new System.Drawing.Point(124, 2);
            this.btnDoctorUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorUpdate.Name = "btnDoctorUpdate";
            this.btnDoctorUpdate.Size = new System.Drawing.Size(118, 51);
            this.btnDoctorUpdate.TabIndex = 11;
            this.btnDoctorUpdate.Text = "Update";
            this.btnDoctorUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDoctorSearch
            // 
            this.btnDoctorSearch.AutoSize = true;
            this.btnDoctorSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDoctorSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorSearch.ForeColor = System.Drawing.Color.White;
            this.btnDoctorSearch.Location = new System.Drawing.Point(246, 2);
            this.btnDoctorSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorSearch.Name = "btnDoctorSearch";
            this.btnDoctorSearch.Size = new System.Drawing.Size(118, 51);
            this.btnDoctorSearch.TabIndex = 4;
            this.btnDoctorSearch.Text = "Search";
            this.btnDoctorSearch.UseVisualStyleBackColor = false;
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.AutoSize = true;
            this.btnDoctorDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDoctorDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDelete.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDelete.Location = new System.Drawing.Point(368, 2);
            this.btnDoctorDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(118, 51);
            this.btnDoctorDelete.TabIndex = 7;
            this.btnDoctorDelete.Text = "Delete";
            this.btnDoctorDelete.UseVisualStyleBackColor = false;
            // 
            // btnDoctorDisplay
            // 
            this.btnDoctorDisplay.AutoSize = true;
            this.btnDoctorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDoctorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDisplay.Location = new System.Drawing.Point(2, 57);
            this.btnDoctorDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorDisplay.Name = "btnDoctorDisplay";
            this.btnDoctorDisplay.Size = new System.Drawing.Size(118, 52);
            this.btnDoctorDisplay.TabIndex = 10;
            this.btnDoctorDisplay.Text = "Display";
            this.btnDoctorDisplay.UseVisualStyleBackColor = false;
            // 
            // btnDoctorCancel
            // 
            this.btnDoctorCancel.AutoSize = true;
            this.btnDoctorCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnDoctorCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorCancel.ForeColor = System.Drawing.Color.White;
            this.btnDoctorCancel.Location = new System.Drawing.Point(124, 57);
            this.btnDoctorCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorCancel.Name = "btnDoctorCancel";
            this.btnDoctorCancel.Size = new System.Drawing.Size(118, 52);
            this.btnDoctorCancel.TabIndex = 9;
            this.btnDoctorCancel.Text = "Cancel";
            this.btnDoctorCancel.UseVisualStyleBackColor = false;
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.lblReportsPlaceholder);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(20, 20);
            this.pnlReports.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(1338, 885);
            this.pnlReports.TabIndex = 1;
            this.pnlReports.Visible = false;
            // 
            // lblReportsPlaceholder
            // 
            this.lblReportsPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportsPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblReportsPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblReportsPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportsPlaceholder.Name = "lblReportsPlaceholder";
            this.lblReportsPlaceholder.Size = new System.Drawing.Size(1338, 885);
            this.lblReportsPlaceholder.TabIndex = 0;
            this.lblReportsPlaceholder.Text = "Reports Module - Coming Soon";
            this.lblReportsPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // AdminDashboard
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
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
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
            this.pnlDoctorScheduling.ResumeLayout(false);
            this.grpDoctorScheduling.ResumeLayout(false);
            this.layoutSchedulingContent.ResumeLayout(false);
            this.layoutSchedulingContent.PerformLayout();
            this.layoutHours.ResumeLayout(false);
            this.layoutHours.PerformLayout();
            this.layoutSchedulingHeader.ResumeLayout(false);
            this.pnlDoctorPicker.ResumeLayout(false);
            this.layoutSchedulingActions.ResumeLayout(false);
            this.layoutSchedulingActions.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpAdminForm.ResumeLayout(false);
            this.grpAdminForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlDoctorManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.grpDoctorMgmt.ResumeLayout(false);
            this.grpDoctorMgmt.PerformLayout();
            this.layoutDoctorActions.ResumeLayout(false);
            this.layoutDoctorActions.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.grpNotifications.ResumeLayout(false);
            this.pnlNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnPatientRegistration;
        private System.Windows.Forms.Button btnDoctorScheduling;
        private System.Windows.Forms.Button btnDoctorManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnReports;
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
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpAdminForm;
        private System.Windows.Forms.TableLayoutPanel pnlPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.TextBox txtUsrPassword;
        private System.Windows.Forms.Button btnGenPassword;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsrUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReportsPlaceholder;
        private System.Windows.Forms.Panel pnlDoctorManagement;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.GroupBox grpDoctorMgmt;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TextBox txtDoctorLName;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblDoctorLName;
        private System.Windows.Forms.TextBox txtDoctorFName;
        private System.Windows.Forms.Label lblDoctorFName;
        private System.Windows.Forms.Panel pnlDoctorScheduling;
        private System.Windows.Forms.GroupBox grpDoctorScheduling;
        private System.Windows.Forms.TableLayoutPanel layoutSchedulingContent;
        private System.Windows.Forms.TableLayoutPanel layoutHours;
        private System.Windows.Forms.Label lblHour12;
        private System.Windows.Forms.Label lblHour11;
        private System.Windows.Forms.Label lblHour10;
        private System.Windows.Forms.Label lblHour9;
        private System.Windows.Forms.Label lblHour8;
        private System.Windows.Forms.Label lblHour7;
        private System.Windows.Forms.Label lblHour6;
        private System.Windows.Forms.Label lblHour5;
        private System.Windows.Forms.Label lblHour4;
        private System.Windows.Forms.Label lblHour3;
        private System.Windows.Forms.Label lblHour2;
        private System.Windows.Forms.Label lblHour1;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.Label lblDay7;
        private System.Windows.Forms.ListBox lbSunday;
        private System.Windows.Forms.ListBox lbMonday;
        private System.Windows.Forms.ListBox lbTuesday;
        private System.Windows.Forms.ListBox lbWednesday;
        private System.Windows.Forms.ListBox lbThursday;
        private System.Windows.Forms.ListBox lbFriday;
        private System.Windows.Forms.ListBox lbSaturday;
        private System.Windows.Forms.TableLayoutPanel layoutSchedulingHeader;
        private System.Windows.Forms.Panel pnlDoctorPicker;
        private System.Windows.Forms.ComboBox cmbDoctorSelect;
        private System.Windows.Forms.Label lblDoctorSelect;
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
        private System.Windows.Forms.TableLayoutPanel layoutDoctorActions;
        private System.Windows.Forms.Button btnDoctorCreate;
        private System.Windows.Forms.Button btnDoctorUpdate;
        private System.Windows.Forms.Button btnDoctorSearch;
        private System.Windows.Forms.Button btnDoctorDelete;
        private System.Windows.Forms.Button btnDoctorDisplay;
        private System.Windows.Forms.Button btnDoctorCancel;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TableLayoutPanel layoutSchedulingActions;
        private System.Windows.Forms.Button btnSchedulingUpdate;
        private System.Windows.Forms.Button btnScheduleSave;
        private System.Windows.Forms.TextBox txtUsrId;
        private System.Windows.Forms.Label lblUsrId;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnUsrCreate;
        private System.Windows.Forms.Button btnUsrUpdate;
        private System.Windows.Forms.Button btnUsrSearch;
        private System.Windows.Forms.Button btnUsrDelete;
        private System.Windows.Forms.Button btnUsrDisplay;
        private System.Windows.Forms.Button btnUsrCancel;
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
