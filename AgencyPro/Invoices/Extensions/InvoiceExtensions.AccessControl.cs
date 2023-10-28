using System.Linq;
using AgencyPro.Invoices.Entities;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Invoices.Extensions
{
    public static partial class InvoiceExtensions
    {
        public static IQueryable<ProjectInvoice> ForAgencyOwner(this IQueryable<ProjectInvoice> entities,
            IProviderAgencyOwner ao)
        {
            return entities.Where(x => x.ProviderOrganizationId == ao.OrganizationId);
        }

        public static IQueryable<ProjectInvoice> ForOrganizationAccountManager(this IQueryable<ProjectInvoice> entities,
            IOrganizationAccountManager am)
        {
            return entities.Where(x =>
                x.AccountManagerId == am.AccountManagerId &&
                x.ProviderOrganizationId == am.OrganizationId);
        }

        public static IQueryable<ProjectInvoice> ForOrganizationProjectManager(this IQueryable<ProjectInvoice> entities,
            IOrganizationProjectManager pm)
        {
            return entities.Where(x =>
                x.ProjectManagerId == pm.ProjectManagerId &&
                x.ProviderOrganizationId == pm.OrganizationId);
        }

        public static IQueryable<ProjectInvoice> ForOrganizationCustomer(this IQueryable<ProjectInvoice> entities,
            IOrganizationCustomer cu)
        {
            return entities.Where(x => x.CustomerId == cu.CustomerId && x.BuyerOrganizationId == cu.OrganizationId);
        }
    }
}