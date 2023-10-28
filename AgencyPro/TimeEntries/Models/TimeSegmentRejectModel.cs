using System.ComponentModel.DataAnnotations;

namespace AgencyPro.TimeEntries.Models
{
    public class TimeSegmentRejectModel
    {
        [Required] public string Reason { get; set; }
    }
}