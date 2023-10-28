using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.MarketingOrganizations.Models
{
    public class MarketingOrganizationInput : MarketingOrganizationUpgradeInput
    {
      
        [BindRequired] public virtual Guid DefaultMarketerId { get; set; }
     


    }
}