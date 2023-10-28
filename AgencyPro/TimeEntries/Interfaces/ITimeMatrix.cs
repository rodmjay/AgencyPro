using System;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Interfaces
{
    public interface ITimeMatrix
    {
        Guid ContractorId { get; set; }
        Guid RecruiterId { get; set; }
        Guid RecruiterOrganizationId { get; set; }
        Guid MarketerId { get; set; }
        Guid MarketerOrganizationId { get; set; }
        Guid CustomerId { get; set; }
        Guid CustomerOrganizationId { get; set; }
        Guid ProjectManagerId { get; set; }
        Guid AccountManagerId { get; set; }
        Guid ProviderOrganizationId { get; set; }
        Guid? StoryId { get; set; }
        Guid ContractId { get; set; }
        Guid ProjectId { get; set; }
        int TimeType { get; set; }
        TimeStatus TimeStatus { get; set; }
        decimal Hours { get; set; }
        DateTime Date { get; set; }
        decimal TotalContractorStream { get; set; }
        decimal TotalMarketerStream { get; set; }
        decimal TotalRecruiterStream { get; set; }
        decimal TotalProjectManagerStream { get; set; }
        decimal TotalAccountManagerStream { get; set; }
        decimal TotalSystemStream { get; set; }
        decimal TotalAgencyStream { get; set; }
        decimal TotalMarketingAgencyStream { get; set; }
        decimal TotalRecruitingAgencyStream { get; set; }
        decimal TotalCustomerAmount { get; set; }
    }
}