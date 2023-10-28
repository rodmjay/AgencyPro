using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.People.Entities;
using AgencyPro.Roles.Interfaces;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Roles.Entities
{
    public class Marketer : AuditableEntity<Marketer>, IMarketer
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Lead> Leads { get; set; }

        public ICollection<OrganizationMarketer> OrganizationMarketers { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }

        public Guid Id { get; set; }
       

        public override void Configure(EntityTypeBuilder<Marketer> builder)
        {
            builder
                .HasOne(x => x.Person)
                .WithOne(x => x.Marketer)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}