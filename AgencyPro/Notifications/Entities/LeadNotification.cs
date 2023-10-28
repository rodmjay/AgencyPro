using System;
using AgencyPro.Leads.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class LeadNotification : Notification
    {
        public Guid LeadId { get; set; }
        public Lead Lead { get; set; }

        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}