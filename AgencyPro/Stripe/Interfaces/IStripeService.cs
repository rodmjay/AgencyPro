using System.Threading.Tasks;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.People.Interfaces;

namespace AgencyPro.Stripe.Interfaces
{
    public interface IStripeService
    {

        
        Task<string> GetAuthUrl(IAgencyOwner customer);

        Task<string> GetAuthUrl(IPerson person);

        Task<string> GetStripeUrl(IPerson person);
        Task<string> GetStripeUrl(IAgencyOwner agencyOwner, bool isRecursive = false);
        
    }
}