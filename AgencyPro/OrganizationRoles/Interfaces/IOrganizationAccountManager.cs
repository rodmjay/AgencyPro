using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationAccountManager
    {
        Guid OrganizationId { get; }
        Guid AccountManagerId { get; }
    }
}