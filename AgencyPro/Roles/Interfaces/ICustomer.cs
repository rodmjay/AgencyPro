using System;

namespace AgencyPro.Roles.Interfaces
{
    public interface ICustomer
    {
        Guid Id { get; set; }
        Guid MarketerId { get; set; }
        Guid MarketerOrganizationId { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}