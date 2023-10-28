using AgencyPro.Common.Data.Bases;
using AgencyPro.FinancialAccounts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Cards.Entities
{
    public class AccountCard : BaseEntity<AccountCard>
    {
        public string Id { get; set; }

        public string AccountId { get; set; }
        public FinancialAccount FinancialAccount { get; set; }

        public StripeCard StripeCard { get; set; }
        public bool IsDeleted { get; set; }

        public string Status { get; set; }
        public string Type { get; set; }

        public override void Configure(EntityTypeBuilder<AccountCard> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}