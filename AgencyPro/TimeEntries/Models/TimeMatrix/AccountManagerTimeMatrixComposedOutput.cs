using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationCustomers;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.Projects.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class AccountManagerTimeMatrixComposedOutput
    {
        public ICollection<AccountManagerTimeMatrixOutput> Matrix { get; set; }

   
        public ICollection<AccountManagerOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<AccountManagerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<AccountManagerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<AccountManagerContractOutput> Contracts { get; set; }
        public ICollection<AccountManagerProjectOutput> Projects { get; set; }
        public ICollection<AccountManagerStoryOutput> Stories { get; set; }
    }
}