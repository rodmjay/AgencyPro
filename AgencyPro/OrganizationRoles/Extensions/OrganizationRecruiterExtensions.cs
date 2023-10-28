using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Extensions
{
    public static class OrganizationRecruiterExtensions
    {
        public static IQueryable<OrganizationRecruiter> ApplyWhereFilters(this IQueryable<OrganizationRecruiter> entities,
            RecruiterFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<OrganizationRecruiter, bool>> WhereFilter(RecruiterFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationRecruiter>();

            return expr;
        }
        
        public static IQueryable<OrganizationRecruiter> FindById(this IQueryable<OrganizationRecruiter> entities,
            Guid recruiterId, Guid organizationId)
        {
            return entities.Where(x => x.OrganizationId == organizationId && x.RecruiterId == recruiterId);
        }

        public static IQueryable<OrganizationRecruiter> ForOrganizationMarketer(
            this IQueryable<OrganizationRecruiter> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x => x.OrganizationId == ma.OrganizationId);
        }

        public static IQueryable<OrganizationRecruiter> ForAgencyOwner(this IQueryable<OrganizationRecruiter> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.OrganizationId == ao.OrganizationId);
        }

        public static IQueryable<OrganizationRecruiter> ForOrganizationAccountManager(
            this IQueryable<OrganizationRecruiter> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x => x.OrganizationId == am.OrganizationId);
        }

        public static IQueryable<OrganizationRecruiter> ForOrganizationProjectManager(
            this IQueryable<OrganizationRecruiter> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.OrganizationId == pm.OrganizationId);
        }

        public static IQueryable<OrganizationRecruiter> ForOrganizationRecruiter(
            this IQueryable<OrganizationRecruiter> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.OrganizationId == re.OrganizationId);
        }

        public static IQueryable<OrganizationRecruiter> ForOrganizationContractor(
            this IQueryable<OrganizationRecruiter> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x => x.OrganizationId == co.OrganizationId);
        }
    }
}