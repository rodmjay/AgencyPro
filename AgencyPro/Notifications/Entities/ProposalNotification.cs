using System;
using AgencyPro.Proposals.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class ProposalNotification : Notification
    {
        public Guid ProposalId { get; set; }
        public FixedPriceProposal Proposal { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}