using System;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Proposals.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgencyPro.Proposals.Interfaces
{
    public interface IProposalPDFService : IService<FixedPriceProposal>
    {
        Task<FileStreamResult> GenerateProposal(IProviderAgencyOwner ao, Guid proposalId);
        Task<FileStreamResult> GenerateProposal(IOrganizationAccountManager am, Guid proposalId);
        Task<FileStreamResult> GenerateProposal(IOrganizationCustomer cu, Guid proposalId);
        Task<FileStreamResult> GenerateProposal(Guid proposalId);
    }
}