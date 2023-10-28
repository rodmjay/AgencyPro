using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.RecruitingOrganizations.Models;

namespace AgencyPro.RecruitingOrganizations.Interfaces
{
    public interface IRecruitingOrganizationService
    {
        Task<List<T>> Discover<T>(IProviderAgencyOwner owner) where T : RecruitingOrganizationOutput;
    }
}