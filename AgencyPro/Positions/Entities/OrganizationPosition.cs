﻿using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Positions.Entities
{
    public class OrganizationPosition : BaseEntity<OrganizationPosition>
    {
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public override void Configure(EntityTypeBuilder<OrganizationPosition> builder)
        {
            throw new NotImplementedException();
        }
    }
}