using System.Collections.Generic;
using AgencyPro.Skills.Models;

namespace AgencyPro.Roles.ViewModels.Contractors
{
    public class RecruiterContractorOutput : ContractorOutput
    {
        public virtual ICollection<ContractorSkillOutput> Skills { get; set; }

    }
}