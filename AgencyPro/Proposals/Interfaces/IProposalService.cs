using System;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Proposals.Entities;
using AgencyPro.Proposals.Models;

namespace AgencyPro.Proposals.Interfaces
{
    public interface IProposalService : IService<FixedPriceProposal>
    {
        Task<FixedPriceProposalOutput> GetProposal(Guid id);
        Task<T> GetProposal<T>(Guid id) where T : FixedPriceProposalOutput;

        Task<PagedList<T>> GetFixedPriceProposals<T>(IOrganizationAccountManager am, ProposalFilters filters) where T : AccountManagerFixedPriceProposalOutput;
        Task<T> GetProposal<T>(IOrganizationAccountManager am, Guid proposalId) where T : AccountManagerFixedPriceProposalOutput;

        Task<ProposalResult> AcceptFixedPriceProposal(Guid proposalId);
        Task<ProposalResult> AcceptFixedPriceProposal(IOrganizationCustomer cu, Guid proposalId);
        Task<ProposalResult> AcceptFixedPriceProposal(IProviderAgencyOwner ao, Guid proposalId);
        Task<ProposalResult> AcceptFixedPriceProposal(IOrganizationAccountManager ao, Guid proposalId);

        Task<ProposalResult> Reject(IOrganizationCustomer organizationCustomer, Guid proposalId,
            ProposalRejectionInput input);

        Task<ProposalResult> Reject(Guid proposalId, ProposalRejectionInput input);

        Task<PagedList<T>> GetFixedPriceProposals<T>(IOrganizationCustomer cu, ProposalFilters filters) where T : CustomerFixedPriceProposalOutput;
        Task<T> GetProposal<T>(IOrganizationCustomer cu, Guid proposalId) where T : CustomerFixedPriceProposalOutput;

        Task<T> GetProposal<T>(IProviderAgencyOwner ao, Guid proposalId) where T : AgencyOwnerFixedPriceProposalOutput;

        Task<PagedList<T>> GetFixedPriceProposals<T>(IProviderAgencyOwner ao, ProposalFilters filters) where T : AgencyOwnerFixedPriceProposalOutput;

        Task<ProposalResult> Create(IAgencyOwner agencyOwner, Guid projectId, ProposalOptions input);
        
        Task<ProposalResult> Create(IOrganizationAccountManager am, Guid projectId, ProposalOptions input);

        Task<bool> DeleteProposal(IAgencyOwner agencyOwner, Guid proposalId);
        Task<bool> DeleteProposal(IOrganizationAccountManager am, Guid proposalId);

        Task<ProposalResult> SendProposal(IProviderAgencyOwner agencyOwner, Guid proposalId);
        Task<ProposalResult> RevokeProposal(IProviderAgencyOwner agencyOwner, Guid proposalId);
        Task<ProposalResult> SendProposal(IOrganizationAccountManager am, Guid proposalId);
        Task<ProposalResult> RevokeProposal(IOrganizationAccountManager am, Guid proposalId);

        Task<ProposalResult> Update(IProviderAgencyOwner agencyOwner, Guid proposalId, ProposalOptions input);

        Task<ProposalResult> Update(IOrganizationAccountManager am, Guid proposalId, ProposalOptions input);
    }
}