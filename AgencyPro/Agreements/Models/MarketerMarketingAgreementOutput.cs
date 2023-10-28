using Newtonsoft.Json;

namespace AgencyPro.Agreements.Models
{
    public class MarketerMarketingAgreementOutput : MarketingAgreementOutput
    {
        [JsonIgnore]
        public override decimal MarketingAgencyBonus { get; set; }

        [JsonIgnore]
        public override decimal MarketingStream { get; set; }
        
        [JsonIgnore]
        public override decimal MarketingAgencyStream { get; set; }

        [JsonIgnore]
        public override bool InitiatedByProvider { get; set; }
    }
}