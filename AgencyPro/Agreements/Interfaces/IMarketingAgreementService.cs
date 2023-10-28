using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Agreements.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Agreements.Interfaces
{
    public interface IMarketingAgreementService
    {
        Task<List<T>> GetAgreements<T>(IProviderAgencyOwner providerAgencyOwner) 
            where T : MarketingAgreementOutput; 

        Task<T> GetAgreement<T>(IProviderAgencyOwner providerAgencyOwner, Guid marketingOrganizationId) 
            where T : MarketingAgreementOutput;

        Task<List<T>> GetAgreements<T>(IMarketingAgencyOwner marketingAgencyOwner) where T : MarketingAgreementOutput;
        Task<T> GetAgreement<T>(IMarketingAgencyOwner marketingAgencyOwner, Guid providerOrganizationId) where T : MarketingAgreementOutput;
        Task<List<T>> GetAgreements<T>(IOrganizationMarketer marketer) where T : MarketingAgreementOutput;
        Task<List<T>> GetAgreements<T>(Guid organizationId) where T : MarketingAgreementOutput;
        Task<T> GetAgreement<T>(Guid marketingOrganizationId, Guid providerOrganizationId) where T : MarketingAgreementOutput;

        Task<AgreementResult> CreateAgreement(IMarketingAgencyOwner marketingAgencyOwner, 
            Guid providerOrganizationId);

        Task<AgreementResult> AcceptAgreement(IProviderAgencyOwner providerAgencyOwner,
            Guid marketingOrganizationId);
        
        Task<AgreementResult> AcceptAgreement(IMarketingAgencyOwner marketingAgencyOwner,
            Guid providerOrganizationId);

        Task<AgreementResult> CreateAgreement(IProviderAgencyOwner providerAgencyOwner, Guid marketingOrganizationId);
    }
}