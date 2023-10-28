using System;
using System.Collections.Generic;
using AgencyPro.Charges.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Retainers.Entities
{
    public class ProjectRetainerIntent : BaseEntity<ProjectRetainerIntent>
    {
        public CustomerAccount CustomerAccount { get; set; }
        public AccountManager AccountManager { get; set; }
        public Guid AccountManagerId { get; set; }
        public Organization ProviderOrganization { get; set; }
        public Guid ProviderOrganizationId { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public OrganizationCustomer OrganizationCustomer { get; set; }
        public Organization CustomerOrganization { get; set; }
        public Customer Customer { get; set; }
        public OrganizationAccountManager OrganizationAccountManager { get; set; }
        public ICollection<StripeCharge> Credits { get; set; }
        public decimal TopOffAmount { get; set; }
        public decimal CurrentBalance { get; set; }
        public override void Configure(EntityTypeBuilder<ProjectRetainerIntent> builder)
        {
            throw new NotImplementedException();
        }
    }
}
