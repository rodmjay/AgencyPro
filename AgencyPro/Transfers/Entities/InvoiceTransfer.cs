using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.Stripe.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Transfers.Entities
{
    public class InvoiceTransfer : BaseEntity<InvoiceTransfer>
    {
        public string TransferId { get; set; }
        public StripeTransfer Transfer { get; set; }

        public string InvoiceId { get; set; }
        public StripeInvoice Invoice { get; set; }

        public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
        public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }
        public override void Configure(EntityTypeBuilder<InvoiceTransfer> builder)
        {
            builder.HasKey(x => x.TransferId);
            builder.HasOne(x => x.Transfer)
                .WithOne(x => x.InvoiceTransfer)
                .HasForeignKey<InvoiceTransfer>(x => x.TransferId)
                .IsRequired();

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.InvoiceTransfers)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            builder.HasMany(x => x.IndividualPayoutIntents)
                .WithOne(x => x.InvoiceTransfer)
                .HasForeignKey(x => x.InvoiceTransferId)
                .IsRequired(false);

            builder.HasMany(x => x.OrganizationPayoutIntents)
                .WithOne(x => x.InvoiceTransfer)
                .HasForeignKey(x => x.InvoiceTransferId)
                .IsRequired(false);

            AddAuditProperties(builder);
        }
    }
}