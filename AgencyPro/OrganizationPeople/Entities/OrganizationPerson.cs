using System;
using System.Collections.Generic;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Comments.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.OrganizationPeople.Interfaces;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.People.Entities;
using AgencyPro.People.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.OrganizationPeople.Entities
{
    public class OrganizationPerson : AuditableEntity<OrganizationPerson>, IOrganizationPerson
    {
        public Organization Organization { get; set; }
        public Person Person { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<IndividualPayoutIntent> Payouts { get; set; } 
        public ICollection<IndividualBonusIntent> BonusIntents { get; set; }

        public OrganizationAccountManager AccountManager { get; set; }
        public OrganizationProjectManager ProjectManager { get; set; }
        public OrganizationCustomer Customer { get; set; }
        public OrganizationContractor Contractor { get; set; }
        public OrganizationRecruiter Recruiter { get; set; }
        public OrganizationMarketer Marketer { get; set; }

        public bool IsDeleted { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid PersonId { get; set; }

        public PersonStatus Status { get; set; }

        public bool IsHidden { get; set; }

        public long PersonFlags { get; set; }
        public long AgencyFlags { get; set; }

        public bool IsOrganizationOwner { get; set; }
        public bool IsDefault { get; set; }
      
        public string ConcurrencyStamp { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public string AffiliateCode { get; set; }

        public override void Configure(EntityTypeBuilder<OrganizationPerson> builder)
        {
            builder
                .HasKey(x => new {x.OrganizationId, x.PersonId});

            builder.HasQueryFilter(x => x.IsDeleted == false);
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.HasMany(x => x.Payouts)
                .WithOne(x => x.OrganizationPerson)
                .HasForeignKey(x => new
                {
                    x.OrganizationId,
                    x.PersonId
                }).IsRequired();


            builder
                .HasOne(x => x.Person)
                .WithMany(x => x.OrganizationPeople)
                .HasForeignKey(x => x.PersonId)
                .IsRequired();

            builder
                .HasOne(x => x.Organization)
                .WithMany(x => x.OrganizationPeople)
                .HasForeignKey(x => x.OrganizationId)
                .IsRequired();

            AddAuditProperties(builder);
        }
    }
}