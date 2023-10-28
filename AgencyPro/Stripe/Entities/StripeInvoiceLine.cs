using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Stripe.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public class StripeInvoiceLine : AuditableEntity<StripeInvoiceLine>, IStripeInvoiceLine
    {
        public string Id { get; set; }
        public string InvoiceId { get; set; }
        public StripeInvoice Invoice { get; set; }
        public string Description { get; set; }
        public bool Discountable { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string InvoiceItemId { get; set; }

        public StripeInvoiceItem InvoiceItem { get; set; }

        public string SubscriptionId { get; set; }
        public string Type { get; set; }

        public override void Configure(EntityTypeBuilder<StripeInvoiceLine> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.Lines)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            builder.HasOne(x => x.InvoiceItem)
                .WithMany(x => x.InvoiceLines)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired(false);

            AddAuditProperties(builder);
        }
    }
}