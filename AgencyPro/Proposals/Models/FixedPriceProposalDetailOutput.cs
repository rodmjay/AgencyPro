using System;
using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.Proposals.Models
{
    public class FixedPriceProposalDetailOutput : FixedPriceProposalOutput
    {
        public override Guid TargetOrganizationId => this.ProjectManagerOrganizationId;

        public override Guid TargetPersonId => this.ProviderOrganizationOwnerId;

        public ProposalAcceptanceDetailOutput ProposalAcceptance { get; set; }
        public ICollection<ProposedContractOutput> ProposedContracts { get; set; }
        public ICollection<ProposedStoryOutput> ProposedStories { get; set; }
    }
}
