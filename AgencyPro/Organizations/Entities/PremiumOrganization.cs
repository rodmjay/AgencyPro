using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class PremiumOrganization : BaseEntity<PremiumOrganization>
    {
        [ForeignKey("Id")] public Organization Organization { get; set; }

        public override void Configure(EntityTypeBuilder<PremiumOrganization> builder)
        {
            builder
                .HasOne(x => x.Organization)
                .WithOne(x => x.PremiumOrganization)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}