using System;
using AgencyPro.Projects.Enums;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    public abstract class MarketingContractOutput : ContractOutput
    {
        [JsonIgnore] public sealed override string ProjectName { get; set; }
        [JsonIgnore] public sealed override string ProjectAbbreviation { get; set; }
        [JsonIgnore] public sealed override ProjectStatus ProjectStatus { get; set; }
        [JsonIgnore] public sealed override decimal CustomerRate { get; set; }
        [JsonIgnore] public sealed override decimal MaxCustomerWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxContractorWeekly { get; set; }
        [JsonIgnore] public sealed override int ProviderNumber { get; set; }
        [JsonIgnore] public sealed override int BuyerNumber { get; set; }
        [JsonIgnore] public sealed override int RecruitingNumber { get; set; }

        [JsonIgnore] public sealed override string ContractorOrganizationImageUrl { get; set; }
       
        [JsonIgnore] public sealed override string RecruiterName { get; set; }
        [JsonIgnore] public sealed override string RecruiterEmail { get; set; }
        [JsonIgnore] public sealed override string RecruiterPhoneNumber { get; set; }
        [JsonIgnore] public sealed override string RecruiterImageUrl { get; set; }
        [JsonIgnore] public sealed override string RecruiterOrganizationName { get; set; }
        [JsonIgnore] public sealed override string RecruiterOrganizationImageUrl { get; set; }

        [JsonIgnore] public sealed override decimal RecruitingAgencyStream { get; set; }

        [JsonIgnore] public sealed override decimal ProjectManagerStream { get; set; }
        [JsonIgnore] public sealed override decimal RecruiterStream { get; set; }

        [JsonIgnore] public sealed override decimal MaxRecruiterWeekly { get; set; }
       
        [JsonIgnore] public sealed override decimal MaxProjectManagerWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxAccountManagerWeekly { get; set; }

        [JsonIgnore] public sealed override decimal MaxRecruitingAgencyWeekly { get; set; }

        [JsonIgnore] public sealed override decimal MaxSystemWeekly { get; set; }
        [JsonIgnore] public sealed override decimal SystemStream { get; set; }

        [JsonIgnore] public sealed override decimal AgencyStream { get; set; }
        [JsonIgnore] public sealed override decimal MaxAgencyWeekly { get; set; }

        [JsonIgnore] public sealed override string ProjectManagerName { get; set; }
        [JsonIgnore] public sealed override string ProjectManagerEmail { get; set; }
        [JsonIgnore] public sealed override string ProjectManagerPhoneNumber { get; set; }
        [JsonIgnore] public sealed override string ProjectManagerOrganizationName { get; set; }
        [JsonIgnore] public sealed override Guid ProjectManagerId { get; set; }
        [JsonIgnore] public sealed override Guid ProjectManagerOrganizationId { get; set; }
        [JsonIgnore] public sealed override string ProjectManagerImageUrl { get; set; }
        [JsonIgnore] public sealed override string ProjectManagerOrganizationImageUrl { get; set; }
        [JsonIgnore] public sealed override string AccountManagerName { get; set; }
        [JsonIgnore] public sealed override string AccountManagerEmail { get; set; }
        [JsonIgnore] public sealed override string AccountManagerPhoneNumber { get; set; }
        [JsonIgnore] public sealed override Guid AccountManagerId { get; set; }
        [JsonIgnore] public sealed override Guid AccountManagerOrganizationId { get; set; }
        [JsonIgnore] public sealed override string AccountManagerOrganizationName { get; set; }
        [JsonIgnore] public sealed override string AccountManagerImageUrl { get; set; }
        [JsonIgnore] public sealed override string AccountManagerOrganizationImageUrl { get; set; }
        [JsonIgnore] public sealed override string ContractorName { get; set; }
        [JsonIgnore] public sealed override string ContractorEmail { get; set; }
        [JsonIgnore] public sealed override string ContractorPhoneNumber { get; set; }
        [JsonIgnore] public sealed override string ContractorOrganizationName { get; set; }
        [JsonIgnore] public sealed override string ContractorImageUrl { get; set; }
        [JsonIgnore] public sealed override Guid RecruiterId { get; set; }
        [JsonIgnore] public sealed override Guid RecruiterOrganizationId { get; set; }
        [JsonIgnore] public sealed override decimal ContractorStream { get; set; }
        [JsonIgnore] public sealed override decimal AccountManagerStream { get; set; }

    }
}