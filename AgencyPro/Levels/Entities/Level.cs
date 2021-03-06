﻿using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Positions.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Levels.Entities
{
    public class Level : BaseEntity<Level>
    {
        public int Id { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public string Name { get; set; }

        public ICollection<OrganizationContractor> Contractors { get; set; }

        public override void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.Position)
                .WithMany(x => x.Levels)
                .HasForeignKey(x => x.PositionId);
        }
    }
}
