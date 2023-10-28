using Newtonsoft.Json;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class MarketerTimeMatrixOutput : TimeMatrixOutput
    {
        //public MarketerOrganizationContractorOutput OrganizationContractor { get; set; }
        //public MarketerOrganizationCustomerOutput OrganizationCustomer { get; set; }
        //public MarketerOrganizationMarketerOutput OrganizationMarketer { get; set; }
        //public MarketerContractOutput Contract { get; set; }


        [JsonIgnore]
        public override decimal TotalAccountManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalMarketingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruitingAgencyStream { get; set; }
        [JsonIgnore]
        public override decimal TotalContractorStream { get; set; }
        [JsonIgnore]
        public override decimal TotalCustomerAmount { get; set; }
        [JsonIgnore]
        public override decimal TotalProjectManagerStream { get; set; }
        [JsonIgnore]
        public override decimal TotalRecruiterStream { get; set; }
        [JsonIgnore]
        public override decimal TotalSystemStream { get; set; }
    }
}