using System;
using System.Collections.Generic;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.FinancialAccounts.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.People.Enums;
using AgencyPro.People.Interfaces;
using AgencyPro.Roles.Models;
using AgencyPro.Users.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.People.Entities
{
    public class Person : AuditableEntity<Person>, IPerson
    {
        public string ReferralCode { get; set; }
        public string SSNLast4;
        public Customer Customer { get; set; }
        public Contractor Contractor { get; set; }
        public Marketer Marketer { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public AccountManager AccountManager { get; set; }
        public IndividualFinancialAccount IndividualFinancialAccount { get; set; }

        public Recruiter Recruiter { get; set; }

        public User User { get; set; }
        public ICollection<PersonNotification> PersonNotifications { get; set; }
        public ICollection<OrganizationPerson> OrganizationPeople { get; set; }
        public ICollection<IndividualPayoutIntent> PayoutIntents { get; set; }
        public ICollection<IndividualBonusIntent> BonusIntents { get; set; }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }

        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
        public string PostalCode { get; set; }
        
        public PersonStatus Status { get; set; }
    
   

        public string DisplayName
        {
            get => FirstName + " " + LastName;
            private set { }
        }
        

        public bool TosAcceptance { get; set; }
        public string TaxId { get; set; }
        public DateTime? TosShownAndAcceptedDate { get; set; }
        public string TosIpAddress { get; set; }
        public string TosUserAgent { get; set; }
        public bool DetailsSubmitted { get; set; }
        public long? DobDay { get; set; }
        public long? DobMonth { get; set; }
        public long? DobYear { get; set; }
        public string Gender { get; set; }
        public string MaidenName { get; set; }
        
        public Lead Lead { get; set; }
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            throw new NotImplementedException();
        }
    }
}