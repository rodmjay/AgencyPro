using System.Collections.Generic;

namespace AgencyPro.Invoices.Models
{
    public class CustomerProjectInvoiceDetailsOutput : CustomerProjectInvoiceOutput
    {
        public ICollection<InvoiceLineOutput> Lines { get; set; }
    }
}