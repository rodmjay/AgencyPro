using System.Collections.Generic;
using AgencyPro.OrganizationRoles.Models.OrganizationMarketers;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class MarketingAgencyOwnerTimeMatrixComposedOutput
    {
        public ICollection<MarketingAgencyOwnerTimeMatrixOutput> Matrix { get; set; }
        public ICollection<AgencyOwnerOrganizationMarketerOutput> Marketers { get; set; }
    }
}