using System;
using AgencyPro.Agreements.Enums;

namespace AgencyPro.Agreements.Interfaces
{
    public interface IMarketingAgreement
    {
        Guid ProviderOrganizationId { get; set; }
        Guid MarketingOrganizationId { get; set; }
        decimal MarketerBonus { get; set; }
        decimal MarketingAgencyStream { get; set; }
        AgreementStatus Status { get; set; }
        bool InitiatedByProvider { get; set; }
        decimal MarketingAgencyBonus { get; set; }
        decimal MarketerStream { get; set; }
    }
}