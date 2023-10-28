using System;
using System.Linq;
using AgencyPro.Roles.Models;

namespace AgencyPro.Roles.Extensions
{
    public static class AccountManagerExtensions
    {
        public static IQueryable<AccountManager> FindById(this IQueryable<AccountManager> entities, Guid id)
        {
            return entities.Where(x => x.Id == id);
        }
    }
}