using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Candidates.Enums;
using AgencyPro.Candidates.Interfaces;
using AgencyPro.Comments.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Roles.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Candidates.Entities
{
    public class Candidate : AuditableEntity<Candidate>, ICandidate
    {
        public OrganizationRecruiter OrganizationRecruiter { get; set; }
        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
        private ICollection<CandidateStatusTransition> _statusTransitions;

        public virtual ICollection<CandidateStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<CandidateStatusTransition>();
            set => _statusTransitions = value;
        }

       public ICollection<CandidateNotification> CandidateNotifications { get; set; }

        public virtual CandidateStatus Status { get; set; }


        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
        public decimal RecruiterStream { get; set; }
        public decimal RecruiterBonus { get; set; }

        public decimal RecruitingAgencyStream { get; set; }
        public decimal RecruitingAgencyBonus { get; set; }

        public bool IsContacted { get; set; }
        public Guid RecruiterId { get; set; }
        public Guid RecruiterOrganizationId { get; set; }
        public Recruiter Recruiter { get; set; }

        public Organization RecruiterOrganization { get; set; }

        public RejectionReason RejectionReason { get; set; }
        public string RejectionDescription { get; set; }

        public Guid? ProjectManagerId { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public Guid? ProjectManagerOrganizationId { get; set; }

        public string Description { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool IsDeleted { get; set; }

        
        public IndividualBonusIntent IndividualBonusIntent { get; set; }
       
        public OrganizationBonusIntent OrganizationBonusIntent { get; set; }
        public override void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder
                 .HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.HasOne(x => x.IndividualBonusIntent)
                .WithOne(x => x.Candidate)
                .HasForeignKey<IndividualBonusIntent>(x => x.CandidateId)
                .IsRequired(false);

            builder.HasOne(x => x.OrganizationBonusIntent)
                .WithOne(x => x.Candidate)
                .HasForeignKey<OrganizationBonusIntent>(x => x.CandidateId)
                .IsRequired(false);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(254);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50);
            builder.Property(x => x.RecruiterStream).HasColumnType("Money");
            builder.Property(x => x.RecruiterBonus).HasColumnType("Money");
            builder.Property(x => x.RecruitingAgencyBonus).HasColumnType("Money");
            builder.Property(x => x.RecruitingAgencyStream).HasColumnType("Money");
            builder.Property(x => x.RejectionDescription).HasMaxLength(1000);

            builder
                .Property(p => p.Iso2)
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(p => p.ProvinceState)
                .IsRequired()
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.HasOne(x => x.Recruiter)
                .WithMany(x => x.Candidates)
                .HasForeignKey(x => x.RecruiterId)
                .IsRequired();

            builder.HasOne(x => x.ProjectManager)
                .WithMany(x => x.Candidates)
                .HasForeignKey(x => x.ProjectManagerId)
                .IsRequired(false);

            builder.OwnsMany(x => x.StatusTransitions, a =>
            {
                a.WithOwner().HasForeignKey(x => x.CandidateId);
                a.HasKey(x => x.Id);
                a.Property(x => x.Id).ValueGeneratedOnAdd();
                a.Ignore(x => x.ObjectState);
                a.Property(x => x.Created).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            });

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.OrganizationProjectManager)
                .WithMany(x => x.Candidates)
                .HasForeignKey(x => new
                {
                    x.ProjectManagerOrganizationId,
                    x.ProjectManagerId
                }).OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.Candidates)
                .HasForeignKey(x => x.ProviderOrganizationId)
                .IsRequired();

            AddAuditProperties(builder, true);
        }
    }
}