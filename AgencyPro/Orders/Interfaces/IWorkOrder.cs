using System;
using AgencyPro.Orders.Enums;

namespace AgencyPro.Orders.Interfaces
{
    public interface IWorkOrder
    {
        Guid Id { get; set; }

        int BuyerNumber { get; set; }
        int ProviderNumber { get; set; }

        string Description { get; set; }
        OrderStatus Status { get; set; }

        Guid AccountManagerId { get; set; }
        Guid AccountManagerOrganizationId { get; set; }

        Guid CustomerId { get; set; }
        Guid CustomerOrganizationId { get; set; }
        DateTimeOffset? ProviderResponseTime { get; set; }
    }
}