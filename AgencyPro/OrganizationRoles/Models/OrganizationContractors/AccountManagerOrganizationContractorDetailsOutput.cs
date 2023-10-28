using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.Skills.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class AccountManagerOrganizationContractorDetailsOutput
        :OrganizationContractorStatistics
    {
        public virtual IList<ContractorSkillOutput> Skills { get; set; }
        public virtual IList<AccountManagerContractOutput> Contracts { get; set; }
        public virtual IList<AccountManagerStoryOutput> Stories { get; set; }
    }
}