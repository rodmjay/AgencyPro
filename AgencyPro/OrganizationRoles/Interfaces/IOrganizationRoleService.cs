using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.OrganizationRoles.Models;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationRoleService<in TInput, TOutput, TPrincipal, in TFilters, in TOrganizationOutput, TCount>
    {
        Task<TPrincipal> GetPrincipal(Guid personId, Guid organizationId);
        Task<TOutput> Get(Guid personId, Guid organizationId);
        Task<T> GetById<T>(Guid personId, Guid organizationId) where T : TOutput;
        Task<T> GetById<T>(TInput input) where T : TOutput;
        Task<List<T>> GetForOrganization<T>(Guid organizationId, TFilters filters) where T : TOutput;
        Task<PagedList<T>> GetForOrganization<T>(Guid organizationId, TFilters filters, PagingQuery pagingFilters) where T : TOutput;
        Task<List<T>> GetForOrganization<T>(Guid organization, Guid[] personIds) where T : TOutput;
        Task<OrganizationRoleResult> Remove(IAgencyOwner ao, Guid personId, bool commit = true);
        Task<T> Create<T>(TInput model) where T : TOutput;
        Task<T> Create<T>(IAgencyOwner ao, TInput input) where T : TOutput;
        Task<T> Update<T>(IAgencyOwner ao, TInput input) where T : TOutput;
        Task<T> Update<T>(IOrganizationAccountManager am, TInput input) where T : TOutput;
        Task<T> GetOrganization<T>(TPrincipal principal) where T : TOrganizationOutput;
        Task<TCount> GetCounts(TPrincipal principal);

    }
}