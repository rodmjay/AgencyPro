using System;
using AgencyPro.Stories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class StoryNotification : Notification<StoryNotification>
    {
        public Guid StoryId { get; set; }
        public Story Story { get; set; }
        public override void Configure(EntityTypeBuilder<StoryNotification> builder)
        {
            builder.HasOne(x => x.Story)
                .WithMany(x => x.Notifications)
                .HasForeignKey(x => x.StoryId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}