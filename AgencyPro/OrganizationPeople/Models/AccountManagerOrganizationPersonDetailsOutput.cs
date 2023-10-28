using AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationContractors;
using AgencyPro.OrganizationRoles.Models.OrganizationMarketers;
using AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers;
using AgencyPro.OrganizationRoles.Models.OrganizationRecruiters;

namespace AgencyPro.OrganizationPeople.Models
{
    public class AccountManagerOrganizationPersonDetailsOutput : AccountManagerOrganizationPersonOutput
    {
        public AccountManagerOrganizationContractorOutput Contractor { get; set; }
        public AccountManagerOrganizationMarketerOutput Marketer { get; set; }
        public AccountManagerOrganizationRecruiterOutput Recruiter { get; set; }
        public AccountManagerOrganizationProjectManagerOutput ProjectManager { get; set; }
        public AccountManagerOrganizationAccountManagerOutput AccountManager { get; set; }
    }
}