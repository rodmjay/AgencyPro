using System;
using AgencyPro.Common.Enums;
using AgencyPro.Users.Enums;

namespace AgencyPro.Notifications.Models
{
    public class NotificationInput
    {
        public Guid? OrganizationId { get; set; }
        public string Message { get; set; }
        public Guid UserId { get; set; }
        public Guid? SubjectId { get; set; }
        public string ExtraData { get; set; }
        public NotificationSubjectType SubjectType { get; set; }
        public IdeaFortuneRole? Role { get; set; }
    }
}