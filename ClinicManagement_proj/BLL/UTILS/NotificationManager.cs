using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.Utils
{
    public static class NotificationManager
    {
        private static List<Notification> notifications = new List<Notification>();

        public static event Action<Notification> NotificationAdded;

        public static void AddNotification(string message, NotificationType type)
        {
            var notif = new Notification(message, type);
            lock (notifications)
            {
                notifications.Add(notif);
                // Clean up old ones
                for (int i = notifications.Count - 1; i >= 0; i--)
                {
                    if (DateTime.Now.Subtract(notifications[i].Timestamp).TotalMinutes > 30)
                    {
                        notifications.RemoveAt(i);
                    }
                }
            }
            NotificationAdded?.Invoke(notif);
        }

        public static List<Notification> GetActiveNotifications()
        {
            lock (notifications)
            {
                List<Notification> active = new List<Notification>();
                foreach (var n in notifications)
                {
                    if (DateTime.Now.Subtract(n.Timestamp).TotalMinutes <= 30)
                    {
                        active.Add(n);
                    }
                }
                return active;
            }
        }
    }
}