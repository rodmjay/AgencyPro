using System;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class OrganizationSubscription : BaseEntity<OrganizationSubscription>
    {
        public Guid Id { get; set; }

        public Organization Organization { get; set; }

        public StripeSubscription StripeSubscription { get; set; }

        public string StripeSubscriptionId { get; set; }

        public override void Configure(EntityTypeBuilder<OrganizationSubscription> builder)
        {
            throw new NotImplementedException();
        }
    }
}