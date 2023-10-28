using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Proposals.Models
{
    [FlowDirective(FlowRoleToken.ProjectManager, "proposals")]
    public class ProjectManagerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;
        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}