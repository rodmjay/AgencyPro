using System;
using AgencyPro.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class ContractNotification : Notification<ContractNotification>
    {
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
        public override void Configure(EntityTypeBuilder<ContractNotification> builder)
        {
            builder.HasOne(x => x.Contract)
                .WithMany(x => x.Notifications)
                .HasForeignKey(x => x.ContractId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}