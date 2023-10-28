using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Projects.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "projects")]
    public class AgencyOwnerProjectOutput : ProjectOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;
        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}