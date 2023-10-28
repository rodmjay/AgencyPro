using System;

namespace AgencyPro.Invoices.Interfaces
{
    public interface IInvoiceMatrix
    {
        Guid CustomerId { get; set; }
        Guid CustomerOrganizationId { get; set; }
    }
}