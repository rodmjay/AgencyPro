using System;

namespace AgencyPro.Skills.Models
{
    public class ContractorSkillOutput
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }

        public virtual int Priority { get; set; }
    }
}