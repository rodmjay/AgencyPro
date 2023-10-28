using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Extensions
{
    public static class OrganizationAccountManagerExtensions
    {
        public static IQueryable<OrganizationAccountManager> ApplyWhereFilters(this IQueryable<OrganizationAccountManager> entities,
            AccountManagerFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<OrganizationAccountManager, bool>> WhereFilter(AccountManagerFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationAccountManager>();

            return expr;
        }



        public static IQueryable<OrganizationAccountManager> FindById(
            this IQueryable<OrganizationAccountManager> entities, Guid accountManagerId, Guid organizationId)
        {
            return entities.Where(x => x.OrganizationId == organizationId && x.AccountManagerId == accountManagerId);
        }

        public static IQueryable<OrganizationAccountManager> ForOrganizationMarketer(
            this IQueryable<OrganizationAccountManager> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x => x.OrganizationId == ma.OrganizationId);
        }

        public static IQueryable<OrganizationAccountManager> ForAgencyOwner(
            this IQueryable<OrganizationAccountManager> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.OrganizationId == ao.OrganizationId);
        }

        public static IQueryable<OrganizationAccountManager> ForOrganizationAccountManager(
            this IQueryable<OrganizationAccountManager> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x => x.OrganizationId == am.OrganizationId);
        }

        public static IQueryable<OrganizationAccountManager> ForOrganizationProjectManager(
            this IQueryable<OrganizationAccountManager> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.OrganizationId == pm.OrganizationId);
        }

        public static IQueryable<OrganizationAccountManager> ForOrganizationRecruiter(
            this IQueryable<OrganizationAccountManager> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.OrganizationId == re.OrganizationId);
        }

        public static IQueryable<OrganizationAccountManager> ForOrganizationContractor(
            this IQueryable<OrganizationAccountManager> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x => x.OrganizationId == co.OrganizationId);
        }
    }
}