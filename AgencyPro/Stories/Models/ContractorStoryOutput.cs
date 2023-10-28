using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Stories.Models
{
    [FlowDirective(FlowRoleToken.Contractor, "stories")]
    public class ContractorStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ContractorOrganizationId.Value;
    }
}