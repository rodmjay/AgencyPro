using System.Collections.Generic;
using AgencyPro.Contracts.Models;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationCustomers;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class MarketerTimeMatrixComposedOutput
    {
        public ICollection<MarketerTimeMatrixOutput> Matrix { get; set; }

        public ICollection<MarketerOrganizationCustomerOutput> Customers { get; set; }
        public ICollection<MarketerOrganizationContractorOutput> Contractors { get; set; }
        public ICollection<MarketerContractOutput> Contracts { get; set; }
    }
}