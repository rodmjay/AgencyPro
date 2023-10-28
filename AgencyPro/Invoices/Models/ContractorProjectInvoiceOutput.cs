using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Invoices.Models
{
    [FlowDirective(FlowRoleToken.Contractor, "invoices")]
    public class ContractorProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
    }
}