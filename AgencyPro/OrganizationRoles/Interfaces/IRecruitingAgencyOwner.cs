using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IRecruitingAgencyOwner
    {
        Guid OrganizationId { get; }
        Guid CustomerId { get; }
    }
}