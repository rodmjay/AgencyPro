using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Roles.Models;
using AgencyPro.Roles.ViewModels.Contractors;

namespace AgencyPro.Roles.Interfaces
{
    public interface IContractorService :
        IService<Contractor>,
        IRoleService<ContractorInput, ContractorUpdateInput, ContractorOutput, IContractor>
    {
        Task<PagedList<T>> GetContractors<T>(
            IOrganizationRecruiter re, CommonFilters filters) where T : ContractorOutput;
    }
}