using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PaymentTerms.Entities
{
    public class OrganizationPaymentTerm : BaseEntity<OrganizationPaymentTerm>
    {
        public Guid OrganizationId { get; set; }
        public int PaymentTermId { get; set; }

        public bool IsDefault { get; set; }

        public Organization Organization { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationPaymentTerm> builder)
        {
            throw new NotImplementedException();
        }
    }
}