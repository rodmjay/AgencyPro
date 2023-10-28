using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.Levels.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Positions.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Roles.Entities;
using AgencyPro.Stories.Entities;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class OrganizationContractor : BaseEntity<OrganizationContractor>
    {
        public Guid OrganizationId { get; set; }
        public Guid ContractorId { get; set; }

        public decimal ContractorStream { get; set; }

        public OrganizationPerson OrganizationPerson { get; set; }

        public ICollection<ProviderOrganization> DefaultOrganizations { get; set; }
        public Organization Organization { get; set; }
        public Contractor Contractor { get; set; }

        public bool IsFeatured { get; set; }
        public string Biography { get; set; }
        public string PortfolioMediaUrl { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Story> Stories { get; set; }

        public bool IsDeleted { get; set; }
        public virtual string ConcurrencyStamp { get; set; }


        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public int? LevelId { get; set; }
        public Level Level { get; set; }
        public int? PositionId { get; set; }
        public Position Position { get; set; }

        public bool AutoApproveTimeEntries { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationContractor> builder)
        {
            builder
                .HasKey(x => new
                {
                    x.OrganizationId,
                    x.ContractorId
                });

            builder.Property(x => x.ContractorStream)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.Contractors)
                .HasForeignKey(x => x.OrganizationId);

            builder
                .HasMany(x => x.Contracts)
                .WithOne(x => x.OrganizationContractor)
                .HasForeignKey(x => new
                {
                    x.ContractorOrganizationId,
                    x.ContractorId
                });

            builder
                .HasMany(x => x.Stories)
                .WithOne(x => x.OrganizationContractor)
                .HasForeignKey(x => new
                {
                    x.ContractorOrganizationId,
                    x.ContractorId
                });

            builder.HasOne(x => x.OrganizationPerson)
                .WithOne(x => x.Contractor);

            builder
                .HasOne(x => x.OrganizationPerson)
                .WithOne(x => x.Contractor)
                .HasForeignKey<OrganizationContractor>(x => new
                {
                    x.OrganizationId,
                    x.ContractorId
                })
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(x => x.Position)
                .WithMany(x => x.Contractors)
                .HasForeignKey(x => x.PositionId)
                .IsRequired(false);

            builder.HasOne(x => x.Level)
                .WithMany(x => x.Contractors)
                .HasForeignKey(x => x.LevelId)
                .IsRequired(false);

            AddAuditProperties(builder);
        }
    }
}