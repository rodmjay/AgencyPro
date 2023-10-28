using System;
using AgencyPro.Candidates.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class CandidateNotification : Notification<CandidateNotification>
    {
        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public override void Configure(EntityTypeBuilder<CandidateNotification> builder)
        {
            builder.HasOne(x => x.Candidate)
                .WithMany(x => x.CandidateNotifications)
                .HasForeignKey(x => x.CandidateId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}