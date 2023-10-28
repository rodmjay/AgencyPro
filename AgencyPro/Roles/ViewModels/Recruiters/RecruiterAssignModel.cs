using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Roles.ViewModels.Recruiters
{
    public sealed class RecruiterAssignModel
    {
        [Required] public string AffiliateId { get; set; }
    }
}