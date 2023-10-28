using System;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IAgencyOwner
    {
        Guid OrganizationId { get; }
        Guid CustomerId { get; }
        bool IsMarketingOwner { get; set; }
        bool IsRecruitingOwner { get; set; }
        bool IsProviderOwner { get; set; }
    }
}