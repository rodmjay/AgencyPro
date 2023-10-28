using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationMarketers;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationRecruiters;

namespace AgencyPro.OrganizationPeople.Models
{
    public class AgencyOwnerOrganizationPersonDetailsOutput : AgencyOwnerOrganizationPersonOutput
    {
        public AgencyOwnerOrganizationContractorOutput Contractor { get; set; }
        public AgencyOwnerOrganizationMarketerOutput Marketer { get; set; }
        public AgencyOwnerOrganizationRecruiterOutput Recruiter { get; set; }
        public AgencyOwnerOrganizationProjectManagerOutput ProjectManager { get; set; }
        public AgencyOwnerOrganizationAccountManagerOutput AccountManager { get; set; }
    }
}