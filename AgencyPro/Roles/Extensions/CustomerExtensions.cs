using System;
using System.Linq;
using AgencyPro.Roles.Entities;

namespace AgencyPro.Roles.Extensions
{
    public static partial class CustomerExtensions
    {
        public static IQueryable<Customer> FindById(this IQueryable<Customer> entities, Guid id)
        {
            return entities.Where(x => x.Id == id);
        }
    }
}