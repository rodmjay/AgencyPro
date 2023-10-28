using System;
using AgencyPro.Projects.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class ProjectNotification : Notification
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}