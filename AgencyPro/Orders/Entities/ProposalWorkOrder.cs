using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Proposals.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Orders.Entities
{
    public class ProposalWorkOrder : BaseEntity<ProposalWorkOrder>
    {
        public Guid WorkOrderId { get; set; }
        public Guid ProposalId { get; set; }

        public FixedPriceProposal Proposal { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public override void Configure(EntityTypeBuilder<ProposalWorkOrder> builder)
        {
            builder.HasKey(x => new
            {
                x.WorkOrderId,
                x.ProposalId
            });

            builder.HasOne(x => x.Proposal)
                .WithMany(x => x.WorkOrders)
                .HasForeignKey(x => x.ProposalId);

            builder.HasOne(x => x.WorkOrder)
                .WithMany(x => x.Proposals)
                .HasForeignKey(x => x.WorkOrderId);
        }
    }
}