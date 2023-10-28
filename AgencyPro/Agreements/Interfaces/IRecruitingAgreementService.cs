using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Agreements.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Agreements.Interfaces
{
    public interface IRecruitingAgreementService
    {
        Task<List<T>> GetAgreements<T>(IProviderAgencyOwner principal) where T : RecruitingAgreementOutput;
        Task<T> GetAgreement<T>(IProviderAgencyOwner principal, Guid recruitingAgencyId) where T : RecruitingAgreementOutput;
        Task<List<T>> GetAgreements<T>(IRecruitingAgencyOwner principal) where T : RecruitingAgreementOutput;
        Task<T> GetAgreement<T>(IRecruitingAgencyOwner principal, Guid providerAgencyId) where T : RecruitingAgreementOutput;
        Task<List<T>> GetAgreements<T>(IOrganizationRecruiter principal) where T : RecruitingAgreementOutput;

        Task<AgreementResult> CreateAgreement(IRecruitingAgencyOwner principal,
            Guid providerOrganizationId,
            RecruitingAgreementInput input);

        Task<AgreementResult> AcceptAgreement(IProviderAgencyOwner principal,
            Guid recruitingOrganizationId);

        Task<AgreementResult> CreateAgreement(IProviderAgencyOwner principal,
            Guid recruitingOrganizationId,
            RecruitingAgreementInput input);

        Task<AgreementResult> AcceptAgreement(IRecruitingAgencyOwner principal,
            Guid providerOrganizationId);

        Task<AgreementResult> CreateAgreement(IProviderAgencyOwner providerAgencyOwner, Guid recruitingOrganizationId);
    }
}