using System;
using AgencyPro.Invoices.Interfaces;
using AgencyPro.Organizations.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Invoices.Models
{
    public class ProjectInvoiceOutput : InvoiceInput, IProjectInvoice, IOrganizationPersonTarget
    {
        public virtual decimal TotalAmount { get; set; }
        public virtual string Id { get; set; }
        public virtual decimal AmountPaid { get; set; }
        public virtual decimal AmountRemaining { get; set; }
        public virtual decimal AmountDue { get; set; }
        public virtual decimal AttemptCount { get; set; }
        public virtual bool Attempted { get; set; }
        public virtual bool AutomaticCollection { get; set; }
        public virtual string BillingReason { get; set; }
        public virtual DateTimeOffset? DueDate { get; set; }

        public virtual decimal EndingBalance { get; set; }
        public virtual string HostedInvoiceUrl { get; set; }
        public virtual string InvoicePdf { get; set; }
        public virtual string Status { get; set; }
        public virtual string Number { get; set; }
        public virtual decimal Total { get; set; }
        public virtual decimal Subtotal { get; set; }

        public virtual string StripeCustomerId { get; set; }
        public virtual Guid CreatedById { get; set; }
        public virtual Guid UpdatedById { get; set; }

        public virtual string ProjectManagerName { get; set; }
        public virtual string ProjectManagerOrganizationName { get; set; }
        public virtual Guid ProjectManagerId { get; set; }
        public virtual Guid ProjectManagerOrganizationId { get; set; }
        public virtual string ProjectManagerImageUrl { get; set; }
        public virtual string ProjectManagerOrganizationImageUrl { get; set; }

        public virtual string AccountManagerName { get; set; }
        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid AccountManagerOrganizationId { get; set; }
        public virtual string AccountManagerOrganizationName { get; set; }
        public virtual string AccountManagerImageUrl { get; set; }
        public virtual string AccountManagerEmail { get; set; }
        public virtual string AccountManagerPhoneNumber { get; set; }
        public virtual string AccountManagerOrganizationImageUrl { get; set; }

      
        public virtual string ProjectName { get; set; }
        public virtual string ProjectAbbreviation { get; set; }

        public virtual string CustomerName { get; set; }
        public virtual Guid CustomerId { get; set; }

        public virtual Guid CustomerOrganizationId { get; set; }
        public virtual string CustomerOrganizationName { get; set; }
        public virtual string CustomerImageUrl { get; set; }
        public virtual string CustomerEmail { get; set; }
        public virtual string CustomerPhoneNumber { get; set; }
        public virtual string CustomerOrganizationImageUrl { get; set; }
        public virtual string CustomerAddressLine1 { get; set; }
        public virtual string CustomerAddressLine2 { get; set; }
        public virtual string CustomerCity { get; set; }
        public virtual string CustomerStateProvince { get; set; }
        public virtual string CustomerIso2 { get; set; }
        public virtual string CustomerPostalCode { get; set; }

        [JsonIgnore]
        public override Guid[] ContractIds { get; set; }

        [JsonIgnore]
        public override bool IncludeAllContracts { get; set; }

        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }

        public string ProviderOrganizationName => this.ProjectManagerOrganizationName;
        public Guid ProviderOrganizationId => this.ProjectManagerOrganizationId;
        public string ProviderOrganizationImageUrl => this.ProjectManagerOrganizationImageUrl;

        [JsonIgnore]
        public virtual Guid TargetOrganizationId { get; }

        public Guid TargetPersonId { get; }
    }
}