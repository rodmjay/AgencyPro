using System;

namespace AgencyPro.OrganizationPeople.Models
{
    public class OrganizationPersonInput
    {
        public Guid PersonId { get; set; }
        
        public virtual bool IsAccountManager { get; set; }
        public virtual bool IsProjectManager { get; set; }
        public virtual bool IsContractor { get; set; }
        public virtual bool IsCustomer { get; set; }
        public virtual bool IsRecruiter { get; set; }
        public virtual bool IsMarketer { get; set; }

        public virtual decimal? ContractorStream { get; set; }

        public virtual decimal? MarketerStream { get; set; }
        public virtual decimal? MarketerBonus { get; set; }

        public virtual decimal? RecruiterStream { get; set; }
        public virtual decimal? RecruiterBonus { get; set; }

        public virtual decimal? ProjectManagerStream { get; set; }
        public virtual decimal? AccountManagerStream { get; set; }

    }
}