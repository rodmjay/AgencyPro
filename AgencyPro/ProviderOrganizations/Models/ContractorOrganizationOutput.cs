using System;
using Newtonsoft.Json;

namespace AgencyPro.ProviderOrganizations.Models
{
    public class ContractorOrganizationOutput : ProviderOrganizationOutput
    {
        [JsonIgnore] public override decimal AccountManagerStream { get; set; }

        [JsonIgnore] public override decimal ProjectManagerStream { get; set; }
        
        [JsonIgnore] public override decimal AgencyStream { get; set; }
        [JsonIgnore] public override string AccountManagerInformation { get; set; }
        public override string ContractorInformation { get; set; }
        [JsonIgnore] public override int FutureDaysAllowed { get; set; }
        [JsonIgnore] public override int PreviousDaysAllowed { get; set; }
        public override string ProviderInformation { get; set; }
        [JsonIgnore] public override string ProjectManagerInformation { get; set; }
        [JsonIgnore] public override int EstimationBasis { get; set; }

        [JsonIgnore] public override decimal SystemStream { get; set; }
        
        [JsonIgnore] public override Guid DefaultAccountManagerId { get; set; }
        [JsonIgnore] public override Guid DefaultProjectManagerId { get; set; }

        [JsonIgnore] public override Guid DefaultContractorId { get; set; }
    }
}