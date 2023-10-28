using System;
using System.Threading.Tasks;
using AgencyPro.Comments.Entities;
using AgencyPro.Comments.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Comments.Interfaces
{
    public interface ICommentService : IService<Comment>
    {
        Task<bool> CreateStoryComment(IProviderAgencyOwner agencyOwner, Guid storyId, CommentInput input);
        Task<bool> CreateProjectComment(IProviderAgencyOwner agencyOwner, Guid projectId, CommentInput input);
        Task<bool> CreateContractComment(IAgencyOwner agencyOwner, Guid contractId, CommentInput input);
        Task<bool> CreateLeadComment(IProviderAgencyOwner agencyOwner, Guid leadId, CommentInput input);
        Task<bool> CreateCandidateComment(IProviderAgencyOwner agencyOwner, Guid candidateId, CommentInput input);
        Task<bool> CreateAccountComment(IProviderAgencyOwner agencyOwner, int accountId, CommentInput input);

        Task<bool> CreateStoryComment(IOrganizationAccountManager accountManager, Guid storyId, CommentInput input);
        Task<bool> CreateProjectComment(IOrganizationAccountManager accountManager, Guid projectId, CommentInput input);
        Task<bool> CreateContractComment(IOrganizationAccountManager accountManager, Guid contractId, CommentInput input);
        Task<bool> CreateLeadComment(IOrganizationAccountManager accountManager, Guid leadId, CommentInput input);
        Task<bool> CreateAccountComment(IOrganizationAccountManager accountManager, int accountId, CommentInput input);

        Task<bool> CreateStoryComment(IOrganizationProjectManager projectManager, Guid storyId, CommentInput input);
        Task<bool> CreateProjectComment(IOrganizationProjectManager projectManager, Guid projectId, CommentInput input);
        Task<bool> CreateContractComment(IOrganizationProjectManager projectManager, Guid contractId, CommentInput input);
        Task<bool> CreateCandidateComment(IOrganizationProjectManager projectManager, Guid candidateId, CommentInput input);

        Task<bool> CreateStoryComment(IOrganizationCustomer customer, Guid storyId, CommentInput input);
        Task<bool> CreateProjectComment(IOrganizationCustomer customer, Guid projectId, CommentInput input);
        Task<bool> CreateContractComment(IOrganizationCustomer customer, Guid contractId, CommentInput input);
        Task<bool> CreateAccountComment(IOrganizationCustomer customer, int accountId, CommentInput input);


        Task<bool> CreateStoryComment(IOrganizationContractor contractor, Guid storyId, CommentInput input);
        Task<bool> CreateProjectComment(IOrganizationContractor contractor, Guid projectId, CommentInput input);
        Task<bool> CreateContractComment(IOrganizationContractor contractor, Guid contractId, CommentInput input);

        Task<bool> CreateLeadComment(IOrganizationMarketer marketer, Guid leadId, CommentInput input);

        Task<bool> CreateCandidateComment(IOrganizationRecruiter recruiter, Guid candidateId, CommentInput input);
    }
}
