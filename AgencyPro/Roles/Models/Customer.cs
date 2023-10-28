using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Cards.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.Orders.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.People.Entities;
using AgencyPro.Proposals.Entities;
using AgencyPro.Retainers.Entities;
using AgencyPro.Roles.Interfaces;
using AgencyPro.TimeEntries.Entities;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Roles.Models
{
    public class Customer : AuditableEntity<Customer>, ICustomer
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public OrganizationMarketer OrganizationMarketer { get; set; }

        public ICollection<OrganizationCustomer> OrganizationCustomers { get; set; }
        public IndividualBuyerAccount BuyerAccount { get; set; }

        public ICollection<Organization> OwnedAgencies { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }
        public ICollection<ProposalAcceptance> ProposalsAccepted { get; set; }

        public ICollection<TimeEntry> ProviderTimeEntries { get; set; }
        public ICollection<TimeEntry> MarketingTimeEntries { get; set; }
        public ICollection<TimeEntry> RecruitingTimeEntries { get; set; }

        public ICollection<TimeEntry> BuyerTimeEntries { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public ICollection<CustomerCard> Cards { get; set; }
        public ICollection<WorkOrder> WorkOrders { get; set; }
        public ICollection<Contract> Contracts { get; set; }

        public Guid Id { get; set; }

        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
       
        public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }

        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            throw new NotImplementedException();
        }
    }
}