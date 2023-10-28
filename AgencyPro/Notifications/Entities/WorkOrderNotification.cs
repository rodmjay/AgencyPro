using System;
using AgencyPro.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class WorkOrderNotification : Notification<WorkOrderNotification>
    {
        public Guid WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public override void Configure(EntityTypeBuilder<WorkOrderNotification> builder)
        {
            builder.HasOne(x => x.WorkOrder)
                .WithMany(x => x.WorkOrderNotifications)
                .HasForeignKey(x => x.WorkOrderId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}