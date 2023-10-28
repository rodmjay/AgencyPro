using AgencyPro.PayoutIntents.Interfaces;

namespace AgencyPro.PayoutIntents.Models
{

    public class OrganizationPayoutIntentOutput : PayoutViewModel, IOrganizationPayoutIntent
    {
        public string OrganizationName { get; set; }
    }
}