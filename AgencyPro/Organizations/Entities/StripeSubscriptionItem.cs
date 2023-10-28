using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class StripeSubscriptionItem : BaseEntity<StripeSubscriptionItem>
    {
        public string Id { get; set; }
        public StripeSubscription Subscription { get; set; }
        public string SubscriptionId { get; set; }

        public string PlanId { get; set; }
        public bool IsDeleted { get; set; }
        public long Quantity { get; set; }
        public override void Configure(EntityTypeBuilder<StripeSubscriptionItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.Subscription)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.SubscriptionId)
                .IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);


            AddAuditProperties(builder);
        }
    }
}