using System;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Proposals.Enums;
using AgencyPro.Roles.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Proposals.Entities
{
    public class ProposalAcceptance : BaseEntity<ProposalAcceptance>
    {
        public Guid Id { get; set; }

        [ForeignKey("Id")] public FixedPriceProposal Proposal { get; set; }

        public DateTimeOffset AcceptedCompletionDate { get; set; }

        public decimal TotalCost { get; set; }

        public int NetTerms { get; set; }

        public decimal? RetainerAmount { get; set; }
        
        public string ProposalBlob { get; set; }
        public decimal CustomerRate { get; set; }
        public string AgreementText { get; set; }
        public ProposalType ProposalType { get; set; }
        public decimal TotalDays { get; set; }
        public decimal Velocity { get; set; }

        public Guid AcceptedBy { get; set; }
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Guid CustomerOrganizationId { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public override void Configure(EntityTypeBuilder<ProposalAcceptance> builder)
        {
            throw new NotImplementedException();
        }
    }
}