using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Invoices.Models
{
    public class InvoiceItemResult : Result
    {
        public string InvoiceItemId { get; set; }
        public int TimeEntriesUpdated { get; set; }
        public Guid ContractId { get; set; }
    }
}