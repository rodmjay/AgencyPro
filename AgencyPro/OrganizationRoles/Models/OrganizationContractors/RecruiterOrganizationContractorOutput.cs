using Newtonsoft.Json;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public sealed class RecruiterOrganizationContractorOutput
        : OrganizationContractorOutput
    {
        [JsonIgnore] public override decimal ContractorStream { get; set; }
        [JsonIgnore] public override bool IsFeatured { get; set; }
    }
}