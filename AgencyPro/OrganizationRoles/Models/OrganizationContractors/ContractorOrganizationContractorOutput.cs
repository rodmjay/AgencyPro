using Newtonsoft.Json;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public sealed class ContractorOrganizationContractorOutput
        : OrganizationContractorOutput
    {
        [JsonIgnore] public override bool IsFeatured { get; set; }
    }
}