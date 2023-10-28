using System;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.TimeEntries.Enums;
using AgencyPro.TimeEntries.Interfaces;

namespace AgencyPro.TimeEntries.Entities
{
    public class TimeMatrix : ITimeMatrix
    {
        public Guid ContractorId { get; set; }
        public Guid RecruiterId { get; set; }
        public Guid RecruiterOrganizationId { get; set; }
        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public Guid ProjectManagerId { get; set; }
        public Guid AccountManagerId { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public Guid? StoryId { get; set; }
        public Guid ContractId { get; set; }
        public Guid ProjectId { get; set; }
        public int TimeType { get; set; }
        public TimeStatus TimeStatus { get; set; }
        public decimal Hours { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalContractorStream { get; set; }
        public decimal TotalMarketerStream { get; set; }
        public decimal TotalRecruiterStream { get; set; }
        public decimal TotalProjectManagerStream { get; set; }
        public decimal TotalAccountManagerStream { get; set; }
        public decimal TotalSystemStream { get; set; }
        public decimal TotalAgencyStream { get; set; }
        public decimal TotalMarketingAgencyStream { get; set; }
        public decimal TotalRecruitingAgencyStream { get; set; }
        public decimal TotalCustomerAmount { get; set; }

        public OrganizationContractor OrganizationContractor { get; set; }
        public OrganizationRecruiter OrganizationRecruiter { get; set; }
        public OrganizationMarketer OrganizationMarketer { get; set; }
        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }

        public Contract Contract { get; set; }
        public Project Project { get; set; }
    }
}
