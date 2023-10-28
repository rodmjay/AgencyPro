using System;
using AgencyPro.Charges.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Charges.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ChargeOutput : IStripeCharge
    {
        public string CustomerOrganizationName { get; set; }
        public string Id { get; set; }
        public bool Disputed { get; set; }
        public bool Paid { get; set; }

        [JsonIgnore]
        public string InvoiceId { get; set; }

        
        public string OrderId { get; set; }
        [JsonIgnore] public string ReceiptEmail { get; set; }
        public string ReceiptUrl { get; set; }
        public string DestinationId { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public string BalanceTransactionId { get; set; }
        public bool? Captured { get; set; }

        [JsonIgnore]
        public string CustomerId { get; set; }

        [JsonIgnore]
        public string OnBehalfOfId { get; set; }
        public bool Refunded { get; set; }

        [JsonIgnore]
        public string StatementDescriptorSuffix { get; set; }
        public string StatementDescriptor { get; set; }
        [JsonIgnore] public string PaymentIntentId { get; set; }
        public string OutcomeType { get; set; }

        [JsonIgnore]
        public string OutcomeSellerMessage { get; set; }
        public string OutcomeReason { get; set; }
        public string OutcomeNetworkStatus { get; set; }
        public string ReceiptNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}
