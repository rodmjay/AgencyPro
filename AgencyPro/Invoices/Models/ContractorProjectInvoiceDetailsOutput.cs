using System.Collections.Generic;

namespace AgencyPro.Invoices.Models
{
    public class ContractorProjectInvoiceDetailsOutput : ContractorProjectInvoiceOutput
    {
        public ICollection<InvoiceLineOutput> Lines { get; set; }
    }
}