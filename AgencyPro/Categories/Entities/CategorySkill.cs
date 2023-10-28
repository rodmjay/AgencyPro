using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Skills.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Categories.Entities
{
    public class CategorySkill : BaseEntity<CategorySkill>
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public override void Configure(EntityTypeBuilder<CategorySkill> builder)
        {
            builder
                .HasKey(sc => new { sc.SkillId, sc.CategoryId });

            builder
                .HasOne(x => x.Skill)
                .WithMany(x => x.SkillCategories)
                .HasForeignKey(x => x.SkillId);

            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.AvailableSkills)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}