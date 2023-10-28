using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationRecruiter
    {
        Guid OrganizationId { get; }    
        Guid RecruiterId { get; }
    }
}