using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Extensions
{
    public static class OrganizationMarketersExtensions
    {
        public static IQueryable<OrganizationMarketer> ApplyWhereFilters(this IQueryable<OrganizationMarketer> entities,
            MarketerFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<OrganizationMarketer, bool>> WhereFilter(MarketerFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationMarketer>();

            return expr;
        }


        public static IQueryable<OrganizationMarketer> ForOrganizationMarketer(
            this IQueryable<OrganizationMarketer> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x => x.OrganizationId == ma.OrganizationId);
        }

        public static IQueryable<OrganizationMarketer> ForAgencyOwner(this IQueryable<OrganizationMarketer> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.OrganizationId == ao.OrganizationId);
        }

        public static IQueryable<OrganizationMarketer> ForOrganizationAccountManager(
            this IQueryable<OrganizationMarketer> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x => x.OrganizationId == am.OrganizationId);
        }

        public static IQueryable<OrganizationMarketer> ForOrganizationProjectManager(
            this IQueryable<OrganizationMarketer> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.OrganizationId == pm.OrganizationId);
        }

        public static IQueryable<OrganizationMarketer> ForOrganizationRecruiter(
            this IQueryable<OrganizationMarketer> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.OrganizationId == re.OrganizationId);
        }

        public static IQueryable<OrganizationMarketer> ForOrganizationContractor(
            this IQueryable<OrganizationMarketer> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x => x.OrganizationId == co.OrganizationId);
        }
    }
}