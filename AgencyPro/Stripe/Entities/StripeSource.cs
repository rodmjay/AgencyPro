using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public class StripeSource : AuditableEntity<StripeSource>
    {
        public string Id { get; set; }
        public string ClientSecret { get; set; }
        public string Flow { get; set; }

        public string CustomerId { get; set; }
        public BuyerAccount Customer { get; set; }

        public string Type { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public long? Amount { get; set; }
        public override void Configure(EntityTypeBuilder<StripeSource> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}