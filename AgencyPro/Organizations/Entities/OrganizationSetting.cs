using System;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class OrganizationSetting : AuditableEntity<OrganizationSetting>
    {
        public Guid OrganizationId { get; set; }

        [ForeignKey(nameof(OrganizationId))]
        public Organization Organization { get; set; }

        public SectionType SectionType { get; set; }
        public MenuType MenuType { get; set; }
        public bool IsEnabled { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationSetting> builder)
        {
            throw new NotImplementedException();
        }
    }
}