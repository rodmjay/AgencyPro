using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationMarketer
    {
        Guid MarketerId { get; set; }
        Guid OrganizationId { get; set; }
    }
}