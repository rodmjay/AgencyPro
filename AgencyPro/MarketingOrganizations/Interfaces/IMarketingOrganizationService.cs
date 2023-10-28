using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.MarketingOrganizations.Interfaces
{
    public interface IMarketingOrganizationService
    {
        Task<List<T>> Discover<T>(IProviderAgencyOwner owner) where T : MarketingOrganizationOutput;
    }
}