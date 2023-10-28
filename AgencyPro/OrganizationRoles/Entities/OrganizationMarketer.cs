using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.MarketingOrganizations.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationRoles.Entities
{
    public class OrganizationMarketer : AuditableEntity<OrganizationMarketer>
    {
        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public ICollection<MarketingOrganization> OrganizationDefaults { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }

        public Guid MarketerId { get; set; }
        public Marketer Marketer { get; set; }

        public string ReferralCode { get; set; }

        public decimal MarketerStream { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Lead> Leads { get; set; }
        public OrganizationPerson OrganizationPerson { get; set; }

        public bool IsSystemDefault { get; set; }
        public bool IsDeleted { get; set; }
        public virtual string ConcurrencyStamp { get; set; }


        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public decimal MarketerBonus { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationMarketer> builder)
        {
            throw new NotImplementedException();
        }
    }
}