using System;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.ProviderOrganizations.Models;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationAccountManagerService : IService<OrganizationAccountManager>,
        IOrganizationRoleService<OrganizationAccountManagerInput, OrganizationAccountManagerOutput,
            IOrganizationAccountManager, AccountManagerFilters, AccountManagerOrganizationOutput, AccountManagerCounts>
    {
     
        Task<T> GetAccountManagerForProject<T>(Guid projectId) 
            where T : OrganizationAccountManagerOutput;

        Task<T> GetAccountManagerOrDefault<T>(Guid organizationId, Guid? accountManager)
            where T : OrganizationAccountManagerOutput;
    }
}