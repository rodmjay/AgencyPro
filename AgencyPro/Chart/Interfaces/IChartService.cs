using System.Threading.Tasks;
using AgencyPro.Chart.ViewModels;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.Chart.Interfaces
{
    public interface  IChartService
    {
        Task<ProviderAgencyOwnerChartOutput> GetProviderChartData(IProviderAgencyOwner owner, TimeMatrixFilters filters, ChartParams chartParams);
        Task<MarketingAgencyOwnerChartOutput> GetMarketingChartData(IMarketingAgencyOwner owner, TimeMatrixFilters filters, ChartParams chartParams);
        Task<RecruitingAgencyOwnerChartOutput> GetRecruitingChartData(IRecruitingAgencyOwner owner, TimeMatrixFilters filters, ChartParams chartParams);

        Task<AccountManagerChartOutput> GetProviderChartData(IOrganizationAccountManager owner, TimeMatrixFilters filters, ChartParams chartParams);
        Task<ProjectManagerChartOutput> GetProviderChartData(IOrganizationProjectManager pm, TimeMatrixFilters filters, ChartParams chartParams);
        Task<CustomerChartOutput> GetProviderChartData(IOrganizationCustomer cu, TimeMatrixFilters filters, ChartParams chartParams);
        Task<ContractorChartOutput> GetProviderChartData(IOrganizationContractor co, TimeMatrixFilters filters, ChartParams chartParams);
        Task<RecruiterChartOutput> GetProviderChartData(IOrganizationRecruiter re, TimeMatrixFilters filters, ChartParams chartParams);
        Task<MarketerChartOutput> GetProviderChartData(IOrganizationMarketer ma, TimeMatrixFilters filters, ChartParams chartParams);
    }
}
