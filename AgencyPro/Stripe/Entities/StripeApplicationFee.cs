using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public class StripeApplicationFee : BaseEntity<StripeApplicationFee>
    {
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<StripeApplicationFee> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}