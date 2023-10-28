using System;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Interfaces
{
    public interface ITimeEntry
    {
        Guid ContractId { get; set; }
        DateTimeOffset StartDate { get; set; }
        DateTimeOffset EndDate { get; set; }
        Guid? StoryId { get; set; }
        Guid Id { get; set; }
        string Notes { get; set; }
        int TimeType { get; set; }
        TimeStatus Status { get; set; }
        decimal InstantContractorStream { get; set; }
        string RejectionReason { get; set; }
        decimal InstantRecruiterStream { get; set; }
        decimal InstantMarketerStream { get; set; }
        decimal InstantProjectManagerStream { get; set; }
        decimal InstantAccountManagerStream { get; set; }
        decimal InstantSystemStream { get; set; }
        decimal InstantAgencyStream { get; set; }
        decimal TotalContractorStream { get; set; }
        decimal TotalRecruiterStream { get; set; }
        decimal TotalMarketerStream { get; set; }
        decimal TotalProjectManagerStream { get; set; }
        decimal TotalAccountManagerStream { get; set; }
        decimal TotalSystemStream { get; set; }
        decimal TotalAgencyStream { get; set; }
        int TotalMinutes { get; set; }
        decimal TotalHours { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        decimal TotalCustomerAmount { get; set; }
        decimal InstantRecruitingAgencyStream { get; set; }
        decimal InstantMarketingAgencyStream { get; set; }
        decimal TotalMarketingAgencyStream { get; set; }
        decimal TotalRecruitingAgencyStream { get; set; }
        decimal TotalRecruitingStream { get; set; }
        decimal TotalMarketingStream { get; set; }
    }
}