using System;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.CustomerAccounts.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.CustomerAccounts.Interfaces
{
    public interface ICustomerAccountService
    {

        Task<CustomerAccountResult> CreateInternalAccount(IOrganizationAccountManager am);

        Task<bool> HasInternalAccount(IProviderAgencyOwner ao);

        Task<bool> HasInternalAccount(IOrganizationAccountManager am);

        Task<PagedList<T>> GetAccounts<T>(IOrganizationCustomer cu, CommonFilters filters) where T : CustomerCustomerAccountOutput;

        Task<CustomerAccountResult> Deactivate(IOrganizationAccountManager am, int number);
        Task<CustomerAccountResult> Deactivate(IProviderAgencyOwner ao, int number);
        Task<CustomerAccountResult> Deactivate(IOrganizationCustomer cu, Guid accountManagerOrganizationId, int number);

        Task<PagedList<T>> GetAccounts<T>(IOrganizationAccountManager am, CommonFilters filters) where T : AccountManagerCustomerAccountOutput;

        Task<PagedList<T>> GetAccounts<T>(IProviderAgencyOwner ao, CommonFilters filters) where T : AgencyOwnerCustomerAccountOutput;

        Task<PagedList<T>> GetAccounts<T>(IOrganizationProjectManager pm, CommonFilters filters) where T : ProjectManagerCustomerAccountOutput;

        Task<T> GetAccount<T>(Guid accountManagerOrganizationId, Guid accountManagerId, Guid customerOrganizationId,
            Guid customerId) where T : CustomerAccountOutput;

        Task<CustomerAccountResult> Create(IOrganizationAccountManager am, NewCustomerAccountInput model, bool checkValidation = true);

       // Task<T> Update<T>(IOrganizationAccountManager am, int id, CustomerAccountInput model) where T : AccountManagerCustomerAccountOutput;
       
        Task<CustomerAccountResult> Create(IProviderAgencyOwner ao, NewCustomerAccountInput model);

        Task<CustomerAccountResult> Update(IProviderAgencyOwner ao, int id, CustomerAccountInput model);

        Task<CustomerAccountResult> LinkOrganizationCustomer(IOrganizationAccountManager am, LinkCustomerWithCompanyInput input);
        Task<CustomerAccountResult> LinkOrganizationCustomer(IOrganizationAccountManager am, LinkCustomerInput input);

        Task<CustomerAccountResult> LinkOrganizationCustomer(IProviderAgencyOwner ao, LinkCustomerInput input);

        Task<CustomerAccountResult> LinkOrganizationCustomer(IProviderAgencyOwner ao, LinkCustomerWithCompanyInput input);
        Task<CustomerAccountResult> LinkOrganizationCustomer(IOrganizationCustomer customer);
        Task<CustomerAccountResult> Create(IOrganizationCustomer cu, JoinAsCustomerInput input);

        Task<T> GetAccount<T>(IOrganizationAccountManager am, int accountId)
            where T : AccountManagerCustomerAccountOutput;
        Task<CustomerAccount> GetAccount(IOrganizationAccountManager am, int accountId);

        Task<T> GetAccount<T>(IProviderAgencyOwner agencyOwner, int accountId) where T : AgencyOwnerCustomerAccountOutput;
        Task<CustomerAccount> GetAccount(IProviderAgencyOwner agencyOwner, int accountId);

        Task<T> GetAccount<T>(IOrganizationCustomer cu, int accountId) where T : CustomerCustomerAccountOutput;

        Task<T> GetAccount<T>(Guid organizationId, int accountId) where T : CustomerAccountOutput;

        Task<CustomerAccountResult> DeleteAccount(IProviderAgencyOwner ao, int accountId);

        Task<CustomerAccount> Get(Guid accountManagerOrganizationId, Guid accountManagerId,
            Guid customerOrganizationId, Guid customerId);
    }
}