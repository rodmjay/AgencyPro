using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Candidates.Models
{
    [FlowDirective(FlowRoleToken.RecruitingAgencyOwner, "candidates")]
    public class RecruitingAgencyCandidateOutput : CandidateOutput
    {
        [JsonIgnore]
        public override Guid? ProjectManagerId { get; set; }

        [JsonIgnore]
        public override string ProjectManagerImageUrl { get; set; }

        [JsonIgnore]
        public override string ProjectManagerName { get; set; }

        [JsonIgnore]
        public override string ProjectManagerOrganizationImageUrl { get; set; }

        public override Guid TargetOrganizationId => this.RecruiterOrganizationId;
        public override Guid TargetPersonId => this.RecruitingOrganizationOwnerId;

        [JsonIgnore]
        public override string ProjectManagerOrganizationName { get; set; }

        [JsonIgnore]
        public override Guid? ProjectManagerOrganizationId { get; set; }

    }
}