using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Enums;
using AgencyPro.Contracts.Models;
using AgencyPro.CustomerAccounts.Enums;
using AgencyPro.Invoices.Models;
using AgencyPro.Orders.Enums;
using AgencyPro.Orders.Models;
using AgencyPro.PaymentTerms.Models;
using AgencyPro.Projects.Enums;
using AgencyPro.Projects.Models;

namespace AgencyPro.CustomerAccounts.Models
{
    public class AgencyOwnerCustomerAccountDetailsOutput : AgencyOwnerCustomerAccountOutput
    {
        public ICollection<AgencyOwnerProjectOutput> Projects { get; set; }
        public ICollection<AgencyOwnerProviderContractOutput> Contracts { get; set; }
        public ICollection<AgencyOwnerProjectInvoiceOutput> Invoices { get; set; }
        public ICollection<ProviderWorkOrderOutput> WorkOrders { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, AccountStatus> StatusTransitions { get; set; }
        public ICollection<PaymentTermOutput> AvailablePaymentTerms { get; set; }
        public IDictionary<ProjectStatus, int> ProjectSummary { get; set; }
        public IDictionary<OrderStatus, int> WorkOrderSummary { get; set; }
        public IDictionary<string,int> InvoiceSummary { get; set; }
        public IDictionary<ContractStatus, int> ContractSummary { get; set; }
    }
}