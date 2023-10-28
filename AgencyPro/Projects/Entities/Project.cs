using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BillingCategories.Entities;
using AgencyPro.Comments.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Common.Extensions;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Enums;
using AgencyPro.Projects.Interfaces;
using AgencyPro.Proposals.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Retainers.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.Stories.Entities;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace AgencyPro.Projects.Entities
{
    public class Project : AuditableEntity<Project>, IProject
    {
        private ICollection<Contract> _contracts;
        private ICollection<Comment> _comments;
        private ICollection<ProjectInvoice> _invoices;

        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public ICollection<ProjectNotification> Notifications { get; set; }

        public ICollection<Story> Stories { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }


        [JsonIgnore()]
        public virtual ICollection<Contract> Contracts
        {
            get => _contracts ??= new Collection<Contract>();
            set => _contracts = value;
        }

        public ICollection<Comment> Comments
        {
            get => _comments ??= new Collection<Comment>();
            set => _comments = value;
        }

        public ProviderOrganization ProviderOrganization { get; set; }
        public Organization BuyerOrganization { get; set; }

       
        public ICollection<ProjectInvoice> Invoices
        {
            get => _invoices ??= new Collection<ProjectInvoice>();
            set => _invoices = value;
        }
        
        public ICollection<ProjectBillingCategory> ProjectBillingCategories { get; set; }
       
        public FixedPriceProposal Proposal { get; set; }
        
        public CustomerAccount CustomerAccount { get; set; }

        private ICollection<ProjectStatusTransition> _statusTransitions;

        public virtual ICollection<ProjectStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<ProjectStatusTransition>();
            set => _statusTransitions = value;
        }

        public bool IsDeleted { get; set; }

        public Guid Id { get; set; }
        public ProjectStatus Status { get; set; }
        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public Guid CustomerOrganizationId { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid ProjectManagerId { get; set; }
        public Guid ProjectManagerOrganizationId { get; set; }
        public ProjectManager ProjectManager { get; set; }

        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public AccountManager AccountManager { get; set; }

        public decimal WeightedContractorAverage =>
            Contracts.WeightedAverage(x => x.ContractorStream, x => x.MaxWeeklyHours);

        public decimal WeightedRecruiterAverage =>
            Contracts.WeightedAverage(x => x.RecruiterStream, x => x.MaxWeeklyHours);

        public decimal WeightedMarketerAverage =>
            Contracts.WeightedAverage(x => x.MarketerStream, x => x.MaxWeeklyHours);

        public decimal WeightedProjectManagerAverage =>
            Contracts.WeightedAverage(x => x.ProjectManagerStream, x => x.MaxWeeklyHours);

        public decimal WeightedAccountManagerAverage =>
            Contracts.WeightedAverage(x => x.AccountManagerStream, x => x.MaxWeeklyHours);

        public decimal WeightedAgencyAverage =>
            Contracts.WeightedAverage(x => x.AgencyStream, x => x.MaxWeeklyHours);

        public decimal WeightedRecruitingAgencyAverage =>
            Contracts.WeightedAverage(x => x.RecruitingAgencyStream, x => x.MaxWeeklyHours);

        public decimal WeightedMarketingAgencyAverage =>
            Contracts.WeightedAverage(x => x.MarketingAgencyStream, x => x.MaxWeeklyHours);

        public decimal WeightedSystemAverage =>
            Contracts.WeightedAverage(x => x.SystemStream, x => x.MaxWeeklyHours);

        public decimal AverageCustomerRate =>
            Contracts.WeightedAverage(x => x.CustomerRate, x => x.MaxWeeklyHours);


        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool AutoApproveTimeEntries { get; set; }


        public string ConcurrencyStamp { get; set; }
        public ProjectRetainerIntent ProjectRetainerIntent { get; set; }
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            throw new NotImplementedException();
        }
    }
}