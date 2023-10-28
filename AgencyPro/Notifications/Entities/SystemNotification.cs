using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class SystemNotification : Notification
    {
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}