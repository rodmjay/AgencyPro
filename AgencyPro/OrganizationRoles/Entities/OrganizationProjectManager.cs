using System;
using System.Collections.Generic;
using AgencyPro.Candidates.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Roles.Entities;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class OrganizationProjectManager : BaseEntity<OrganizationProjectManager>, IOrganizationProjectManager
    {
        public Organization Organization { get; set; }
        public ProjectManager ProjectManager { get; set; }

        public OrganizationPerson OrganizationPerson { get; set; }

        public ICollection<ProviderOrganization> DefaultOrganizations { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }

        public decimal ProjectManagerStream { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<Candidate> Candidates { get; set; }

        public bool IsDeleted { get; set; }
        public Guid OrganizationId { get; set; }

        public Guid ProjectManagerId { get; set; }
        public string ConcurrencyStamp { get; set; }


        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public override void Configure(EntityTypeBuilder<OrganizationProjectManager> builder)
        {
            builder.HasKey(x => new { x.OrganizationId, x.ProjectManagerId });

            builder.Property(x => x.ProjectManagerStream).HasColumnType("Money");
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.ProjectManagers)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasMany(x => x.Projects)
                .WithOne(x => x.OrganizationProjectManager)
                .HasForeignKey(x => new { x.ProjectManagerOrganizationId, x.ProjectManagerId });

            builder.HasOne(x => x.OrganizationPerson)
                .WithOne(x => x.ProjectManager)
                .HasForeignKey<OrganizationProjectManager>(x => new { x.OrganizationId, x.ProjectManagerId })
                .OnDelete(DeleteBehavior.Cascade);

            AddAuditProperties(builder);
        }
    }
}