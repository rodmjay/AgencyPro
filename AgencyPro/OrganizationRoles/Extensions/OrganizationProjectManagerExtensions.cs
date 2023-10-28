using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Extensions
{
    public static class OrganizationProjectManagerExtensions
    {
        public static IQueryable<OrganizationProjectManager> ApplyWhereFilters(this IQueryable<OrganizationProjectManager> entities,
            ProjectManagerFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<OrganizationProjectManager, bool>> WhereFilter(ProjectManagerFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationProjectManager>();

            return expr;
        }

        public static IQueryable<OrganizationProjectManager> FindById(this IQueryable<OrganizationProjectManager> entities,
            Guid projectManagerId, Guid organizationId)
        {
            return entities
                .Where(x => x.OrganizationId == organizationId && x.ProjectManagerId == projectManagerId);
        }

        public static IQueryable<OrganizationProjectManager> ForOrganizationMarketer(
            this IQueryable<OrganizationProjectManager> entities,
            IOrganizationMarketer ma)
        {
            return entities
                .Where(x => x.OrganizationId == ma.OrganizationId);
        }

        public static IQueryable<OrganizationProjectManager> ForAgencyOwner(
            this IQueryable<OrganizationProjectManager> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.OrganizationId == ao.OrganizationId);
        }

        public static IQueryable<OrganizationProjectManager> ForOrganizationAccountManager(
            this IQueryable<OrganizationProjectManager> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x => x.OrganizationId == am.OrganizationId);
        }

        public static IQueryable<OrganizationProjectManager> ForOrganizationProjectManager(
            this IQueryable<OrganizationProjectManager> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.OrganizationId == pm.OrganizationId);
        }

        public static IQueryable<OrganizationProjectManager> ForOrganizationRecruiter(
            this IQueryable<OrganizationProjectManager> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.OrganizationId == re.OrganizationId);
        }

        public static IQueryable<OrganizationProjectManager> ForOrganizationContractor(
            this IQueryable<OrganizationProjectManager> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x => x.OrganizationId == co.OrganizationId);
        }
    }
}