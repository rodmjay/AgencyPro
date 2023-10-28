using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Notifications.Entities;
using AgencyPro.Orders.Enums;
using AgencyPro.Orders.Interfaces;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.ProviderOrganizations.Entities;
using AgencyPro.Roles.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Orders.Entities
{
    public class WorkOrder : BaseEntity<WorkOrder>, IWorkOrder
    {
        public ICollection<ProposalWorkOrder> Proposals { get; set; }
        public ICollection<WorkOrderNotification> WorkOrderNotifications { get; set; }
        public CustomerAccount CustomerAccount { get; set; }

        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }

        public AccountManager AccountManager { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }

        public ProviderOrganization ProviderOrganization { get; set; }
        public Organization BuyerOrganization { get; set; }

        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }

        public Customer Customer { get; set; }

        public Guid Id { get; set; }

        public int BuyerNumber { get; set; }
        public int ProviderNumber { get; set; }

        public string Description { get; set; }

        public DateTimeOffset? ProviderResponseTime { get; set; }
        
        public OrderStatus Status { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<WorkOrder> builder)
        {
            throw new NotImplementedException();
        }
    }
}