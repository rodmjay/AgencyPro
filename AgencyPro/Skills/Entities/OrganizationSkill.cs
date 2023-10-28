using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Skills.Interfaces;
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
            throw new NotImplementedException();
        }
    }
}