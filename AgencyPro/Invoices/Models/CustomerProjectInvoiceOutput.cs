using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Invoices.Models
{
    [FlowDirective(FlowRoleToken.Customer, "invoices")]
    public class CustomerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;

    }
}