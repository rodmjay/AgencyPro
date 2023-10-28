using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Proposals.Models
{
    [FlowDirective(FlowRoleToken.Customer, "proposals")]
    public class CustomerFixedPriceProposalOutput : FixedPriceProposalOutput
    {
        [JsonIgnore]
        public override decimal OtherPercentBasis { get; set; }

        public override Guid TargetOrganizationId => this.CustomerOrganizationId;
        public override Guid TargetPersonId => this.CustomerId;
    }
}