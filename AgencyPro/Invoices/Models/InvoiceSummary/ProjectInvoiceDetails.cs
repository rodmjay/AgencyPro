using System.Collections.Generic;

namespace AgencyPro.Invoices.Models.InvoiceSummary
{
    public class ProjectInvoiceDetails : ProjectInvoiceSummaryItem
    {
        public ICollection<ContractInvoiceSummaryItem> Contracts { get; set; }
    }
}