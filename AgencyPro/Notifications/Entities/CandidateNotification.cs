using System;
using AgencyPro.Candidates.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class CandidateNotification : Notification
    {
        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}