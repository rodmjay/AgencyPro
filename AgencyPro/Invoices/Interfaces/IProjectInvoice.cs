using System;
using AgencyPro.Stripe.Interfaces;

namespace AgencyPro.Invoices.Interfaces
{
    public interface IProjectInvoice : IInvoice
    {
        Guid ProjectId { get; set; }
     
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        string RefNo { get; set; }
    }
}