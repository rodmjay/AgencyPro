using System.Collections.Generic;
using System.Collections.ObjectModel;
using AgencyPro.BuyerAccounts.Interfaces;
using AgencyPro.Cards.Entities;
using AgencyPro.Charges.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Stripe.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BuyerAccounts.Entities
{
    public class BuyerAccount : AuditableEntity<BuyerAccount>, IBuyerAccount
    {
        private ICollection<StripeInvoiceItem> _items;

        public decimal Balance { get; set; }
        public bool Delinquent { get; set; }

        public string Id { get; set; }
       

        public virtual OrganizationBuyerAccount OrganizationBuyerAccount { get; set; }
        public virtual IndividualBuyerAccount IndividualBuyerAccount { get; set; }
        
        public virtual ICollection<StripeInvoiceItem> InvoiceItems
        {
            get => _items ??= new Collection<StripeInvoiceItem>();
            set => _items = value;
        }



        private ICollection<StripeSource> _sources;

        public virtual ICollection<StripeSource> PaymentSources
        {
            get => _sources ??= new Collection<StripeSource>();
            set => _sources = value;
        }



        private ICollection<StripeInvoice> _invoices;

        public virtual ICollection<StripeInvoice> Invoices
        {
            get => _invoices ??= new Collection<StripeInvoice>();
            set => _invoices = value;
        }
        
        private ICollection<StripeCharge> _charges;

        public virtual ICollection<StripeCharge> Charges
        {
            get => _charges ??= new Collection<StripeCharge>();
            set => _charges = value;
        }

        public ICollection<StripeCheckoutSession> CheckoutSessions { get; set; }
       

        private ICollection<CustomerCard> _cards;

        public virtual ICollection<CustomerCard> Cards
        {
            get => _cards ??= new Collection<CustomerCard>();
            set => _cards = value;
        }

        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<BuyerAccount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasQueryFilter(x => x.IsDeleted == false);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Balance).HasColumnType("Money");

            builder.HasOne(x => x.IndividualBuyerAccount)
                .WithOne(x => x.BuyerAccount)
                .HasForeignKey<IndividualBuyerAccount>(x => x.BuyerAccountId);

            builder.HasOne(x => x.OrganizationBuyerAccount)
                .WithOne(x => x.BuyerAccount)
                .HasForeignKey<OrganizationBuyerAccount>(x => x.BuyerAccountId);

            builder.HasMany(x => x.Invoices)
                .WithOne(x => x.BuyerAccount)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.PaymentSources)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.InvoiceItems)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.CheckoutSessions)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.Charges)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.Cards)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            AddAuditProperties(builder);
        }
    }
}