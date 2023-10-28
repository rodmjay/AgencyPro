using Newtonsoft.Json;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class ProviderTimeMatrixOutput : TimeMatrixOutput
    {
        [JsonIgnore]
        public override decimal TotalSystemStream { get; set; }

        [JsonIgnore]
        public override decimal TotalAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal TotalMarketingAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal TotalRecruitingAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal TotalCustomerAmount { get; set; }
    }
}