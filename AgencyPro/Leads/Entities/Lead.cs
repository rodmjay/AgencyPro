using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Comments.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Leads.Enums;
using AgencyPro.Leads.Interfaces;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.People.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Roles.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Leads.Entities
{
    public class Lead : AuditableEntity<Lead>, ILead
    {
        public OrganizationMarketer OrganizationMarketer { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
        public Marketer Marketer { get; set; }
        public Guid ProviderOrganizationId { get; set; }

        public bool IsInternal
        {
            get { return MarketerOrganizationId == ProviderOrganizationId; }
            set
            {

            }
        }

        public Organization MarketerOrganization { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }


        public ICollection<LeadNotification> LeadNotifications { get; set; }

        private ICollection<LeadStatusTransition> _statusTransitions;

        public virtual ICollection<LeadStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<LeadStatusTransition>();
            set => _statusTransitions = value;
        }
        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string OrganizationName { get; set; }
        public string ReferralCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
        public string Description { get; set; }
        public decimal MarketerStream { get; set; }
        public decimal MarketerBonus { get; set; }
        public decimal MarketingAgencyStream { get; set; }
        public decimal MarketingAgencyBonus { get; set; }

        public LeadStatus Status { get; set; }

        public bool IsContacted { get; set; }

        public Guid? AccountManagerOrganizationId { get; set; }
        public Guid? AccountManagerId { get; set; }
        public AccountManager AccountManager { get; set; }
        public Guid? PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime? CallbackDate { get; set; }
        public string MeetingNotes { get; set; }
        public string RejectionReason { get; set; }

        public Guid CreatedById { get; set; }

        public Guid UpdatedById { get; set; }
        public string ConcurrencyStamp { get; set; }
        public bool IsDeleted { get; set; }

        public IndividualBonusIntent IndividualBonusIntent { get; set; }
        public OrganizationBonusIntent OrganizationBonusIntent { get; set; }

        public override void Configure(EntityTypeBuilder<Lead> builder)
        {
            throw new NotImplementedException();
        }
    }
}