using System;
using AgencyPro.Stripe.Interfaces;

namespace AgencyPro.Invoices.Models
{
    public class InvoiceLineOutput : IStripeInvoiceLine
    {
        public string Id { get; set; }
        public string InvoiceId { get; set; }
        public string Description { get; set; }
        public bool Discountable { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string InvoiceItemId { get; set; }
        public string SubscriptionId { get; set; }
        public string Type { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}