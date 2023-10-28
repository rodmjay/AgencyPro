using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.Organizations.Entities;
using AgencyPro.ProviderOrganizations.Models;

namespace AgencyPro.Organizations.Projections
{
    public partial class OrganizationProjections
    {
        private void MarketingOrganizationProjections()
        {
            CreateMap<Organization, MarketingOrganizationOutput>()
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
                .ForMember(x => x.ImageUrl, x => x.MapFrom(y => y.ImageUrl))
                .ForMember(x => x.Marketers, opt => opt.MapFrom(x => x.Marketers.Count))
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .IncludeAllDerived();

            CreateMap<Organization, MarketerOrganizationOutput>()
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
                .ForMember(x => x.ImageUrl, x => x.MapFrom(y => y.ImageUrl))
                .ForMember(x => x.Marketers, opt => opt.MapFrom(x => x.Marketers.Count))
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .IncludeAllDerived();

            CreateMap<Organization, MarketingAgencyOwnerOrganizationOutput>();

            CreateMap<Organization, ProviderAgencyOwnerMarketingOrganizationOutput>()
                .IncludeAllDerived();
        }
    }
}