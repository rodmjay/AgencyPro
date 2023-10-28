using System;
using AgencyPro.Agreements.Enums;
using AgencyPro.Agreements.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.MarketingOrganizations.Entities;
using AgencyPro.ProviderOrganizations.Entities;
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
            throw new NotImplementedException();
        }
    }
}