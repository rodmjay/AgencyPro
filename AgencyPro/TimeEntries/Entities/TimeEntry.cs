using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BillingCategories.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.Stories.Entities;
using AgencyPro.Stripe.Entities;
using AgencyPro.TimeEntries.Enums;
using AgencyPro.TimeEntries.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.TimeEntries.Entities
{
    public class TimeEntry : BaseEntity<TimeEntry>, ITimeEntry
    {


        private ICollection<TimeEntryStatusTransition> _statusTransitions;

        public virtual ICollection<TimeEntryStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<TimeEntryStatusTransition>();
            set => _statusTransitions = value;
        }

        public BillingCategory BillingCategory { get; set; }
        public Contract Contract { get; set; }
        public Story Story { get; set; }

        public string InvoiceItemId { get; set; }
        public StripeInvoiceItem InvoiceItem { get; set; }
        
        public Guid ContractId { get; set; }

        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public Guid? StoryId { get; set; }

        public Guid Id { get; set; }
        public string Notes { get; set; }
        
        public int TimeType { get; set; }
        

        public TimeStatus Status { get; set; }

        public decimal InstantContractorStream { get; set; }
        public string RejectionReason { get; set; }
        public decimal InstantRecruiterStream { get; set; }
        public decimal InstantMarketerStream { get; set; }
        public decimal InstantProjectManagerStream { get; set; }
        public decimal InstantAccountManagerStream { get; set; }
        public decimal InstantSystemStream { get; set; }
        public decimal InstantAgencyStream { get; set; }
        public decimal InstantRecruitingAgencyStream { get; set; }
        public decimal InstantMarketingAgencyStream { get; set; }

        public Guid RecruitingOrganizationId { get; set; }
        public Guid RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }
        public OrganizationRecruiter OrganizationRecruiter { get; set; }
        public Guid MarketerId { get; set; }
        public Guid MarketingOrganizationId { get; set; }
        public Marketer Marketer { get; set; }
        public OrganizationMarketer OrganizationMarketer { get; set; }
        public Guid ProjectManagerId { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public Guid AccountManagerId { get; set; }
        public AccountManager AccountManager { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public Guid ContractorId { get; set; }
        public Contractor Contractor { get; set; }
        public OrganizationContractor OrganizationContractor { get; set; }

        public Guid ProviderAgencyOwnerId { get; set; }
        public Customer ProviderAgencyOwner { get; set; }

        public Guid MarketingAgencyOwnerId { get; set; }
        public Customer MarketingAgencyOwner { get; set; }

        public Guid RecruitingAgencyOwnerId { get; set; }
        public Customer RecruitingAgencyOwner { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public Customer Customer { get; set; }
        
        public decimal TotalContractorStream
        {
            get => InstantContractorStream * TotalHours;
            set { }
        }

        public decimal TotalRecruiterStream
        {
            get => InstantRecruiterStream * TotalHours;
            set { }
        }

        public decimal TotalMarketerStream
        {
            get => InstantMarketerStream * TotalHours;
            set { }
        }

        public decimal TotalProjectManagerStream
        {
            get => InstantProjectManagerStream * TotalHours;
            set { }
        }

        public decimal TotalAccountManagerStream
        {
            get => InstantAccountManagerStream * TotalHours;
            set { }
        }

        public decimal TotalSystemStream
        {
            get => InstantSystemStream * TotalHours;
            set { }
        }

        public decimal TotalAgencyStream
        {
            get => InstantAgencyStream * TotalHours;
            set { }
        }

        public decimal TotalRecruitingAgencyStream
        {
            get => InstantRecruitingAgencyStream * TotalHours;
            set { }
        }

        public decimal TotalRecruitingStream
        {
            get => TotalRecruiterStream + TotalRecruitingAgencyStream;
            set { }
        }

        public decimal TotalMarketingStream
        {
            get => TotalMarketerStream + TotalMarketingAgencyStream;
            set { }
        }

        public decimal TotalMarketingAgencyStream
        {
            get => InstantMarketingAgencyStream * TotalHours;
            set { }
        }

        public DateTimeOffset Updated { get; set; }

        public decimal TotalCustomerAmount
        {
            get => (
                       InstantAgencyStream +
                       InstantSystemStream +
                       InstantAccountManagerStream +
                       InstantContractorStream +
                       InstantMarketerStream +
                       InstantRecruiterStream +
                       InstantProjectManagerStream +
                       InstantRecruitingAgencyStream + 
                       InstantMarketingAgencyStream
                  ) * TotalHours;
            set { }
        }

        public int TotalMinutes
        {
            get => Convert.ToInt32((EndDate - StartDate).TotalMinutes);
            set { }
        }

        public decimal TotalHours
        {
            get => Convert.ToDecimal((EndDate - StartDate).TotalHours);
            set { }
        }

        public DateTimeOffset Created { get; set; }

        public string ConcurrencyStamp { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<TimeEntry> builder)
        {
            throw new NotImplementedException();
        }
    }
}