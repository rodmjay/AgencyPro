using Newtonsoft.Json;

namespace AgencyPro.ProviderOrganizations.Models
{
    public class ProjectManagerOrganizationOutput : ProviderOrganizationOutput
    {
        [JsonIgnore] public override decimal AccountManagerStream { get; set; }
        
        [JsonIgnore] public override decimal AgencyStream { get; set; }

        public override int PreviousDaysAllowed { get; set; }
        [JsonIgnore] public override decimal SystemStream { get; set; }

        [JsonIgnore] public override string AccountManagerInformation { get; set; }
        public override string ContractorInformation { get; set; }
        public override int FutureDaysAllowed { get; set; }
        public override string ProviderInformation { get; set; }
        public override string ProjectManagerInformation { get; set; }
    }
}