using System.Threading.Tasks;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.TimeEntries.Models;
using AgencyPro.TimeEntries.Models.TimeMatrix;

namespace AgencyPro.TimeEntries.Interfaces
{
    public interface ITimeMatrixService
    {
        Task<AccountManagerTimeMatrixComposedOutput> GetComposedOutput(IOrganizationAccountManager am, TimeMatrixFilters filters);
        Task<ProjectManagerTimeMatrixComposedOutput> GetComposedOutput(IOrganizationProjectManager pm, TimeMatrixFilters filters);
        Task<CustomerTimeMatrixComposedOutput> GetComposedOutput(IOrganizationCustomer cu, TimeMatrixFilters filters);
        Task<ContractorTimeMatrixComposedOutput> GetComposedOutput(IOrganizationContractor co, TimeMatrixFilters filters);
        Task<RecruiterTimeMatrixComposedOutput> GetComposedOutput(IOrganizationRecruiter re, TimeMatrixFilters filters);
        Task<MarketerTimeMatrixComposedOutput> GetComposedOutput(IOrganizationMarketer ma, TimeMatrixFilters filters);

        Task<ProviderAgencyOwnerTimeMatrixComposedOutput> GetProviderAgencyComposedOutput(IProviderAgencyOwner owner, TimeMatrixFilters filters);
        Task<MarketingAgencyOwnerTimeMatrixComposedOutput> GetMarketingAgencyComposedOutput(IMarketingAgencyOwner owner, TimeMatrixFilters filters);
        Task<RecruitingAgencyOwnerTimeMatrixComposedOutput> GetRecruitingAgencyComposedOutput(IRecruitingAgencyOwner owner, TimeMatrixFilters filters);
       
        
    }
}