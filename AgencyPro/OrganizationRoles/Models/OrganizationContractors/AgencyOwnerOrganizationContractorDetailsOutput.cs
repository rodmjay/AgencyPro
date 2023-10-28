using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.Skills.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class AgencyOwnerOrganizationContractorDetailsOutput
        : OrganizationContractorStatistics
    {
        public virtual IList<ContractorSkillOutput> Skills { get; set; }
        public virtual IList<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public virtual IList<AgencyOwnerStoryOutput> Stories { get; set; }
    }
}