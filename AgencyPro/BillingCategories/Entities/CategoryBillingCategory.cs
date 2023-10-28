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
            throw new System.NotImplementedException();
        }
    }
}