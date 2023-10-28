using AutoMapper;

namespace AgencyPro.PayoutIntents.Projections
{
    public partial class PayoutIntentProjections : Profile
    {
        public PayoutIntentProjections()
        {
            CreateOrganizationPayoutMaps();
            CreateIndividualPayoutMaps();
        }
    }
}
