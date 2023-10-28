using System.Linq;
using AgencyPro.Proposals.Entities;
using AgencyPro.Proposals.Models;
using AutoMapper;

namespace AgencyPro.Proposals.Projections
{
    public partial class ProposalProjections : Profile
    {
        public ProposalProjections()
        {
            CreateMap<FixedPriceProposal, FixedPriceProposalOutput>()
                .ForMember(x => x.RetainerPercent, opt => opt.MapFrom(x => x.RetainerPercent))
                .ForMember(x => x.RequiresRetainer, opt => opt.MapFrom(x => x.RetainerPercent > 0))
                .ForMember(x=>x.ProviderOrganizationOwnerId, opt=>opt.MapFrom(x=>x.Project.ProviderOrganization.Organization.CustomerId))
                .ForMember(x => x.ProjectAbbreviation, opt => opt.MapFrom(x => x.Project.Abbreviation))
                .ForMember(x => x.AccountManagerImageUrl,
                    opt => opt.MapFrom(
                        x => x.Project.AccountManager.Person.ImageUrl))
                .ForMember(x => x.AccountManagerEmail,
                    opt => opt.MapFrom(
                        x => x.Project.AccountManager.Person.User.Email))
                .ForMember(x => x.AccountManagerPhoneNumber,
                    opt => opt.MapFrom(
                        x => x.Project.AccountManager.Person.User.PhoneNumber))

                .ForMember(x => x.AccountManagerName,
                    opt => opt.MapFrom(
                        x => x.Project.AccountManager.Person.DisplayName))

                .ForMember(x => x.AccountManagerId,
                    opt => opt.MapFrom(
                        x => x.Project.AccountManagerId))

                .ForMember(x => x.AccountManagerOrganizationImageUrl,
                    opt => opt.MapFrom(
                        x => x.Project.OrganizationAccountManager.Organization.ImageUrl))

                .ForMember(x => x.AccountManagerOrganizationName,
                    opt => opt.MapFrom(
                        x => x.Project.OrganizationAccountManager.Organization.Name))

                .ForMember(x => x.AccountManagerOrganizationId,
                    opt => opt.MapFrom(
                        x => x.Project.OrganizationAccountManager.OrganizationId))
                .ForMember(x => x.ProjectManagerImageUrl,
                    opt => opt.MapFrom(
                        x => x.Project.ProjectManager.Person.ImageUrl))
                .ForMember(x => x.ProjectManagerEmail,
                    opt => opt.MapFrom(
                        x => x.Project.ProjectManager.Person.User.Email))
                .ForMember(x => x.ProjectManagerPhoneNumber,
                    opt => opt.MapFrom(
                        x => x.Project.ProjectManager.Person.User.PhoneNumber))
                .ForMember(x => x.ProjectManagerName,
                    opt => opt.MapFrom(x =>
                        x.Project.ProjectManager.Person.DisplayName))
                .ForMember(x => x.ProjectManagerId, opt => opt.MapFrom(x => x.Project.ProjectManagerId))
                .ForMember(x => x.ProjectManagerOrganizationId,
                    opt => opt.MapFrom(x => x.Project.ProjectManagerOrganizationId))
                .ForMember(x => x.ProjectManagerOrganizationName,
                    opt => opt.MapFrom(x => x.Project.OrganizationProjectManager.Organization.Name))
                .ForMember(x => x.ProjectManagerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.Project.OrganizationProjectManager.Organization.ImageUrl))
                .ForMember(x => x.ContractCount,
                    opt => opt.MapFrom(x => x.Project.Contracts.Count()))
                .ForMember(x => x.StoryCount,
                    opt => opt.MapFrom(x => x.Project.Stories.Count))
                .ForMember(x => x.CustomerName,
                    opt => opt.MapFrom(x => x.Project.OrganizationCustomer.Customer.Person.DisplayName))
                .ForMember(x => x.CustomerImageUrl,
                    opt => opt.MapFrom(x => x.Project.OrganizationCustomer.Customer.Person.ImageUrl))
                .ForMember(x => x.CustomerEmail,
                    opt => opt.MapFrom(x => x.Project.OrganizationCustomer.Customer.Person.User.Email))
                .ForMember(x => x.CustomerPhoneNumber,
                    opt => opt.MapFrom(x => x.Project.OrganizationCustomer.Customer.Person.User.PhoneNumber))
                .ForMember(x => x.CustomerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.Project.OrganizationCustomer.Organization.ImageUrl))
                .ForMember(x => x.CustomerId,
                    opt => opt.MapFrom(x => x.Project.CustomerId))
                .ForMember(x => x.CustomerOrganizationName,
                    opt => opt.MapFrom(x => x.Project.OrganizationCustomer.Organization.Name))
                .ForMember(x => x.CustomerOrganizationId,
                    opt => opt.MapFrom(x => x.Project.CustomerOrganizationId))
                .ForMember(x => x.ProjectName, opt => opt.MapFrom(x => x.Project.Name))
                .ForMember(x => x.VelocityBasis, opt => opt.MapFrom(x => x.VelocityBasis))
                .ForMember(x => x.WeeklyMaxHourBasis, opt => opt.MapFrom(x => x.WeeklyMaxHourBasis))
                .ForMember(x => x.BudgetBasis, opt => opt.MapFrom(x => x.BudgetBasis))
                .ForMember(x => x.Status, opt => opt.MapFrom(x => x.Status))
                .ForMember(x => x.ExtraDayBasis, opt => opt.MapFrom(x => x.ExtraDayBasis))
                .ForMember(x => x.EstimationBasis, opt => opt.MapFrom(x => x.EstimationBasis))
                .ForMember(x => x.CustomerRateBasis, opt => opt.MapFrom(x => x.CustomerRateBasis))
                .ForMember(x => x.OtherPercentBasis, opt => opt.MapFrom(x => x.OtherPercentBasis))
                .ForMember(x => x.StoryPointBasis, opt => opt.MapFrom(x => x.StoryPointBasis))
                .ForMember(x => x.TotalHours, opt => opt.MapFrom(x => x.TotalHours))
                .ForMember(x => x.TotalPriceQuoted, opt => opt.MapFrom(x => x.TotalPriceQuoted))
                .IncludeAllDerived();

            CreateMap<FixedPriceProposal, FixedPriceProposalDetailOutput>()
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance))
                .ForMember(x => x.ProposedStories, opt => opt.MapFrom(x => x.Project.Stories))
                .ForMember(x => x.ProposedContracts, opt => opt.MapFrom(x => x.Project.Contracts))
                .IncludeAllDerived();

            CreateMap<FixedPriceProposal, AgencyOwnerFixedPriceProposalOutput>()
                .IncludeAllDerived();

            CreateMap<FixedPriceProposal, AgencyOwnerFixedPriceProposalDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance))
                .ForMember(x => x.ProposedStories, opt => opt.MapFrom(x => x.Project.Stories))
                .ForMember(x => x.ProposedContracts, opt => opt.MapFrom(x => x.Project.Contracts));

            CreateMap<FixedPriceProposal, AgencyOwnerFixedPriceProposalModel>()
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance));

            CreateMap<FixedPriceProposal, AccountManagerFixedPriceProposalOutput>()
                .IncludeAllDerived();

            CreateMap<FixedPriceProposal, ProjectManagerFixedPriceProposalOutput>()
                .IncludeAllDerived();

            CreateMap<FixedPriceProposal, AccountManagerFixedPriceProposalDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance))
                .ForMember(x => x.ProposedStories, opt => opt.MapFrom(x => x.Project.Stories))
                .ForMember(x => x.ProposedContracts, opt => opt.MapFrom(x => x.Project.Contracts));

            CreateMap<FixedPriceProposal, AccountManagerFixedPriceProposalDetailModel>()
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance));

            CreateMap<FixedPriceProposal, ProjectManagerFixedPriceProposalDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance))
                .ForMember(x => x.ProposedStories, opt => opt.MapFrom(x => x.Project.Stories))
                .ForMember(x => x.ProposedContracts, opt => opt.MapFrom(x => x.Project.Contracts));


            CreateMap<FixedPriceProposal, CustomerFixedPriceProposalOutput>()
                .IncludeAllDerived();
            

            CreateMap<FixedPriceProposal, CustomerFixedPriceProposalDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance))
                .ForMember(x => x.ProposedStories, opt => opt.MapFrom(x => x.Project.Stories))
                .ForMember(x => x.ProposedContracts, opt => opt.MapFrom(x => x.Project.Contracts));

            CreateMap<FixedPriceProposal, CustomerFixedPriceProposalDetailModel>()
                .ForMember(x => x.ProposalAcceptance, opt => opt.MapFrom(x => x.ProposalAcceptance));

            CreateEmailProjections();
        }
    }
}