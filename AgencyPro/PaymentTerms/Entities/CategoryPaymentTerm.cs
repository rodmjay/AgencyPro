using AgencyPro.Categories.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PaymentTerms.Entities
{
    public class CategoryPaymentTerm : BaseEntity<CategoryPaymentTerm>
    {
        public int CategoryId { get; set; }
        public int PaymentTermId { get; set; }
        public Category Category { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public override void Configure(EntityTypeBuilder<CategoryPaymentTerm> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}