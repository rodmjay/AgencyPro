using System.Collections.Generic;
using System.Threading.Tasks;
using AgencyPro.Cards.Models;
using AgencyPro.OrganizationRoles.Interfaces;
using Stripe;

namespace AgencyPro.Cards.Interfaces
{
    public interface ICardService
    {
        Task<int> AddCustomerCard(string customerId, CardInputModel input);
        Task<int> AddAccountCard(string customerId, CardInputModel input);

        Task<int> PullCard(Card card);
        Task<int> PullCard(IExternalAccount card);
        Task<List<CustomerCardViewModel>> GetCards(IOrganizationCustomer customer);
    }
}