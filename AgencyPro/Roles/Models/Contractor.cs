using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.People.Entities;
using AgencyPro.Roles.Interfaces;
using AgencyPro.Skills.Entities;
using AgencyPro.Stories.Entities;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Roles.Models
{
    public class Contractor : AuditableEntity<Contractor>, IContractor
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public OrganizationRecruiter OrganizationRecruiter { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Story> Stories { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<OrganizationContractor> OrganizationContractors { get; set; }
        public Guid Id { get; set; }

        public Guid RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }
        public Guid RecruiterOrganizationId { get; set; }

        public bool IsAvailable { get; set; }

        public int HoursAvailable { get; set; }

        public DateTime? LastWorkedUtc { get; set; }

        public ICollection<ContractorSkill> ContractorSkills { get; set; }
        public override void Configure(EntityTypeBuilder<Contractor> builder)
        {
            throw new NotImplementedException();
        }
    }
}