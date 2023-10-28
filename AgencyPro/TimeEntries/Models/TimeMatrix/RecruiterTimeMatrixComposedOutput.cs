using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class RecruiterTimeMatrixComposedOutput
    {
        public ICollection<RecruiterTimeMatrixOutput> Matrix { get; set; }

        public ICollection<RecruiterOrganizationAccountManagerOutput> AccountManagers { get; set; }
        public ICollection<RecruiterOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<RecruiterContractOutput> Contracts { get; set; }
    }
}