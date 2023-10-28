using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Agreements.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.MarketingOrganizations.Interfaces;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.MarketingOrganizations.Entities
{
    public class MarketingOrganization : BaseEntity<MarketingOrganization>, IMarketingOrganization
    {
        public Guid Id { get; set; }
        [ForeignKey("Id")] public Organization Organization { get; set; }

        public decimal MarketerStream { get; set; }
        public decimal MarketingAgencyStream { get; set; }
        public decimal MarketerBonus { get; set; }
        public decimal MarketingAgencyBonus { get; set; }

        public bool Discoverable { get; set; }

        public decimal ServiceFeePerLead { get; set; }
        
        public ICollection<Contract> MarketerContracts { get; set; }
        public OrganizationMarketer DefaultOrganizationMarketer { get; set; }
        public Guid DefaultMarketerId { get; set; }

        public ICollection<MarketingAgreement> MarketingAgreements { get; set; }

        public decimal CombinedMarketingStream
        {
            get => MarketerStream + MarketingAgencyStream;
            set
            {

            }
        }

        public decimal CombinedMarketingBonus
        {
            get => MarketerBonus + MarketingAgencyBonus + ServiceFeePerLead;
            set
            {

            }
        }


        public override void Configure(EntityTypeBuilder<MarketingOrganization> builder)
        {
            throw new NotImplementedException();
        }
    }
}