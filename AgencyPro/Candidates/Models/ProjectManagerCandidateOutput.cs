using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Candidates.Models
{
    [FlowDirective(FlowRoleToken.ProjectManager, "candidates")]
    public class ProjectManagerCandidateOutput : CandidateOutput
    {
        [JsonIgnore] public override Guid? ProjectManagerOrganizationId { get; set; }
        [JsonIgnore] public override Guid? ProjectManagerId { get; set; }
        [JsonIgnore] public override string ProjectManagerImageUrl { get; set; }
        [JsonIgnore] public override string ProjectManagerName { get; set; }
        [JsonIgnore] public override string ProjectManagerOrganizationImageUrl { get; set; }

        public override Guid TargetOrganizationId => ProviderOrganizationId;
        public override Guid TargetPersonId => ProjectManagerId.Value;

        [JsonIgnore] public override string ProjectManagerOrganizationName { get; set; }
        [JsonIgnore] public override decimal RecruitingAgencyStream { get; set; }
        [JsonIgnore] public override decimal RecruitingAgencyBonus { get; set; }
        [JsonIgnore] public override decimal RecruiterBonus { get; set; }
        [JsonIgnore] public override decimal RecruiterStream { get; set; }
        [JsonIgnore] public override decimal RecruitingStream { get; }
        [JsonIgnore] public override decimal RecruitingBonus { get; }
    }
}