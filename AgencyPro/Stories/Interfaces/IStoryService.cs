using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Stories.Entities;
using AgencyPro.Stories.Models;

namespace AgencyPro.Stories.Interfaces
{
    public interface IStoryService : IService<Story>
    {
        Task<Result> UpdateStory(IOrganizationContractor co, Guid storyId, UpdateStoryInput model);

        Task<Result> UpdateStory(IOrganizationProjectManager pm, Guid storyId, UpdateStoryInput model);

        Task<Result> UpdateStory(IOrganizationAccountManager am, Guid storyId, UpdateStoryInput model);

        Task<Result> UpdateStory(IProviderAgencyOwner ao, Guid storyId, UpdateStoryInput model);

        Task<T> GetStory<T>(IOrganizationCustomer cu, Guid storyId) 
            where T : CustomerStoryOutput;

        Task<T> GetStory<T>(IOrganizationProjectManager pm, Guid storyId) 
            where T : ProjectManagerStoryOutput;

        Task<T> GetStory<T>(IOrganizationContractor co, Guid storyId) 
            where T : ContractorStoryOutput;

        Task<T> GetStory<T>(IOrganizationAccountManager am, Guid storyId) 
            where T : AccountManagerStoryOutput;

        Task<T> GetStory<T>(IProviderAgencyOwner ao, Guid storyId) 
            where T : AgencyOwnerStoryOutput;

        Task<PagedList<T>> GetStories<T>(IOrganizationProjectManager pm, StoryFilters filters) 
            where T : ProjectManagerStoryOutput;

        Task<PagedList<T>> GetStories<T>(IOrganizationContractor co, StoryFilters filters) 
            where T : ContractorStoryOutput;

        Task<PagedList<T>> GetStories<T>(IOrganizationCustomer cu, StoryFilters filters) 
            where T : CustomerStoryOutput;

        Task<PagedList<T>> GetStories<T>(IOrganizationAccountManager am, StoryFilters filters) 
            where T : AccountManagerStoryOutput;

        Task<PagedList<T>> GetStories<T>(IProviderAgencyOwner ao, StoryFilters filters) 
            where T : AgencyOwnerStoryOutput;

        Task<Result> CreateStory(IOrganizationProjectManager pm, CreateStoryInput input);

        Task<Result> CreateStory(IOrganizationAccountManager organizationAccountManager,
            CreateStoryInput input);

        Task<Result> CreateStory(IProviderAgencyOwner agencyOwner, CreateStoryInput input);

        Task<Result> DeleteStory(IOrganizationContractor co, Guid storyId);

        Task<Result> DeleteStory(IOrganizationProjectManager pm, Guid storyId);

        Task<Result> DeleteStory(IProviderAgencyOwner agencyOwner, Guid storyId);

        Task<List<T>> GetStories<T>(IProviderAgencyOwner owner, Guid?[] uniqueStoryIds) 
            where T : AgencyOwnerStoryOutput;

        Task<List<T>> GetStories<T>(IOrganizationAccountManager am, Guid?[] uniqueStoryIds)
            where T : AccountManagerStoryOutput;

        Task<List<T>> GetStories<T>(IOrganizationProjectManager pm, Guid?[] uniqueStoryIds)
            where T : ProjectManagerStoryOutput;

        Task<List<T>> GetStories<T>(IOrganizationCustomer cu, Guid?[] uniqueStoryIds) 
            where T : CustomerStoryOutput;

        Task<List<T>> GetStories<T>(IOrganizationContractor co, Guid?[] uniqueStoryIds) 
            where T : ContractorStoryOutput;

        Task<Result> AssignStory(IOrganizationProjectManager pm, Guid storyId, AssignStoryInput input);

        Task<Result> AssignStory(IProviderAgencyOwner ao, Guid storyId, AssignStoryInput input);
    }
}