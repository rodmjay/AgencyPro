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
using AgencyPro.Roles.Models;
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
            throw new NotImplementedException();
        }
    }
}