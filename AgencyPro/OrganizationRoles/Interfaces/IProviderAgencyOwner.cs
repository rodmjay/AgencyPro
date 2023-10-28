using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IProviderAgencyOwner 
    {
        Guid OrganizationId { get; }
        Guid CustomerId { get; }
    }
}