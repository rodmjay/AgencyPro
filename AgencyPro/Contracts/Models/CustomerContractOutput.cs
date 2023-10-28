using System;
using AgencyPro.Projects.Enums;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    public class CustomerContractOutput : BuyerContractOutput
    {
        public override string ProjectName { get; set; }
        public override string ProjectAbbreviation { get; set; }
        public override ProjectStatus ProjectStatus { get; set; }
        [JsonIgnore] public override int ProviderNumber { get; set; }
        public override int BuyerNumber { get; set; }
        [JsonIgnore] public override int MarketingNumber { get; set; }
        [JsonIgnore] public override int RecruitingNumber { get; set; }
        public override decimal CustomerRate { get; set; }
        public override decimal MaxCustomerWeekly { get; set; }
        public override string ProjectManagerName { get; set; }
        public override string ProjectManagerOrganizationName { get; set; }
        public override Guid ProjectManagerId { get; set; }
        public override Guid ProjectManagerOrganizationId { get; set; }
        public override string ProjectManagerImageUrl { get; set; }
        public override string ProjectManagerOrganizationImageUrl { get; set; }
        public override string AccountManagerName { get; set; }
        public override Guid AccountManagerId { get; set; }
        public override Guid AccountManagerOrganizationId { get; set; }
        public override string AccountManagerOrganizationName { get; set; }
        public override string AccountManagerImageUrl { get; set; }
        public override string AccountManagerOrganizationImageUrl { get; set; }
        public override string ContractorName { get; set; }
        public override string ContractorOrganizationName { get; set; }
        public override string ContractorImageUrl { get; set; }
        public override string ContractorOrganizationImageUrl { get; set; }
        public override string CustomerName { get; set; }
        public override string CustomerImageUrl { get; set; }
        public override string CustomerOrganizationName { get; set; }
        public override string CustomerOrganizationImageUrl { get; set; }
        public override Guid CustomerOrganizationId { get; set; }
        public override Guid CustomerId { get; set; }
        public override decimal TotalHoursLogged { get; set; }
        public override decimal TotalApprovedHours { get; set; }
    }
}