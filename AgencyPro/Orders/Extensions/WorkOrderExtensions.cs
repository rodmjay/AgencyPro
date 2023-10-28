using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.Orders.Entities;
using AgencyPro.Orders.Models;

namespace AgencyPro.Orders.Extensions
{
    public static partial class WorkOrderExtensions
    {
        public static IQueryable<WorkOrder> ApplyWhereFilters(this IQueryable<WorkOrder> entities,
            WorkOrderFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<WorkOrder, bool>> WhereFilter(WorkOrderFilters filters)
        {
            var expr = PredicateBuilder.True<WorkOrder>();

            if (filters.AccountManagerOrganizationId.HasValue)
                expr = expr.And(x => x.AccountManagerOrganizationId == filters.AccountManagerOrganizationId);
            
            return expr;
        }
    }
}