using System;
using AgencyPro.PayoutIntents.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AgencyPro.PayoutIntents.Models
{
    public abstract class PayoutViewModel
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public string InvoiceItemId { get; set; }
        public decimal Amount { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CommissionType Type { get; set; }
        public string Description { get; set; }
        public string InvoiceTransferId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }


        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }

        public string ContractorName { get; set; }
        public string ContractorId { get; set; }
        public string ContractorImageUrl { get; set; }

        public string ProviderOrganizationName { get; set; }
        public string ProviderOrganizationId { get; set; }
        public string ProviderOrganizationImageUrl { get; set; }

        public string ProjectName { get; set; }
        public Guid? ProjectId { get; set; }

        public string InvoiceNumber { get; set; }
        public DateTimeOffset? InvoiceDueDate { get; set; }

        [JsonIgnore]
        public decimal? TransferAmount { get; set; }

        public bool IsComplete => TransferAmount.HasValue && TransferAmount >= Amount;

        public bool PayoutsEnabled { get; set; }
    }
}