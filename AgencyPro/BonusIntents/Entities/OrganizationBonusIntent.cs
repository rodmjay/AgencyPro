using System;
using AgencyPro.BonusIntents.Enums;
using AgencyPro.BonusIntents.Interfaces;
using AgencyPro.Candidates.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Leads.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Transfers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BonusIntents.Entities
{
    public class OrganizationBonusIntent : AuditableEntity<OrganizationBonusIntent>, IOrganizationBonusIntent
    {
        public Guid Id { get; set; }

        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public BonusType BonusType { get; set; }

        public BonusTransfer BonusTransfer { get; set; }
        public string TransferId { get; set; }

        public decimal Amount { get; set; }
        public string Description { get; set; }
      

        public Guid? LeadId { get; set; }
        public Lead Lead { get; set; }
        public Guid? CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationBonusIntent> builder)
        {
            // id properties
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.BonusIntents)
                .HasForeignKey(x => x.OrganizationId)
                .IsRequired();

            builder.HasOne(x => x.BonusTransfer)
                .WithMany(x => x.OrganizationBonusIntents)
                .HasForeignKey(x => x.TransferId)
                .IsRequired(false);

            AddAuditProperties(builder);
        }
    }
}