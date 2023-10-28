using System.Collections.Generic;

namespace AgencyPro.Invoices.Models
{
    public class ManagerProjectInvoiceDetailsOutput : ManagerProjectInvoiceOutput
    {
        public ICollection<InvoiceLineOutput> Lines { get; set; }
    }
}