using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IMarketingAgencyOwner
    {
        Guid OrganizationId { get; }
        Guid CustomerId { get; }
    }
}