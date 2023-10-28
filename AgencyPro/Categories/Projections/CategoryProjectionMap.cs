using AgencyPro.Categories.Entities;
using AgencyPro.Categories.Models;
using AutoMapper;

namespace AgencyPro.Categories.Projections
{
    public class CategoryProjectionMap : Profile
    {
        public CategoryProjectionMap()
        {
            CreateMap<Category, CategoryInput>()
                .Include<Category, CategoryOutput>()
                .Include<Category, CategoryDetailsOutput>()
                .Include<Category, AccountManagerCategoryOutput>();

            CreateMap<Category, CategoryOutput>();
            CreateMap<Category, CategoryDetailsOutput>();
            CreateMap<Category, AccountManagerCategoryOutput>();
        }
    }
}