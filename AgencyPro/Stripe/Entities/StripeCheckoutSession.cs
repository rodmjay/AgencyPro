using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public class StripeCheckoutSession : BaseEntity<StripeCheckoutSession>
    {
        public string Id { get; set; }
        public BuyerAccount Customer { get; set; }
        public string CustomerId { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<StripeCheckoutSession> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}