using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationPeople.Filters;

namespace AgencyPro.OrganizationPeople.Extensions
{


    public static partial class OrganizationPersonExtensions
    {
      


        public static IQueryable<OrganizationPerson> ApplyWhereFilters(this IQueryable<OrganizationPerson> entities,
            OrganizationPeopleFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        private static Expression<Func<OrganizationPerson, bool>> WhereFilter(OrganizationPeopleFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationPerson>();

            if (filters.AccountManagers.HasValue && filters.AccountManagers.Value)
                expr = expr.And(
                    x => filters.AccountManagers.Value ? x.AccountManager != null : x.AccountManager == null);

            if (filters.ProjectManagers.HasValue && filters.ProjectManagers.Value)
                expr = expr.And(
                    x => filters.ProjectManagers.Value ? x.ProjectManager != null : x.ProjectManager == null);

            if (filters.Recruiters.HasValue && filters.Recruiters.Value)
                expr = expr.And(x => filters.Recruiters.Value ? x.Recruiter != null : x.Recruiter == null);

            if (filters.Marketers.HasValue && filters.Marketers.Value)
                expr = expr.And(x => filters.Marketers.Value ? x.Marketer != null : x.Marketer == null);

            if (filters.Contractors.HasValue && filters.Contractors.Value)
                expr = expr.And(x => filters.Contractors.Value ? x.Contractor != null : x.Contractor == null);

            if (filters.Customers.HasValue && filters.Customers.Value)
                expr = expr.And(x => filters.Customers.Value ? x.Customer != null : x.Customer == null);

            return expr;
        }
    }
}