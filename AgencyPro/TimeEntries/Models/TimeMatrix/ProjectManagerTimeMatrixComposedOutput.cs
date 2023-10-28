using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationCustomers;
using AgencyPro.Projects.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class ProjectManagerTimeMatrixComposedOutput
    {
        public ICollection<ProjectManagerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<ProjectManagerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<ProjectManagerOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<ProjectManagerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<ProjectManagerContractOutput> Contracts { get; set; }
        public ICollection<ProjectManagerProjectOutput> Projects { get; set; }
        public ICollection<ProjectManagerStoryOutput> Stories { get; set; }
    }
}