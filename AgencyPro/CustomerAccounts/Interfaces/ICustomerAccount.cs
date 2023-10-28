using System;
using AgencyPro.CustomerAccounts.Enums;

namespace AgencyPro.CustomerAccounts.Interfaces
{
    public interface ICustomerAccount
    {
        int BuyerNumber { get; set; }
        int Number { get; set; }
        Guid CustomerId { get; set; }
        Guid CustomerOrganizationId { get; set; }
        AccountStatus AccountStatus { get; set; }
        Guid AccountManagerId { get; set; }
        Guid AccountManagerOrganizationId { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        decimal MarketerStream { get; set; }
        decimal MarketingAgencyStream { get; set; }
    }
}