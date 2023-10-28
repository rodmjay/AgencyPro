using System.Threading.Tasks;
using AgencyPro.PaymentIntents.Models;
using Stripe;

namespace AgencyPro.PaymentIntents.Interfaces
{
    public interface IPaymentIntentService
    {
        Task<PaymentIntentResult> PaymentIntentCreated(PaymentIntent paymentIntent);
        Task<PaymentIntentResult> PaymentIntentUpdated(PaymentIntent paymentIntent);

        Task<PaymentIntentResult> PaymentIntentAmountCapturableUpdated(PaymentIntent paymentIntent);
    }
}
