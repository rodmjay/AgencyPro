using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Plans.Entities
{
    public class StripePlan : BaseEntity<StripePlan>
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Interval { get; set; }
        public bool IsActive { get; set; }
        public string StripeId { get; set; }
        public string StripeBlob { get; set; }
        public string ProductId { get; set; }
        public int TrialPeriodDays { get; set; }

        public override void Configure(EntityTypeBuilder<StripePlan> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}
