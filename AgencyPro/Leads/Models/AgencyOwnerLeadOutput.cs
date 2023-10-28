using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Leads.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "leads")]
    public class AgencyOwnerLeadOutput : LeadOutput
    {
        public override Guid TargetOrganizationId => ProviderOrganizationId;
        public override Guid TargetPersonId => ProviderOrganizationOwnerId;

        [JsonIgnore] public override decimal MarketerStream { get; set; }
        [JsonIgnore] public override decimal MarketerBonus { get; set; }
        [JsonIgnore] public override decimal MarketingAgencyBonus { get; set; }
        [JsonIgnore] public override decimal MarketingAgencyStream { get; set; }
    }
}