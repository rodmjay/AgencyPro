using AgencyPro.BillingCategories.Entities;
using AgencyPro.BillingCategories.Models;
using AutoMapper;

namespace AgencyPro.BillingCategories.Projections
{
    public class BillingCategoryProjections : Profile
    {
        public BillingCategoryProjections()
        {
            CreateMap<BillingCategory, BillingCategoryOutput>()
                .ForMember(x=>x.Id, opt=>opt.MapFrom(x=>x.Id))
                .ForMember(x=>x.IsEnabled, opt=>opt.MapFrom(x=>x.IsEnabled))
                .ForMember(x=>x.IsPrivate, opt=>opt.MapFrom(x=>x.IsPrivate))
                .ForMember(x=>x.IsStoryBucket, opt=>opt.MapFrom(x=>x.IsStoryBucket))
                .ForMember(x=>x.Name, opt=>opt.MapFrom(x=>x.Name));

            CreateMap<OrganizationBillingCategory, BillingCategoryOutput>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.BillingCategory.Id))
                .ForMember(x => x.IsEnabled, opt => opt.MapFrom(x => x.BillingCategory.IsEnabled))
                .ForMember(x => x.IsPrivate, opt => opt.MapFrom(x => x.BillingCategory.IsPrivate))
                .ForMember(x => x.IsStoryBucket, opt => opt.MapFrom(x => x.BillingCategory.IsStoryBucket))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.BillingCategory.Name));

            CreateMap<ProjectBillingCategory, BillingCategoryOutput>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.BillingCategory.Id))
                .ForMember(x => x.IsEnabled, opt => opt.MapFrom(x => x.BillingCategory.IsEnabled))
                .ForMember(x => x.IsPrivate, opt => opt.MapFrom(x => x.BillingCategory.IsPrivate))
                .ForMember(x => x.IsStoryBucket, opt => opt.MapFrom(x => x.BillingCategory.IsStoryBucket))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.BillingCategory.Name));
        }
    }
}
