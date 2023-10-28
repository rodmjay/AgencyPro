using Newtonsoft.Json;

namespace AgencyPro.Roles.ViewModels.Contractors
{
    public class ProjectManagerContractorOutput : ContractorOutput
    {
        [JsonIgnore] public override decimal RecruiterStream { get; set; }
    }
}