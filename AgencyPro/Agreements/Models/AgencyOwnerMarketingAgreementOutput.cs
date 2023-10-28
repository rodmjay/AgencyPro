using Newtonsoft.Json;

namespace AgencyPro.Agreements.Models
{
    public class AgencyOwnerMarketingAgreementOutput : MarketingAgreementOutput
    {
        [JsonIgnore]
        public override decimal MarketerStream { get; set; }

        [JsonIgnore]
        public override decimal MarketerBonus { get; set; }

        [JsonIgnore]
        public override decimal MarketingAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal MarketingAgencyBonus { get; set; }
        
    }
}