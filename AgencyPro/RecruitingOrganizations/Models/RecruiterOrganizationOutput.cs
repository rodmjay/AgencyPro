using Newtonsoft.Json;

namespace AgencyPro.RecruitingOrganizations.Models
{
    public class RecruiterOrganizationOutput : RecruitingOrganizationOutput
    {
       
        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }
    }
}