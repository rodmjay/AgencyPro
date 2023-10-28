using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Contracts.Models
{
    public class UpdateProviderContractInput
    {
        [Range(1,100)]
        public virtual int MaxWeeklyHours { get; set; }

        [Range(0, 999)]
        [DataType(DataType.Currency)]
        public virtual decimal? ContractorStream { get; set; }

        [Range(0, 999)]
        [DataType(DataType.Currency)]
        public virtual decimal? ProjectManagerStream { get; set; }

        [Range(0, 999)]
        [DataType(DataType.Currency)]
        public virtual decimal? AccountManagerStream { get; set; }

        [Range(0, 999)]
        [DataType(DataType.Currency)]
        public virtual decimal? AgencyStream { get; set; }
    }
}