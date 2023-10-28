using System;
using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Roles.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class IndividualBuyerAccount : BaseEntity<IndividualBuyerAccount>
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }

        public BuyerAccount BuyerAccount { get; set; }

        public string BuyerAccountId { get; set; }
        public override void Configure(EntityTypeBuilder<IndividualBuyerAccount> builder)
        {
            throw new NotImplementedException();
        }
    }
}