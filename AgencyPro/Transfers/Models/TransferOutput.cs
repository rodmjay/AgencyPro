using System;
using AgencyPro.Transfers.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Transfers.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TransferOutput : IStripeTransfer
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountReversed { get; set; }
        public string Description { get; set; }
        public string DestinationId { get; set; }
        public string DestinationPaymentId { get; set; }

        public string InvoiceId { get; set; }

        public bool IndividualTransfer { get; set; }
        public bool OrganizationTransfer => !IndividualTransfer;
        public string RecipientName { get; set; }
        public string OrganizationName { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
