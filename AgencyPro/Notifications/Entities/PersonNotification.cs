using System;
using AgencyPro.People.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class PersonNotification : Notification<PersonNotification>
    {
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public override void Configure(EntityTypeBuilder<PersonNotification> builder)
        {
            builder.HasOne(x => x.Person)
                .WithMany(x => x.PersonNotifications)
                .HasForeignKey(x => x.PersonId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}