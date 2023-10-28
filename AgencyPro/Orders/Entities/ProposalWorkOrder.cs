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
            throw new NotImplementedException();
        }
    }
}