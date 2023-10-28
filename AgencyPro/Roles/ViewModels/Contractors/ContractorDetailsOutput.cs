using System.Collections.Generic;
using AgencyPro.Skills.Models;
using Newtonsoft.Json;

namespace AgencyPro.Roles.ViewModels.Contractors
{
    public class ContractorDetailsOutput : ContractorOutput
    {
        [JsonIgnore]
        public override decimal RecruiterStream { get; set; }

        public virtual ICollection<ContractorSkillOutput> Skills { get; set; }

    }
}