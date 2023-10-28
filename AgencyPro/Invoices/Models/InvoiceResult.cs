using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Invoices.Models
{
    public class InvoiceResult : Result
    {
        public string InvoiceId { get; set; }
        public Guid? ProjectId { get; set; }
    }
}