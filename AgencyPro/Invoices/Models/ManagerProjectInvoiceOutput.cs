using System;

namespace AgencyPro.Invoices.Models
{
    public class ManagerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;

    }
}