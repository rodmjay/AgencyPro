using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Agreements.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.RecruitingOrganizations.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.RecruitingOrganizations.Entities
{
    public class RecruitingOrganization : BaseEntity<RecruitingOrganization>, IRecruitingOrganization
    {
        public Guid Id { get; set; }
        [ForeignKey("Id")] public Organization Organization { get; set; }

        public ICollection<Contract> RecruiterContracts { get; set; }
        public ICollection<RecruitingAgreement> RecruitingAgreements { get; set; }


        public decimal RecruiterStream { get; set; }
        public decimal RecruitingAgencyStream { get; set; }
        public decimal RecruiterBonus { get; set; }
        public decimal RecruitingAgencyBonus { get; set; }

        public bool Discoverable { get; set; }

        public decimal ServiceFeePerLead { get; set; }

  
        public Guid DefaultRecruiterId { get; set; }
        public OrganizationRecruiter DefaultOrganizationRecruiter { get; set; }

        public decimal CombinedRecruitingStream
        {
            get => RecruiterStream + RecruitingAgencyStream;
            set
            {

            }
        }

        public decimal CombinedRecruitingBonus
        {
            get => RecruiterBonus + RecruitingAgencyBonus + ServiceFeePerLead;
            set
            {

            }
        }
        //public OrganizationJoinSettings ProviderEngagementSettings { get; set; }
        //public decimal CombinedRecruitingStream
        //{
        //    get => RecruiterStream + RecruitingAgencyStream;
        //    set
        //    {

        //    }
        //}
        public override void Configure(EntityTypeBuilder<RecruitingOrganization> builder)
        {
            throw new NotImplementedException();
        }
    }
}