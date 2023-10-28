using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Models.OrganizationRecruiters;
using AgencyPro.RecruitingOrganizations.Models;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationRecruiterService
        : IService<OrganizationRecruiter>,
            IOrganizationRoleService<OrganizationRecruiterInput, OrganizationRecruiterOutput,
                IOrganizationRecruiter, RecruiterFilters, RecruiterOrganizationOutput, RecruiterCounts>
    {
      
    }
}