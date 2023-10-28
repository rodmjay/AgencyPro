using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BillingCategories.Entities
{
    
    public class OrganizationBillingCategory : BaseEntity<OrganizationBillingCategory>
    {
        public Guid OrganizationId { get; set; }
        public int BillingCategoryId { get; set; }

        public Organization Organization { get; set; }
        public BillingCategory BillingCategory { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationBillingCategory> builder)
        {
            builder.HasKey(x => new
            {
                x.OrganizationId,
                x.BillingCategoryId
            });

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.BillingCategories)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasOne(x => x.BillingCategory)
                .WithMany(x => x.OrganizationBillingCategories)
                .HasForeignKey(x => x.BillingCategoryId);

            AddAuditProperties(builder);
        }
    }
}
