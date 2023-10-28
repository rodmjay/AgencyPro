using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Notifications.Enums;
using AgencyPro.Notifications.Interfaces;

namespace AgencyPro.Notifications.Entities
{
    public abstract class Notification<T> : BaseEntity<T>, INotification where T : class
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public NotificationType Type { get; set; }
        public Guid UserId { get; set; }
        public bool RequiresAcknowledgement { get;set; }
        public bool? Acknowledged { get; set; }
    }
}