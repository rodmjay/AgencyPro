using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Notifications.Models
{
    public class NotificationResult : Result
    {
        public Guid NotificationId { get; set; }
    }
}