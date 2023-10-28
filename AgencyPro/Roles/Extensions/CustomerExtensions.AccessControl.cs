using System.Linq;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Roles.Models;

namespace AgencyPro.Roles.Extensions
{
    public static partial class CustomerExtensions
    {
        public static IQueryable<Customer> ForOrganizationMarketer(this IQueryable<Customer> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x => x.MarketerOrganizationId == ma.OrganizationId);
        }
    }
}