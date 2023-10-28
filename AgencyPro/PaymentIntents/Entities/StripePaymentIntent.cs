using System;
using System.Collections.Generic;
using AgencyPro.Charges.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.PaymentIntents.Interfaces;
using AgencyPro.Stripe.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PaymentIntents.Entities
{
    public class StripePaymentIntent : BaseEntity<StripePaymentIntent>, IStripePaymentIntent
    {
        public string Id { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountCapturable { get; set; }
        public decimal? AmountReceived { get; set; }
        public DateTime? CancelledAt { get; set; }
        public string CaptureMethod { get; set; }

        public ICollection<StripeCharge> Charges { get; set; }

        public string InvoiceId { get; set; }
        public StripeInvoice StripeInvoice { get; set; }

        public string ConfirmationMethod { get; set; }
        public string CustomerId { get; set; }
        public string TransferGroup { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<StripePaymentIntent> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasMany(x => x.Charges)
                .WithOne(x => x.PaymentIntent)
                .HasForeignKey(x => x.PaymentIntentId);

            builder.HasOne(x => x.StripeInvoice)
                .WithOne(x => x.PaymentIntent)
                .HasForeignKey<StripePaymentIntent>(x => x.InvoiceId);


            AddAuditProperties(builder);
        }
    }
}