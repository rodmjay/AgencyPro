using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Stories.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "stories")]
    public class AgencyOwnerStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;
    }
}