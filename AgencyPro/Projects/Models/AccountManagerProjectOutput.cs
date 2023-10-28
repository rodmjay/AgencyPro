using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Projects.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "projects")]
    public class AccountManagerProjectOutput : ProjectOutput
    {
        public override Guid TargetOrganizationId => ProjectManagerOrganizationId;
        public override Guid TargetPersonId => AccountManagerId;

        [JsonIgnore] public override decimal WeightedAgencyAverage { get; }
        [JsonIgnore] public override decimal WeightedMarketingAgencyAverage { get; }
        [JsonIgnore] public override decimal WeightedRecruitingAgencyAverage { get; }

        [JsonIgnore] public override decimal WeightedSystemAverage { get; }


        [JsonIgnore] public override decimal MaxSystemStream { get; set; }

        [JsonIgnore] public override decimal MaxAgencyStream { get; set; }
        [JsonIgnore] public override decimal MaxRecruitingAgencyStream { get; set; }
        [JsonIgnore] public override decimal MaxMarketingAgencyStream { get; set; }
    }
}