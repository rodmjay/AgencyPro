using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Levels.Entities;
using AgencyPro.OrganizationRoles.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Positions.Entities
{
    public class Position : BaseEntity<Position>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Level> Levels { get; set; }

        public ICollection<CategoryPosition> Categories { get; set; }
        public ICollection<OrganizationContractor> Contractors { get; set; }
        public ICollection<OrganizationPosition> Organizations { get; set; }
        public override void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasMany(x => x.Levels)
                .WithOne(x => x.Position)
                .HasForeignKey(x => x.PositionId);

        }
    }


}
