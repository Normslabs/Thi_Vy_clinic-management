using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClinicManagement_proj.BLL.Utils;

namespace ClinicManagement_proj.UI
{
    public partial class AdminDashboard : Form
    {
        private static bool isEditMode = false;
        private static bool isPasswordChanged = false;

        private readonly Color SIDEBAR_BG = Color.FromArgb(44, 62, 80);
        private readonly Color SIDEBAR_ACTIVE = Color.FromArgb(52, 73, 94);
        private readonly Color HEADER_BG = Color.FromArgb(41, 128, 185);
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return resized;
        }

        private void AdjustButtonStyles(Button button)
        {
            button.Image = ResizeImage(button.Image, 30, 30);
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public AdminDashboard()
        {
            InitializeComponent();

            // Adjust notification button
            btnNotifications.Image = ResizeImage(btnNotifications.Image, 25, 25);
            btnNotifications.ImageAlign = ContentAlignment.MiddleCenter;

            // Adjust button image sizes
            AdjustButtonStyles(btnDoctorManagement);
            AdjustButtonStyles(btnDoctorScheduling);
            AdjustButtonStyles(btnPatientRegistration);
            AdjustButtonStyles(btnReports);
            AdjustButtonStyles(btnUserManagement);

            SetupSchedulingListViews();

            ShowPanel(pnlUserManagement);
            SetActiveButton(btnUserManagement);

            NotificationManager.NotificationAdded += OnNotificationAdded;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ResetUsrForm();
            ResetDoctorForm();
        }

        // Navigation Methods
        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlReports);
            SetActiveButton(btnReports);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUserManagement);
            SetActiveButton(btnUserManagement);
        }

        private void btnDoctorManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDoctorManagement);
            SetActiveButton(btnDoctorManagement);
        }

        private void btnDoctorScheduling_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDoctorScheduling);
            RefreshSchedulingListViews();
            SetActiveButton(btnDoctorScheduling);
        }

        private void btnPatientRegistration_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlPatientRegistration);
            SetActiveButton(btnPatientRegistration);
        }

        // Helper method to show selected panel and hide others
        private void ShowPanel(Panel panelToShow)
        {
            pnlReports.Visible = false;
            pnlUserManagement.Visible = false;
            pnlDoctorManagement.Visible = false;
            pnlDoctorScheduling.Visible = false;
            pnlPatientRegistration.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        // Helper method to highlight active button
        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons to default color
            btnReports.BackColor = SIDEBAR_BG;
            btnUserManagement.BackColor = SIDEBAR_BG;
            btnDoctorManagement.BackColor = SIDEBAR_BG;
            btnDoctorScheduling.BackColor = SIDEBAR_BG;
            btnPatientRegistration.BackColor = SIDEBAR_BG;

            // Highlight the active button
            activeButton.BackColor = SIDEBAR_ACTIVE;
        }

        private void AdminDashboard_ResizeEnd(object sender, EventArgs e)
        {
            if (pnlDoctorScheduling.Visible)
            {
                RefreshSchedulingListViews();
            }
        }

        private void OnNotificationAdded(Notification notif)
        {
            // Show toast
            timerToast.Stop();
            lblToast.Text = notif.Message;
            lblToast.BackColor = notif.Type == NotificationType.Error ? Color.Red : notif.Type == NotificationType.Warning ? Color.Orange : Color.Green;
            lblToast.Visible = true;
            timerToast.Start();
            // Update list if visible
            if (pnlNotifications.Visible)
            {
                RefreshNotificationsList();
            }
        }

        private void timerToast_Tick(object sender, EventArgs e)
        {
            lblToast.Visible = false;
            timerToast.Stop();
        }

        private void RefreshNotificationsList()
        {
            lbNotifications.Items.Clear();
            foreach (var n in NotificationManager.GetActiveNotifications().OrderByDescending(n => n.Timestamp))
            {
                lbNotifications.Items.Add($"{n.Timestamp:HH:mm:ss} - {n.Type}: {n.Message}");
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            pnlNotifications.Visible = !pnlNotifications.Visible;
            if (pnlNotifications.Visible)
            {
                RefreshNotificationsList();
            }
        }
    }
}
