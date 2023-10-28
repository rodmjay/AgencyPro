using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.TimeEntries.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "time")]
    public class AccountManagerTimeEntryOutput
        : TimeEntryOutput
    {
        public override Guid TargetOrganizationId => this.ContractorOrganizationId;
        public override Guid TargetPersonId => this.AccountManagerId;
    }
}