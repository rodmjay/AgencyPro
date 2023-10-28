using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Proposals.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "proposals")]
    public class AgencyOwnerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;
        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;
        
    }
}