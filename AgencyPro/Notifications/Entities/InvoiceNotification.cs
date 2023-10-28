using System;
using AgencyPro.Invoices.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Notifications.Entities
{
    public class InvoiceNotification : Notification
    {
        public string InvoiceId { get; set; }
        public Guid ProjectId { get; set; }

        public ProjectInvoice Invoice { get; set; }
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            throw new NotImplementedException();
        }
    }
}