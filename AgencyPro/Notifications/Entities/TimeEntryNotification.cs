using System;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class TimeEntryNotification : Notification
    {
        public Guid TimeEntryId { get; set; }
        public TimeEntry TimeEntry { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}