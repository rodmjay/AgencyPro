using System.Linq;
using AgencyPro.Agreements.Enums;
using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AutoMapper;

namespace AgencyPro.OrganizationRoles.Models.OrganizationMarketers
{
    public class OrganizationMarketerProjections : Profile
    {
        public OrganizationMarketerProjections()
        {
            CreateMap<OrganizationMarketer, OrganizationMarketerOutput>()
                .ForMember(x => x.DisplayName, opt => opt.MapFrom(x => x.Marketer.Person.DisplayName))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => x.Marketer.Person.ImageUrl))
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Marketer.Person.User.Email))
                .ForMember(x => x.PhoneNumber, opt => opt.MapFrom(x => x.Marketer.Person.User.PhoneNumber))
                .ForMember(x => x.Status, opt => opt.MapFrom(x => x.OrganizationPerson.Status))

                .IncludeAllDerived();

            CreateMap<OrganizationMarketer, OrganizationMarketerStatistics>()
                .ForMember(x => x.TotalLeads, opt => opt.MapFrom(x => x.Leads.Count))
                .ForMember(x => x.TotalContracts, opt => opt.MapFrom(x => x.Contracts.Count))
                .ForMember(x => x.TotalCustomers, opt => opt.MapFrom(x => x.Customers.Count))
                .IncludeAllDerived();


            CreateMap<OrganizationMarketer, AgencyOwnerOrganizationMarketerOutput>();
            CreateMap<OrganizationMarketer, AccountManagerOrganizationMarketerOutput>();

            CreateMap<OrganizationMarketer, MarketerCounts>()
                .ForMember(x => x.Leads, opt => opt.MapFrom(x => x.Leads.Count))
                .ForMember(x => x.Contracts, opt => opt.MapFrom(x => x.Contracts.Count))
                .ForMember(x => x.ChannelPartners, opt => opt.MapFrom(x => x.Organization.MarketingOrganization.MarketingAgreements.Count(y => y.Status == AgreementStatus.Approved)))
                .ForMember(x => x.Customers, opt => opt.MapFrom(x => x.Customers.Count));


            CreateMap<OrganizationMarketer, MarketerOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .ForMember(x => x.MarketerStream, o => o.MapFrom(x => x.MarketerStream))
                .ForMember(x => x.MarketerBonus, o => o.MapFrom(x => x.MarketerBonus))
                .IncludeAllDerived();

        }
    }
}