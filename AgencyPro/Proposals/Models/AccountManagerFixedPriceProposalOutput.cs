using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Proposals.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "proposals")]
    public class AccountManagerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.AccountManagerOrganizationId;
        public override Guid TargetPersonId => this.AccountManagerId;

    }
}