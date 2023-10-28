using System.Linq;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.CustomerAccounts.Extensions
{
    public static partial class CustomerAccountExtensions
    {
        public static IQueryable<CustomerAccount> ForAgencyOwner(this IQueryable<CustomerAccount> entities,
            IProviderAgencyOwner ao)
        {
            return entities.Where(x => x.AccountManagerOrganizationId == ao.OrganizationId);
        }

        public static IQueryable<CustomerAccount> ForProjectManager(this IQueryable<CustomerAccount> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x => x.AccountManagerOrganizationId == pm.OrganizationId);
        }

        public static IQueryable<CustomerAccount> ForOrganizationAccountManager(
            this IQueryable<CustomerAccount> entities, IOrganizationAccountManager am)
        {
            return entities.Where(x =>
                x.AccountManagerId == am.AccountManagerId && x.AccountManagerOrganizationId == am.OrganizationId);
        }

        public static IQueryable<CustomerAccount> ForOrganizationCustomer(this IQueryable<CustomerAccount> entities,
            IOrganizationCustomer cu)
        {
            return entities.Where(x => x.CustomerId == cu.CustomerId && x.CustomerOrganizationId == cu.OrganizationId);
        }
    }
}