using Newtonsoft.Json;

namespace AgencyPro.MarketingOrganizations.Models
{
    public class MarketerOrganizationOutput : MarketingOrganizationOutput
    {
        [JsonIgnore]
        public override decimal ServiceFeePerLead { get; set; }
    }
}