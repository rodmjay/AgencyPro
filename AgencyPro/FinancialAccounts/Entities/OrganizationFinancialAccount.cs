using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.FinancialAccounts.Entities
{
    public class OrganizationFinancialAccount : AuditableEntity<OrganizationFinancialAccount>
    {
        public Guid Id { get; set; }
        
        public FinancialAccount FinancialAccount { get; set; }
        public Organization Organization { get; set; }

        public string FinancialAccountId { get; set; }


        public override void Configure(EntityTypeBuilder<OrganizationFinancialAccount> builder)
        {
            throw new NotImplementedException();
        }
    }
}