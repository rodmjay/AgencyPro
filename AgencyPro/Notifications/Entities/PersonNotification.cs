using System;
using AgencyPro.People.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class PersonNotification : Notification
    {
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}