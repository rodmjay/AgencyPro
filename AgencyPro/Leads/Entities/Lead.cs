using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Comments.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Leads.Enums;
using AgencyPro.Leads.Interfaces;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.People.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Roles.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Leads.Entities
{
    public class Lead : AuditableEntity<Lead>, ILead
    {
        public OrganizationMarketer OrganizationMarketer { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
        public Marketer Marketer { get; set; }
        public Guid ProviderOrganizationId { get; set; }

        public bool IsInternal
        {
            get { return MarketerOrganizationId == ProviderOrganizationId; }
            set
            {

            }
        }

        public Organization MarketerOrganization { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }


        public ICollection<LeadNotification> LeadNotifications { get; set; }

        private ICollection<LeadStatusTransition> _statusTransitions;

        public virtual ICollection<LeadStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<LeadStatusTransition>();
            set => _statusTransitions = value;
        }
        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string OrganizationName { get; set; }
        public string ReferralCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
        public string Description { get; set; }
        public decimal MarketerStream { get; set; }
        public decimal MarketerBonus { get; set; }
        public decimal MarketingAgencyStream { get; set; }
        public decimal MarketingAgencyBonus { get; set; }

        public LeadStatus Status { get; set; }

        public bool IsContacted { get; set; }

        public Guid? AccountManagerOrganizationId { get; set; }
        public Guid? AccountManagerId { get; set; }
        public AccountManager AccountManager { get; set; }
        public Guid? PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime? CallbackDate { get; set; }
        public string MeetingNotes { get; set; }
        public string RejectionReason { get; set; }

        public Guid CreatedById { get; set; }

        public Guid UpdatedById { get; set; }
        public string ConcurrencyStamp { get; set; }
        public bool IsDeleted { get; set; }

        public IndividualBonusIntent IndividualBonusIntent { get; set; }
        public OrganizationBonusIntent OrganizationBonusIntent { get; set; }

        public override void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(x => x.OrganizationName).HasMaxLength(50);
            builder.Property(x => x.MeetingNotes).IsRequired(false).HasMaxLength(5000);
            builder.Property(x => x.MarketerStream).IsRequired().HasColumnType("Money");
            builder.Property(x => x.MarketingAgencyStream).IsRequired().HasColumnType("Money");
            builder.Property(x => x.MarketingAgencyBonus).IsRequired().HasColumnType("Money");
            builder.Property(x => x.MarketerBonus).IsRequired().HasColumnType("Money");
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);

            builder.HasOne(x => x.IndividualBonusIntent)
                .WithOne(x => x.Lead)
                .HasForeignKey<IndividualBonusIntent>(x => x.LeadId)
                .IsRequired(false);

            builder.HasOne(x => x.OrganizationBonusIntent)
                .WithOne(x => x.Lead)
                .HasForeignKey<OrganizationBonusIntent>(x => x.LeadId)
                .IsRequired(false);


            builder.OwnsMany(x => x.StatusTransitions, a =>
            {
                a.WithOwner().HasForeignKey(x => x.LeadId);
                a.HasKey(x => x.Id);
                a.Property(x => x.Id).ValueGeneratedOnAdd();
                a.Ignore(x => x.ObjectState);
                a.Property(x => x.Created).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            });

            builder.Property(x => x.IsInternal)
                .HasComputedColumnSql(@"case when [MarketerOrganizationId]=[ProviderOrganizationId] then cast(1 as bit) else cast(0 as bit) end");


            builder
                .Property(p => p.Iso2)
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(p => p.ProvinceState)
                .IsRequired()
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.HasOne(x => x.OrganizationMarketer)
                .WithMany(x => x.Leads)
                .HasForeignKey(x => new
                {
                    x.MarketerOrganizationId,
                    x.MarketerId
                }).IsRequired();

            builder.HasOne(x => x.AccountManager)
                .WithMany(x => x.Leads)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired(false);

            builder.HasOne(x => x.Marketer)
                .WithMany(x => x.Leads)
                .HasForeignKey(x => x.MarketerId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.Leads)
                .HasForeignKey(x => new
                {
                    OrganizationId = x.AccountManagerOrganizationId,
                    x.AccountManagerId
                }).IsRequired(false);

            builder.HasOne(x => x.MarketerOrganization)
                .WithMany(x => x.Leads)
                .HasForeignKey(x => x.MarketerOrganizationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.Leads)
                .HasForeignKey(x => x.ProviderOrganizationId)
                .IsRequired();

            builder.HasOne(x => x.Person)
                .WithOne(x => x.Lead)
                .HasForeignKey<Lead>(x => x.PersonId);

            AddAuditProperties(builder);
        }
    }
}