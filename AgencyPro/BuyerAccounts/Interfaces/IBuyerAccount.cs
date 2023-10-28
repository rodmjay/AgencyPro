using System;

namespace AgencyPro.BuyerAccounts.Interfaces
{
    public interface IBuyerAccount
    {
        decimal Balance { get; set; }
        bool Delinquent { get; set; }
        string Id { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}