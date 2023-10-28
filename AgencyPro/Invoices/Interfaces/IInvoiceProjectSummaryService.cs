using System;
using System.Threading.Tasks;
using AgencyPro.Invoices.Models.InvoiceSummary;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Invoices.Interfaces
{
    public interface IInvoiceProjectSummaryService
    {
        Task<ProjectInvoiceSummary> GetProjectInvoiceSummary(IProviderAgencyOwner agencyOwner);
        Task<ProjectInvoiceDetails> GetProjectInvoiceDetails(IProviderAgencyOwner agencyOwner, Guid projectId);
    }
}