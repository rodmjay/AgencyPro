using Newtonsoft.Json;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class ProjectManagerOrganizationContractorOutput
        : OrganizationContractorOutput
    {
        [JsonIgnore] public override decimal ContractorStream { get; set; }
        [JsonIgnore] public override bool IsFeatured { get; set; }
    }
}