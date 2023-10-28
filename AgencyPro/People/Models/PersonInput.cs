using System.ComponentModel.DataAnnotations;

namespace AgencyPro.People.Models
{
    public class PersonInput
    {
        public virtual bool SendEmail { get; set; }

        public virtual string DisplayName => FirstName + " " + LastName;

        [Display(Name = "First Name")]
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public virtual string FirstName { get; set; }

        [Display(Name = "Last")]
        [MinLength(1)]
        [MaxLength(30)]
        public virtual string LastName { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public virtual string EmailAddress { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public virtual string PhoneNumber { get; set; }

        [Display(Name = "Country")]
        [MaxLength(2)]
        public virtual string Iso2 { get; set; }

        [Display(Name = "State/Province")]
        public virtual string ProvinceState { get; set; }
    }
}