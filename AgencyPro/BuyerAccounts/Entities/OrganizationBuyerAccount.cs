using System;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BuyerAccounts.Entities
{
    public class OrganizationBuyerAccount : BaseEntity<OrganizationBuyerAccount>
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Id))]
        public Organization Organization { get; set; }

        [ForeignKey(nameof(BuyerAccountId))]
        public BuyerAccount BuyerAccount { get; set; }

        public string BuyerAccountId { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationBuyerAccount> builder)
        {
            builder.HasOne(x => x.BuyerAccount)
                .WithOne(x => x.OrganizationBuyerAccount)
                .HasForeignKey<OrganizationBuyerAccount>(x => x.BuyerAccountId)
                .IsRequired(true);

            builder.HasOne(x => x.Organization)
                .WithOne(x => x.OrganizationBuyerAccount)
                .HasForeignKey<OrganizationBuyerAccount>(x => x.Id)
                .IsRequired(true);
        }
    }
}