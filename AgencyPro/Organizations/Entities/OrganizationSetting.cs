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
            builder.HasKey(x => new
            {
                x.OrganizationId,
                x.SectionType,
                x.MenuType
            });

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.OrganizationSettings)
                .HasForeignKey(x => x.OrganizationId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

            AddAuditProperties(builder);
        }
    }
}