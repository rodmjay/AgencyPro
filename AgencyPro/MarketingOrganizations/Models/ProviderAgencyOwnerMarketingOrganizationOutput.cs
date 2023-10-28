using System;
using Newtonsoft.Json;

namespace AgencyPro.MarketingOrganizations.Models
{
    public class ProviderAgencyOwnerMarketingOrganizationOutput : MarketingOrganizationOutput
    {
        [JsonIgnore]
        public override Guid DefaultMarketerId { get; set; }

        [JsonIgnore]
        public override decimal ServiceFeePerLead { get; set; }

        [JsonIgnore]
        public override decimal MarketerStream { get; set; }

        [JsonIgnore]
        public override decimal MarketingAgencyStream { get; set; }

        public decimal MarketingStream => MarketerStream + MarketingAgencyStream;

        [JsonIgnore]
        public override decimal MarketingAgencyBonus { get; set; }

        [JsonIgnore]
        public override decimal MarketerBonus { get; set; }
        
        public decimal MarketingBonus => MarketerBonus + MarketingAgencyBonus + ServiceFeePerLead;
    }
}