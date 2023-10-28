using Newtonsoft.Json;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class ContractorTimeMatrixOutput : TimeMatrixOutput
    {
        [JsonIgnore]
        public override decimal TotalAccountManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruitingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalCustomerAmount { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalProjectManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruiterStream { get; set; }
        [JsonIgnore]
        public override decimal TotalSystemStream { get; set; }

    }
}