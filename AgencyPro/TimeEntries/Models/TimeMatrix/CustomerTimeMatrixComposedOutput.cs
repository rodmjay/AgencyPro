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
    public class CustomerTimeMatrixComposedOutput
    {
        public ICollection<CustomerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<CustomerOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<CustomerOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<CustomerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<CustomerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<CustomerContractOutput> Contracts { get; set; }
        public ICollection<CustomerProjectOutput> Projects { get; set; }
        public ICollection<CustomerStoryOutput> Stories { get; set; }
    }
}