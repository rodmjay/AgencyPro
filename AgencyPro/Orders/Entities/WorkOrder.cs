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
using AgencyPro.Roles.Entities;
using Microsoft.EntityFrameworkCore;
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
            builder.HasKey(x => x.Id);

            builder.HasIndex("AccountManagerOrganizationId", "ProviderNumber")
                .HasDatabaseName("ProviderNumberIndex").IsUnique();

            builder.HasIndex("CustomerOrganizationId", "BuyerNumber")
                .HasDatabaseName("BuyerNumberIndex").IsUnique();

            builder.HasOne(x => x.AccountManager)
                .WithMany(x => x.WorkOrders)
                .HasForeignKey(x => x.AccountManagerId)
                .IsRequired(true);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.WorkOrders)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired(true);

            builder.HasOne(x => x.CustomerAccount)
                .WithMany(x => x.WorkOrders)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                }).IsRequired();

            builder.HasOne(x => x.OrganizationAccountManager)
                .WithMany(x => x.WorkOrders)
                .HasForeignKey(x => new
                {
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                });

            builder.HasOne(x => x.ProviderOrganization)
                .WithMany(x => x.WorkOrders)
                .HasForeignKey(x => x.AccountManagerOrganizationId);

            builder.HasQueryFilter(x => x.IsDeleted == false);

            AddAuditProperties(builder);
        }
    }
}