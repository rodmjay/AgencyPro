using System;

namespace AgencyPro.MarketingOrganizations.Interfaces
{
    public interface IMarketingOrganization
    {
        decimal MarketerStream { get; set; }
        decimal MarketingAgencyStream { get; set; }
        decimal MarketerBonus { get; set; }
        decimal MarketingAgencyBonus { get; set; }
        Guid DefaultMarketerId { get; set; }
        Guid Id { get; set; }
        decimal ServiceFeePerLead { get; set; }
    }
}