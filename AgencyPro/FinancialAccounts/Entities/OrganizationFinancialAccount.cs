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
            builder.HasOne(x => x.Organization)
                .WithOne(x => x.OrganizationFinancialAccount)
                .HasForeignKey<OrganizationFinancialAccount>(x => x.Id)
                .IsRequired(true);

            builder.HasOne(x => x.FinancialAccount)
                .WithOne(x => x.OrganizationFinancialAccount)
                .HasForeignKey<OrganizationFinancialAccount>(x => x.FinancialAccountId)
                .IsRequired(true);

            AddAuditProperties(builder);
        }
    }
}