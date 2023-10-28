using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationProjectManager
    {
        Guid ProjectManagerId { get; set; }
        Guid OrganizationId { get; set; }
    }
}