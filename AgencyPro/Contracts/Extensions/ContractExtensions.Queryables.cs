using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.Contracts.Entities;
using AgencyPro.Contracts.Models;

namespace AgencyPro.Contracts.Extensions
{
    public static partial class ContractExtensions
    {
        public static IQueryable<Contract> ApplyWhereFilters(this IQueryable<Contract> entities,
            ContractFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        private static Expression<Func<Contract, bool>> WhereFilter(ContractFilters filters)
        {
            var expr = PredicateBuilder.True<Contract>();

            if (filters.CustomerId.HasValue)
                expr = expr.And(x => x.CustomerId == filters.CustomerId);

            if (filters.CustomerOrganizationId.HasValue)
                expr = expr.And(x => x.BuyerOrganizationId == filters.CustomerOrganizationId);

            if (filters.ProjectManagerId.HasValue)
                expr = expr.And(x => x.ProjectManagerId == filters.ProjectManagerId);

            if (filters.ProjectManagerOrganizationId.HasValue)
                expr = expr.And(x => x.ProjectManagerOrganizationId == filters.ProjectManagerOrganizationId);

            if (filters.AccountManagerId.HasValue)
                expr = expr.And(x => x.AccountManagerId == filters.AccountManagerId);

            if (filters.AccountManagerOrganizationId.HasValue)
                expr = expr.And(x => x.AccountManagerOrganizationId == filters.AccountManagerOrganizationId);
            
            if (filters.ProjectId.HasValue)
                expr = expr.And(x => x.ProjectId == filters.ProjectId);

            if (filters.ContractorId.HasValue)
                expr = expr.And(x => x.ContractorId == filters.ContractorId);

            if (filters.ContractorOrganizationId.HasValue)
                expr = expr.And(x => x.ContractorOrganizationId == filters.ContractorOrganizationId);
            
            if (filters.Statuses.Any())
                expr = expr.And(x => filters.Statuses.Contains(x.Status));

            return expr;
        }

        public static IQueryable<Contract> FindById(this IQueryable<Contract> entities, Guid id)
        {
            return entities.Where(x => x.Id == id);
        }
    }
}