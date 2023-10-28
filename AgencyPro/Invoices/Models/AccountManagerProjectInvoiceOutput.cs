using System;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Invoices.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "invoices")]
    public class AccountManagerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
    }
}