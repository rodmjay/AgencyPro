using System;
using System.Collections.Generic;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.FinancialAccounts.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.People.Enums;
using AgencyPro.People.Interfaces;
using AgencyPro.Roles.Entities;
using AgencyPro.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.People.Entities
{
    public class Person : AuditableEntity<Person>, IPerson
    {
        public string ReferralCode { get; set; }
        public string SSNLast4;
        public Customer Customer { get; set; }
        public Contractor Contractor { get; set; }
        public Marketer Marketer { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public AccountManager AccountManager { get; set; }
        public IndividualFinancialAccount IndividualFinancialAccount { get; set; }

        public Recruiter Recruiter { get; set; }

        public User User { get; set; }
        public ICollection<PersonNotification> PersonNotifications { get; set; }
        public ICollection<OrganizationPerson> OrganizationPeople { get; set; }
        public ICollection<IndividualPayoutIntent> PayoutIntents { get; set; }
        public ICollection<IndividualBonusIntent> BonusIntents { get; set; }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }

        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
        public string PostalCode { get; set; }
        
        public PersonStatus Status { get; set; }
    
   

        public string DisplayName
        {
            get => FirstName + " " + LastName;
            private set { }
        }
        

        public bool TosAcceptance { get; set; }
        public string TaxId { get; set; }
        public DateTime? TosShownAndAcceptedDate { get; set; }
        public string TosIpAddress { get; set; }
        public string TosUserAgent { get; set; }
        public bool DetailsSubmitted { get; set; }
        public long? DobDay { get; set; }
        public long? DobMonth { get; set; }
        public long? DobYear { get; set; }
        public string Gender { get; set; }
        public string MaidenName { get; set; }
        
        public Lead Lead { get; set; }
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            // id properties
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            // name properties
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
            builder.Property(p => p.DisplayName).HasComputedColumnSql("[FirstName] + ' ' + [LastName]");


            builder.Property(x => x.ImageUrl).HasMaxLength(500);
            builder.Property(x => x.Address).HasMaxLength(100);
            builder.Property(x => x.Address2).HasMaxLength(100);

            builder
                .Property(p => p.Iso2)
                .HasColumnType("char(2)")
                .HasDefaultValue("US")
                .HasMaxLength(2);

            builder.Property(p => p.ProvinceState)
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder
                .Property(p => p.City)
                .HasMaxLength(200);

            builder
                .HasOne(t => t.User)
                .WithOne(x => x.Person)
                .HasForeignKey<Person>(b => b.Id)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasMany(x => x.OrganizationPeople)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId);

            builder.HasOne(x => x.Lead)
                .WithOne(x => x.Person)
                .HasForeignKey<Lead>(x => x.PersonId)
                .IsRequired(false);

            builder.HasMany(x => x.PayoutIntents)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId)
                .IsRequired(true);

            AddAuditProperties(builder);
        }
    }
}