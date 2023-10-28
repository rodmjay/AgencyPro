using System;
using AgencyPro.PayoutIntents.Enums;

namespace AgencyPro.PayoutIntents.Interfaces
{
    public interface IIndividualPayoutIntent
    {
        Guid Id { get; set; }
        Guid PersonId { get; set; }
        Guid OrganizationId { get; set; }
        string InvoiceItemId { get; set; }
        decimal Amount { get; set; }
        CommissionType Type { get; set; }
        string Description { get; set; }
        string InvoiceTransferId { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}