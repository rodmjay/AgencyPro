using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Cards.Entities
{
    public class CustomerCard : BaseEntity<CustomerCard>
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }
        public BuyerAccount Customer { get; set; }

        public StripeCard StripeCard { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<CustomerCard> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}