using System.Collections.Generic;
using AgencyPro.BillingCategories.Models;
using AgencyPro.OrganizationPeople.Models;

namespace AgencyPro.ProviderOrganizations.Models
{
    public class AccountManagerOrganizationDetailsOutput : AccountManagerOrganizationOutput
    {
        public ICollection<AccountManagerOrganizationPersonOutput> OrganizationPeople { get; set; }

        public ICollection<BillingCategoryOutput> AvailableBillingCategories { get; set; }
        public ICollection<BillingCategoryOutput> BillingCategories { get; set; }

    }
}