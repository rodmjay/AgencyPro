using Newtonsoft.Json;

namespace AgencyPro.Agreements.Models
{
    public class RecruiterRecruitingAgreementOutput : RecruitingAgreementOutput
    {
        [JsonIgnore]
        public override decimal RecruitingAgencyBonus { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }

        [JsonIgnore]
        public override decimal RecruitingBonus { get; }

        [JsonIgnore]
        public override decimal RecruitingStream { get; }

        [JsonIgnore]
        public override bool InitiatedByProvider { get; set; }
    }
}