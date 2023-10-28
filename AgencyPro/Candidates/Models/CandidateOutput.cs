using System;
using System.Collections.Generic;
using System.Linq;
using AgencyPro.Candidates.Enums;
using AgencyPro.Candidates.Interfaces;
using AgencyPro.Organizations.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Candidates.Models
{
    public abstract class CandidateOutput : CandidateInput, ICandidate, IOrganizationPersonTarget
    {
       
        public virtual string ProviderOrganizationName { get; set; }
        public virtual string ProviderOrganizationImageUrl { get; set; }
        public virtual Guid ProviderOrganizationId { get; set; }
        public virtual Guid RecruiterId { get; set; }
        public virtual Guid RecruiterOrganizationId { get; set; }


        public bool IsExternal => RecruiterOrganizationId != this.ProviderOrganizationId;


        public Dictionary<DateTimeOffset, CandidateStatus> StatusTransitions { get; set; }

        public virtual CandidateStatus Status { get
            { return StatusTransitions.OrderByDescending(x => x.Key).Select(x=>x.Value).First(); } }

        public virtual Guid Id { get; set; }

        public virtual decimal RecruitingStream => RecruiterStream + RecruitingAgencyStream;
        public virtual decimal RecruitingBonus => RecruiterBonus + RecruitingAgencyBonus;

        public virtual decimal RecruiterStream { get; set; }
        public virtual decimal RecruiterBonus { get; set; }
        public virtual decimal RecruitingAgencyStream { get; set; }
        public virtual decimal RecruitingAgencyBonus { get; set; }
        public virtual RejectionReason RejectionReason { get; set; }
        public virtual string RejectionDescription { get; set; }
        public virtual Guid? ProjectManagerId { get; set; }
        public virtual Guid? ProjectManagerOrganizationId { get; set; }
        [JsonIgnore] public virtual Guid CreatedById { get; set; }
        [JsonIgnore] public virtual Guid UpdatedById { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        
        public virtual string ProjectManagerImageUrl { get; set; }
        public virtual string ProjectManagerName { get; set; }
        public virtual string ProjectManagerOrganizationName { get; set; }
        public virtual string ProjectManagerOrganizationImageUrl { get; set; }
        public virtual string RecruiterImageUrl { get; set; }
        public virtual string RecruiterName { get; set; }
        public virtual string RecruiterPhoneNumber { get; set; }
        public virtual string RecruiterEmail { get; set; }
        public virtual string RecruiterOrganizationName { get; set; }
        public virtual string RecruiterOrganizationImageUrl { get; set; }
        [JsonIgnore]public abstract Guid TargetOrganizationId { get; }
        [JsonIgnore] public abstract Guid TargetPersonId { get; }

        public virtual Guid RecruitingOrganizationOwnerId { get; set; }
        public virtual Guid ProviderOrganizationOwnerId { get; set; }
    }
}