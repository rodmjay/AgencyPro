using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Organizations.Entities;
using AgencyPro.Organizations.Models;
using AgencyPro.ProviderOrganizations.Models;
using AgencyPro.RecruitingOrganizations.Models;
using AgencyPro.Roles.Interfaces;
using Microsoft.AspNetCore.Http;

namespace AgencyPro.Organizations.Interfaces
{
    public interface IOrganizationService : IService<Organization>
    {
        Task<Result> UpgradeOrganization(IOrganizationCustomer customer, OrganizationUpgradeInput input);

        Task<Result> UpgradeOrganization(IAgencyOwner agencyOwner,
            MarketingOrganizationUpgradeInput input);
        Task<Result> UpgradeOrganization(IAgencyOwner agencyOwner,
            ProviderOrganizationUpgradeInput input);
        Task<Result> UpgradeOrganization(IAgencyOwner agencyOwner,
            RecruitingOrganizationUpgradeInput input);

        Task<Result> UpdateOrganization(IAgencyOwner agencyOwner, OrganizationUpdateInput input);
        Task<Result> UpdateOrganization(IMarketingAgencyOwner agencyOwner, MarketingOrganizationInput input);
        Task<Result> UpdateOrganization(IProviderAgencyOwner agencyOwner, ProviderOrganizationInput input);
        Task<Result> UpdateOrganization(IRecruitingAgencyOwner agencyOwner, RecruitingOrganizationInput input);

        //Task<T> UpdateMarketingOrganization<T>(IAgencyOwner agencyOwner, MarketingOrganizationUpdateInput input) where T : MarketingAgencyOwnerOrganizationOutput;
        //Task<T> UpdateProviderOrganization<T>(IAgencyOwner agencyOwner, ProviderOrganizationUpdateInput input) where T : ProviderAgencyOwnerOrganizationOutput;
        Task<Result> UpdateBuyerOrganization(IOrganizationCustomer cu, OrganizationUpdateInput input);

        Task<Result> UpdateOrganizationPic(IAgencyOwner agencyOwner, IFormFile image);
        Task<Result> UpdateOrganizationPic(IOrganizationCustomer customerOrg, IFormFile image);

        Task<Result> CreateOrganization(IAgencyOwner ao, OrganizationCreateInput input, Guid customerId);
        Task<Result> CreateOrganization(ICustomer cu, OrganizationCreateInput input);
        Task<Result> CreateOrganization(IOrganizationAccountManager am, OrganizationCreateInput input, Guid customerId);
        
        Task<OrganizationOutput> Get(Guid organizationId);
        Task<T> GetOrganization<T>(Guid organizationId) where T : OrganizationOutput;
        Task DeleteOrganization(Guid organizationId);

        Task<T> GetOrganization<T>(IOrganizationAccountManager am) where T : AccountManagerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationProjectManager pm) where T : ProjectManagerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationCustomer cu) where T : CustomerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationContractor co) where T : ContractorOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationMarketer ma) where T : MarketerOrganizationOutput;
        Task<T> GetOrganization<T>(IOrganizationRecruiter re) where T : RecruiterOrganizationOutput;
        Task<T> GetOrganization<T>(IAgencyOwner ao) where T : OrganizationOutput;

        Task<T> GetProviderOrganization<T>(IOrganizationCustomer cu, Guid organizationId) where T : CustomerProviderOrganizationOutput;
        Task<List<T>> GetProviderOrganizations<T>(IOrganizationCustomer cu, OrganizationFilters filters) where T : CustomerProviderOrganizationOutput;
        Task<CustomerProviderOrganizationSummary> GetProviderOrganizationSummary(IOrganizationCustomer cu, OrganizationFilters filters);

        Task<List<T>> GetOrganizations<T>(Guid personId) where T : OrganizationOutput;
        Task<List<T>> GetOrganizations<T>(IMarketer marketer) where T : MarketerOrganizationOutput;
        Task<List<T>> GetOrganizations<T>(IRecruiter marketer) where T : RecruiterOrganizationOutput;

        Task<List<AffiliationOutput>> GetAffiliationsForPerson(Guid userUserId);
        Task<AffiliationOutput> GetAffiliationsForPerson(Guid personId, Guid organizationId);


        Task<AgencyOwnerCounts> GetCounts(IAgencyOwner agencyOwner);
        Task<AgencyOwnerMarketingOrganizationDetailsOutput> GetMarketingDetails(IMarketingAgencyOwner agencyOwner);
        Task<AgencyOwnerRecruitingOrganizationDetailsOutput> GetRecruitingDetails(IRecruitingAgencyOwner agencyOwner);
        Task<AgencyOwnerProviderOrganizationDetailsOutput> GetProviderDetails(IProviderAgencyOwner agencyOwner);
    }
}