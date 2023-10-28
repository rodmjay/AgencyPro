using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Stories.Models
{
    [FlowDirective(FlowRoleToken.Customer, "stories")]
    public class CustomerStoryOutput : StoryOutput
    {
        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;
    }
}