using System;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
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
            throw new NotImplementedException();
        }
    }
}