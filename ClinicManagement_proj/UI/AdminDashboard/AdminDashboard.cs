using ClinicManagement_proj.BLL.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    public partial class AdminDashboard : Form
    {
        private bool isEditMode = false;
        private bool isPasswordChanged = false;

        private readonly Color SIDEBAR_BG = Color.FromArgb(44, 62, 80);
        private readonly Color SIDEBAR_ACTIVE = Color.FromArgb(52, 73, 94);
        private readonly Color HEADER_BG = Color.FromArgb(41, 128, 185);

        private NavigationManager navigationManager;
        private UserManagementController userManagementController;
        private DoctorManagementController doctorManagementController;
        private SchedulingController schedulingController;
        private PatientRegistrationController patientRegistrationController;
        private ReportsController reportsController;

        public AdminDashboard()
        {
            InitializeComponent();
            InitializeManagers();
            SetupNavigation();
            SetupNotifications();
            StyleButtons();
            SetupSchedulingListViews();
        }

        /// <summary>
        /// Initialize all managers and controllers
        /// </summary>
        private void InitializeManagers()
        {
            navigationManager = new NavigationManager(SIDEBAR_BG, SIDEBAR_ACTIVE);

            // Initialize panel controllers
            userManagementController = new UserManagementController(pnlUserManagement, this);
            doctorManagementController = new DoctorManagementController(pnlDoctorManagement, this);
            schedulingController = new SchedulingController(pnlDoctorScheduling, this);
            patientRegistrationController = new PatientRegistrationController(pnlPatientRegistration, this);
            reportsController = new ReportsController(pnlReports, this);
        }

        /// <summary>
        /// Setup navigation between panels
        /// </summary>
        private void SetupNavigation()
        {
            navigationManager.RegisterPanel(btnUserManagement, userManagementController);
            navigationManager.RegisterPanel(btnDoctorManagement, doctorManagementController);
            navigationManager.RegisterPanel(btnDoctorScheduling, schedulingController);
            navigationManager.RegisterPanel(btnPatientRegistration, patientRegistrationController);
            navigationManager.RegisterPanel(btnReports, reportsController);

            navigationManager.InitializeAll();
            navigationManager.NavigateTo(btnUserManagement);
        }

        /// <summary>
        /// Setup notification system
        /// </summary>
        private void SetupNotifications()
        {
            NotificationManager.NotificationAdded += OnNotificationAdded;
        }

        /// <summary>
        /// Apply styling to navigation buttons
        /// </summary>
        private void StyleButtons()
        {
            ImageHelper.StyleButton(btnDoctorManagement, 30, 30);
            ImageHelper.StyleButton(btnDoctorScheduling, 30, 30);
            ImageHelper.StyleButton(btnPatientRegistration, 30, 30);
            ImageHelper.StyleButton(btnReports, 30, 30);
            ImageHelper.StyleButton(btnUserManagement, 30, 30);

            btnNotifications.Image = ImageHelper.ResizeImage(btnNotifications.Image, 25, 25);
            btnNotifications.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ResetUsrForm();
            ResetDoctorForm();
        }

        // Navigation Methods - Now simplified using NavigationManager
        private void btnReports_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateTo(btnReports);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateTo(btnUserManagement);
        }

        private void btnDoctorManagement_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateTo(btnDoctorManagement);
        }

        private void btnDoctorScheduling_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateTo(btnDoctorScheduling);
            RefreshSchedulingListViews();
        }

        private void btnPatientRegistration_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateTo(btnPatientRegistration);
        }

        private void AdminDashboard_ResizeEnd(object sender, EventArgs e)
        {
            if (pnlDoctorScheduling.Visible)
            {
                RefreshSchedulingListViews();
            }
        }

        /// <summary>
        /// Cleanup resources on form closing
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            navigationManager?.CleanupAll();
            ImageHelper.ClearCache();
            NotificationManager.NotificationAdded -= OnNotificationAdded;
            base.OnFormClosing(e);
        }
    }
}
