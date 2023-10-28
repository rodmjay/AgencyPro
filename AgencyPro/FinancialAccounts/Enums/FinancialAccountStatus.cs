using System.Runtime.Serialization;

namespace AgencyPro.FinancialAccounts.Enums
{
    // todo: move this to flags 
    public enum FinancialAccountStatus
    {
        [EnumMember(Value = "Active")]
        Active = 0,

        [EnumMember(Value = "Inactive")]
        Inactive = 1
    }
}