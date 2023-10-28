using System;
using System.Collections.Generic;
using AgencyPro.Categories.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Skills.Entities
{
    public class Skill : BaseEntity<Skill>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public int Priority { get; set; }

        public ICollection<OrganizationSkill> OrganizationSkill { get; set; }
        public ICollection<CategorySkill> SkillCategories { get; set; }
        public ICollection<ContractorSkill> ContractorSkills { get; set; }
        public override void Configure(EntityTypeBuilder<Skill> builder)
        {
            throw new NotImplementedException();
        }
    }
}