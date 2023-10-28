using System.Linq;
using AgencyPro.Roles.Models;

namespace AgencyPro.Roles.Extensions
{
    public static partial class ContractorExtensions
    {
        public static IQueryable<Contractor> StandardIncludes(this IQueryable<Contractor> entities)
        {
            return entities;
        }

        public static IQueryable<Contractor> IncludeDetailedIncludes(this IQueryable<Contractor> entities)
        {
            return entities;
        }
    }
}