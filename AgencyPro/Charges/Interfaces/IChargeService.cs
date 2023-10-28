using System.Threading.Tasks;
using Stripe;

namespace AgencyPro.Charges.Interfaces
{
    public interface IChargeService
    {
        Task<int> PullCharge(Charge charge);

    }
}
