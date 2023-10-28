using AgencyPro.Proposals.Entities;
using AgencyPro.Proposals.Models;
using AutoMapper;

namespace AgencyPro.Proposals.Projections
{
    public class ProposalAcceptanceProjectionMap : Profile
    {
        public ProposalAcceptanceProjectionMap()
        {
            CreateMap<ProposalAcceptance, ProposalAcceptanceOutput>();

            CreateMap<ProposalAcceptance, ProposalAcceptanceDetailOutput>()
                .ForMember(x => x.ProjectName, opt => opt.MapFrom(x => x.Proposal.Project.Name))
                .ForMember(x => x.ProjectAbbreviation, opt => opt.MapFrom(x => x.Proposal.Project.Abbreviation))
                .ForMember(x => x.AccountManagerImageUrl,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.AccountManager.Person.ImageUrl))

                .ForMember(x => x.AccountManagerName,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.AccountManager.Person.DisplayName))

                .ForMember(x => x.AccountManagerId,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.AccountManagerId))

                .ForMember(x => x.AccountManagerOrganizationImageUrl,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.OrganizationAccountManager.Organization.ImageUrl))

                .ForMember(x => x.AccountManagerOrganizationName,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.OrganizationAccountManager.Organization.Name))

                .ForMember(x => x.AccountManagerOrganizationId,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.OrganizationAccountManager.OrganizationId))



                .ForMember(x => x.ProjectManagerImageUrl,
                    opt => opt.MapFrom(
                        x => x.Proposal.Project.ProjectManager.Person.ImageUrl))
                .ForMember(x => x.ProjectManagerName,
                    opt => opt.MapFrom(x =>
                        x.Proposal.Project.ProjectManager.Person.DisplayName))
                .ForMember(x => x.ProjectManagerId, opt => opt.MapFrom(x => x.Proposal.Project.ProjectManagerId))
                .ForMember(x => x.ProjectManagerOrganizationId,
                    opt => opt.MapFrom(x => x.Proposal.Project.ProjectManagerOrganizationId))
                .ForMember(x => x.ProjectManagerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.Proposal.Project.OrganizationProjectManager.Organization.ImageUrl))
                .ForMember(x => x.AcceptedCompletionDate, opt => opt.MapFrom(x => x.AcceptedCompletionDate))
                .ForMember(x => x.NetTerms, opt => opt.MapFrom(x => x.NetTerms))
                .ForMember(x=>x.TotalDays, opt=>opt.MapFrom(x=>x.TotalDays))
                .ForMember(x=>x.TotalCost, opt=>opt.MapFrom(x=>x.TotalCost))
                .ForMember(x=>x.CustomerRate, opt=>opt.MapFrom(x=>x.CustomerRate))
                .ForMember(x => x.ProposalType, opt => opt.MapFrom(x => x.ProposalType));
        }
    }
}