using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Invoices.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "invoices")]
    public class AgencyOwnerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;

    }
}