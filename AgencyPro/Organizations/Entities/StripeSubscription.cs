using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Stripe.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class StripeSubscription : BaseEntity<StripeSubscription>
    {
        public OrganizationSubscription OrganizationSubscription { get; set; }
        public string Id { get; set; }

        public DateTime? CanceledAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndedAt { get; set; }
        public DateTime? TrialEnd { get; set; }
        public DateTime? CurrentPeriodEnd { get; set; }
        public DateTime? CurrentPeriodStart { get; set; }

        public string CustomerId { get; set; }

        public bool CancelAtPeriodEnd { get; set; }

        public ICollection<StripeInvoice> Invoices { get; set; }
        public ICollection<StripeSubscriptionItem> Items { get; set; }
        public override void Configure(EntityTypeBuilder<StripeSubscription> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.OrganizationSubscription)
                .WithOne(x => x.StripeSubscription)
                .HasForeignKey<OrganizationSubscription>(x => x.StripeSubscriptionId);

            builder.HasMany(x => x.Items)
                .WithOne(x => x.Subscription)
                .OnDelete(DeleteBehavior.Cascade);

            AddAuditProperties(builder);
        }
    }
}