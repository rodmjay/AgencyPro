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
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.FinancialAccount)
                .WithMany(x => x.Cards)
                .HasForeignKey(x => x.AccountId)
                .IsRequired();

            builder.HasOne(x => x.StripeCard)
                .WithOne(x => x.AccountCard)
                .HasForeignKey<AccountCard>(x => x.Id);

            AddAuditProperties(builder);
        }
    }
}