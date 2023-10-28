using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Entities;
using AgencyPro.Stripe.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Invoices.Entities
{
    public class ProjectInvoice : AuditableEntity<ProjectInvoice>
    {
        public Project Project { get; set; }

        public Guid ProjectId { get; set; }

        public string RefNo { get; set; }

        public string InvoiceId { get; set; }

        public StripeInvoice Invoice { get; set; }

        public Guid AccountManagerId { get; set; }
        public AccountManager AccountManager { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public Organization ProviderOrganization { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid BuyerOrganizationId { get; set; }
        public Organization BuyerOrganization { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }

        public CustomerAccount CustomerAccount { get; set; }

        public Guid ProjectManagerId { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public ICollection<ProjectInvoiceAdditionalExpense> AdditionalExpenses { get; set; }

        public override void Configure(EntityTypeBuilder<ProjectInvoice> builder)
        {
            builder.HasKey(x => x.InvoiceId);
            builder.Property(x => x.InvoiceId).IsRequired();

            builder.HasOne(x => x.Project)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.ProjectId)
                .IsRequired();

            builder.HasOne(x => x.AccountManager)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.ProjectManager)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.ProjectManagerId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.ProviderInvoices)
                .HasForeignKey(x => x.ProviderOrganizationId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.BuyerOrganization)
                .WithMany(x => x.BuyerInvoices)
                .HasForeignKey(x => x.BuyerOrganizationId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.OrganizationProjectManager)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.ProjectManagerId
                })
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.AccountManagerId
                })
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.OrganizationCustomer)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => new
                {
                    x.BuyerOrganizationId,
                    x.CustomerId
                })
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(x => x.OrganizationProjectManager)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.ProjectManagerId
                })
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(x => x.CustomerAccount)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => new
                {
                    x.BuyerOrganizationId,
                    x.CustomerId,
                    x.ProviderOrganizationId,
                    x.AccountManagerId
                }).IsRequired();

            builder.HasOne(x => x.Invoice)
                .WithOne(x => x.ProjectInvoice)
                .HasForeignKey<ProjectInvoice>(x => x.InvoiceId);

            builder.HasMany(x => x.AdditionalExpenses)
                .WithOne(x => x.ProjectInvoice)
                .HasForeignKey(x => x.InvoiceId);

            AddAuditProperties(builder, true);
        }
    }
}