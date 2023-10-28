using AgencyPro.PaymentIntents.Entities;
using AgencyPro.PaymentIntents.Models;
using AutoMapper;

namespace AgencyPro.PaymentIntents.Projections
{
    public class PaymentIntentProjections : Profile
    {
        public PaymentIntentProjections()
        {
            CreateMap<StripePaymentIntent, PaymentOutput>();
        }
    }
}
