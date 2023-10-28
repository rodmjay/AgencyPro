using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Roles.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Skills.Entities
{
    public class ContractorSkill : BaseEntity<ContractorSkill>
    {
        public Contractor Contractor { get; set; }
        public Skill Skill { get; set; }

        public Guid SkillId { get; set; }
        public Guid ContractorId { get; set; }

        public int SelfAssessment { get; set; }
        public override void Configure(EntityTypeBuilder<ContractorSkill> builder)
        {
            throw new NotImplementedException();
        }
    }
}