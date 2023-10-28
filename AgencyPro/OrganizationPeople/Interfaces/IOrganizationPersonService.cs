using System;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationPeople.Interfaces
{
    public interface IOrganizationPersonService : IService<OrganizationPerson>
    {
        Task<T> GetOrganizationPerson<T>(Guid personId, Guid organizationId) where T : OrganizationPersonOutput;
        Task<OrganizationPersonOutput> Get(Guid personId, Guid organizationId);
        Task<IOrganizationPerson> GetPrincipal(Guid personId, Guid organizationId);

        Task<PagedList<T>> GetPeople<T>(IAgencyOwner ao, OrganizationPeopleFilters filters)
            where T : AgencyOwnerOrganizationPersonOutput;

        Task<PagedList<T>> GetPeople<T>(IOrganizationAccountManager am, OrganizationPeopleFilters filters)
            where T : AccountManagerOrganizationPersonOutput;

        Task<OrganizationPersonResult> Remove(IAgencyOwner input, Guid personId);

        Task<OrganizationPersonResult> Create(IAgencyOwner ao, CreateOrganizationPersonInput input);
        Task<OrganizationPersonResult> Create(IOrganizationAccountManager am, CreateOrganizationPersonInput input);

        Task<OrganizationPersonResult> Create(OrganizationPersonInput input, Guid organizationId);
        Task<OrganizationPersonResult> Create(CreateOrganizationPersonInput input, Guid organizationId, Guid? affiliateOrganizationId, bool checkValidation = true);

        Task<OrganizationPersonResult> AddExistingPerson(IAgencyOwner agencyOwner, AddExistingPersonInput input);

        Task<OrganizationPersonResult> HideOrganization(IOrganizationPerson person);
        Task<OrganizationPersonResult> ShowOrganization(IOrganizationPerson person);

        Task<OrganizationPersonOutput> GetPersonByCode(string code);
    }
}