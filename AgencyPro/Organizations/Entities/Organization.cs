using System;
using System.Collections.Generic;
using AgencyPro.BillingCategories.Entities;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Candidates.Entities;
using AgencyPro.Categories.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.FinancialAccounts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.MarketingOrganizations.Entities;
using AgencyPro.Orders.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Enums;
using AgencyPro.Organizations.Interfaces;
using AgencyPro.PaymentTerms.Entities;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.Positions.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.RecruitingOrganizations.Entities;
using AgencyPro.Retainers.Entities;
using AgencyPro.StoryTemplates.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Organizations.Entities
{
    public class Organization : AuditableEntity<Organization>, IOrganization
    {
        public Category Category { get; set; }

        public PremiumOrganization PremiumOrganization { get; set; }
        public MarketingOrganization MarketingOrganization { get; set; }
        public RecruitingOrganization RecruitingOrganization { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }

        public ICollection<OrganizationProjectManager> ProjectManagers { get; set; }
        public ICollection<OrganizationAccountManager> AccountManagers { get; set; }
        public ICollection<OrganizationContractor> Contractors { get; set; }
        public ICollection<OrganizationCustomer> Customers { get; set; }
        public ICollection<OrganizationRecruiter> Recruiters { get; set; }
        public ICollection<OrganizationMarketer> Marketers { get; set; }
        public ICollection<OrganizationPosition> Positions { get; set; }

        public ICollection<ProjectInvoice> ProviderInvoices { get; set; }
        public ICollection<ProjectInvoice> BuyerInvoices { get; set; }

        public ICollection<Contract> BuyerContracts { get; set; }


        public ICollection<OrganizationPerson> OrganizationPeople { get; set; }
        public ICollection<OrganizationBillingCategory> BillingCategories { get; set; }
        public ICollection<OrganizationPaymentTerm> PaymentTerms { get; set; }

        public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }

        public OrganizationFinancialAccount OrganizationFinancialAccount { get; set; }
        public OrganizationBuyerAccount OrganizationBuyerAccount { get; set; }
        public OrganizationSubscription OrganizationSubscription { get; set; }

        public ICollection<CustomerAccount> BuyerCustomerAccounts { get; set; }

        public ICollection<Project> BuyerProjects { get; set; }
        public ICollection<OrganizationPayoutIntent> PayoutIntents { get; set; }
        public ICollection<OrganizationBonusIntent> BonusIntents { get; set; }
        public ICollection<OrganizationSetting> OrganizationSettings { get; set; }

        public ICollection<Lead> Leads { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<WorkOrder> BuyerWorkOrders { get; set; }
        public ICollection<StoryTemplate> StoryTemplates { get; set; }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string TertiaryColor { get; set; }

        public string ColumnBgColor { get; set; }
        public string MenuBgHoverColor { get; set; }
        public string HoverItemColor { get; set; }
        public string TextColor { get; set; }
        public string ActiveItemColor { get; set; }
        public string ActivePresenceColor { get; set; }
        public string ActiveItemTextColor { get; set; }
        public string MentionBadgeColor { get; set; }


        public int CategoryId { get; set; }

        public OrganizationType OrganizationType { get; set; }
     

        public Guid UpdatedById { get; set; }
        public Guid CreatedById { get; set; }

        public string AffiliateInformation { get; set; }
        public string ProviderInformation { get; set; }
        
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Iso2 { get; set; }
        public string ProvinceState { get; set; }
        public string PostalCode { get; set; }

        public Guid CustomerId { get; set; }
        public Roles.Models.Customer Customer { get; set; }
        public ICollection<ProjectRetainerIntent> BuyerRetainerIntents { get; set; }
        public IEnumerable<ProjectRetainerIntent> ProviderRetainerIntents { get; set; }
        public override void Configure(EntityTypeBuilder<Organization> builder)
        {
            throw new NotImplementedException();
        }
    }
}