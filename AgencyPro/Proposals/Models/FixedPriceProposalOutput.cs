using System;
using AgencyPro.Organizations.Interfaces;
using AgencyPro.Proposals.Enums;

namespace AgencyPro.Proposals.Models
{
    public abstract class FixedPriceProposalOutput : ProposalOptions, IOrganizationPersonTarget
    {
        public decimal TotalHours { get; set; }
        public decimal TotalDays { get; set; }
        public virtual decimal TotalPriceQuoted { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual Guid CustomerId { get; set; }
        public virtual Guid CustomerOrganizationId { get; set; }
        public virtual string CustomerOrganizationName { get; set; }

        public virtual int ContractCount { get; set; }
        public virtual int StoryCount { get; set; }

        public virtual string CustomerImageUrl { get; set; }
        public virtual string CustomerPhoneNumber { get; set; }
        public virtual string CustomerEmail { get; set; }
        public virtual string CustomerOrganizationImageUrl { get; set; }
        public Guid Id { get; set; }
        public Guid ProviderOrganizationOwnerId { get; set; }
        public virtual ProposalStatus Status { get; set; }

        public virtual ProposalType ProposalType { get; set; }

        public virtual int ExtraDayBasis { get; set; }

        public virtual int StoryHours { get; set; }

        public virtual decimal DailyCapacity { get; set; }
        public virtual decimal WeeklyCapacity { get; set; }
        public virtual string ProjectAbbreviation { get; set; }

        public virtual string ProjectManagerName { get; set; }
        public virtual string ProjectManagerOrganizationName { get; set; }
        public virtual Guid ProjectManagerId { get; set; }
        public virtual Guid ProjectManagerOrganizationId { get; set; }
        public virtual string ProjectManagerPhoneNumber { get; set; }
        public virtual string ProjectManagerEmail { get; set; }
        public virtual string ProjectManagerImageUrl { get; set; }
        public virtual string ProjectManagerOrganizationImageUrl { get; set; }

        public virtual string AccountManagerName { get; set; }
        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid AccountManagerOrganizationId { get; set; }
        public virtual string AccountManagerOrganizationName { get; set; }
        public virtual string AccountManagerPhoneNumber { get; set; }
        public virtual string AccountManagerEmail { get; set; }
        public virtual string AccountManagerImageUrl { get; set; }
        public virtual string AccountManagerOrganizationImageUrl { get; set; }
        public abstract Guid TargetOrganizationId { get; }
        public abstract Guid TargetPersonId { get; }
    }
}