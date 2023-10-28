using AgencyPro.BuyerAccounts.Models;

namespace AgencyPro.ProviderOrganizations.Models
{
    public class CustomerOrganizationDetailsOutput : CustomerOrganizationOutput
    {
        public BuyerAccountOutput BuyerAccount { get; set; }
    }
}