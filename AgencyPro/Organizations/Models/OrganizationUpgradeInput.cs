using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AgencyPro.Common.Extensions;
using AgencyPro.Common.Validation;
using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.Organizations.Enums;
using AgencyPro.ProviderOrganizations.Models;
using AgencyPro.RecruitingOrganizations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.Organizations.Models
{
    [BindProperties]
    public class OrganizationUpgradeInput : ValidatableModel
    {
        [BindProperty]
        public RecruitingOrganizationUpgradeInput RecruitingOrganizationInput { get; set; }

        [BindProperty]
        public MarketingOrganizationUpgradeInput MarketingOrganizationInput { get; set; }

        [BindProperty]
        public ProviderOrganizationUpgradeInput ProviderOrganizationInput { get; set; }

        [BindProperty]
        public virtual int CategoryId { get; set; }

        [BindNever]
        public OrganizationType OrganizationType
        {
            get
            {
                var type = OrganizationType.Buyer;

                if (RecruitingOrganizationInput != null) type.Add(OrganizationType.Recruiting);
                if (MarketingOrganizationInput != null) type.Add(OrganizationType.Marketing);
                if (ProviderOrganizationInput != null) type.Add(OrganizationType.Provider);

                return type;
            }
        }

        public bool IsSubscriptionRequired => (int)OrganizationType > (int)OrganizationType.Marketing;

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if ((int)OrganizationType <= 1) yield break;
        }
    }
}