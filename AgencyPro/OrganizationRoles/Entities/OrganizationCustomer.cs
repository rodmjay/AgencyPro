using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Proposals.Entities;
using AgencyPro.Retainers.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class OrganizationCustomer : BaseEntity<OrganizationCustomer>, IOrganizationCustomer
    {
        public Guid OrganizationId { get; set; }
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Organization Organization { get; set; }
        public OrganizationPerson OrganizationPerson { get; set; }
        public ICollection<Contract> Contracts { get; set; }

        public ICollection<CustomerAccount> Accounts { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }
        //public ICollection<OrganizationPayoutIntent> PayoutIntents { get; set; }
        public ICollection<ProposalAcceptance> ProposalsAccepted { get; set; }


        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public virtual string ConcurrencyStamp { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationCustomer> builder)
        {
            throw new NotImplementedException();
        }
    }
}