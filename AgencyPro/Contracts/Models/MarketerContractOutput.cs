using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    [FlowDirective(FlowRoleToken.Marketer, "contracts")]
    public class MarketerContractOutput : MarketingContractOutput
    {
        public override Guid TargetOrganizationId => MarketerOrganizationId;
        [JsonIgnore] public override decimal MaxMarketingAgencyWeekly { get; set; }

        public override decimal MaxMarketerWeekly { get; set; }

        public override decimal MarketerStream { get; set; }

        public override int MarketingNumber { get; set; }
        [JsonIgnore] public override Guid MarketerId { get; set; }
        [JsonIgnore] public override decimal MarketingAgencyStream { get; set; }
        [JsonIgnore] public override Guid MarketerOrganizationId { get; set; }
        [JsonIgnore] public override string MarketerImageUrl { get; set; }
        [JsonIgnore] public override string MarketerOrganizationImageUrl { get; set; }
        public override decimal TotalHoursLogged { get; set; }
        public override decimal TotalApprovedHours { get; set; }
        [JsonIgnore] public override string MarketerName { get; set; }
        [JsonIgnore] public override string MarketerOrganizationName { get; set; }

  
        public override string CustomerName { get; set; }
        public override string CustomerImageUrl { get; set; }
        public override string CustomerOrganizationName { get; set; }
        public override string CustomerOrganizationImageUrl { get; set; }
        public override Guid CustomerOrganizationId { get; set; }
        public override Guid CustomerId { get; set; }

        public override Guid TargetPersonId => this.MarketerId;
    }
}