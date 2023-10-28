using System.ComponentModel.DataAnnotations;

namespace AgencyPro.MarketingOrganizations.Models
{
    public class MarketingOrganizationUpgradeInput
    {
        [Range(0, 100)]
        public virtual decimal MarketingAgencyStream { get; set; }
        [Range(0, 100)]
        public virtual decimal MarketerBonus { get; set; }
        [Range(0, 100)]
        public virtual decimal MarketingAgencyBonus { get; set; }
        [Range(0, 100)]
        public virtual decimal MarketerStream { get; set; }
        
        public bool Discoverable { get; set; }


    }
}