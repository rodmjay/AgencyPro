﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Invoices.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.Orders.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.People.Entities;
using AgencyPro.Retainers.Entities;
using AgencyPro.Roles.Interfaces;
using AgencyPro.TimeEntries.Entities;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Roles.Models
{
    public class AccountManager : AuditableEntity<AccountManager>, IAccountManager
    {
        [ForeignKey("Id")] public Person Person { get; set; }

        public ICollection<OrganizationAccountManager> OrganizationAccountManagers { get; set; }
        public ICollection<WorkOrder> WorkOrders { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public ICollection<Lead> Leads { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<ProjectInvoice> Invoices { get; set; }
        public Guid Id { get; set; }
      
        public ICollection<ProjectRetainerIntent> RetainerIntents { get; set; }
        public override void Configure(EntityTypeBuilder<AccountManager> builder)
        {
            throw new NotImplementedException();
        }
    }
}