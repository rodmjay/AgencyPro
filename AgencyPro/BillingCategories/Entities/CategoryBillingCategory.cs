using AgencyPro.Categories.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BillingCategories.Entities
{
    public class CategoryBillingCategory : BaseEntity<CategoryBillingCategory>
    {
        public int CategoryId { get; set; }
        public int BillingCategoryId { get; set; }

        public Category Category { get; set; }
        public BillingCategory BillingCategory { get; set; }

        public override void Configure(EntityTypeBuilder<CategoryBillingCategory> builder)
        {
            builder.HasKey(x => new
            {
                x.CategoryId,
                x.BillingCategoryId
            });

            builder.HasOne(x => x.Category)
                .WithMany(x => x.AvailableBillingCategories)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.BillingCategory)
                .WithMany(x => x.CategoryBillingCategories)
                .HasForeignKey(x => x.BillingCategoryId);
            
        }
    }
}