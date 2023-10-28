using System;
using AgencyPro.Agreements.Enums;
using AgencyPro.Agreements.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.RecruitingOrganizations.Entities;
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
            throw new NotImplementedException();
        }
    }
}