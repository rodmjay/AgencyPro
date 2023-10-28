using System;
using AgencyPro.Leads.Enums;

namespace AgencyPro.Leads.Interfaces
{
    public interface ILead
    {
        Guid MarketerId { get; set; }
        Guid MarketerOrganizationId { get; set; }
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string OrganizationName { get; set; }
        string ReferralCode { get; set; }
        string PhoneNumber { get; set; }
        string Description { get; set; }
        decimal MarketerStream { get; set; }
        LeadStatus Status { get;}
        bool IsContacted { get; set; }
        Guid? AccountManagerOrganizationId { get; set; }
        Guid? AccountManagerId { get; set; }
        DateTime? CallbackDate { get; set; }
        string MeetingNotes { get; set; }
        string RejectionReason { get; set; }
        Guid CreatedById { get; set; }
        Guid UpdatedById { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        decimal MarketerBonus { get; set; }
        decimal MarketingAgencyStream { get; set; }
        decimal MarketingAgencyBonus { get; set; }
        Guid ProviderOrganizationId { get; set; }
    }
}