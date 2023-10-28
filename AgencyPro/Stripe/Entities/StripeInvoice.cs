using System;
using System.Collections.Generic;
using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Charges.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Invoices.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.PaymentIntents.Entities;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.Stripe.Interfaces;
using AgencyPro.Transfers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public sealed class StripeInvoice : BaseEntity<StripeInvoice>, IInvoice
    {
        public StripeInvoice()
        {
            this.Items = new List<StripeInvoiceItem>();
            this.Lines = new List<StripeInvoiceLine>();
            this.InvoiceTransfers = new List<InvoiceTransfer>();
            this.IndividualPayoutIntents = new List<IndividualPayoutIntent>();
            this.OrganizationPayoutIntents = new List<OrganizationPayoutIntent>();
        }



        public string Id { get; set; }
        public ProjectInvoice ProjectInvoice { get; set; }

        public string SubscriptionId { get; set; }
        public StripeSubscription SubscriptionInvoice { get; set; }

        public decimal AmountPaid { get; set; }
        public decimal AmountRemaining { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AttemptCount { get; set; }
        public bool Attempted { get; set; }
        public bool AutomaticCollection { get; set; }
        public string BillingReason { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public decimal EndingBalance { get; set; }
        public string HostedInvoiceUrl { get; set; }
        public string InvoicePdf { get; set; }
        public ICollection<StripeInvoiceItem> Items { get; set; }
        public bool IsDeleted { get; set; }

        public string StripePaymentIntentId { get; set; }
        public StripePaymentIntent PaymentIntent { get; set; }
       
        public string CustomerId { get; set; }
        public BuyerAccount BuyerAccount { get; set; }

        public ICollection<StripeInvoiceLine> Lines { get; set; }
        public ICollection<InvoiceTransfer> InvoiceTransfers { get; set; }
        public ICollection<StripeCharge> Charges { get; set; }
        public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
        public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }

        public string Status { get; set; }
        public string Number { get; set; }

        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public override void Configure(EntityTypeBuilder<StripeInvoice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.Total).HasColumnType("Money");
            builder.Property(x => x.Subtotal).HasColumnType("Money");
            builder.Property(x => x.AmountRemaining).HasColumnType("Money");
            builder.Property(x => x.AmountDue).HasColumnType("Money");
            builder.Property(x => x.AmountPaid).HasColumnType("Money");

            builder.HasOne(x => x.BuyerAccount)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.Items)
                .WithOne(x => x.Invoice)
                .HasForeignKey(x => x.InvoiceId);

            builder.HasOne(x => x.PaymentIntent)
                .WithOne(x => x.StripeInvoice)
                .HasForeignKey<StripePaymentIntent>(x => x.InvoiceId);

            builder.HasOne(x => x.ProjectInvoice)
                .WithOne(x => x.Invoice)
                .HasForeignKey<ProjectInvoice>(x => x.InvoiceId);

            builder.HasOne(x => x.SubscriptionInvoice)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.SubscriptionId);

            builder.HasMany(x => x.Lines)
                .WithOne(x => x.Invoice)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            builder.HasMany(x => x.Charges)
                .WithOne(x => x.Invoice)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            builder.HasMany(x => x.IndividualPayoutIntents)
                .WithOne(x => x.Invoice)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            builder.HasMany(x => x.OrganizationPayoutIntents)
                .WithOne(x => x.Invoice)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired();

            AddAuditProperties(builder);
        }
    }
}