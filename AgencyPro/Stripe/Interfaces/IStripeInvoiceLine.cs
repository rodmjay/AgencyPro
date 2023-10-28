using System;

namespace AgencyPro.Stripe.Interfaces
{
    public interface IStripeInvoiceLine
    {
        string Id { get; set; }
        string InvoiceId { get; set; }
        string Description { get; set; }
        bool Discountable { get; set; }
        DateTime? PeriodStart { get; set; }
        DateTime? PeriodEnd { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        decimal Amount { get; set; }
        string Currency { get; set; }
        string InvoiceItemId { get; set; }
        string SubscriptionId { get; set; }
        string Type { get; set; }
    }
}