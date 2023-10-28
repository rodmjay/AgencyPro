using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Extensions
{
    public static class OrganizationContractorExtensions
    {
        public static IQueryable<OrganizationContractor> ApplyWhereFilters(this IQueryable<OrganizationContractor> entities,
            ContractorFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<OrganizationContractor, bool>> WhereFilter(ContractorFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationContractor>();

            if (filters.ProjectId.HasValue)
                expr = expr.And(x => x.Contracts.Select(a => a.ProjectId)
                    .Contains(filters.ProjectId.Value));

            return expr;
        }

        public static IQueryable<OrganizationContractor> FindById(this IQueryable<OrganizationContractor> entities,
            Guid contractorId, Guid organizationId)
        {
            return entities.Where(x => x.OrganizationId == organizationId && x.ContractorId == contractorId);
        }

        public static IQueryable<OrganizationContractor> ForOrganizationMarketer(
            this IQueryable<OrganizationContractor> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x => x.OrganizationId == ma.OrganizationId);
        }

        public static IQueryable<OrganizationContractor> ForAgencyOwner(
            this IQueryable<OrganizationContractor> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.OrganizationId == ao.OrganizationId);
        }

        public static IQueryable<OrganizationContractor> ForOrganizationAccountManager(
            this IQueryable<OrganizationContractor> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x => x.OrganizationId == am.OrganizationId);
        }

        public static IQueryable<OrganizationContractor> ForOrganizationProjectManager(
            this IQueryable<OrganizationContractor> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.OrganizationId == pm.OrganizationId);
        }

        public static IQueryable<OrganizationContractor> ForOrganizationRecruiter(
            this IQueryable<OrganizationContractor> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.OrganizationId == re.OrganizationId);
        }

        public static IQueryable<OrganizationContractor> ForOrganizationContractor(
            this IQueryable<OrganizationContractor> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x => x.OrganizationId == co.OrganizationId);
        }
    }
}