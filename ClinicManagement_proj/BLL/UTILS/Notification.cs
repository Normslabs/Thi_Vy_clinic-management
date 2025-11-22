using System;

namespace ClinicManagement_proj.BLL.Utils
{
    public enum NotificationType
    {
        Info,
        Warning,
        Error
    }

    public class Notification
    {
        public string Message { get; set; }
        public NotificationType Type { get; set; }
        public DateTime Timestamp { get; set; }

        public Notification(string message, NotificationType type)
        {
            Message = message;
            Type = type;
            Timestamp = DateTime.Now;
        }
    }
}