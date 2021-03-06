﻿using System;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PandaDocs
{
    public class PandaDocument : BaseEntity<PandaDocument>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
        public DateTimeOffset? ExpirationDate { get; set; }
        public bool IsDeleted { get; set; }

        public ServiceAgreement ServiceAgreement { get; set; }
        public override void Configure(EntityTypeBuilder<PandaDocument> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ServiceAgreement)
                .WithOne(x => x.Document)
                .HasForeignKey<ServiceAgreement>(x => x.DocumentId);

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.Id).IsRequired();


            AddAuditProperties(builder);
        }
    }
}
