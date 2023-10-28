using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.CustomerAccounts.Entities
{
    public class CustomerAccountStatusTransition : BaseEntity<CustomerAccountStatusTransition>
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public AccountStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public override void Configure(EntityTypeBuilder<CustomerAccountStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
    }
}
