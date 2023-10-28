using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationContractor
    {
        Guid OrganizationId { get; }
        Guid ContractorId { get; }
    }
}