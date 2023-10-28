using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BillingCategories.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Entities;
using AgencyPro.Stories.Entities;
using AgencyPro.Stripe.Entities;
using AgencyPro.TimeEntries.Enums;
using AgencyPro.TimeEntries.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.TimeEntries.Entities
{
    public class TimeEntry : BaseEntity<TimeEntry>, ITimeEntry
    {


        private ICollection<TimeEntryStatusTransition> _statusTransitions;

        public virtual ICollection<TimeEntryStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<TimeEntryStatusTransition>();
            set => _statusTransitions = value;
        }

        public BillingCategory BillingCategory { get; set; }
        public Contract Contract { get; set; }
        public Story Story { get; set; }

        public string InvoiceItemId { get; set; }
        public StripeInvoiceItem InvoiceItem { get; set; }
        
        public Guid ContractId { get; set; }

        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public Guid? StoryId { get; set; }

        public Guid Id { get; set; }
        public string Notes { get; set; }
        
        public int TimeType { get; set; }
        

        public TimeStatus Status { get; set; }

        public decimal InstantContractorStream { get; set; }
        public string RejectionReason { get; set; }
        public decimal InstantRecruiterStream { get; set; }
        public decimal InstantMarketerStream { get; set; }
        public decimal InstantProjectManagerStream { get; set; }
        public decimal InstantAccountManagerStream { get; set; }
        public decimal InstantSystemStream { get; set; }
        public decimal InstantAgencyStream { get; set; }
        public decimal InstantRecruitingAgencyStream { get; set; }
        public decimal InstantMarketingAgencyStream { get; set; }

        public Guid RecruitingOrganizationId { get; set; }
        public Guid RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }
        public OrganizationRecruiter OrganizationRecruiter { get; set; }
        public Guid MarketerId { get; set; }
        public Guid MarketingOrganizationId { get; set; }
        public Marketer Marketer { get; set; }
        public OrganizationMarketer OrganizationMarketer { get; set; }
        public Guid ProjectManagerId { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public OrganizationProjectManager OrganizationProjectManager { get; set; }
        public Guid AccountManagerId { get; set; }
        public AccountManager AccountManager { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public Guid ContractorId { get; set; }
        public Contractor Contractor { get; set; }
        public OrganizationContractor OrganizationContractor { get; set; }

        public Guid ProviderAgencyOwnerId { get; set; }
        public Customer ProviderAgencyOwner { get; set; }

        public Guid MarketingAgencyOwnerId { get; set; }
        public Customer MarketingAgencyOwner { get; set; }

        public Guid RecruitingAgencyOwnerId { get; set; }
        public Customer RecruitingAgencyOwner { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public Customer Customer { get; set; }
        
        public decimal TotalContractorStream
        {
            get => InstantContractorStream * TotalHours;
            set { }
        }

        public decimal TotalRecruiterStream
        {
            get => InstantRecruiterStream * TotalHours;
            set { }
        }

        public decimal TotalMarketerStream
        {
            get => InstantMarketerStream * TotalHours;
            set { }
        }

        public decimal TotalProjectManagerStream
        {
            get => InstantProjectManagerStream * TotalHours;
            set { }
        }

        public decimal TotalAccountManagerStream
        {
            get => InstantAccountManagerStream * TotalHours;
            set { }
        }

        public decimal TotalSystemStream
        {
            get => InstantSystemStream * TotalHours;
            set { }
        }

        public decimal TotalAgencyStream
        {
            get => InstantAgencyStream * TotalHours;
            set { }
        }

        public decimal TotalRecruitingAgencyStream
        {
            get => InstantRecruitingAgencyStream * TotalHours;
            set { }
        }

        public decimal TotalRecruitingStream
        {
            get => TotalRecruiterStream + TotalRecruitingAgencyStream;
            set { }
        }

        public decimal TotalMarketingStream
        {
            get => TotalMarketerStream + TotalMarketingAgencyStream;
            set { }
        }

        public decimal TotalMarketingAgencyStream
        {
            get => InstantMarketingAgencyStream * TotalHours;
            set { }
        }

        public DateTimeOffset Updated { get; set; }

        public decimal TotalCustomerAmount
        {
            get => (
                       InstantAgencyStream +
                       InstantSystemStream +
                       InstantAccountManagerStream +
                       InstantContractorStream +
                       InstantMarketerStream +
                       InstantRecruiterStream +
                       InstantProjectManagerStream +
                       InstantRecruitingAgencyStream + 
                       InstantMarketingAgencyStream
                  ) * TotalHours;
            set { }
        }

        public int TotalMinutes
        {
            get => Convert.ToInt32((EndDate - StartDate).TotalMinutes);
            set { }
        }

        public decimal TotalHours
        {
            get => Convert.ToDecimal((EndDate - StartDate).TotalHours);
            set { }
        }

        public DateTimeOffset Created { get; set; }

        public string ConcurrencyStamp { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }

        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<TimeEntry> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Story)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.StoryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.BillingCategory)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.TimeType);

            builder.HasQueryFilter(z => !z.IsDeleted);

            var totalHoursComputation = @"(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)";
            var totalMinutesComputation = @"DATEDIFF(minute, [StartDate], [EndDate])";

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(x => x.TotalMinutes).HasComputedColumnSql(totalMinutesComputation);
            builder.Property(x => x.TotalHours).HasComputedColumnSql(totalHoursComputation);
            builder
                .HasOne(x => x.Contract)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.ContractId)
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.BuyerTimeEntries)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationCustomer)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId
                })
                .IsRequired();

            builder.HasOne(x => x.Project)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.ProjectId)
                .IsRequired();

            builder.OwnsMany(x => x.StatusTransitions, a =>
            {
                a.WithOwner().HasForeignKey(x => x.TimeEntryId);
                a.HasKey(x => x.Id);
                a.Property(x => x.Id).ValueGeneratedOnAdd();
                a.Ignore(x => x.ObjectState);
                a.Property(x => x.Created).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            });

            builder.Property(x => x.InstantAccountManagerStream).HasColumnType("Money");
            builder.Property(x => x.InstantProjectManagerStream).HasColumnType("Money");
            builder.Property(x => x.InstantContractorStream).HasColumnType("Money");
            builder.Property(x => x.InstantMarketerStream).HasColumnType("Money");
            builder.Property(x => x.InstantRecruiterStream).HasColumnType("Money");
            builder.Property(x => x.InstantAgencyStream).HasColumnType("Money");
            builder.Property(x => x.InstantRecruitingAgencyStream).HasColumnType("Money");
            builder.Property(x => x.InstantMarketingAgencyStream).HasColumnType("Money");
            builder.Property(x => x.InstantSystemStream).HasColumnType("Money");

            builder.Property(x => x.TotalRecruitingAgencyStream)
                .HasComputedColumnSql($@"[InstantRecruitingAgencyStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalMarketingAgencyStream)
                .HasComputedColumnSql($@"[InstantMarketingAgencyStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalAccountManagerStream)
                .HasComputedColumnSql($@"[InstantAccountManagerStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalContractorStream)
                .HasComputedColumnSql($@"[InstantContractorStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalRecruiterStream)
                .HasComputedColumnSql($@"[InstantRecruiterStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalMarketerStream)
                .HasComputedColumnSql($@"[InstantMarketerStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalProjectManagerStream)
                .HasComputedColumnSql($@"[InstantProjectManagerStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalAgencyStream)
                .HasComputedColumnSql($@"[InstantAgencyStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalSystemStream)
                .HasComputedColumnSql($@"[InstantSystemStream]*{totalHoursComputation}");
            builder.Property(x => x.TotalCustomerAmount)
                .HasComputedColumnSql($@"([InstantSystemStream]+[InstantAccountManagerStream]+[InstantProjectManagerStream]+[InstantMarketerStream]+[InstantRecruiterStream]+[InstantContractorStream]+[InstantAgencyStream]+[InstantRecruitingAgencyStream]+[InstantMarketingAgencyStream])*{totalHoursComputation}");

            builder.Property(x => x.TotalRecruitingStream)
                .HasComputedColumnSql($@"([InstantRecruitingAgencyStream]*{totalHoursComputation})+([InstantRecruiterStream]*{totalHoursComputation})");
            builder.Property(x => x.TotalMarketingStream)
                .HasComputedColumnSql($@"([InstantMarketingAgencyStream]*{totalHoursComputation})+([InstantMarketerStream]*{totalHoursComputation})");


            builder.HasOne(x => x.InvoiceItem)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.InvoiceItemId)
                .OnDelete(DeleteBehavior.SetNull);


            builder.HasOne(x => x.Recruiter)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.RecruiterId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationRecruiter)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => new
                {
                    x.RecruitingOrganizationId,
                    x.RecruiterId
                });

            builder.HasOne(x => x.Contractor)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.ContractorId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationContractor)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.ContractorId
                });

            builder.HasOne(x => x.Marketer)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.MarketerId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationMarketer)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => new
                {
                    x.MarketingOrganizationId,
                    x.MarketerId
                });

            builder.HasOne(x => x.ProjectManager)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.ProjectManagerId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationProjectManager)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.ProjectManagerId
                });

            builder.HasOne(x => x.AccountManager)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired();

            builder.HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.TimeEntries)
                .HasForeignKey(x => new
                {
                    x.ProviderOrganizationId,
                    x.AccountManagerId
                });

            builder.HasOne(x => x.RecruitingAgencyOwner)
                .WithMany(x => x.RecruitingTimeEntries)
                .HasForeignKey(x => x.RecruitingAgencyOwnerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.MarketingAgencyOwner)
                .WithMany(x => x.MarketingTimeEntries)
                .HasForeignKey(x => x.MarketingAgencyOwnerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ProviderAgencyOwner)
                .WithMany(x => x.ProviderTimeEntries)
                .HasForeignKey(x => x.ProviderAgencyOwnerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            AddAuditProperties(builder);
        }
    }
}