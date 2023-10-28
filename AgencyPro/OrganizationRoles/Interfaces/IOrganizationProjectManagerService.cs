using System;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.ProviderOrganizations.Models;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationProjectManagerService : IService<OrganizationProjectManager>,
        IOrganizationRoleService<OrganizationProjectManagerInput, OrganizationProjectManagerOutput,
            IOrganizationProjectManager, ProjectManagerFilters, ProjectManagerOrganizationOutput, ProjectManagerCounts>
    {
        Task<T> GetProjectManagerForProject<T>(Guid projectId) where T : OrganizationProjectManagerOutput;
    }
}