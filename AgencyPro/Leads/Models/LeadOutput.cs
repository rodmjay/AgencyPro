using System;
using AgencyPro.Leads.Enums;
using AgencyPro.Leads.Interfaces;
using AgencyPro.Organizations.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Leads.Models
{
    public abstract class LeadOutput : LeadInput, ILead, IOrganizationPersonTarget
    {
        [JsonIgnore]
        public abstract Guid TargetOrganizationId { get; }

        [JsonIgnore]
        public abstract Guid TargetPersonId { get; }

        public virtual string MarketerName { get; set; }
        public virtual string MarketerImageUrl { get; set; }
        public virtual string MarketerPhoneNumber { get; set; }
        public virtual string MarketerEmail { get; set; }
        public virtual string MarketerOrganizationName { get; set; }
        public virtual string MarketerOrganizationImageUrl { get; set; }

        public bool IsExternal => MarketerOrganizationId != ProviderOrganizationId;

        public virtual string AccountManagerName { get; set; }
        public virtual string AccountManagerImageUrl { get; set; }
        public virtual string AccountManagerOrganizationName { get; set; }
        public virtual string AccountManagerOrganizationImageUrl { get; set; }
        public virtual decimal MarketerStream { get; set; }

        public virtual Guid MarketerId { get; set; }
        public virtual Guid MarketerOrganizationId { get; set; }

        public virtual Guid Id { get; set; }

        public virtual LeadStatus Status { get; set; }

        public virtual Guid? AccountManagerOrganizationId { get; set; }
        public virtual Guid? AccountManagerId { get; set; }
        public virtual string RejectionReason { get; set; }
        public virtual Guid CreatedById { get; set; }
        public virtual Guid UpdatedById { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        public virtual decimal MarketerBonus { get; set; }
        public virtual decimal MarketingAgencyStream { get; set; }
        public virtual decimal MarketingAgencyBonus { get; set; }

        public virtual decimal MarketingStream => MarketerStream + MarketingAgencyStream;
        public virtual decimal MarketingBonus => MarketerBonus + MarketingAgencyBonus;

        public virtual string ProviderOrganizationName { get; set; }
        public virtual string ProviderOrganizationImageUrl { get; set; }
        public virtual Guid ProviderOrganizationId { get; set; }
        public virtual Guid ProviderOrganizationOwnerId { get; set; }
        public virtual Guid MarketingOrganizationOwnerId { get; set; }
    }
}