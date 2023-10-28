using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Skills.Models;

namespace AgencyPro.Skills.Interfaces
{
    public interface IOrganizationSkillService
    {
        Task<OrganizationSkillOutput> Add(IAgencyOwner agencyOwner, Guid skillId, OrganizationSkillInput input);
        Task<OrganizationSkillOutput> Update(IAgencyOwner agencyOwner, Guid skillId, OrganizationSkillInput input);

        Task<bool> Remove(IAgencyOwner agencyOwner, Guid skillId);

        Task<List<OrganizationSkillOutput>> GetSkills(Guid organizationId);
    }
}