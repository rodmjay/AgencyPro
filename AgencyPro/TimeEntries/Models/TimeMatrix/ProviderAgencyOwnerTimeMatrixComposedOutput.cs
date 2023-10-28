using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationCustomers;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.Projects.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class ProviderAgencyOwnerTimeMatrixComposedOutput
    {
        public ICollection<ProviderAgencyOwnerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<AgencyOwnerOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<AgencyOwnerOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<AgencyOwnerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<AgencyOwnerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public ICollection<AgencyOwnerProjectOutput> Projects { get; set; }
        public ICollection<AgencyOwnerStoryOutput> Stories { get; set; }
    }
}