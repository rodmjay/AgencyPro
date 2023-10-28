using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Contracts.Models
{
    public class UpdateMarketingContractInput
    {
        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public virtual decimal? MarketerStream { get; set; }

        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public virtual decimal? MarketingAgencyStream { get; set; }
    }
}