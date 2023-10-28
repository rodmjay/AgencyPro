using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.ProviderOrganizations.Models;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationContractorService : IService<OrganizationContractor>,
        IOrganizationRoleService<OrganizationContractorInput,
            OrganizationContractorOutput, IOrganizationContractor, ContractorFilters, ContractorOrganizationOutput, ContractorCounts>
    {
        Task<List<T>> GetFeaturedContractors<T>(Guid organizationId)
            where T : OrganizationContractorOutput;
        
        Task<T> UpdateRecruiter<T>(IAgencyOwner agencyOwner, Guid contractorId, UpdateContractorRecruiterInput input) where T : AgencyOwnerOrganizationContractorOutput;
    }
}