using System;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Common.Services.Interfaces;
using AgencyPro.OrganizationRoles.Interfaces;
using AgencyPro.Roles.Models;
using AgencyPro.Roles.ViewModels.Customers;

namespace AgencyPro.Roles.Interfaces
{
    public interface ICustomerService :
        IService<Customer>,
        IRoleService<CustomerInput, CustomerUpdateInput, CustomerOutput, ICustomer>
    {
        Task<ICustomer> GetPrincipal(Guid customerId);
        Task<PagedList<T>> GetList<T>(
            IOrganizationMarketer ma, CommonFilters filters) where T : MarketerCustomerOutput;

    }
}