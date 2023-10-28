using System;
using AgencyPro.Orders.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class WorkOrderNotification : Notification
    {
        public Guid WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}