using System;
using System.Threading.Tasks;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.OrganizationPeople.Filters;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.OrganizationRoles.Models.OrganizationMarketers;

namespace AgencyPro.OrganizationRoles.Interfaces
{
    public interface IOrganizationMarketerService : IService<OrganizationMarketer>,
        IOrganizationRoleService<OrganizationMarketerInput, 
            OrganizationMarketerOutput, IOrganizationMarketer, MarketerFilters, MarketerOrganizationOutput, MarketerCounts>
    {
       
        Task<T> GetMarketerForProject<T>(Guid inputProjectId)   
            where T : OrganizationMarketerOutput;
        

        Task<T> GetMarketerOrDefault<T>(Guid? organizationId, Guid? marketerId, string referralCode)
            where T : OrganizationMarketerOutput;
    }
}