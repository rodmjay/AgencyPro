using System;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class TimeEntryNotification : Notification<TimeEntryNotification>
    {
        public Guid TimeEntryId { get; set; }
        public TimeEntry TimeEntry { get; set; }
        public override void Configure(EntityTypeBuilder<TimeEntryNotification> builder)
        {
            
        }
    }
}