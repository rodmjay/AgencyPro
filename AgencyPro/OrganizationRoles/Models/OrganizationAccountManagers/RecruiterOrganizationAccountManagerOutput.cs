using AgencyPro.People.Enums;
using Newtonsoft.Json;

namespace AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers
{
    public class RecruiterOrganizationAccountManagerOutput 
        : OrganizationAccountManagerOutput
    {
        [JsonIgnore]
        public override decimal AccountManagerStream { get; set; }

        [JsonIgnore]
        public override PersonStatus Status { get; set; }
    }
}