using System;

namespace AgencyPro.Contracts.Interfaces
{
    public interface IContract
    {
        Guid Id { get; set; }

        int ProviderNumber { get; set; }

        int BuyerNumber { get; set; }

        int MarketingNumber { get; set; }

        int RecruitingNumber { get; set; }

        Guid ContractorId { get; set; }
        Guid ContractorOrganizationId { get; set; }
        Guid MarketerId { get; set; }
        Guid MarketerOrganizationId { get; set; }
        Guid RecruiterId { get; set; }
        Guid RecruiterOrganizationId { get; set; }
        int MaxWeeklyHours { get; set; }
        decimal ContractorStream { get; set; }
        decimal MarketerStream { get; set; }
        decimal AccountManagerStream { get; set; }
        decimal ProjectManagerStream { get; set; }
        decimal RecruiterStream { get; set; }
        decimal SystemStream { get; set; }
        decimal AgencyStream { get; set; }
        decimal RecruitingAgencyStream { get; set; }
        decimal MarketingAgencyStream { get; set; }
        decimal CustomerRate { get; }
        decimal MaxCustomerWeekly { get; }
        decimal MaxContractorWeekly { get; }
        decimal MaxRecruiterWeekly { get; }
        decimal MaxMarketerWeekly { get; }
        decimal MaxProjectManagerWeekly { get; }
        decimal MaxAccountManagerWeekly { get; }
        decimal MaxAgencyWeekly { get; }
        decimal MaxSystemWeekly { get; }
        Guid ProjectId { get; set; }
        Guid CreatedById { get; set; }
        Guid UpdatedById { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        bool IsDeleted { get; set; }
        decimal MaxRecruitingAgencyWeekly { get; }
        decimal MaxMarketingAgencyWeekly { get;  }
    }
}