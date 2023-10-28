using System;

namespace AgencyPro.Charges.Interfaces
{
    public interface IStripeCharge
    {
        string Id { get; set; }
        bool Disputed { get; set; }
        bool Paid { get; set; }
        string InvoiceId { get; set; }
        string OrderId { get; set; }
        string ReceiptEmail { get; set; }
        string ReceiptUrl { get; set; }
        string DestinationId { get; set; }
        string Description { get; set; }
        string BalanceTransactionId { get; set; }
        bool? Captured { get; set; }
        string CustomerId { get; set; }
        string OnBehalfOfId { get; set; }
        bool Refunded { get; set; }
        string StatementDescriptorSuffix { get; set; }
        string StatementDescriptor { get; set; }
        string PaymentIntentId { get; set; }
        string OutcomeType { get; set; }
        string OutcomeSellerMessage { get; set; }
        string OutcomeReason { get; set; }
        string OutcomeNetworkStatus { get; set; }
        string ReceiptNumber { get; set; }
        decimal Amount { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}