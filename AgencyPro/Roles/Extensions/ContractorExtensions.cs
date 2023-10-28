using System;
using System.Linq;
using AgencyPro.Roles.Entities;

namespace AgencyPro.Roles.Extensions
{
    public static partial class ContractorExtensions
    {
        public static IQueryable<Contractor> FindById(this IQueryable<Contractor> entities, Guid id)
        {
            return entities.Where(x => x.Id == id);
        }
    }
}