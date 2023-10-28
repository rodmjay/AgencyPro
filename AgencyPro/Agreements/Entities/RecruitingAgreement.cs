using System;
using AgencyPro.Agreements.Enums;
using AgencyPro.Agreements.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.RecruitingOrganizations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Agreements.Entities
{
    public class RecruitingAgreement : BaseEntity<RecruitingAgreement>, IRecruitingAgreement
    {
        public Guid ProviderOrganizationId { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }

        public Guid RecruitingOrganizationId { get; set; }
        public RecruitingOrganization RecruitingOrganization { get; set; }

        public bool InitiatedByProvider { get; set; }

        public virtual decimal RecruiterStream { get; set; }
        public virtual decimal RecruitingAgencyBonus { get; set; }
        public virtual decimal RecruiterBonus { get; set; }
        public virtual decimal RecruitingAgencyStream { get; set; }

        public string RecruiterInformation { get; set; }


        public decimal RecruitingStream
        {
            get { return RecruiterStream + RecruitingAgencyStream; }
            set { }
        }

        public decimal RecruitingBonus
        {
            get { return RecruiterBonus + RecruitingAgencyBonus; }
            set { }
        }

        public AgreementStatus Status { get; set; }
        public override void Configure(EntityTypeBuilder<RecruitingAgreement> builder)
        {
            builder.HasKey(x => new
            {
                x.ProviderOrganizationId,
                x.RecruitingOrganizationId
            });

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.RecruitingAgreements)
                .HasForeignKey(x => x.ProviderOrganizationId);

            builder.Property(x => x.RecruiterBonus).HasColumnType("Money");
            builder.Property(x => x.RecruitingAgencyBonus).HasColumnType("Money");
            builder.Property(x => x.RecruiterStream).HasColumnType("Money");
            builder.Property(x => x.RecruitingAgencyStream).HasColumnType("Money");


            var recruitingStreamComputation = $@"[{nameof(RecruitingAgreement.RecruitingAgencyStream)}]+[{nameof(RecruitingAgreement.RecruiterStream)}]";
            var recruitingBonusComputation = $@"[{nameof(RecruitingAgreement.RecruitingAgencyBonus)}]+[{nameof(RecruitingAgreement.RecruiterBonus)}]";

            builder.Property(x => x.RecruitingStream).HasComputedColumnSql(recruitingStreamComputation);
            builder.Property(x => x.RecruitingBonus).HasComputedColumnSql(recruitingBonusComputation);

            AddAuditProperties(builder);
        }
    }
}