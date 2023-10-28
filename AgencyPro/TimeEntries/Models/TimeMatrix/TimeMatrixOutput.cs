using System;
using AgencyPro.TimeEntries.Enums;
using AgencyPro.TimeEntries.Interfaces;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class TimeMatrixOutput : ITimeMatrix
    {
        public virtual Guid ContractorId { get; set; }
        public virtual Guid RecruiterId { get; set; }
        public virtual Guid RecruiterOrganizationId { get; set; }
        public virtual Guid MarketerId { get; set; }
        public virtual Guid MarketerOrganizationId { get; set; }
        public virtual Guid CustomerId { get; set; }
        public virtual Guid CustomerOrganizationId { get; set; }
        public virtual Guid ProjectManagerId { get; set; }
        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid ProviderOrganizationId { get; set; }
        public virtual Guid? StoryId { get; set; }
        public virtual Guid ContractId { get; set; }
        public virtual Guid ProjectId { get; set; }
        public virtual int TimeType { get; set; }
        public virtual TimeStatus TimeStatus { get; set; }
        public virtual decimal Hours { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal TotalContractorStream { get; set; }
        public virtual decimal TotalMarketerStream { get; set; }
        public virtual decimal TotalRecruiterStream { get; set; }
        public virtual decimal TotalProjectManagerStream { get; set; }
        public virtual decimal TotalAccountManagerStream { get; set; }
        public virtual decimal TotalSystemStream { get; set; }
        public virtual decimal TotalAgencyStream { get; set; }
        public virtual decimal TotalMarketingAgencyStream { get; set; }
        public virtual decimal TotalRecruitingAgencyStream { get; set; }
        public virtual decimal TotalCustomerAmount { get; set; }
    }
}