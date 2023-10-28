using AgencyPro.FinancialAccounts.Enums;

namespace AgencyPro.FinancialAccounts.Interfaces
{
    public interface IFinancialAccount
    {
        FinancialAccountStatus Status { get; set; }
        bool ChargesEnabled { get; set; }
        bool PayoutsEnabled { get; set; }
        string AccountId { get; set; }
    }
}