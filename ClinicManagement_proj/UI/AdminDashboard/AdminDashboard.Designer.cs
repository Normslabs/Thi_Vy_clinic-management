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
            this.btnPatientRegistration = new System.Windows.Forms.Button();
            this.btnDoctorScheduling = new System.Windows.Forms.Button();
            this.btnDoctorManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.dgvRegPatients = new System.Windows.Forms.DataGridView();
            this.grpPatientRegistration = new System.Windows.Forms.GroupBox();
            this.layoutPatientButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnCancelPatient = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPPhone = new System.Windows.Forms.TextBox();
            this.lblPPhone = new System.Windows.Forms.Label();
            this.dateDoB = new System.Windows.Forms.DateTimePicker();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtMedicalNumber = new System.Windows.Forms.TextBox();
            this.lblMedicalNumber = new System.Windows.Forms.Label();
            this.txtPLName = new System.Windows.Forms.TextBox();
            this.lblPLName = new System.Windows.Forms.Label();
            this.txtPFName = new System.Windows.Forms.TextBox();
            this.lblPFName = new System.Windows.Forms.Label();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpAdminForm = new System.Windows.Forms.GroupBox();
            this.pnlPassword = new System.Windows.Forms.TableLayoutPanel();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.txtUsrPassword = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsrSubmit = new System.Windows.Forms.Button();
            this.btnGenPassword = new System.Windows.Forms.Button();
            this.btnUsrDelete = new System.Windows.Forms.Button();
            this.btnUsrCancel = new System.Windows.Forms.Button();
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsrUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReportsPlaceholder = new System.Windows.Forms.Label();
            this.pnlDoctorManagement = new System.Windows.Forms.Panel();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.grpDoctorMgmt = new System.Windows.Forms.GroupBox();
            this.comboDoctorUserId = new System.Windows.Forms.ComboBox();
            this.lblDocUserId = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtDoctorLName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoctorSubmit = new System.Windows.Forms.Button();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            this.btnDoctorCancel = new System.Windows.Forms.Button();
            this.comboSpecialization = new System.Windows.Forms.ComboBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblDoctorLName = new System.Windows.Forms.Label();
            this.txtDoctorFName = new System.Windows.Forms.TextBox();
            this.lblDoctorFName = new System.Windows.Forms.Label();
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
            this.layoutScheduleActions = new System.Windows.Forms.TableLayoutPanel();
            this.pnlScheduleActions = new System.Windows.Forms.Panel();
            this.btnScheduleSave = new System.Windows.Forms.Button();
            this.pnlUserPicker = new System.Windows.Forms.Panel();
            this.comboDoctorSelect = new System.Windows.Forms.ComboBox();
            this.lblDoctorSelect = new System.Windows.Forms.Label();
            this.pnlEffectiveDate = new System.Windows.Forms.Panel();
            this.dtEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.grpNotifications = new System.Windows.Forms.GroupBox();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.lblToast = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lbNotifications = new System.Windows.Forms.ListBox();
            this.timerToast = new System.Windows.Forms.Timer(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPatients)).BeginInit();
            this.grpPatientRegistration.SuspendLayout();
            this.layoutPatientButtons.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpAdminForm.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlDoctorManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.grpDoctorMgmt.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlDoctorScheduling.SuspendLayout();
            this.grpDoctorScheduling.SuspendLayout();
            this.layoutSchedulingContent.SuspendLayout();
            this.layoutHours.SuspendLayout();
            this.layoutScheduleActions.SuspendLayout();
            this.pnlScheduleActions.SuspendLayout();
            this.pnlUserPicker.SuspendLayout();
            this.pnlEffectiveDate.SuspendLayout();
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
            this.lblHeader.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(280, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(1679, 125);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Admin Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
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
            this.pnlSidebar.Size = new System.Drawing.Size(298, 621);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnPatientRegistration
            // 
            this.btnPatientRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPatientRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientRegistration.FlatAppearance.BorderSize = 0;
            this.btnPatientRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegistration.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDoctorScheduling.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDoctorManagement.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorManagement.ForeColor = System.Drawing.Color.White;
            this.btnDoctorManagement.Image = global::ClinicManagement_proj.Properties.Resources.doctor_icon_light;
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
            this.btnUserManagement.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnReports.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::ClinicManagement_proj.Properties.Resources.reports_icon;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 50);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblSidebarTitle.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlMainContent.Controls.Add(this.pnlPatientRegistration);
            this.pnlMainContent.Controls.Add(this.pnlUserManagement);
            this.pnlMainContent.Controls.Add(this.pnlReports);
            this.pnlMainContent.Controls.Add(this.pnlDoctorManagement);
            this.pnlMainContent.Controls.Add(this.pnlDoctorScheduling);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(298, 125);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(1381, 621);
            this.pnlMainContent.TabIndex = 3;
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.Controls.Add(this.dgvRegPatients);
            this.pnlPatientRegistration.Controls.Add(this.grpPatientRegistration);
            this.pnlPatientRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientRegistration.Location = new System.Drawing.Point(20, 20);
            this.pnlPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(1341, 581);
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
            this.dgvRegPatients.Location = new System.Drawing.Point(616, 3);
            this.dgvRegPatients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegPatients.MultiSelect = false;
            this.dgvRegPatients.Name = "dgvRegPatients";
            this.dgvRegPatients.ReadOnly = true;
            this.dgvRegPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRegPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRegPatients.RowTemplate.Height = 24;
            this.dgvRegPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegPatients.Size = new System.Drawing.Size(725, 591);
            this.dgvRegPatients.TabIndex = 7;
            // 
            // grpPatientRegistration
            // 
            this.grpPatientRegistration.Controls.Add(this.layoutPatientButtons);
            this.grpPatientRegistration.Controls.Add(this.txtEmail);
            this.grpPatientRegistration.Controls.Add(this.lblEmail);
            this.grpPatientRegistration.Controls.Add(this.txtPPhone);
            this.grpPatientRegistration.Controls.Add(this.lblPPhone);
            this.grpPatientRegistration.Controls.Add(this.dateDoB);
            this.grpPatientRegistration.Controls.Add(this.lblDoB);
            this.grpPatientRegistration.Controls.Add(this.txtMedicalNumber);
            this.grpPatientRegistration.Controls.Add(this.lblMedicalNumber);
            this.grpPatientRegistration.Controls.Add(this.txtPLName);
            this.grpPatientRegistration.Controls.Add(this.lblPLName);
            this.grpPatientRegistration.Controls.Add(this.txtPFName);
            this.grpPatientRegistration.Controls.Add(this.lblPFName);
            this.grpPatientRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPatientRegistration.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientRegistration.Location = new System.Drawing.Point(0, 0);
            this.grpPatientRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatientRegistration.Name = "grpPatientRegistration";
            this.grpPatientRegistration.Padding = new System.Windows.Forms.Padding(25);
            this.grpPatientRegistration.Size = new System.Drawing.Size(610, 581);
            this.grpPatientRegistration.TabIndex = 6;
            this.grpPatientRegistration.TabStop = false;
            this.grpPatientRegistration.Text = "Register Patient";
            // 
            // layoutPatientButtons
            // 
            this.layoutPatientButtons.ColumnCount = 4;
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPatientButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPatientButtons.Controls.Add(this.btnCreatePatient, 3, 0);
            this.layoutPatientButtons.Controls.Add(this.btnDeletePatient, 2, 0);
            this.layoutPatientButtons.Controls.Add(this.btnCancelPatient, 1, 0);
            this.layoutPatientButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.layoutPatientButtons.Location = new System.Drawing.Point(25, 499);
            this.layoutPatientButtons.Margin = new System.Windows.Forms.Padding(2);
            this.layoutPatientButtons.Name = "layoutPatientButtons";
            this.layoutPatientButtons.RowCount = 1;
            this.layoutPatientButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPatientButtons.Size = new System.Drawing.Size(560, 57);
            this.layoutPatientButtons.TabIndex = 10;
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatePatient.AutoSize = true;
            this.btnCreatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnCreatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePatient.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePatient.ForeColor = System.Drawing.Color.White;
            this.btnCreatePatient.Location = new System.Drawing.Point(450, 2);
            this.btnCreatePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(108, 53);
            this.btnCreatePatient.TabIndex = 5;
            this.btnCreatePatient.Text = "Create";
            this.btnCreatePatient.UseVisualStyleBackColor = false;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePatient.AutoSize = true;
            this.btnDeletePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePatient.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.ForeColor = System.Drawing.Color.White;
            this.btnDeletePatient.Location = new System.Drawing.Point(338, 2);
            this.btnDeletePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(108, 53);
            this.btnDeletePatient.TabIndex = 7;
            this.btnDeletePatient.Text = "Delete";
            this.btnDeletePatient.UseVisualStyleBackColor = false;
            // 
            // btnCancelPatient
            // 
            this.btnCancelPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelPatient.AutoSize = true;
            this.btnCancelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancelPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPatient.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPatient.ForeColor = System.Drawing.Color.White;
            this.btnCancelPatient.Location = new System.Drawing.Point(226, 2);
            this.btnCancelPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelPatient.Name = "btnCancelPatient";
            this.btnCancelPatient.Size = new System.Drawing.Size(108, 53);
            this.btnCancelPatient.TabIndex = 4;
            this.btnCancelPatient.Text = "Cancel";
            this.btnCancelPatient.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(24, 448);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(559, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 408);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(560, 35);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPPhone
            // 
            this.txtPPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPhone.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPhone.Location = new System.Drawing.Point(24, 361);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.Size = new System.Drawing.Size(559, 31);
            this.txtPPhone.TabIndex = 5;
            // 
            // lblPPhone
            // 
            this.lblPPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPPhone.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPhone.Location = new System.Drawing.Point(24, 321);
            this.lblPPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPPhone.Name = "lblPPhone";
            this.lblPPhone.Size = new System.Drawing.Size(560, 35);
            this.lblPPhone.TabIndex = 4;
            this.lblPPhone.Text = "Phone Number";
            this.lblPPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateDoB
            // 
            this.dateDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDoB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDoB.Location = new System.Drawing.Point(24, 187);
            this.dateDoB.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.dateDoB.Name = "dateDoB";
            this.dateDoB.Size = new System.Drawing.Size(559, 31);
            this.dateDoB.TabIndex = 5;
            // 
            // lblDoB
            // 
            this.lblDoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(24, 147);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(560, 35);
            this.lblDoB.TabIndex = 4;
            this.lblDoB.Text = "First Name";
            this.lblDoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedicalNumber
            // 
            this.txtMedicalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicalNumber.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalNumber.Location = new System.Drawing.Point(24, 274);
            this.txtMedicalNumber.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtMedicalNumber.Name = "txtMedicalNumber";
            this.txtMedicalNumber.Size = new System.Drawing.Size(559, 31);
            this.txtMedicalNumber.TabIndex = 5;
            // 
            // lblMedicalNumber
            // 
            this.lblMedicalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedicalNumber.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalNumber.Location = new System.Drawing.Point(24, 234);
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
            this.txtPLName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLName.Location = new System.Drawing.Point(318, 102);
            this.txtPLName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPLName.Name = "txtPLName";
            this.txtPLName.Size = new System.Drawing.Size(267, 31);
            this.txtPLName.TabIndex = 5;
            // 
            // lblPLName
            // 
            this.lblPLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLName.Location = new System.Drawing.Point(318, 60);
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
            this.txtPFName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPFName.Location = new System.Drawing.Point(25, 102);
            this.txtPFName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtPFName.Name = "txtPFName";
            this.txtPFName.Size = new System.Drawing.Size(268, 31);
            this.txtPFName.TabIndex = 5;
            // 
            // lblPFName
            // 
            this.lblPFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPFName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFName.Location = new System.Drawing.Point(25, 60);
            this.lblPFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPFName.Name = "lblPFName";
            this.lblPFName.Size = new System.Drawing.Size(269, 35);
            this.lblPFName.TabIndex = 4;
            this.lblPFName.Text = "First Name";
            this.lblPFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.dgvUsers);
            this.pnlUserManagement.Controls.Add(this.grpAdminForm);
            this.pnlUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserManagement.Location = new System.Drawing.Point(20, 20);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1341, 581);
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
            this.dgvUsers.Size = new System.Drawing.Size(710, 576);
            this.dgvUsers.TabIndex = 4;
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // grpAdminForm
            // 
            this.grpAdminForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAdminForm.Controls.Add(this.pnlPassword);
            this.grpAdminForm.Controls.Add(this.pnlButtons);
            this.grpAdminForm.Controls.Add(this.comboRoles);
            this.grpAdminForm.Controls.Add(this.label2);
            this.grpAdminForm.Controls.Add(this.lblPassword);
            this.grpAdminForm.Controls.Add(this.txtUsrUsername);
            this.grpAdminForm.Controls.Add(this.lblUsername);
            this.grpAdminForm.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdminForm.Location = new System.Drawing.Point(2, 2);
            this.grpAdminForm.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdminForm.Name = "grpAdminForm";
            this.grpAdminForm.Padding = new System.Windows.Forms.Padding(25);
            this.grpAdminForm.Size = new System.Drawing.Size(635, 576);
            this.grpAdminForm.TabIndex = 5;
            this.grpAdminForm.TabStop = false;
            this.grpAdminForm.Text = "Create User";
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
            this.pnlPassword.Location = new System.Drawing.Point(22, 189);
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
            this.btnTogglePassword.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.Location = new System.Drawing.Point(484, 2);
            this.btnTogglePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(102, 34);
            this.btnTogglePassword.TabIndex = 8;
            this.btnTogglePassword.Text = "Show";
            this.btnTogglePassword.UseVisualStyleBackColor = false;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // txtUsrPassword
            // 
            this.txtUsrPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsrPassword.BackColor = System.Drawing.Color.White;
            this.txtUsrPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrPassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrPassword.Location = new System.Drawing.Point(5, 2);
            this.txtUsrPassword.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtUsrPassword.Name = "txtUsrPassword";
            this.txtUsrPassword.Size = new System.Drawing.Size(475, 31);
            this.txtUsrPassword.TabIndex = 7;
            this.txtUsrPassword.UseSystemPasswordChar = true;
            this.txtUsrPassword.TextChanged += new System.EventHandler(this.txtUsrPassword_TextChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.ColumnCount = 4;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlButtons.Controls.Add(this.btnUsrSubmit, 3, 0);
            this.pnlButtons.Controls.Add(this.btnGenPassword, 0, 0);
            this.pnlButtons.Controls.Add(this.btnUsrDelete, 2, 0);
            this.pnlButtons.Controls.Add(this.btnUsrCancel, 1, 0);
            this.pnlButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnlButtons.Location = new System.Drawing.Point(25, 374);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 1;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButtons.Size = new System.Drawing.Size(585, 56);
            this.pnlButtons.TabIndex = 10;
            // 
            // btnUsrSubmit
            // 
            this.btnUsrSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsrSubmit.AutoSize = true;
            this.btnUsrSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUsrSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrSubmit.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrSubmit.ForeColor = System.Drawing.Color.White;
            this.btnUsrSubmit.Location = new System.Drawing.Point(470, 2);
            this.btnUsrSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrSubmit.Name = "btnUsrSubmit";
            this.btnUsrSubmit.Size = new System.Drawing.Size(113, 52);
            this.btnUsrSubmit.TabIndex = 5;
            this.btnUsrSubmit.Text = "Create";
            this.btnUsrSubmit.UseVisualStyleBackColor = false;
            this.btnUsrSubmit.Click += new System.EventHandler(this.btnUsrSubmit_Click);
            // 
            // btnGenPassword
            // 
            this.btnGenPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenPassword.AutoSize = true;
            this.btnGenPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGenPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenPassword.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPassword.ForeColor = System.Drawing.Color.White;
            this.btnGenPassword.Location = new System.Drawing.Point(2, 2);
            this.btnGenPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenPassword.Name = "btnGenPassword";
            this.btnGenPassword.Size = new System.Drawing.Size(230, 52);
            this.btnGenPassword.TabIndex = 6;
            this.btnGenPassword.Text = "Generate Password";
            this.btnGenPassword.UseVisualStyleBackColor = false;
            this.btnGenPassword.Click += new System.EventHandler(this.btnGenPassword_Click);
            // 
            // btnUsrDelete
            // 
            this.btnUsrDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsrDelete.AutoSize = true;
            this.btnUsrDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUsrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrDelete.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrDelete.ForeColor = System.Drawing.Color.White;
            this.btnUsrDelete.Location = new System.Drawing.Point(353, 2);
            this.btnUsrDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrDelete.Name = "btnUsrDelete";
            this.btnUsrDelete.Size = new System.Drawing.Size(113, 52);
            this.btnUsrDelete.TabIndex = 7;
            this.btnUsrDelete.Text = "Delete";
            this.btnUsrDelete.UseVisualStyleBackColor = false;
            this.btnUsrDelete.Click += new System.EventHandler(this.btnUsrDelete_Click);
            // 
            // btnUsrCancel
            // 
            this.btnUsrCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsrCancel.AutoSize = true;
            this.btnUsrCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnUsrCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrCancel.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrCancel.ForeColor = System.Drawing.Color.White;
            this.btnUsrCancel.Location = new System.Drawing.Point(236, 2);
            this.btnUsrCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsrCancel.Name = "btnUsrCancel";
            this.btnUsrCancel.Size = new System.Drawing.Size(113, 52);
            this.btnUsrCancel.TabIndex = 4;
            this.btnUsrCancel.Text = "Cancel";
            this.btnUsrCancel.UseVisualStyleBackColor = false;
            this.btnUsrCancel.Click += new System.EventHandler(this.btnUsrCancel_Click);
            // 
            // comboRoles
            // 
            this.comboRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRoles.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(25, 292);
            this.comboRoles.Margin = new System.Windows.Forms.Padding(2);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(585, 31);
            this.comboRoles.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Role";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 148);
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
            this.txtUsrUsername.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrUsername.Location = new System.Drawing.Point(25, 102);
            this.txtUsrUsername.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtUsrUsername.Name = "txtUsrUsername";
            this.txtUsrUsername.Size = new System.Drawing.Size(584, 31);
            this.txtUsrUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(25, 60);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(585, 35);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.lblReportsPlaceholder);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(20, 20);
            this.pnlReports.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(1341, 581);
            this.pnlReports.TabIndex = 1;
            this.pnlReports.Visible = false;
            // 
            // lblReportsPlaceholder
            // 
            this.lblReportsPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportsPlaceholder.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblReportsPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblReportsPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportsPlaceholder.Name = "lblReportsPlaceholder";
            this.lblReportsPlaceholder.Size = new System.Drawing.Size(1341, 581);
            this.lblReportsPlaceholder.TabIndex = 0;
            this.lblReportsPlaceholder.Text = "Reports Module - Coming Soon";
            this.lblReportsPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDoctorManagement
            // 
            this.pnlDoctorManagement.Controls.Add(this.dgvDoctors);
            this.pnlDoctorManagement.Controls.Add(this.grpDoctorMgmt);
            this.pnlDoctorManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorManagement.Location = new System.Drawing.Point(20, 20);
            this.pnlDoctorManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorManagement.Name = "pnlDoctorManagement";
            this.pnlDoctorManagement.Size = new System.Drawing.Size(1341, 581);
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
            this.dgvDoctors.Size = new System.Drawing.Size(814, 581);
            this.dgvDoctors.TabIndex = 7;
            // 
            // grpDoctorMgmt
            // 
            this.grpDoctorMgmt.Controls.Add(this.comboDoctorUserId);
            this.grpDoctorMgmt.Controls.Add(this.lblDocUserId);
            this.grpDoctorMgmt.Controls.Add(this.lblNotice);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorLName);
            this.grpDoctorMgmt.Controls.Add(this.tableLayoutPanel2);
            this.grpDoctorMgmt.Controls.Add(this.comboSpecialization);
            this.grpDoctorMgmt.Controls.Add(this.lblSpecialization);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorLName);
            this.grpDoctorMgmt.Controls.Add(this.txtDoctorFName);
            this.grpDoctorMgmt.Controls.Add(this.lblDoctorFName);
            this.grpDoctorMgmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDoctorMgmt.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctorMgmt.Location = new System.Drawing.Point(0, 0);
            this.grpDoctorMgmt.Margin = new System.Windows.Forms.Padding(2);
            this.grpDoctorMgmt.Name = "grpDoctorMgmt";
            this.grpDoctorMgmt.Padding = new System.Windows.Forms.Padding(25);
            this.grpDoctorMgmt.Size = new System.Drawing.Size(539, 581);
            this.grpDoctorMgmt.TabIndex = 6;
            this.grpDoctorMgmt.TabStop = false;
            this.grpDoctorMgmt.Text = "Create Doctor";
            // 
            // comboDoctorUserId
            // 
            this.comboDoctorUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDoctorUserId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDoctorUserId.FormattingEnabled = true;
            this.comboDoctorUserId.Location = new System.Drawing.Point(24, 81);
            this.comboDoctorUserId.Margin = new System.Windows.Forms.Padding(2);
            this.comboDoctorUserId.Name = "comboDoctorUserId";
            this.comboDoctorUserId.Size = new System.Drawing.Size(489, 31);
            this.comboDoctorUserId.TabIndex = 14;
            this.comboDoctorUserId.SelectedIndexChanged += new System.EventHandler(this.comboDoctorUserId_SelectedIndexChanged);
            // 
            // lblDocUserId
            // 
            this.lblDocUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocUserId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocUserId.Location = new System.Drawing.Point(26, 44);
            this.lblDocUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocUserId.Name = "lblDocUserId";
            this.lblDocUserId.Size = new System.Drawing.Size(489, 35);
            this.lblDocUserId.TabIndex = 13;
            this.lblDocUserId.Text = "User Associated";
            this.lblDocUserId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotice.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(28, 430);
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
            this.txtDoctorLName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorLName.Location = new System.Drawing.Point(24, 261);
            this.txtDoctorLName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtDoctorLName.Name = "txtDoctorLName";
            this.txtDoctorLName.Size = new System.Drawing.Size(488, 31);
            this.txtDoctorLName.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnDoctorSubmit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDoctorDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDoctorCancel, 1, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 484);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 56);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnDoctorSubmit
            // 
            this.btnDoctorSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorSubmit.AutoSize = true;
            this.btnDoctorSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDoctorSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorSubmit.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorSubmit.ForeColor = System.Drawing.Color.White;
            this.btnDoctorSubmit.Location = new System.Drawing.Point(391, 2);
            this.btnDoctorSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorSubmit.Name = "btnDoctorSubmit";
            this.btnDoctorSubmit.Size = new System.Drawing.Size(96, 52);
            this.btnDoctorSubmit.TabIndex = 5;
            this.btnDoctorSubmit.Text = "Create";
            this.btnDoctorSubmit.UseVisualStyleBackColor = false;
            this.btnDoctorSubmit.Click += new System.EventHandler(this.btnDoctorSubmit_Click);
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorDelete.AutoSize = true;
            this.btnDoctorDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDoctorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDelete.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDelete.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDelete.Location = new System.Drawing.Point(294, 2);
            this.btnDoctorDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(93, 52);
            this.btnDoctorDelete.TabIndex = 7;
            this.btnDoctorDelete.Text = "Delete";
            this.btnDoctorDelete.UseVisualStyleBackColor = false;
            this.btnDoctorDelete.Click += new System.EventHandler(this.btnDoctorDelete_Click);
            // 
            // btnDoctorCancel
            // 
            this.btnDoctorCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorCancel.AutoSize = true;
            this.btnDoctorCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnDoctorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorCancel.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorCancel.ForeColor = System.Drawing.Color.White;
            this.btnDoctorCancel.Location = new System.Drawing.Point(197, 2);
            this.btnDoctorCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctorCancel.Name = "btnDoctorCancel";
            this.btnDoctorCancel.Size = new System.Drawing.Size(93, 52);
            this.btnDoctorCancel.TabIndex = 4;
            this.btnDoctorCancel.Text = "Cancel";
            this.btnDoctorCancel.UseVisualStyleBackColor = false;
            this.btnDoctorCancel.Click += new System.EventHandler(this.btnDoctorCancel_Click);
            // 
            // comboSpecialization
            // 
            this.comboSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSpecialization.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSpecialization.FormattingEnabled = true;
            this.comboSpecialization.Location = new System.Drawing.Point(24, 354);
            this.comboSpecialization.Margin = new System.Windows.Forms.Padding(2);
            this.comboSpecialization.Name = "comboSpecialization";
            this.comboSpecialization.Size = new System.Drawing.Size(489, 31);
            this.comboSpecialization.TabIndex = 9;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialization.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(25, 316);
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
            this.lblDoctorLName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorLName.Location = new System.Drawing.Point(26, 224);
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
            this.txtDoctorFName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorFName.Location = new System.Drawing.Point(24, 170);
            this.txtDoctorFName.Margin = new System.Windows.Forms.Padding(5, 2, 2, 5);
            this.txtDoctorFName.Name = "txtDoctorFName";
            this.txtDoctorFName.Size = new System.Drawing.Size(488, 31);
            this.txtDoctorFName.TabIndex = 5;
            // 
            // lblDoctorFName
            // 
            this.lblDoctorFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorFName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorFName.Location = new System.Drawing.Point(26, 132);
            this.lblDoctorFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorFName.Name = "lblDoctorFName";
            this.lblDoctorFName.Size = new System.Drawing.Size(489, 35);
            this.lblDoctorFName.TabIndex = 4;
            this.lblDoctorFName.Text = "First Name";
            this.lblDoctorFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDoctorScheduling
            // 
            this.pnlDoctorScheduling.Controls.Add(this.grpDoctorScheduling);
            this.pnlDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorScheduling.Location = new System.Drawing.Point(20, 20);
            this.pnlDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoctorScheduling.Name = "pnlDoctorScheduling";
            this.pnlDoctorScheduling.Size = new System.Drawing.Size(1341, 581);
            this.pnlDoctorScheduling.TabIndex = 4;
            this.pnlDoctorScheduling.Visible = false;
            // 
            // grpDoctorScheduling
            // 
            this.grpDoctorScheduling.Controls.Add(this.layoutSchedulingContent);
            this.grpDoctorScheduling.Controls.Add(this.layoutScheduleActions);
            this.grpDoctorScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDoctorScheduling.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoctorScheduling.Location = new System.Drawing.Point(0, 0);
            this.grpDoctorScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.grpDoctorScheduling.Name = "grpDoctorScheduling";
            this.grpDoctorScheduling.Padding = new System.Windows.Forms.Padding(25);
            this.grpDoctorScheduling.Size = new System.Drawing.Size(1341, 581);
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
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.959054F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
            this.layoutSchedulingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.57728F));
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
            this.layoutSchedulingContent.Location = new System.Drawing.Point(25, 142);
            this.layoutSchedulingContent.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSchedulingContent.Name = "layoutSchedulingContent";
            this.layoutSchedulingContent.RowCount = 2;
            this.layoutSchedulingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutSchedulingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSchedulingContent.Size = new System.Drawing.Size(1291, 412);
            this.layoutSchedulingContent.TabIndex = 10;
            // 
            // layoutHours
            // 
            this.layoutHours.ColumnCount = 1;
            this.layoutHours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutHours.Controls.Add(this.lblHour12, 0, 11);
            this.layoutHours.Controls.Add(this.lblHour11, 0, 10);
            this.layoutHours.Controls.Add(this.lblHour10, 0, 9);
            this.layoutHours.Controls.Add(this.lblHour9, 0, 8);
            this.layoutHours.Controls.Add(this.lblHour8, 0, 7);
            this.layoutHours.Controls.Add(this.lblHour7, 0, 6);
            this.layoutHours.Controls.Add(this.lblHour6, 0, 5);
            this.layoutHours.Controls.Add(this.lblHour5, 0, 4);
            this.layoutHours.Controls.Add(this.lblHour4, 0, 3);
            this.layoutHours.Controls.Add(this.lblHour3, 0, 2);
            this.layoutHours.Controls.Add(this.lblHour2, 0, 1);
            this.layoutHours.Controls.Add(this.lblHour1, 0, 0);
            this.layoutHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutHours.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutHours.Location = new System.Drawing.Point(2, 47);
            this.layoutHours.Margin = new System.Windows.Forms.Padding(2);
            this.layoutHours.Name = "layoutHours";
            this.layoutHours.RowCount = 12;
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.layoutHours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutHours.Size = new System.Drawing.Size(60, 363);
            this.layoutHours.TabIndex = 1;
            // 
            // lblHour12
            // 
            this.lblHour12.AutoSize = true;
            this.lblHour12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour12.Location = new System.Drawing.Point(2, 330);
            this.lblHour12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour12.Name = "lblHour12";
            this.lblHour12.Size = new System.Drawing.Size(56, 33);
            this.lblHour12.TabIndex = 11;
            this.lblHour12.Text = "22:00";
            this.lblHour12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour11
            // 
            this.lblHour11.AutoSize = true;
            this.lblHour11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour11.Location = new System.Drawing.Point(2, 300);
            this.lblHour11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour11.Name = "lblHour11";
            this.lblHour11.Size = new System.Drawing.Size(56, 30);
            this.lblHour11.TabIndex = 10;
            this.lblHour11.Text = "20:00";
            this.lblHour11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour10
            // 
            this.lblHour10.AutoSize = true;
            this.lblHour10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour10.Location = new System.Drawing.Point(2, 270);
            this.lblHour10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour10.Name = "lblHour10";
            this.lblHour10.Size = new System.Drawing.Size(56, 30);
            this.lblHour10.TabIndex = 9;
            this.lblHour10.Text = "18:00";
            this.lblHour10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour9
            // 
            this.lblHour9.AutoSize = true;
            this.lblHour9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour9.Location = new System.Drawing.Point(2, 240);
            this.lblHour9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour9.Name = "lblHour9";
            this.lblHour9.Size = new System.Drawing.Size(56, 30);
            this.lblHour9.TabIndex = 8;
            this.lblHour9.Text = "16:00";
            this.lblHour9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour8
            // 
            this.lblHour8.AutoSize = true;
            this.lblHour8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour8.Location = new System.Drawing.Point(2, 210);
            this.lblHour8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour8.Name = "lblHour8";
            this.lblHour8.Size = new System.Drawing.Size(56, 30);
            this.lblHour8.TabIndex = 7;
            this.lblHour8.Text = "14:00";
            this.lblHour8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour7
            // 
            this.lblHour7.AutoSize = true;
            this.lblHour7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour7.Location = new System.Drawing.Point(2, 180);
            this.lblHour7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour7.Name = "lblHour7";
            this.lblHour7.Size = new System.Drawing.Size(56, 30);
            this.lblHour7.TabIndex = 6;
            this.lblHour7.Text = "12:00";
            this.lblHour7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour6
            // 
            this.lblHour6.AutoSize = true;
            this.lblHour6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour6.Location = new System.Drawing.Point(2, 150);
            this.lblHour6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour6.Name = "lblHour6";
            this.lblHour6.Size = new System.Drawing.Size(56, 30);
            this.lblHour6.TabIndex = 5;
            this.lblHour6.Text = "10:00";
            this.lblHour6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour5
            // 
            this.lblHour5.AutoSize = true;
            this.lblHour5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour5.Location = new System.Drawing.Point(2, 120);
            this.lblHour5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour5.Name = "lblHour5";
            this.lblHour5.Size = new System.Drawing.Size(56, 30);
            this.lblHour5.TabIndex = 4;
            this.lblHour5.Text = "08:00";
            this.lblHour5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour4
            // 
            this.lblHour4.AutoSize = true;
            this.lblHour4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour4.Location = new System.Drawing.Point(2, 90);
            this.lblHour4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour4.Name = "lblHour4";
            this.lblHour4.Size = new System.Drawing.Size(56, 30);
            this.lblHour4.TabIndex = 3;
            this.lblHour4.Text = "06:00";
            this.lblHour4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour3
            // 
            this.lblHour3.AutoSize = true;
            this.lblHour3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour3.Location = new System.Drawing.Point(2, 60);
            this.lblHour3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour3.Name = "lblHour3";
            this.lblHour3.Size = new System.Drawing.Size(56, 30);
            this.lblHour3.TabIndex = 2;
            this.lblHour3.Text = "04:00";
            this.lblHour3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour2
            // 
            this.lblHour2.AutoSize = true;
            this.lblHour2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour2.Location = new System.Drawing.Point(2, 30);
            this.lblHour2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour2.Name = "lblHour2";
            this.lblHour2.Size = new System.Drawing.Size(56, 30);
            this.lblHour2.TabIndex = 1;
            this.lblHour2.Text = "02:00";
            this.lblHour2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHour1
            // 
            this.lblHour1.AutoSize = true;
            this.lblHour1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour1.Location = new System.Drawing.Point(2, 0);
            this.lblHour1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHour1.Name = "lblHour1";
            this.lblHour1.Size = new System.Drawing.Size(56, 30);
            this.lblHour1.TabIndex = 0;
            this.lblHour1.Text = "00:00";
            this.lblHour1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay1.Location = new System.Drawing.Point(66, 0);
            this.lblDay1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(171, 45);
            this.lblDay1.TabIndex = 2;
            this.lblDay1.Text = "Sunday";
            this.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay2.Location = new System.Drawing.Point(241, 0);
            this.lblDay2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(171, 45);
            this.lblDay2.TabIndex = 15;
            this.lblDay2.Text = "Monday";
            this.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay3.Location = new System.Drawing.Point(416, 0);
            this.lblDay3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(171, 45);
            this.lblDay3.TabIndex = 16;
            this.lblDay3.Text = "Tuesday";
            this.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay4.Location = new System.Drawing.Point(591, 0);
            this.lblDay4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(171, 45);
            this.lblDay4.TabIndex = 17;
            this.lblDay4.Text = "Wednesday";
            this.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay5.Location = new System.Drawing.Point(766, 0);
            this.lblDay5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(171, 45);
            this.lblDay5.TabIndex = 16;
            this.lblDay5.Text = "Thursday";
            this.lblDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay6.Location = new System.Drawing.Point(941, 0);
            this.lblDay6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(171, 45);
            this.lblDay6.TabIndex = 16;
            this.lblDay6.Text = "Friday";
            this.lblDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay7.Location = new System.Drawing.Point(1116, 0);
            this.lblDay7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(173, 45);
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
            this.lbSunday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunday.ItemHeight = 25;
            this.lbSunday.Location = new System.Drawing.Point(66, 47);
            this.lbSunday.Margin = new System.Windows.Forms.Padding(2);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSunday.Size = new System.Drawing.Size(171, 350);
            this.lbSunday.TabIndex = 18;
            // 
            // lbMonday
            // 
            this.lbMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMonday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMonday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonday.ItemHeight = 25;
            this.lbMonday.Location = new System.Drawing.Point(241, 47);
            this.lbMonday.Margin = new System.Windows.Forms.Padding(2);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMonday.Size = new System.Drawing.Size(171, 350);
            this.lbMonday.TabIndex = 19;
            // 
            // lbTuesday
            // 
            this.lbTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTuesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTuesday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuesday.ItemHeight = 25;
            this.lbTuesday.Location = new System.Drawing.Point(416, 47);
            this.lbTuesday.Margin = new System.Windows.Forms.Padding(2);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTuesday.Size = new System.Drawing.Size(171, 350);
            this.lbTuesday.TabIndex = 19;
            // 
            // lbWednesday
            // 
            this.lbWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWednesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbWednesday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWednesday.ItemHeight = 25;
            this.lbWednesday.Location = new System.Drawing.Point(591, 47);
            this.lbWednesday.Margin = new System.Windows.Forms.Padding(2);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbWednesday.Size = new System.Drawing.Size(171, 350);
            this.lbWednesday.TabIndex = 19;
            // 
            // lbThursday
            // 
            this.lbThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbThursday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbThursday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThursday.ItemHeight = 25;
            this.lbThursday.Location = new System.Drawing.Point(766, 47);
            this.lbThursday.Margin = new System.Windows.Forms.Padding(2);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbThursday.Size = new System.Drawing.Size(171, 350);
            this.lbThursday.TabIndex = 19;
            // 
            // lbFriday
            // 
            this.lbFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFriday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFriday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriday.ItemHeight = 25;
            this.lbFriday.Location = new System.Drawing.Point(941, 47);
            this.lbFriday.Margin = new System.Windows.Forms.Padding(2);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFriday.Size = new System.Drawing.Size(171, 350);
            this.lbFriday.TabIndex = 20;
            // 
            // lbSaturday
            // 
            this.lbSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSaturday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSaturday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturday.ItemHeight = 25;
            this.lbSaturday.Location = new System.Drawing.Point(1116, 47);
            this.lbSaturday.Margin = new System.Windows.Forms.Padding(2);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSaturday.Size = new System.Drawing.Size(173, 350);
            this.lbSaturday.TabIndex = 19;
            // 
            // layoutScheduleActions
            // 
            this.layoutScheduleActions.ColumnCount = 3;
            this.layoutScheduleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutScheduleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutScheduleActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutScheduleActions.Controls.Add(this.pnlScheduleActions, 2, 0);
            this.layoutScheduleActions.Controls.Add(this.pnlUserPicker, 0, 0);
            this.layoutScheduleActions.Controls.Add(this.pnlEffectiveDate, 1, 0);
            this.layoutScheduleActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutScheduleActions.Location = new System.Drawing.Point(25, 49);
            this.layoutScheduleActions.Margin = new System.Windows.Forms.Padding(2);
            this.layoutScheduleActions.Name = "layoutScheduleActions";
            this.layoutScheduleActions.RowCount = 1;
            this.layoutScheduleActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutScheduleActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.layoutScheduleActions.Size = new System.Drawing.Size(1291, 81);
            this.layoutScheduleActions.TabIndex = 17;
            // 
            // pnlScheduleActions
            // 
            this.pnlScheduleActions.Controls.Add(this.btnScheduleSave);
            this.pnlScheduleActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScheduleActions.Location = new System.Drawing.Point(862, 2);
            this.pnlScheduleActions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScheduleActions.Name = "pnlScheduleActions";
            this.pnlScheduleActions.Padding = new System.Windows.Forms.Padding(20);
            this.pnlScheduleActions.Size = new System.Drawing.Size(427, 77);
            this.pnlScheduleActions.TabIndex = 4;
            // 
            // btnScheduleSave
            // 
            this.btnScheduleSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnScheduleSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnScheduleSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleSave.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleSave.ForeColor = System.Drawing.Color.White;
            this.btnScheduleSave.Location = new System.Drawing.Point(295, 20);
            this.btnScheduleSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnScheduleSave.Name = "btnScheduleSave";
            this.btnScheduleSave.Size = new System.Drawing.Size(112, 37);
            this.btnScheduleSave.TabIndex = 6;
            this.btnScheduleSave.Text = "Save";
            this.btnScheduleSave.UseVisualStyleBackColor = false;
            // 
            // pnlUserPicker
            // 
            this.pnlUserPicker.Controls.Add(this.comboDoctorSelect);
            this.pnlUserPicker.Controls.Add(this.lblDoctorSelect);
            this.pnlUserPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserPicker.Location = new System.Drawing.Point(2, 2);
            this.pnlUserPicker.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserPicker.Name = "pnlUserPicker";
            this.pnlUserPicker.Size = new System.Drawing.Size(426, 77);
            this.pnlUserPicker.TabIndex = 0;
            // 
            // comboDoctorSelect
            // 
            this.comboDoctorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDoctorSelect.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDoctorSelect.FormattingEnabled = true;
            this.comboDoctorSelect.Location = new System.Drawing.Point(15, 34);
            this.comboDoctorSelect.Margin = new System.Windows.Forms.Padding(2);
            this.comboDoctorSelect.Name = "comboDoctorSelect";
            this.comboDoctorSelect.Size = new System.Drawing.Size(350, 31);
            this.comboDoctorSelect.TabIndex = 14;
            // 
            // lblDoctorSelect
            // 
            this.lblDoctorSelect.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSelect.Location = new System.Drawing.Point(11, 0);
            this.lblDoctorSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorSelect.Name = "lblDoctorSelect";
            this.lblDoctorSelect.Size = new System.Drawing.Size(349, 32);
            this.lblDoctorSelect.TabIndex = 13;
            this.lblDoctorSelect.Text = "Doctor";
            this.lblDoctorSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEffectiveDate
            // 
            this.pnlEffectiveDate.Controls.Add(this.dtEffectiveDate);
            this.pnlEffectiveDate.Controls.Add(this.lblEffectiveDate);
            this.pnlEffectiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEffectiveDate.Location = new System.Drawing.Point(432, 2);
            this.pnlEffectiveDate.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEffectiveDate.Name = "pnlEffectiveDate";
            this.pnlEffectiveDate.Size = new System.Drawing.Size(426, 77);
            this.pnlEffectiveDate.TabIndex = 1;
            // 
            // dtEffectiveDate
            // 
            this.dtEffectiveDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEffectiveDate.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEffectiveDate.Location = new System.Drawing.Point(16, 34);
            this.dtEffectiveDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtEffectiveDate.Name = "dtEffectiveDate";
            this.dtEffectiveDate.Size = new System.Drawing.Size(349, 28);
            this.dtEffectiveDate.TabIndex = 16;
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveDate.Location = new System.Drawing.Point(15, 0);
            this.lblEffectiveDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(349, 32);
            this.lblEffectiveDate.TabIndex = 15;
            this.lblEffectiveDate.Text = "Effective Date";
            this.lblEffectiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.grpNotifications);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1679, 125);
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
            this.grpNotifications.Location = new System.Drawing.Point(857, 0);
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
            this.btnNotifications.Location = new System.Drawing.Point(737, 40);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(55, 55);
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
            this.lblToast.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToast.ForeColor = System.Drawing.Color.White;
            this.lblToast.Location = new System.Drawing.Point(30, 40);
            this.lblToast.Name = "lblToast";
            this.lblToast.Padding = new System.Windows.Forms.Padding(5);
            this.lblToast.Size = new System.Drawing.Size(701, 55);
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
            this.pnlNotifications.Location = new System.Drawing.Point(1679, 125);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(0, 621);
            this.pnlNotifications.TabIndex = 1;
            this.pnlNotifications.Visible = false;
            // 
            // lbNotifications
            // 
            this.lbNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNotifications.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.ItemHeight = 17;
            this.lbNotifications.Location = new System.Drawing.Point(0, 0);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.Size = new System.Drawing.Size(0, 595);
            this.lbNotifications.TabIndex = 0;
            // 
            // timerToast
            // 
            this.timerToast.Interval = 5000;
            this.timerToast.Tick += new System.EventHandler(this.timerToast_Tick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1679, 746);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1697, 793);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResizeEnd += new System.EventHandler(this.AdminDashboard_ResizeEnd);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlPatientRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPatients)).EndInit();
            this.grpPatientRegistration.ResumeLayout(false);
            this.grpPatientRegistration.PerformLayout();
            this.layoutPatientButtons.ResumeLayout(false);
            this.layoutPatientButtons.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpAdminForm.ResumeLayout(false);
            this.grpAdminForm.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlDoctorManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.grpDoctorMgmt.ResumeLayout(false);
            this.grpDoctorMgmt.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlDoctorScheduling.ResumeLayout(false);
            this.grpDoctorScheduling.ResumeLayout(false);
            this.layoutSchedulingContent.ResumeLayout(false);
            this.layoutSchedulingContent.PerformLayout();
            this.layoutHours.ResumeLayout(false);
            this.layoutHours.PerformLayout();
            this.layoutScheduleActions.ResumeLayout(false);
            this.pnlScheduleActions.ResumeLayout(false);
            this.pnlUserPicker.ResumeLayout(false);
            this.pnlEffectiveDate.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlDoctorManagement;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.GroupBox grpDoctorMgmt;
        private System.Windows.Forms.ComboBox comboDoctorUserId;
        private System.Windows.Forms.Label lblDocUserId;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TextBox txtDoctorLName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDoctorSubmit;
        private System.Windows.Forms.Button btnDoctorDelete;
        private System.Windows.Forms.Button btnDoctorCancel;
        private System.Windows.Forms.ComboBox comboSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblDoctorLName;
        private System.Windows.Forms.TextBox txtDoctorFName;
        private System.Windows.Forms.Label lblDoctorFName;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpAdminForm;
        private System.Windows.Forms.TableLayoutPanel pnlPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.TextBox txtUsrPassword;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnUsrSubmit;
        private System.Windows.Forms.Button btnGenPassword;
        private System.Windows.Forms.Button btnUsrDelete;
        private System.Windows.Forms.Button btnUsrCancel;
        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsrUsername;
        private System.Windows.Forms.Label lblUsername;
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
        private System.Windows.Forms.TableLayoutPanel layoutScheduleActions;
        private System.Windows.Forms.Panel pnlScheduleActions;
        private System.Windows.Forms.Button btnScheduleSave;
        private System.Windows.Forms.Panel pnlUserPicker;
        private System.Windows.Forms.ComboBox comboDoctorSelect;
        private System.Windows.Forms.Label lblDoctorSelect;
        private System.Windows.Forms.Panel pnlEffectiveDate;
        private System.Windows.Forms.DateTimePicker dtEffectiveDate;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReportsPlaceholder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox grpNotifications;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.ListBox lbNotifications;
        private System.Windows.Forms.Label lblToast;
        private System.Windows.Forms.Timer timerToast;
        private System.Windows.Forms.DataGridView dgvRegPatients;
        private System.Windows.Forms.GroupBox grpPatientRegistration;
        private System.Windows.Forms.TableLayoutPanel layoutPatientButtons;
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnCancelPatient;
        private System.Windows.Forms.TextBox txtPFName;
        private System.Windows.Forms.Label lblPFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPPhone;
        private System.Windows.Forms.Label lblPPhone;
        private System.Windows.Forms.DateTimePicker dateDoB;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtMedicalNumber;
        private System.Windows.Forms.Label lblMedicalNumber;
        private System.Windows.Forms.TextBox txtPLName;
        private System.Windows.Forms.Label lblPLName;
    }
}
