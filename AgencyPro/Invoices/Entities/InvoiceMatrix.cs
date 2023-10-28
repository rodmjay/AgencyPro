using System;
using AgencyPro.Invoices.Interfaces;

namespace AgencyPro.Invoices.Entities
{
    public class InvoiceMatrix : IInvoiceMatrix
    {
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }

        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }

        private bool IsOverdue { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
    }
}