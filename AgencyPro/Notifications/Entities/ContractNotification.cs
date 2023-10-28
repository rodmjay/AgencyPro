using System;
using AgencyPro.Contracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class ContractNotification : Notification
    {
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}