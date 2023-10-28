using System;
using System.Threading.Tasks;
using AgencyPro.BuyerAccounts.Models;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Roles.Entities;

namespace AgencyPro.BuyerAccounts.Interfaces
{
    public interface IBuyerAccountService
    {
        Task<BuyerAccountOutput> GetBuyerAccount(IOrganizationCustomer customer);

        Task<int> PullCustomer(Customer customer);


        Task<int> PushCustomer(Guid organizationId, Guid customerId);

        Task<int> ImportBuyerAccounts(int limit);
        Task<int> ExportCustomers();
        Task<int> ExportCustomers(Guid organizationId);
        Task<string> GetAuthUrl(IOrganizationCustomer customer);
        Task<string> GetStripeUrl(IOrganizationCustomer customer, bool isRecursive = false);


    }
}