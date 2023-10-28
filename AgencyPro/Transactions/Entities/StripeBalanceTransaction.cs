using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Stripe.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Transactions.Entities
{
    public class StripeBalanceTransaction : AuditableEntity<StripeBalanceTransaction>
    {
        public string Id { get; set; }
        public string TransactionType { get; set; }
        public string Status { get; set; }

        public decimal Gross { get; set; }
        public decimal Net { get; set; }
        public decimal Fee { get; set; }
      
        public string Description { get; set; }
        public DateTime AvailableOn { get; set; }
        public bool IsDeleted { get; set; }

        public string PayoutId { get; set; }
        public StripePayout Payout { get; set; }
        public override void Configure(EntityTypeBuilder<StripeBalanceTransaction> builder)
        {
            throw new NotImplementedException();
        }
    }
}