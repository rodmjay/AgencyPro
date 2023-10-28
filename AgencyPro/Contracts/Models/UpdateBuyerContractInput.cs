using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Contracts.Models
{
    public class UpdateBuyerContractInput
    {
        [Range(1, 100)]
        public virtual int MaxWeeklyHours { get; set; }

    }
}