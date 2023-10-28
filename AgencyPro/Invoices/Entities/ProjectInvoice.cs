using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.Stripe.Entities;
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
            throw new NotImplementedException();
        }
    }
}