using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Skills.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Skills.Entities
{
    public class OrganizationSkill : AuditableEntity<OrganizationSkill>, IOrganizationSkill
    {
        public ProviderOrganization Organization { get; set; }
        public Skill Skill { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid SkillId { get; set; }
        public int Priority { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationSkill> builder)
        {
            builder
                .HasKey(x => new
                {
                    x.OrganizationId,
                    x.SkillId
                });

            builder
                .HasOne(x => x.Organization)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Skill)
                .WithMany(x => x.OrganizationSkill)
                .HasForeignKey(x => x.SkillId)
                .OnDelete(DeleteBehavior.Cascade);

            AddAuditProperties(builder);
        }
    }
}