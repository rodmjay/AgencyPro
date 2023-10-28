using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Enums;
using AgencyPro.Contracts.Models;
using AgencyPro.CustomerAccounts.Enums;
using AgencyPro.Invoices.Models;
using AgencyPro.Orders.Enums;
using AgencyPro.Orders.Models;
using AgencyPro.Projects.Enums;
using AgencyPro.Projects.Models;

namespace AgencyPro.CustomerAccounts.Models
{
    public class AccountManagerCustomerAccountDetailsOutput : AccountManagerCustomerAccountOutput
    {
        public ICollection<AccountManagerProjectOutput> Projects { get; set; }
        public ICollection<AccountManagerContractOutput> Contracts { get; set; }
        public ICollection<AccountManagerProjectInvoiceOutput> Invoices { get; set; }
        public ICollection<ProviderWorkOrderOutput> WorkOrders { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, AccountStatus> StatusTransitions { get; set; }
        public IDictionary<ProjectStatus, int> ProjectSummary { get; set; }
        public IDictionary<OrderStatus, int> WorkOrderSummary { get; set; }
        public IDictionary<string, int> InvoiceSummary { get; set; }
        public IDictionary<ContractStatus, int> ContractSummary { get; set; }

    }
}