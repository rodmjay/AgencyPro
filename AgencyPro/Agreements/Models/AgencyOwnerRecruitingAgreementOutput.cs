using Newtonsoft.Json;

namespace AgencyPro.Agreements.Models
{
    public class AgencyOwnerRecruitingAgreementOutput : RecruitingAgreementOutput
    {
        [JsonIgnore]
        public override decimal RecruiterStream { get; set; }

        [JsonIgnore]
        public override decimal RecruiterBonus { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyBonus { get; set; }
    }

}