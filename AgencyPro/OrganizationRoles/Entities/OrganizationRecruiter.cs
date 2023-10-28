using System;
using System.Collections.Generic;
using AgencyPro.Candidates.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Organizations.Entities;
using AgencyPro.RecruitingOrganizations.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class OrganizationRecruiter : BaseEntity<OrganizationRecruiter>, IOrganizationRecruiter
    {
        public Organization Organization { get; set; }
        public Recruiter Recruiter { get; set; }

        public OrganizationPerson OrganizationPerson { get; set; }

        public decimal RecruiterStream { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }

        public ICollection<Contractor> Contractors { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public bool IsSystemDefault { get; set; }

        public bool IsDeleted { get; set; }
        public Guid OrganizationId { get; set; }

        public Guid RecruiterId { get; set; }
        public string ConcurrencyStamp { get; set; }


        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public ICollection<RecruitingOrganization> RecruitingOrganizationDefaults { get; set; }
        public decimal RecruiterBonus { get; set; }

        public override void Configure(EntityTypeBuilder<OrganizationRecruiter> builder)
        {
            throw new NotImplementedException();
        }
    }
}