using System;
using AgencyPro.Stories.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class StoryNotification : Notification
    {
        public Guid StoryId { get; set; }
        public Story Story { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}