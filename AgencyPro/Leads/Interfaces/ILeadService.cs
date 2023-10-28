using System;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Leads.Entities;
using AgencyPro.Leads.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Leads.Interfaces
{
    public interface ILeadService : IService<Lead>
    {
        Task<int> MatchingLeadsByEmail(string email);
        Task<int> CountLeadsPerProviderByEmail(Guid providerOrganizationId, string email, Guid? leadId = null);

        Task<Result> QualifyLead(IProviderAgencyOwner ao, Guid leadId, LeadQualifyInput input);

        Task<Result> PromoteLead(IOrganizationAccountManager am, Guid leadId, PromoteLeadOptions options);

        Task<Result> RejectLead(IOrganizationAccountManager am, Guid leadId, LeadRejectInput input);

        Task<PagedList<T>> GetLeads<T>(IOrganizationMarketer ma, CommonFilters filters) where T : MarketerLeadOutput;
        Task<PagedList<T>> GetLeads<T>(IProviderAgencyOwner ao, CommonFilters filters) where T : AgencyOwnerLeadOutput;
        Task<PagedList<T>> GetLeads<T>(IMarketingAgencyOwner ao, CommonFilters filters) where T : AgencyOwnerLeadOutput;
        Task<PagedList<T>> GetLeads<T>(IOrganizationAccountManager am, CommonFilters filters) where T : AccountManagerLeadOutput;

        Task<T> GetAsync<T>(Guid leadId) where T : LeadOutput;
        Task<Lead> GetAsync(Guid leadId);

        Task<T> GetLead<T>(IOrganizationMarketer ma, Guid leadId) where T : MarketerLeadOutput;

        Task<T> GetLead<T>(IOrganizationAccountManager organizationAccountManager, Guid leadId)
            where T : AccountManagerLeadOutput;

        Task<T> GetLead<T>(IProviderAgencyOwner agencyOwner, Guid leadId) where T : AgencyOwnerLeadOutput;
        Task<T> GetLead<T>(IMarketingAgencyOwner agencyOwner, Guid leadId) where T : AgencyOwnerLeadOutput;

        Task<Result> UpdateLead(IProviderAgencyOwner agencyOwner, Guid leadId, LeadInput model);

        Task<Result> UpdateLead(IOrganizationAccountManager am, Guid leadId, LeadInput model);

        Task<Result> UpdateLead(IOrganizationMarketer ma, Guid leadId, LeadInput model);

        Task<Result> DeleteLead(IProviderAgencyOwner agencyOwner, Guid leadId);
        Task<Result> DeleteLead(IOrganizationMarketer ma, Guid leadId);
        Task<Result> DeleteLead(IOrganizationAccountManager am, Guid leadId);

        Task<Result> RejectLead(IProviderAgencyOwner agencyOwner, Guid leadId, LeadRejectInput input);

        Task<Result> CreateInternalLead(IOrganizationMarketer organizationMarketer, LeadInput model);
        Task<Result> CreateExternalLead(IOrganizationMarketer organizationMarketer, Guid providerOrganizationId, LeadInput model);
        Task<Result> CreateInternalLead(Guid organizationId, LeadInput model);
    }
}