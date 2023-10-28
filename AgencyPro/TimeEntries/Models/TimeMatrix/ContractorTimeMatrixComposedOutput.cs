using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationCustomers;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationRecruiters;
using AgencyPro.Projects.Models;
using AgencyPro.Stories.Models;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class ContractorTimeMatrixComposedOutput
    {
        public ICollection<ContractorTimeMatrixOutput> Matrix { get; set; }

        public ICollection<ContractorOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<ContractorOrganizationRecruiterOutput> Recruiters { get; set; }
        public ICollection<ContractorOrganizationProjectManagerOutput> ProjectManagers { get; set; }
        public ICollection<ContractorOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<OrganizationContractorOutput> Contractors { get; set; }
        public ICollection<ContractorContractOutput> Contracts { get; set; }
        public ICollection<ContractorProjectOutput> Projects { get; set; }
        public ICollection<ContractorStoryOutput> Stories { get; set; }
    }
}