using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Roles.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BuyerAccounts.Entities
{
    public class IndividualBuyerAccount : BaseEntity<IndividualBuyerAccount>
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }

        public BuyerAccount BuyerAccount { get; set; }

        public string BuyerAccountId { get; set; }
        public override void Configure(EntityTypeBuilder<IndividualBuyerAccount> builder)
        {
            builder.HasOne(x => x.Customer)
                .WithOne(x => x.BuyerAccount)
                .HasForeignKey<IndividualBuyerAccount>(x => x.Id)
                .IsRequired();

            builder.HasOne(x => x.BuyerAccount)
                .WithOne(x => x.IndividualBuyerAccount)
                .HasForeignKey<IndividualBuyerAccount>(x => x.BuyerAccountId)
                .IsRequired();

            AddAuditProperties(builder);
        }
    }
}