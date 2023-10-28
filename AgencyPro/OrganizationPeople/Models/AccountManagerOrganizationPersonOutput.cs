using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.OrganizationPeople.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "people")]
    public class AccountManagerOrganizationPersonOutput : OrganizationPersonOutput
    {
        public override Guid TargetOrganizationId => this.OrganizationId;
    }
}