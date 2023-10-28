using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.Orders.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Retainers.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class OrganizationAccountManager : BaseEntity<OrganizationAccountManager>, IOrganizationAccountManager
    {
        public Organization Organization { get; set; }
        
        public AccountManager AccountManager { get; set; }

        public ICollection<ProviderOrganization> DefaultOrganizations { get; set; }

        public ICollection<WorkOrder> WorkOrders { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }

        public OrganizationPerson OrganizationPerson { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public decimal AccountManagerStream { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<CustomerAccount> Accounts { get; set; }

        public ICollection<Lead> Leads { get; set; }
        public ICollection<Contract> Contracts { get; set; }

        public bool IsDeleted { get; set; }
        public Guid OrganizationId { get; set; }

        public Guid AccountManagerId { get; set; }
        public virtual string ConcurrencyStamp { get; set; }
        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationAccountManager> builder)
        {
            throw new NotImplementedException();
        }
    }
}