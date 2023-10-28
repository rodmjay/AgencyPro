using System;

namespace AgencyPro.Stripe.Interfaces
{
    public interface IInvoice
    {
        string Id { get; set; }
        decimal AmountPaid { get; set; }
        decimal AmountRemaining { get; set; }
        decimal AmountDue { get; set; }
        decimal AttemptCount { get; set; }
        bool Attempted { get; set; }
        bool AutomaticCollection { get; set; }
        string BillingReason { get; set; }
        DateTimeOffset? DueDate { get; set; }
        decimal EndingBalance { get; set; }
        string HostedInvoiceUrl { get; set; }
        string InvoicePdf { get; set; }
        string Status { get; set; }
        string Number { get; set; }
        decimal Total { get; set; }
        decimal Subtotal { get; set; }
    }
}