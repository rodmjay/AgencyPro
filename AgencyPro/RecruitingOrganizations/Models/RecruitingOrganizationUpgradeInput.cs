using System.ComponentModel.DataAnnotations;

namespace AgencyPro.RecruitingOrganizations.Models
{
    public class RecruitingOrganizationUpgradeInput
    {
        [Range(0, 100)]
        public virtual decimal RecruiterStream { get; set; }

        [Range(0, 100)]
        public virtual decimal RecruiterBonus { get; set; }
        [Range(0, 100)]
        public virtual decimal RecruitingAgencyBonus { get; set; }

        [Range(0, 100)]
        public virtual decimal RecruitingAgencyStream { get; set; }

        public bool Discoverable { get; set; }
    }
}