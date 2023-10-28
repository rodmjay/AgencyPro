using System;
using AgencyPro.Projects.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class ProjectNotification : Notification<ProjectNotification>
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public override void Configure(EntityTypeBuilder<ProjectNotification> builder)
        {
            builder.HasOne(x => x.Project)
                .WithMany(x => x.Notifications)
                .HasForeignKey(x => x.ProjectId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}