using System;
using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Leads.Models
{
    public class LeadInput
    {
        public virtual string ReferralCode { get; set; }

        [Required] public virtual string FirstName { get; set; }

        [Required] public virtual string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public virtual string EmailAddress { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Description { get; set; }

        public virtual string OrganizationName { get; set; }

        public virtual string Iso2 { get; set; }

        public virtual string ProvinceState { get; set;}

        public virtual bool IsContacted { get; set; }

        public virtual DateTime? CallbackDate { get; set; }
        public virtual string MeetingNotes { get; set; }
    }
}