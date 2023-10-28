using AgencyPro.Organizations.Entities;
using AgencyPro.RecruitingOrganizations.Models;

namespace AgencyPro.Organizations.Projections
{
    public partial class OrganizationProjections
    {
        private void RecruitingOrganizationProjections()
        {
            CreateMap<Organization, RecruiterOrganizationOutput>()
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
                .ForMember(x => x.ImageUrl, x => x.MapFrom(y => y.ImageUrl))
                .ForMember(x => x.OrganizationType, x => x.MapFrom(y => y.OrganizationType))
                .ForMember(x => x.Recruiters, x => x.MapFrom(y => y.Recruiters.Count))
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.PrimaryColor, opt => opt.MapFrom(x => x.PrimaryColor))
                .ForMember(x => x.SecondaryColor, opt => opt.MapFrom(x => x.SecondaryColor))
                .ForMember(x => x.TertiaryColor, opt => opt.MapFrom(x => x.TertiaryColor))

                .IncludeAllDerived();

            CreateMap<Organization, RecruitingOrganizationOutput>()
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
                .ForMember(x => x.ImageUrl, x => x.MapFrom(y => y.ImageUrl))
                .ForMember(x => x.OrganizationType, x => x.MapFrom(y => y.OrganizationType))
                .ForMember(x => x.Recruiters, x => x.MapFrom(y => y.Recruiters.Count))
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.PrimaryColor, opt => opt.MapFrom(x => x.PrimaryColor))
                .ForMember(x => x.SecondaryColor, opt => opt.MapFrom(x => x.SecondaryColor))
                .ForMember(x => x.TertiaryColor, opt => opt.MapFrom(x => x.TertiaryColor))

                .IncludeAllDerived();


            CreateMap<Organization, RecruitingAgencyOwnerOrganizationOutput>();
            CreateMap<Organization, AgencyOwnerRecruitingOrganizationDetailsOutput>();
            CreateMap<Organization, ProviderAgencyOwnerRecruitingOrganizationOutput>();
        }
    }
}