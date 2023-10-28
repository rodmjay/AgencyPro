using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    [FlowDirective(FlowRoleToken.Customer, "contracts/buyer-contracts")]
    public abstract class BuyerContractOutput : ContractOutput
    {
        public override Guid TargetOrganizationId => CustomerOrganizationId;
        public override Guid TargetPersonId => CustomerId;

        [JsonIgnore] public sealed override decimal MarketingAgencyStream { get; set; }
        
        [JsonIgnore] public sealed override decimal MaxContractorWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxRecruiterWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxMarketerWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxProjectManagerWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxAccountManagerWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxAgencyWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxSystemWeekly { get; set; }
        [JsonIgnore] public sealed override Guid MarketerOrganizationId { get; set; }
       

        [JsonIgnore] public sealed override string RecruiterName { get; set; }
        [JsonIgnore] public sealed override string RecruiterImageUrl { get; set; }
        [JsonIgnore] public sealed override string RecruiterOrganizationName { get; set; }
        [JsonIgnore] public sealed override string RecruiterOrganizationImageUrl { get; set; }
        [JsonIgnore] public sealed override string MarketerName { get; set; }
        [JsonIgnore] public sealed override string MarketerImageUrl { get; set; }
        [JsonIgnore] public sealed override string MarketerOrganizationName { get; set; }
        [JsonIgnore] public sealed override string MarketerOrganizationImageUrl { get; set; }

        [JsonIgnore] public sealed override Guid RecruiterId { get; set; }
        [JsonIgnore] public sealed override Guid RecruiterOrganizationId { get; set; }
        [JsonIgnore] public sealed override Guid MarketerId { get; set; }
        [JsonIgnore] public sealed override decimal ContractorStream { get; set; }
        [JsonIgnore] public sealed override decimal MarketerStream { get; set; }
        [JsonIgnore] public sealed override decimal AccountManagerStream { get; set; }
        [JsonIgnore] public sealed override decimal ProjectManagerStream { get; set; }
        [JsonIgnore] public sealed override decimal RecruiterStream { get; set; }
        [JsonIgnore] public sealed override decimal SystemStream { get; set; }
        [JsonIgnore] public sealed override decimal AgencyStream { get; set; }
        [JsonIgnore] public sealed override decimal RecruitingAgencyStream { get; set; }
        [JsonIgnore] public sealed override decimal MaxRecruitingAgencyWeekly { get; set; }
        [JsonIgnore] public sealed override decimal MaxMarketingAgencyWeekly { get; set; }
    }
}