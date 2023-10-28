using System;
using AgencyPro.Skills.Interfaces;

namespace AgencyPro.Skills.Models
{
    public class OrganizationSkillOutput : OrganizationSkillInput, IOrganizationSkill
    {
        public virtual string SkillName { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid SkillId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}