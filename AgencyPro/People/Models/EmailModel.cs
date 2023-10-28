using System.ComponentModel.DataAnnotations;

namespace AgencyPro.People.Models
{
    public class EmailModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}