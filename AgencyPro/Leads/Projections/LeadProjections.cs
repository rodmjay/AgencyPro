using System.Linq;
using AgencyPro.Leads.Entities;
using AgencyPro.Leads.Models;
using AutoMapper;

namespace AgencyPro.Leads.Projections
{
    public partial class LeadProjections : Profile
    {
        public LeadProjections()
        {
            CreateMap<Lead, LeadOutput>()
                .ForMember(x => x.ProviderOrganizationOwnerId, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.CustomerId))
                .ForMember(x => x.MarketingOrganizationOwnerId, opt => opt.MapFrom(x => x.MarketerOrganization.CustomerId))
                .ForMember(x => x.ProviderOrganizationId, opt => opt.MapFrom(x => x.ProviderOrganizationId))
                .ForMember(x => x.ProviderOrganizationName, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Name))
                .ForMember(x => x.ProviderOrganizationImageUrl, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.ImageUrl))
                .ForMember(x => x.MarketerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.OrganizationMarketer.Organization.ImageUrl))
                .ForMember(x => x.MarketerOrganizationName,
                    opt => opt.MapFrom(x => x.OrganizationMarketer.Organization.Name))
                .ForMember(x => x.MarketerName,
                    opt => opt.MapFrom(x => x.Marketer.Person.DisplayName))
                .ForMember(x => x.MarketerEmail,
                    opt => opt.MapFrom(x => x.Marketer.Person.User.Email))
                .ForMember(x => x.MarketerPhoneNumber,
                    opt => opt.MapFrom(x => x.Marketer.Person.User.PhoneNumber))
                .ForMember(x => x.MarketerImageUrl,
                    opt => opt.MapFrom(x => x.Marketer.Person.ImageUrl))
                .ForMember(x => x.AccountManagerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.OrganizationAccountManager.Organization.ImageUrl))
                .ForMember(x => x.AccountManagerOrganizationName,
                    opt => opt.MapFrom(x => x.OrganizationAccountManager.Organization.Name))
                .ForMember(x => x.AccountManagerName,
                    opt => opt.MapFrom(x => x.AccountManager.Person.DisplayName))
                .ForMember(x => x.AccountManagerImageUrl,
                    opt => opt.MapFrom(x => x.AccountManager.Person.ImageUrl))
                .ForMember(x => x.MarketerBonus, opt => opt.MapFrom(x => x.MarketerBonus))
                .ForMember(x => x.MarketerStream, opt => opt.MapFrom(x => x.MarketerStream))
                .ForMember(x => x.MarketingAgencyBonus, opt => opt.MapFrom(x => x.MarketingAgencyBonus))
                .ForMember(x => x.MarketingAgencyStream, opt => opt.MapFrom(x => x.MarketingAgencyStream))
                .IncludeAllDerived();

            CreateMap<Lead, AccountManagerLeadOutput>()
                .IncludeAllDerived();

            CreateMap<Lead, AccountManagerLeadDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.Comments, opt => opt.MapFrom(x => x.Comments.OrderBy(y => y.Created)));

            CreateMap<Lead, AgencyOwnerLeadOutput>()
                .IncludeAllDerived();

            CreateMap<Lead, AgencyOwnerLeadDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.Comments, opt => opt.MapFrom(x => x.Comments.OrderBy(y => y.Created)));

            CreateMap<Lead, MarketerLeadOutput>()
                .IncludeAllDerived();

            CreateMap<Lead, MarketerLeadDetailsOutput>()
                .ForMember(x => x.StatusTransitions, opt => opt.MapFrom(x => x.StatusTransitions.ToDictionary(a => a.Created, b => b.Status)))
                .ForMember(x => x.Comments, opt => opt.MapFrom(x => x.Comments.OrderBy(y => y.Created)));

            EmailMaps();

        }
    }
}