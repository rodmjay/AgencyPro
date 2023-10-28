using AgencyPro.FinancialAccounts.Enums;
using AgencyPro.FinancialAccounts.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AgencyPro.FinancialAccounts.Models
{
    public class FinancialAccountOutput : IFinancialAccount
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FinancialAccountStatus Status { get; set; }

        public bool ChargesEnabled { get; set; }

        public bool PayoutsEnabled { get; set; }
        public string AccountId { get; set; }
        
    }
}
