using System;
using AgencyPro.Stripe.Interfaces;

namespace AgencyPro.Invoices.Models
{
    public class InvoiceItemOutput : IStripeInvoiceItem
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public string CustomerId { get; set; }
        public string Description { get; set; }
        public string InvoiceId { get; set; }
        public int Quantity { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public Guid? ContractId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}