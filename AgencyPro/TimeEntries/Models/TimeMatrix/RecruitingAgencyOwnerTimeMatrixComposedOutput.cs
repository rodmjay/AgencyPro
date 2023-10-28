using System.Collections.Generic;
using AgencyPro.OrganizationRoles.Models.OrganizationRecruiters;

namespace AgencyPro.TimeEntries.Models.TimeMatrix
{
    public class RecruitingAgencyOwnerTimeMatrixComposedOutput
    {
        public ICollection<RecruitingAgencyOwnerTimeMatrixOutput> Matrix { get; set; }
        public ICollection<AgencyOwnerOrganizationRecruiterOutput> Recruiters { get; set; }
    }
}