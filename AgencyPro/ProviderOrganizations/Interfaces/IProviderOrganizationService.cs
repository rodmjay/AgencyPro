using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.ProviderOrganizations.Models;

namespace AgencyPro.ProviderOrganizations.Interfaces
{
    public interface IProviderOrganizationService
    {
        Task<List<MarketerProviderOrganizationOutput>> GetProviderOrganizations(IOrganizationMarketer marketer);
        Task<List<RecruiterProviderOrganizationOutput>> GetProviderOrganizations(IOrganizationRecruiter recruiter);

        Task<List<T>> Discover<T>(IMarketingAgencyOwner principal) where T : MarketingAgencyOwnerProviderOrganizationOutput;
        Task<List<T>> Discover<T>(IRecruitingAgencyOwner principal) where T : RecruitingAgencyOwnerProviderOrganizationOutput;
    }
}