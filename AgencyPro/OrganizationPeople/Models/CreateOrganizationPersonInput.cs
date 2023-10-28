using System;
using AgencyPro.People.Models;

namespace AgencyPro.OrganizationPeople.Models
{
    public class CreateOrganizationPersonInput : PersonInput
    {
        public bool IsContractor { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsAccountManager { get; set; }
        public bool IsRecruiter { get; set; }
        public bool IsMarketer { get; set; }

        public decimal? AccountManagerStream { get; set; }
        public decimal? ProjectManagerStream { get; set; }
        public decimal? ContractorStream { get; set; }
        public decimal? RecruiterStream { get; set; }
        public decimal? RecruiterBonus { get; set; }
        public decimal? MarketerStream { get; set; }
        public decimal? MarketerBonus { get; set; }

        public Guid? RecruiterId { get; set; }
        public Guid? MarketerId { get; set; }
        public Guid? AffiliateOrganizationId { get; set; }
    }
}