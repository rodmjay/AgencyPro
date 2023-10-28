using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Candidates.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.People.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Interfaces;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Roles.Entities
{
    public class ProjectManager : AuditableEntity<ProjectManager>, IProjectManager
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public ICollection<OrganizationProjectManager> OrganizationProjectManagers { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }

        public Guid Id { get; set; }
       

        public override void Configure(EntityTypeBuilder<ProjectManager> builder)
        {
            builder
                .HasOne(x => x.Person)
                .WithOne(x => x.ProjectManager)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}