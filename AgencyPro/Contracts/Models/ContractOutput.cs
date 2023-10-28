using System;
using AgencyPro.Contracts.Enums;
using AgencyPro.Contracts.Interfaces;
using AgencyPro.Organizations.Interfaces;
using AgencyPro.Projects.Enums;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    public abstract class ContractOutput : ContractInput, IContract, IOrganizationPersonTarget
    {


        [JsonIgnore]
        public abstract Guid TargetOrganizationId { get; }
        
        public virtual string ContractId { get; set; }


        public virtual string ProjectName { get; set; }
        public virtual string ProjectAbbreviation { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }


        public virtual Guid Id { get; set; }

        [JsonProperty("number")]
        public virtual int ProviderNumber { get; set; }

        [JsonProperty("number")]
        public virtual int BuyerNumber { get; set; }

        [JsonProperty("number")]
        public virtual int MarketingNumber { get; set; }

        [JsonProperty("number")]
        public virtual int RecruitingNumber { get; set; }

        public virtual decimal CustomerRate { get; set; }
        public virtual decimal MaxCustomerWeekly { get; set; }
        public virtual decimal MaxContractorWeekly { get; set; }
        public virtual decimal MaxRecruiterWeekly { get; set; }
        public virtual decimal MaxMarketerWeekly { get; set; }
        public virtual decimal MaxProjectManagerWeekly { get; set; }
        public virtual decimal MaxAccountManagerWeekly { get; set; }
        public virtual decimal MaxAgencyWeekly { get; set; }
        public virtual decimal MaxRecruitingAgencyWeekly { get; set; }
        public virtual decimal MaxMarketingAgencyWeekly { get; set; }
        public virtual decimal MaxSystemWeekly { get; set; }

        [JsonIgnore] public virtual Guid CreatedById { get; set; }
        [JsonIgnore] public virtual Guid UpdatedById { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        [JsonIgnore] public virtual bool IsDeleted { get; set; }

        public virtual Guid RecruiterId { get; set; }

        public virtual Guid RecruiterOrganizationId { get; set; }
        public virtual Guid MarketerId { get; set; }

        public virtual decimal ContractorStream { get; set; }
        public virtual decimal MarketerStream { get; set; }
        public virtual decimal AccountManagerStream { get; set; }
        public virtual decimal ProjectManagerStream { get; set; }
        public virtual decimal RecruiterStream { get; set; }
        public virtual decimal SystemStream { get; set; }
        public virtual decimal AgencyStream { get; set; }
        public virtual decimal RecruitingAgencyStream { get; set; }
        public virtual decimal MarketingAgencyStream { get; set; }

        public virtual bool IsPaused { get; set; }

        public virtual bool IsEnded { get; set; }

        public virtual Guid MarketerOrganizationId { get; set; }

        public virtual string ProjectManagerName { get; set; }
        public virtual string ProjectManagerOrganizationName { get; set; }
        public virtual string ProjectManagerEmail { get; set; }
        public virtual string ProjectManagerPhoneNumber { get; set; }
        public virtual Guid ProjectManagerId { get; set; }
        public virtual Guid ProjectManagerOrganizationId { get; set; }
        public virtual string ProjectManagerImageUrl { get; set; }
        public virtual string ProjectManagerOrganizationImageUrl { get; set; }

        public virtual string AccountManagerName { get; set; }
        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid AccountManagerOrganizationId { get; set; }
        public virtual string AccountManagerOrganizationName { get; set; }
        public virtual string AccountManagerEmail { get; set; }
        public virtual string AccountManagerPhoneNumber { get; set; }
        public virtual string AccountManagerImageUrl { get; set; }
        public virtual string AccountManagerOrganizationImageUrl { get; set; }

        public virtual string ContractorName { get; set; }
        public virtual string ContractorOrganizationName { get; set; }
        public virtual string ContractorEmail { get; set; }
        public virtual string ContractorPhoneNumber { get; set; }
        public virtual string ContractorImageUrl { get; set; }
        public virtual string ContractorOrganizationImageUrl { get; set; }

        public virtual string CustomerName { get; set; }
        public virtual string CustomerImageUrl { get; set; }
        public virtual string CustomerEmail { get; set; }
        public virtual string CustomerPhoneNumber { get; set; }
        public virtual string CustomerOrganizationName { get; set; }
        public virtual string CustomerOrganizationImageUrl { get; set; }
        public virtual Guid CustomerOrganizationId { get; set; }
        public virtual Guid CustomerId { get; set; }


        public virtual string RecruiterName { get; set; }
        public virtual string RecruiterEmail { get; set; }
        public virtual string RecruiterPhoneNumber { get; set; }
        public virtual string RecruiterImageUrl { get; set; }
        public virtual string RecruiterOrganizationName { get; set; }
        public virtual string RecruiterOrganizationImageUrl { get; set; }

        public virtual string MarketerName { get; set; }
        public virtual string MarketerEmail { get; set; }
        public virtual string MarketerPhoneNumber { get; set; }
        public virtual string MarketerImageUrl { get; set; }
        public virtual string MarketerOrganizationName { get; set; }
        public virtual string MarketerOrganizationImageUrl { get; set; }

        public virtual decimal TotalHoursLogged { get; set; }

        public virtual decimal TotalApprovedHours { get; set; }

        public virtual ContractStatus Status { get; set; }

        public abstract Guid TargetPersonId { get; }

        public virtual Guid MarketingOrganizationOwnerId { get; set; }
        public virtual Guid RecruitingOrganizationOwnerId { get; set; }
        public virtual Guid ProviderOrganizationOwnerId { get; set; }

        

    }
}