using System;
using AgencyPro.Projects.Enums;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    public abstract class RecruitingContractOutput : ContractOutput
    {
        [JsonIgnore] public sealed override decimal ContractorStream { get; set; }

        [JsonIgnore]
        public sealed override decimal MarketerStream { get; set; }

        [JsonIgnore] public sealed override decimal AccountManagerStream { get; set; }
        [JsonIgnore] public sealed override decimal ProjectManagerStream { get; set; }

        [JsonIgnore] public sealed override decimal MarketingAgencyStream { get; set; }

        [JsonIgnore] public sealed override decimal CustomerRate { get; set; }
        [JsonIgnore] public sealed override decimal MaxCustomerWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxContractorWeekly { get; set; }


        [JsonIgnore] public sealed override string ProjectName { get; set; }
        [JsonIgnore] public sealed override string ProjectAbbreviation { get; set; }
        [JsonIgnore] public sealed override ProjectStatus ProjectStatus { get; set; }
        [JsonIgnore] public sealed override int ProviderNumber { get; set; }
        [JsonIgnore] public sealed override int BuyerNumber { get; set; }
        [JsonIgnore] public sealed override int MarketingNumber { get; set; }

        [JsonIgnore]
        public sealed override decimal MaxMarketerWeekly { get; set; }

        [JsonIgnore]
        public sealed override decimal MaxMarketingAgencyWeekly { get; set; }

        [JsonIgnore]
        public sealed override decimal MaxSystemWeekly { get; set; }

        [JsonIgnore]
        public sealed override decimal AgencyStream { get; set; }

        [JsonIgnore]
        public sealed override decimal SystemStream { get; set; }

        [JsonIgnore] public sealed override decimal MaxAccountManagerWeekly { get; set; }

        [JsonIgnore]
        public sealed override decimal MaxAgencyWeekly { get; set; }

        [JsonIgnore] public sealed override Guid MarketerId { get; set; }
        [JsonIgnore] public sealed override Guid MarketerOrganizationId { get; set; }
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

        [JsonIgnore] public sealed override string CustomerName { get; set; }
        [JsonIgnore] public sealed override string CustomerEmail { get; set; }
        [JsonIgnore] public sealed override string CustomerPhoneNumber { get; set; }
        [JsonIgnore] public sealed override string CustomerImageUrl { get; set; }

        [JsonIgnore] public sealed override Guid CustomerId { get; set; }

        [JsonIgnore] public sealed override string MarketerImageUrl { get; set; }
        [JsonIgnore] public sealed override string MarketerOrganizationImageUrl { get; set; }
        [JsonIgnore] public sealed override string MarketerName { get; set; }
        [JsonIgnore] public sealed override string MarketerEmail { get; set; }
        [JsonIgnore] public sealed override string MarketerPhoneNumber { get; set; }
        [JsonIgnore] public sealed override string MarketerOrganizationName { get; set; }
        [JsonIgnore] public sealed override decimal MaxProjectManagerWeekly { get; set; }
    }
}