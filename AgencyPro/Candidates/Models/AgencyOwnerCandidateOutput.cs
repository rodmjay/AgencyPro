using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Candidates.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "candidates")]
    public class AgencyOwnerCandidateOutput : CandidateOutput
    {
        [JsonIgnore]
        public override decimal RecruiterStream { get; set; }

        [JsonIgnore]
        public override decimal RecruiterBonus { get; set; }

        [JsonIgnore]
        public override decimal RecruitingAgencyBonus { get; set; }

        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;

        [JsonIgnore]
        public override decimal RecruitingAgencyStream { get; set; }
    }
}