using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.BillingCategories.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.BillingCategories.Interfaces
{
    public interface IBillingCategoryService
    {
        Task<List<BillingCategoryOutput>> GetBillingCategoriesByCategory(int categoryId);
        Task<List<BillingCategoryOutput>> GetBillingCategoriesByOrganization(Guid organizationId);
        Task<List<BillingCategoryOutput>> GetBillingCategoriesByProject(Guid organizationId, Guid projectId);


        Task<bool> AddBillingCategory(IProviderAgencyOwner agencyOwner, int billingCategoryId);
        Task<bool> AddBillingCategoryToProject(IProviderAgencyOwner agencyOwner, Guid projectId, int billingCategoryId);
        Task<bool> RemoveBillingCategory(IProviderAgencyOwner agencyOwner, int billingCategoryId);
        Task<bool> RemoveBillingCategoryFromProject(IProviderAgencyOwner agencyOwner, Guid projectId, int billingCategoryId);
    }
}
