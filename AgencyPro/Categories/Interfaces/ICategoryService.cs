using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Categories.Entities;
using AgencyPro.Categories.Models;
using AgencyPro.Common.Services.Interfaces;

namespace AgencyPro.Categories.Interfaces
{
    public interface ICategoryService : IService<Category>
    {
        Task<List<T>> GetCategories<T>() where T : CategoryOutput;
        Task<T> GetCategory<T>(int categoryId) where T : CategoryOutput;
    }
}