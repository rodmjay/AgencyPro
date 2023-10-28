using System;
using AgencyPro.PaymentIntents.Interfaces;

namespace AgencyPro.PaymentIntents.Models
{
    public class PaymentOutput : IStripePaymentIntent
    {
        public string Id { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountCapturable { get; set; }
        public decimal? AmountReceived { get; set; }
        public DateTime? CancelledAt { get; set; }
        public string CaptureMethod { get; set; }
        public string InvoiceId { get; set; }
        public string ConfirmationMethod { get; set; }
        public string CustomerId { get; set; }
        public string TransferGroup { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}
