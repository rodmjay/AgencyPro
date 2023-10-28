using System.Threading.Tasks;
using AgencyPro.FinancialAccounts.Models;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.People.Interfaces;

namespace AgencyPro.FinancialAccounts.Interfaces
{
    public interface IFinancialAccountService
    {
        Task<FinancialAccountDetails> GetFinancialAccount(IPerson person);
        Task<FinancialAccountDetails> GetFinancialAccount(IAgencyOwner customer);

        Task<FinancialAccountResult> AccountCreatedOrUpdated(global::Stripe.Account account);

        Task<bool> RemoveFinancialAccount(IPerson person);
        Task<bool> RemoveFinancialAccount(IAgencyOwner agencyOwner);
    }
}
