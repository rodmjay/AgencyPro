using AgencyPro.BuyerAccounts.Models;
using AgencyPro.FinancialAccounts.Models;
using AgencyPro.MarketingOrganizations.Models;
using AgencyPro.Organizations.Models;
using AgencyPro.RecruitingOrganizations.Models;

namespace AgencyPro.ProviderOrganizations.Models
{
    public class AgencyOwnerOrganizationDetailsOutput : OrganizationOutput
    {
        public AgencyOwnerProviderOrganizationDetailsOutput ProviderOrganizationDetails { get; set; }
        public AgencyOwnerMarketingOrganizationDetailsOutput MarketingOrganizationDetails { get; set; }
        public AgencyOwnerRecruitingOrganizationDetailsOutput RecruitingOrganizationDetails { get; set; }

        public FinancialAccountOutput FinancialAccount { get; set; }
        public BuyerAccountOutput BuyerAccount { get; set; }
    }
}