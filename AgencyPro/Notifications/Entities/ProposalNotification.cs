using System;
using AgencyPro.Proposals.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class ProposalNotification : Notification<ProposalNotification>
    {
        public Guid ProposalId { get; set; }
        public FixedPriceProposal Proposal { get; set; }
        public override void Configure(EntityTypeBuilder<ProposalNotification> builder)
        {
            builder.HasOne(x => x.Proposal)
                .WithMany(x => x.Notifications)
                .HasForeignKey(x => x.ProposalId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}