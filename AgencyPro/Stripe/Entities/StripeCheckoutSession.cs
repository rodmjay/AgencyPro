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
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.CheckoutSessions)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired();

            AddAuditProperties(builder);
        }
    }
}