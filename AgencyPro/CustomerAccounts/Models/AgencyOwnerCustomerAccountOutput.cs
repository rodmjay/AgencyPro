using Newtonsoft.Json;

namespace AgencyPro.CustomerAccounts.Models
{
    public class AgencyOwnerCustomerAccountOutput : CustomerAccountOutput
    {
        [JsonIgnore]
        public override int BuyerNumber { get; set; }
    }
}