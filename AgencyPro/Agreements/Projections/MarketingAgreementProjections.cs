using AgencyPro.Agreements.Entities;
using AgencyPro.Agreements.Models;
using AutoMapper;

namespace AgencyPro.Agreements.Projections
{
    public partial class MarketingAgreementProjections : Profile
    {
        public MarketingAgreementProjections()
        {
            CreateMap<MarketingAgreement, MarketingAgreementOutput>()
                .ForMember(x => x.ProviderOrganizationId, opt => opt.MapFrom(x => x.ProviderOrganizationId))
                .ForMember(x => x.ProviderOrganizationName, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Name))
                .ForMember(x => x.ProviderOrganizationImageUrl, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.ImageUrl))
                .ForMember(x => x.MarketingOrganizationId, opt => opt.MapFrom(x => x.MarketingOrganizationId))
                .ForMember(x => x.MarketingOrganizationName, opt => opt.MapFrom(x => x.MarketingOrganization.Organization.Name))
                .ForMember(x => x.MarketingOrganizationImageUrl, opt => opt.MapFrom(x => x.MarketingOrganization.Organization.ImageUrl))
                .ForMember(x => x.MarketerStream, opt => opt.MapFrom(x => x.MarketerStream))
                .ForMember(x => x.MarketingAgencyStream, opt => opt.MapFrom(x => x.MarketingAgencyStream))
                .ForMember(x => x.MarketingAgencyBonus, opt => opt.MapFrom(x => x.MarketingAgencyBonus))
                .ForMember(x => x.MarketerBonus, opt => opt.MapFrom(x => x.MarketerBonus))
                
                .IncludeAllDerived();

            CreateMap<MarketingAgreement, AgencyOwnerMarketingAgreementOutput>();
            CreateMap<MarketingAgreement, MarketerMarketingAgreementOutput>();
            CreateEmailMaps();
        }
    }
}