using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.OrganizationPeople.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "people")]

    public class AgencyOwnerOrganizationPersonOutput
        : OrganizationPersonOutput
    {
        public override Guid TargetOrganizationId => this.OrganizationId;
    }
}