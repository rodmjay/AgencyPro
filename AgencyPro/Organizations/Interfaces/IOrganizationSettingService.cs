using System;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Organizations.Entities;
using AgencyPro.Organizations.Enums;
using AgencyPro.Organizations.Models;

namespace AgencyPro.Organizations.Interfaces
{
    public interface IOrganizationSettingService : IService<OrganizationSetting>
    {
        Task<OrganizationSettingResult> CreateSetting(IProviderAgencyOwner agencyOwner, OrganizationSettingInputModel model);
        Task<OrganizationSettingOutput> GetSetting(IProviderAgencyOwner agencyOwner, SectionType sectionType);
        Task<OrganizationSettingResult> CheckOrganizationAllowed(Guid organizationId, SectionType sectionType, MenuType menuType);
    }
}
