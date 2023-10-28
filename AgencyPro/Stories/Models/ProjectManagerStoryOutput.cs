using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Stories.Models
{
    [FlowDirective(FlowRoleToken.ProjectManager, "stories")]
    public class ProjectManagerStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}