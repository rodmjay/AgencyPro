using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.CustomerAccounts.Filters;

namespace AgencyPro.CustomerAccounts.Extensions
{
    public static partial class CustomerAccountExtensions
    {
        public static IQueryable<CustomerAccount> ApplyWhereFilters(this IQueryable<CustomerAccount> entities,
            CustomerAccountFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        private static Expression<Func<CustomerAccount, bool>> WhereFilter(CustomerAccountFilters filters)
        {
            var expr = PredicateBuilder.True<CustomerAccount>();

            if (filters.CustomerId.HasValue)
                expr = expr.And(x => x.CustomerId == filters.CustomerId);

            if (filters.CustomerOrganizationId.HasValue)
                expr = expr.And(x => x.CustomerOrganizationId == filters.CustomerOrganizationId);

            if (filters.AccountManagerId.HasValue)
                expr = expr.And(x => x.AccountManagerId == filters.AccountManagerId);

            if (filters.AccountManagerOrganizationId.HasValue)
                expr = expr.And(x => x.AccountManagerOrganizationId == filters.AccountManagerOrganizationId);
           
            if (filters.Number.HasValue)
                expr = expr.And(x => x.Number == filters.Number);


            return expr;
        }
    }
}