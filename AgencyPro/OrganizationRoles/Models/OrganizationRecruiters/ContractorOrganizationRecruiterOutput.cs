using Newtonsoft.Json;

namespace AgencyPro.OrganizationRoles.Models.OrganizationRecruiters
{
    public class ContractorOrganizationRecruiterOutput
        : OrganizationRecruiterOutput
    {
        [JsonIgnore] public override decimal RecruiterStream { get; set; }
        [JsonIgnore] public override decimal RecruiterBonus { get; set; }
    }
}