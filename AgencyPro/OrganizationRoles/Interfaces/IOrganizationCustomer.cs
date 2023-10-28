using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationCustomer
    {
        Guid OrganizationId { get; }
        Guid CustomerId { get; }
    }
}