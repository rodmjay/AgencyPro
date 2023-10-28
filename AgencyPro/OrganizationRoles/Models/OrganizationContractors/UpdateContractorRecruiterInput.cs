using System;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class UpdateContractorRecruiterInput
    {
        public Guid RecruiterId { get; set; }
        public bool UpdateAllContracts { get; set; }
    }
}