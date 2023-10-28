using System;

namespace AgencyPro.Stripe.Interfaces
{
    public interface IStripeInvoiceItem
    {
        string Id { get; set; }
        decimal Amount { get; set; }
        string CustomerId { get; set; }
        string Description { get; set; }
        string InvoiceId { get; set; }
        int Quantity { get; set; }
        DateTime? PeriodStart { get; set; }
        DateTime? PeriodEnd { get; set; }
        Guid? ContractId { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}