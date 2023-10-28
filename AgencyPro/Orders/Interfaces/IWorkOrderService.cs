using System;
using System.Threading.Tasks;
using AgencyPro.Common.Models;
using AgencyPro.Orders.Models;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.Orders.Interfaces
{
    public interface IWorkOrderService
    {
        Task<PagedList<T>> GetWorkOrders<T>(IOrganizationCustomer customer, WorkOrderFilters filters) where T : BuyerWorkOrderOutput;
        Task<PagedList<T>> GetWorkOrders<T>(IOrganizationAccountManager accountManager, WorkOrderFilters filters) where T : ProviderWorkOrderOutput;
        Task<PagedList<T>> GetWorkOrders<T>(IAgencyOwner agencyOwner, WorkOrderFilters filters) where T : ProviderWorkOrderOutput;

        Task<T> GetWorkOrder<T>(IOrganizationCustomer customer, Guid orderId) where T : BuyerWorkOrderOutput;
        Task<T> GetWorkOrder<T>(IOrganizationAccountManager accountManager, Guid orderId) where T : ProviderWorkOrderOutput;
        Task<T> GetWorkOrder<T>(IAgencyOwner agencyOwner, Guid orderId) where T : ProviderWorkOrderOutput;


        Task<T> UpdateWorkOrder<T>(IOrganizationCustomer customer, Guid orderId, UpdateWorkOrderInput input) where T : BuyerWorkOrderOutput;
        Task<T> UpdateWorkOrder<T>(IOrganizationAccountManager accountManager, Guid orderId, UpdateWorkOrderInput input) where T : ProviderWorkOrderOutput;
        Task<T> UpdateWorkOrder<T>(IAgencyOwner agencyOwner, Guid orderId, UpdateWorkOrderInput input) where T : ProviderWorkOrderOutput;

        Task<T> CreateWorkOrder<T>(IOrganizationCustomer customer, WorkOrderInput input) where T : BuyerWorkOrderOutput;

        Task<T> SendWorkOrder<T>(IOrganizationCustomer customer, Guid orderId) where T : BuyerWorkOrderOutput;
        Task<T> Revoke<T>(IOrganizationCustomer customer, Guid orderId) where T : BuyerWorkOrderOutput;

        Task<T> AcceptWorkOrder<T>(IOrganizationAccountManager accountManager, Guid workOrderId, WorkOrderAcceptInput input)
            where T : ProviderWorkOrderOutput;
        Task<T> AcceptWorkOrder<T>(IAgencyOwner agencyOwner, Guid workOrderId, WorkOrderAcceptInput input)
            where T : ProviderWorkOrderOutput;

        Task<T> Reject<T>(IOrganizationAccountManager accountManager, Guid workOrderId) where T: ProviderWorkOrderOutput;
        Task<T> Reject<T>(IAgencyOwner agencyOwner, Guid workOrderId) where T: ProviderWorkOrderOutput;
    }
}