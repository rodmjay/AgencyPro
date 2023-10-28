using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class PremiumOrganization : BaseEntity<PremiumOrganization>
    {
        [ForeignKey("Id")] public Organization Organization { get; set; }

        public override void Configure(EntityTypeBuilder<PremiumOrganization> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}