using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Candidates.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.People.Entities;
using AgencyPro.Roles.Interfaces;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Roles.Models
{
    public class Recruiter : BaseEntity<Recruiter>, IRecruiter
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public ICollection<OrganizationRecruiter> OrganizationRecruiters { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Contractor> Contractors { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }

        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

        public override void Configure(EntityTypeBuilder<Recruiter> builder)
        {
            throw new NotImplementedException();
        }
    }
}