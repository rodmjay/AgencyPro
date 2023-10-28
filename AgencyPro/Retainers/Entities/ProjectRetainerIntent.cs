using System;
using System.Collections.Generic;
using AgencyPro.Charges.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Retainers.Entities
{
    public class ProjectRetainerIntent : BaseEntity<ProjectRetainerIntent>
    {
        public CustomerAccount CustomerAccount { get; set; }
        public AccountManager AccountManager { get; set; }
        public Guid AccountManagerId { get; set; }
        public Organization ProviderOrganization { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public Organization CustomerOrganization { get; set; }
        public Customer Customer { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public ICollection<StripeCharge> Credits { get; set; }
        public decimal TopOffAmount { get; set; }
        public decimal CurrentBalance { get; set; }
        public override void Configure(EntityTypeBuilder<ProjectRetainerIntent> builder)
        {
            builder.HasKey(x => x.ProjectId);

            builder.HasOne(x => x.AccountManager)
                .WithMany(x => x.RetainerIntents)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.CustomerAccount)
                .WithMany(x => x.RetainerIntents)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.ProviderOrganizationId,
                    x.AccountManagerId
                })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.RetainerIntents)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.RetainerIntents)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.AccountManagerId
                })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OrganizationCustomer)
                .WithMany(x => x.RetainerIntents)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId
                })
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.CustomerOrganization)
                .WithMany(x => x.BuyerRetainerIntents)
                .HasForeignKey(x => x.CustomerOrganizationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.ProviderRetainerIntents)
                .HasForeignKey(x => x.ProviderOrganizationId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Project)
                .WithOne(x => x.ProjectRetainerIntent)
                .HasForeignKey<ProjectRetainerIntent>(x => x.ProjectId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Credits)
                .WithOne(x => x.RetainerIntent)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
