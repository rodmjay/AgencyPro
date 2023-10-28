using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class SystemNotification : Notification<SystemNotification>
    {
        public override void Configure(EntityTypeBuilder<SystemNotification> builder)
        {
            
        }
    }
}