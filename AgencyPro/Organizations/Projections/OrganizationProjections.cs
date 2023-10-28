using System.Linq;
using AgencyPro.Agreements.Enums;
using AgencyPro.Candidates.Enums;
using AgencyPro.Leads.Enums;
using AgencyPro.Orders.Enums;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.Organizations.Entities;
using AgencyPro.Organizations.Models;
using AgencyPro.Proposals.Enums;
using AgencyPro.ProviderOrganizations.Models;
using AgencyPro.RecruitingOrganizations.Models;
using AgencyPro.TimeEntries.Enums;
using AutoMapper;

namespace AgencyPro.Organizations.Projections
{
    public partial class OrganizationProjections : Profile
    {
        public OrganizationProjections()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<Organization, OrganizationOutput>()

                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))

                .ForMember(x => x.PrimaryColor, opt => opt.MapFrom(x => x.PrimaryColor))
                .ForMember(x => x.SecondaryColor, opt => opt.MapFrom(x => x.SecondaryColor))
                .ForMember(x => x.TertiaryColor, opt => opt.MapFrom(x => x.TertiaryColor))
                .ForMember(x => x.OrganizationType, opt => opt.MapFrom(x => x.OrganizationType))
                .IncludeAllDerived();
            
            CreateMap<Organization, ProviderOrganizationOutput>()
                .ForMember(x => x.EstimationBasis, opt => opt.MapFrom(x => x.ProviderOrganization.EstimationBasis))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => x.ImageUrl))
                .ForMember(x => x.Description, opt => opt.MapFrom(x => x.Description))
                .ForMember(x => x.OrganizationType, opt => opt.MapFrom(x => x.OrganizationType))
                .ForMember(x => x.PrimaryColor, opt => opt.MapFrom(x => x.PrimaryColor))
                .ForMember(x => x.SecondaryColor, opt => opt.MapFrom(x => x.SecondaryColor))
                .ForMember(x => x.TertiaryColor, opt => opt.MapFrom(x => x.TertiaryColor))
                .ForMember(x => x.ProviderInformation, opt => opt.MapFrom(x => x.ProviderInformation))
               
                .IncludeAllDerived();

            CreateMap<Organization, CustomerProviderOrganizationOutput>()
                .ForMember(x => x.Skills,
                    opt => opt.MapFrom(x => x.ProviderOrganization.Skills.ToDictionary(z => z.SkillId, y => y.Priority)));

            CreateMap<Organization, CustomerOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<Organization, ContractorOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<Organization, RecruiterOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<Organization, RecruitingOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<Organization, ProjectManagerOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<Organization, CustomerOrganizationDetailsOutput>()
                .ForMember(x => x.BuyerAccount, opt => opt.MapFrom(x => x.OrganizationBuyerAccount));

            CreateMap<Organization, AccountManagerOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<Organization, AccountManagerOrganizationDetailsOutput>()
                .ForMember(x => x.AvailableBillingCategories, opt => opt.MapFrom(x => x.Category.AvailableBillingCategories.Select(y => y.BillingCategory)))
                .ForMember(x => x.BillingCategories, opt => opt.MapFrom(x => x.BillingCategories.Select(y => y.BillingCategory)));


            CreateMap<Organization, ProviderAgencyOwnerOrganizationOutput>()
                .ForMember(x => x.TotalContractors, opt => opt.MapFrom(x => x.Contractors.Count))
                .ForMember(x => x.TotalContracts,
                    opt => opt.MapFrom(x => x.Contractors.SelectMany(y => y.Contracts).Count()))
                .ForMember(x => x.TotalProjects,
                    opt => opt.MapFrom(x => x.ProjectManagers.SelectMany(y => y.Projects).Count()))
                .ForMember(x => x.TotalAccounts,
                    opt => opt.MapFrom(x => x.AccountManagers.SelectMany(y => y.Accounts).Count()))
                .ForMember(x => x.TotalAccountManagers, opt => opt.MapFrom(x => x.AccountManagers.Count))
                .ForMember(x => x.TotalProjectManagers, opt => opt.MapFrom(x => x.ProjectManagers.Count))
                .ForMember(x => x.TotalRecruiters, opt => opt.MapFrom(x => x.Recruiters.Count))
                .ForMember(x => x.TotalMarketers, opt => opt.MapFrom(x => x.Marketers.Count))
                .ForMember(x => x.TotalCustomers, opt => opt.MapFrom(x => x.Customers.Count))
                .ForMember(x => x.DefaultContractorStream, opt => opt.MapFrom(x => x.ProviderOrganization.ContractorStream))
                .ForMember(x => x.MaxWeeklyHours,
                    opt => opt.MapFrom(x => x.Contractors.SelectMany(y => y.Contracts).Sum(z => z.MaxWeeklyHours)))
                .IncludeAllDerived();

            CreateMap<Organization, AgencyOwnerOrganizationDetailsOutput>()

                // todo verify this doesn't break anything.
                .ForMember(x => x.FinancialAccount, opt => opt.MapFrom(x => x.OrganizationFinancialAccount.FinancialAccount))
                .ForMember(x => x.BuyerAccount, opt => opt.MapFrom(x => x.OrganizationBuyerAccount.BuyerAccount))
                .ForMember(x => x.ProviderOrganizationDetails, opt => opt.MapFrom(x => x.ProviderOrganization))
                .ForMember(x => x.MarketingOrganizationDetails, opt => opt.MapFrom(x => x.MarketingOrganization))
                .ForMember(x => x.RecruitingOrganizationDetails, opt => opt.MapFrom(x => x.RecruitingOrganization));

            CreateMap<Organization, AgencyOwnerProviderOrganizationDetailsOutput>()
                .ForMember(x => x.AvailablePositions, opt => opt.MapFrom(x => x.Category.Positions.Select(y => y.Position)))
                .ForMember(x => x.AvailablePaymentTerms, opt => opt.MapFrom(x => x.Category.AvailablePaymentTerms.Select(y => y.PaymentTerm)))
                .ForMember(x => x.Positions, opt => opt.MapFrom(x => x.Positions.Select(y => y.PositionId)))
                .ForMember(x => x.AvailableBillingCategories,
                    opt => opt.MapFrom(x => x.Category.AvailableBillingCategories.Select(y => y.BillingCategory)))
                .ForMember(x => x.AvailableSkills,
                    opt => opt.MapFrom(x => x.Category.AvailableSkills.Select(y => y.Skill)))
                .ForMember(x => x.Skills, opt => opt.MapFrom(x => x.ProviderOrganization.Skills.ToDictionary(z => z.SkillId, y => y.Priority)))
                .ForMember(x => x.PaymentTerms, opt => opt.MapFrom(x => x.PaymentTerms.ToDictionary(z => z.PaymentTermId, y => y.IsDefault)))
                .ForMember(x => x.BillingCategories,
                    opt => opt.MapFrom(x => x.BillingCategories.Select(y => y.BillingCategory)));

            CreateMap<Organization, AgencyOwnerCounts>()

                .ForMember(x => x.TimeEntries, opt => opt.MapFrom(x => x.ProviderOrganization.Projects.SelectMany(y => y.Contracts.SelectMany(z => z.TimeEntries).Where(a => a.Status == TimeStatus.Logged)).Count()))
                .ForMember(x => x.Stories, opt => opt.MapFrom(x => x.ProviderOrganization.Projects.SelectMany(y => y.Stories).Count()))
                .ForMember(x => x.Proposals, opt => opt.MapFrom(x => x.ProviderOrganization.Projects.Count(y => y.Proposal != null && y.Proposal.Status != ProposalStatus.Rejected)))

                .ForMember(x => x.People, opt => opt.MapFrom(x => x.OrganizationPeople.Count))
                .ForMember(x => x.Accounts, opt => opt.MapFrom(x => x.ProviderOrganization.CustomerAccounts.Count))
                .ForMember(x => x.Projects, opt => opt.MapFrom(x => x.ProviderOrganization.Projects.Count))

                .ForMember(x => x.ProviderContracts, opt => opt.MapFrom(x => x.ProviderOrganization.Contracts.Count))
                .ForMember(x => x.RecruitingContracts, opt => opt.MapFrom(x => x.RecruitingOrganization.RecruiterContracts.Count))
                .ForMember(x => x.MarketingContracts, opt => opt.MapFrom(x => x.MarketingOrganization.MarketerContracts.Count))

                .ForMember(x => x.ProviderMarketingPartner, opt => opt.MapFrom(x => x.ProviderOrganization.MarketingAgreements.Count(y => y.Status != AgreementStatus.Rejected)))
                .ForMember(x => x.ProviderRecruitingPartner, opt => opt.MapFrom(x => x.ProviderOrganization.RecruitingAgreements.Count(y => y.Status != AgreementStatus.Rejected)))
                .ForMember(x => x.MarketingPartner, opt => opt.MapFrom(x => x.MarketingOrganization.MarketingAgreements.Count(y => y.Status != AgreementStatus.Rejected)))
                .ForMember(x => x.RecruitingPartner, opt => opt.MapFrom(x => x.RecruitingOrganization.RecruitingAgreements.Count(y => y.Status != AgreementStatus.Rejected)))

                .ForMember(x => x.Leads, opt => opt.MapFrom(x => x.ProviderOrganization.Leads.Count(y => y.Status == LeadStatus.New)
                            + x.Leads.Count(y => y.IsInternal == false)))
                .ForMember(x => x.Candidates, opt => opt.MapFrom(x => x.ProviderOrganization.Candidates.Count(y => y.Status == CandidateStatus.New)))
                .ForMember(x => x.WorkOrders, opt => opt.MapFrom(x => x.ProviderOrganization.WorkOrders.Count(y => y.Status != OrderStatus.Draft)))
                .ForMember(x => x.Invoices, opt => opt.MapFrom(x => x.ProviderOrganization.Projects.SelectMany(y => y.Invoices).Count()));


            AgreementProjections();
            MarketingOrganizationProjections();
            RecruitingOrganizationProjections();
        }
    }
}