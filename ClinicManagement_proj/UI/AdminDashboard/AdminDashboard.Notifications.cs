using ClinicManagement_proj.BLL.Utils;
using System;
using System.Drawing;
using System.Linq;

namespace ClinicManagement_proj.UI
{
    public partial class AdminDashboard
    {
        /// <summary>
        /// Handle new notification added event
        /// </summary>
        private void OnNotificationAdded(Notification notif)
        {
            ShowToast(notif);

            // Update list if notifications panel is visible
            if (pnlNotifications.Visible)
            {
                RefreshNotificationsList();
            }
        }

        /// <summary>
        /// Show a toast notification
        /// </summary>
        private void ShowToast(Notification notif)
        {
            timerToast.Stop();
            lblToast.Text = notif.Message;
            lblToast.BackColor = GetNotificationColor(notif.Type);
            lblToast.Visible = true;
            timerToast.Start();
        }

        /// <summary>
        /// Get color based on notification type
        /// </summary>
        private Color GetNotificationColor(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Error:
                    return Color.Red;
                case NotificationType.Warning:
                    return Color.Orange;
                default:
                    return Color.Green;
            }
        }

        /// <summary>
        /// Timer tick to hide toast notification
        /// </summary>
        private void timerToast_Tick(object sender, EventArgs e)
        {
            lblToast.Visible = false;
            timerToast.Stop();
        }

        /// <summary>
        /// Refresh the notifications list
        /// </summary>
        private void RefreshNotificationsList()
        {
            lbNotifications.Items.Clear();
            foreach (var n in NotificationManager.GetActiveNotifications().OrderByDescending(n => n.Timestamp))
            {
                lbNotifications.Items.Add($"{n.Timestamp:HH:mm:ss} - {n.Type}: {n.Message}");
            }
        }

        /// <summary>
        /// Toggle notifications panel visibility
        /// </summary>
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