using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Leads.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Leads.Interfaces
{
    public interface ILeadMatrixService
    {
        Task<List<T>> GetResults<T>(IOrganizationMarketer ma, LeadMatrixFilters filters) where T : MarketerLeadMatrixOutput;
        Task<List<T>> GetResults<T>(IAgencyOwner ao, LeadMatrixFilters filters) where T : AgencyOwnerLeadMatrixOutput;

    }
}