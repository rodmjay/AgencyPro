using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Invoices.Entities;
using AgencyPro.Invoices.Models;
using AgencyPro.OrganizationRoles.Interfaces;
using Stripe;

namespace AgencyPro.Invoices.Interfaces
{
    public interface IProjectInvoiceService : IService<ProjectInvoice>
    {
        Task<T> GetAsync<T>(string invoiceId) where T : ProjectInvoiceOutput, new();
        Task<T> GetInvoice<T>(IProviderAgencyOwner agencyOwner, string invoiceId)
            where T : AgencyOwnerProjectInvoiceOutput, new();

        Task<T> GetInvoice<T>(IOrganizationAccountManager am, string invoiceId)
            where T : AccountManagerProjectInvoiceOutput, new();

        Task<InvoiceResult> CreateInvoice(IProviderAgencyOwner agencyOwner, InvoiceInput input);

        Task<InvoiceResult> CreateInvoice(IOrganizationAccountManager am, InvoiceInput input);

        Task<InvoiceResult> FinalizeInvoice(IProviderAgencyOwner ao, string invoiceId);
        Task<InvoiceResult> VoidInvoice(IProviderAgencyOwner ao, string invoiceId);

        Task<InvoiceResult> FinalizeInvoice(IOrganizationAccountManager am, string invoiceId);

        Task<T> GetInvoice<T>(IOrganizationCustomer cu, string invoiceId) 
            where T : CustomerProjectInvoiceOutput;
        Task<PagedList<T>> GetInvoices<T>(IProviderAgencyOwner ao, InvoiceFilters filters) 
            where T : AgencyOwnerProjectInvoiceOutput,new();
        Task<PagedList<T>> GetInvoices<T>(IOrganizationCustomer cu, InvoiceFilters filters)
            where T : CustomerProjectInvoiceOutput, new();
        Task<PagedList<T>> GetInvoices<T>(IOrganizationAccountManager am, InvoiceFilters filters)
            where T : AccountManagerProjectInvoiceOutput, new();

        Task<InvoiceResult> DeleteInvoice(IProviderAgencyOwner agencyOwner, string invoiceId);
        Task<InvoiceResult> DeleteInvoice(IOrganizationAccountManager accountManager, string invoiceId);

        Task<InvoiceResult> SendInvoice(IProviderAgencyOwner agencyOwner, string invoiceId);
        Task<InvoiceResult> SendInvoice(IOrganizationAccountManager agencyOwner, string invoiceId);

        Task<InvoiceItemResult> InvoiceItemUpdated(InvoiceItem invoiceItem);
        //Task<int> ImportInvoices(int limit);
        Task<InvoiceItemResult> InvoiceItemCreated(InvoiceItem invoiceItem);
        Task<InvoiceItemResult> InvoiceItemDeleted(InvoiceItem invoiceItem);

        Task<InvoiceResult> InvoiceFinalized(Invoice invoice);
        Task<InvoiceResult> InvoiceSent(Invoice invoice);
        Task<InvoiceResult> InvoiceDeleted(Invoice invoice);
        Task<InvoiceResult> InvoiceUpdated(Invoice invoice);
        Task<InvoiceResult> InvoicePaymentSucceeded(Invoice invoice);

        Task<InvoiceResult> InvoiceCreated(Invoice invoice, string refNo);
    }
}