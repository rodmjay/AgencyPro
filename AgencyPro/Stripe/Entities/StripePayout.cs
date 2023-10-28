using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Transactions.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public class StripePayout : AuditableEntity<StripePayout>
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset ArrivalDate { get; set; }
        public bool Automatic { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<StripeBalanceTransaction> BalanceTransactions { get; set; }
        public override void Configure(EntityTypeBuilder<StripePayout> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            AddAuditProperties(builder);


            builder.HasMany(x => x.BalanceTransactions)
                .WithOne(x => x.Payout)
                .HasForeignKey(x => x.PayoutId)
                .IsRequired(false);
        }
    }
}