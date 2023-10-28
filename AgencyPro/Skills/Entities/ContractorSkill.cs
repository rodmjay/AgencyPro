using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Roles.Entities;
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
            builder.HasKey(sc => new { sc.SkillId, sc.ContractorId });

            builder.HasOne(x => x.Skill)
                .WithMany(x => x.ContractorSkills)
                .HasForeignKey(x => x.SkillId);

            builder.HasOne(x => x.Contractor)
                .WithMany(x => x.ContractorSkills)
                .HasForeignKey(x => x.ContractorId);
        }
    }
}