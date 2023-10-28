using System;

namespace AgencyPro.Invoices.Interfaces
{
    public interface IInvoiceExtraLineItem
    {
        Guid Id { get; set; }
        Guid InvoiceId { get; set; }
        decimal UnitPrice { get; set; }
        decimal Quantity { get; set; }
        string Description { get; set; }
    }
}