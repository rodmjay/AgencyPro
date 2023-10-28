using System;
using AgencyPro.Leads.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class LeadNotification : Notification<LeadNotification>
    {
        public Guid LeadId { get; set; }
        public Lead Lead { get; set; }

        public override void Configure(EntityTypeBuilder<LeadNotification> builder)
        {
            builder.HasOne(x => x.Lead)
                .WithMany(x => x.LeadNotifications)
                .HasForeignKey(x => x.LeadId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}