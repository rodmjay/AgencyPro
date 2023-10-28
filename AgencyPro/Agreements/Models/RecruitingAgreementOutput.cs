using System;
using AgencyPro.Agreements.Enums;
using AgencyPro.Agreements.Interfaces;

namespace AgencyPro.Agreements.Models
{
    public abstract class RecruitingAgreementOutput : IRecruitingAgreement
    {
        public Guid ProviderOrganizationId { get; set; }
        public Guid RecruitingOrganizationId { get; set; }
        public AgreementStatus Status { get; set; }
        public virtual bool InitiatedByProvider { get; set; }
        
        public virtual decimal RecruitingStream => RecruitingAgencyStream + RecruiterStream;

        public virtual decimal RecruitingBonus => RecruiterBonus + RecruitingAgencyBonus;

        public string RecruitingOrganizationName { get; set; }
        public string RecruiterOrganizationImageUrl { get; set; }

        public string ProviderOrganizationName { get; set; }
        public string ProviderOrganizationImageUrl { get; set; }
        public virtual decimal RecruiterStream { get; set; }
        public virtual decimal RecruitingAgencyBonus { get; set; }
        public virtual decimal RecruiterBonus { get; set; }
        public virtual decimal RecruitingAgencyStream { get; set; }


    }
}