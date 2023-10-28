using System;
using AgencyPro.Notifications.Interfaces;

namespace AgencyPro.Notifications.Models
{
    public class NotificationOutput : NotificationInput, INotification
    {
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public int Flags { get; set; }
    }
}