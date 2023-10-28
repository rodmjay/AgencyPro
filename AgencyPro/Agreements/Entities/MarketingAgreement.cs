using System;
using AgencyPro.Agreements.Enums;
using AgencyPro.Agreements.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.MarketingOrganizations.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Agreements.Entities
{
    public class MarketingAgreement : BaseEntity<MarketingAgreement>, IMarketingAgreement
    {
        public Guid ProviderOrganizationId { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }

        public Guid MarketingOrganizationId { get; set; }
        public MarketingOrganization MarketingOrganization { get; set; }
        

        public bool InitiatedByProvider { get; set; }

        public decimal MarketerBonus { get; set; }
        public decimal MarketingAgencyStream { get; set; }
        public decimal MarketingAgencyBonus { get; set; }
        public decimal MarketerStream { get; set; }
        public bool RequireUniqueEmail { get; set; }

        public string MarketerInformation { get; set; }

        public decimal MarketingStream
        {
            get { return MarketerStream + MarketingAgencyStream; }
            set { }
        }

        public decimal MarketingBonus
        {
            get { return MarketerBonus + MarketingAgencyBonus; }
            set { }
        }

        public AgreementStatus Status { get; set; }
        public override void Configure(EntityTypeBuilder<MarketingAgreement> builder)
        {
            builder.HasKey(x => new
            {
                x.ProviderOrganizationId,
                x.MarketingOrganizationId
            });

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.MarketingAgreements)
                .HasForeignKey(x => x.ProviderOrganizationId);

            builder.Property(x => x.MarketerBonus).HasColumnType("Money");
            builder.Property(x => x.MarketingAgencyStream).HasColumnType("Money");
            builder.Property(x => x.MarketerStream).HasColumnType("Money");
            builder.Property(x => x.MarketingAgencyBonus).HasColumnType("Money");


            var marketingStreamComputation = $@"[{nameof(MarketingAgreement.MarketingAgencyStream)}]+[{nameof(MarketingAgreement.MarketerStream)}]";
            var marketingBonusComputation = $@"[{nameof(MarketingAgreement.MarketerBonus)}]+[{nameof(MarketingAgreement.MarketingAgencyBonus)}]";

            builder.Property(x => x.MarketingStream).HasComputedColumnSql(marketingStreamComputation);
            builder.Property(x => x.MarketingBonus).HasComputedColumnSql(marketingBonusComputation);

            AddAuditProperties(builder);
        }
    }
}