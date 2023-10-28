using System;
using System.Linq;
using System.Linq.Expressions;
using AgencyPro.Common.Queries;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Extensions
{
    public static class OrganizationCustomerExtensions
    {
        public static IQueryable<OrganizationCustomer> ApplyWhereFilters(this IQueryable<OrganizationCustomer> entities,
            CustomerFilters filters)
        {
            return entities.Where(WhereFilter(filters));
        }

        public static Expression<Func<OrganizationCustomer, bool>> WhereFilter(CustomerFilters filters)
        {
            var expr = PredicateBuilder.True<OrganizationCustomer>();
            
            return expr;
        }

        public static IQueryable<OrganizationCustomer> FindByOrganizationNameAndEmail(
            this IQueryable<OrganizationCustomer> entities,
            string email,
            string organizationName)
        {
            return entities
                .Where(x => x.Organization.Name == organizationName
                            && x.Customer.Person.User.Email == email);
        }

        public static IQueryable<OrganizationCustomer> ForOrganizationMarketer(
            this IQueryable<OrganizationCustomer> entities,
            IOrganizationMarketer ma)
        {
            return entities.Where(x => x.OrganizationId == ma.OrganizationId);
        }

        public static IQueryable<OrganizationCustomer> ForAgencyOwner(this IQueryable<OrganizationCustomer> entities,
            IAgencyOwner ao)
        {
            return entities.Where(x => x.OrganizationId == ao.OrganizationId);
        }

        public static IQueryable<OrganizationCustomer> ForOrganizationAccountManager(
            this IQueryable<OrganizationCustomer> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x => x.OrganizationId == am.OrganizationId);
        }

        public static IQueryable<OrganizationCustomer> ForOrganizationProjectManager(
            this IQueryable<OrganizationCustomer> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.OrganizationId == pm.OrganizationId);
        }

        public static IQueryable<OrganizationCustomer> ForOrganizationRecruiter(
            this IQueryable<OrganizationCustomer> entities,
            IOrganizationRecruiter re)
        {
            return entities.Where(x => x.OrganizationId == re.OrganizationId);
        }

        public static IQueryable<OrganizationCustomer> ForOrganizationContractor(
            this IQueryable<OrganizationCustomer> entities,
            IOrganizationContractor co)
        {
            return entities.Where(x => x.OrganizationId == co.OrganizationId);
        }
    }
}