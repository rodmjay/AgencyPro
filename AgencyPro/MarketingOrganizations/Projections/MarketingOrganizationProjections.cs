using AgencyPro.Agreements.Models;
using AgencyPro.MarketingOrganizations.Entities;
using AgencyPro.MarketingOrganizations.Models;
using AutoMapper;

namespace AgencyPro.MarketingOrganizations.Projections
{
    public class MarketingOrganizationProjections : Profile
    {
        public MarketingOrganizationProjections()
        {
            CreateMap<MarketingOrganization, MarketingOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .ForMember(x => x.DefaultMarketerId, opt => opt.MapFrom(x => x.DefaultMarketerId))
                .ForMember(x => x.ServiceFeePerLead, opt => opt.MapFrom(x => x.ServiceFeePerLead))
                .IncludeAllDerived();


            CreateMap<MarketingOrganization, AgencyOwnerMarketingOrganizationDetailsOutput>()
                .IncludeAllDerived();

            CreateMap<MarketingOrganization, ProviderAgencyOwnerMarketingOrganizationOutput>()
                .IncludeAllDerived();

            CreateMap<MarketingOrganization, MarketingAgreementOutput>()
                .ForMember(x => x.MarketingOrganizationName, x => x.MapFrom(y => y.Organization.Name))
                .ForMember(x => x.MarketingOrganizationImageUrl, x => x.MapFrom(y => y.Organization.ImageUrl))
                .ForMember(x => x.MarketingOrganizationId, x => x.MapFrom(y => y.Id))
                .IncludeAllDerived();

        }
    }
}