using Newtonsoft.Json;

namespace AgencyPro.Roles.ViewModels.Contractors
{
    public sealed class CustomerContractorOutput : ContractorOutput
    {
        [JsonIgnore] public override decimal RecruiterStream { get; set; }
    }
}