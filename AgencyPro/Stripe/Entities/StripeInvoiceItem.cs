using System;
using System.Collections.Generic;
using AgencyPro.BuyerAccounts.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.PayoutIntents.Entities;
using AgencyPro.Stripe.Interfaces;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stripe.Entities
{
    public class StripeInvoiceItem : AuditableEntity<StripeInvoiceItem>, IStripeInvoiceItem
    {
        public StripeInvoiceItem()
        {

            this.TimeEntries = new List<TimeEntry>();
            this.InvoiceLines = new List<StripeInvoiceLine>();
            this.IndividualPayoutIntents = new List<IndividualPayoutIntent>();
            this.OrganizationPayoutIntents = new List<OrganizationPayoutIntent>();
        }

        public string Id { get; set; }
        public decimal Amount { get; set; }

        public string CustomerId { get; set; }
        public BuyerAccount Customer { get; set; }

        public string Description { get; set; }

        public string InvoiceId { get; set; }
        public StripeInvoice Invoice { get; set; }
        
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<StripeInvoiceLine> InvoiceLines { get; set; }
        public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }
        public ICollection<OrganizationPayoutIntent> OrganizationPayoutIntents { get; set; }


        public Guid? ContractId { get; set; }
        public Contract Contract { get; set; }
        public override void Configure(EntityTypeBuilder<StripeInvoiceItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.InvoiceItems)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.InvoiceId);

            builder.HasMany(x => x.TimeEntries)
                .WithOne(x => x.InvoiceItem)
                .HasForeignKey(x => x.InvoiceItemId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.Contract)
                .WithMany(x => x.InvoiceItems)
                .HasForeignKey(x => x.ContractId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.IndividualPayoutIntents)
                .WithOne(x => x.InvoiceItem)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired();

            builder.HasMany(x => x.OrganizationPayoutIntents)
                .WithOne(x => x.InvoiceItem)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired();

            builder.HasMany(x => x.InvoiceLines)
                .WithOne(x => x.InvoiceItem)
                .HasForeignKey(x => x.InvoiceItemId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            AddAuditProperties(builder);
        }
    }
}