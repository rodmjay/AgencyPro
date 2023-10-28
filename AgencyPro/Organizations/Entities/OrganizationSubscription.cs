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
            builder.HasOne(x => x.Organization)
                .WithOne(x => x.OrganizationSubscription)
                .HasForeignKey<OrganizationSubscription>(x => x.Id)
                .IsRequired(true);

            builder.HasOne(x => x.StripeSubscription)
                .WithOne(x => x.OrganizationSubscription)
                .HasForeignKey<OrganizationSubscription>(x => x.StripeSubscriptionId)
                .IsRequired(true);

            AddAuditProperties(builder);
        }
    }
}