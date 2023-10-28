using System;
using AgencyPro.Cards.Interfaces;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Cards.Entities
{
    public class StripeCard : BaseEntity<StripeCard>, IStripeCard
    {
        public string Id { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
      
        public string Brand { get; set; }
        public string Country { get; set; }
        public string CvcCheck { get; set; }
        public string DynamicLast4 { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Fingerprint { get; set; }
        public string Funding { get; set; }
        public string Last4 { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public bool IsDeleted { get; set; }
       
        public CustomerCard CustomerCard { get; set; }
        public AccountCard AccountCard { get; set; }
        public override void Configure(EntityTypeBuilder<StripeCard> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.AccountCard)
                .WithOne(x => x.StripeCard)
                .HasForeignKey<AccountCard>(x => x.Id);

            builder.HasOne(x => x.CustomerCard)
                .WithOne(x => x.StripeCard)
                .HasForeignKey<CustomerCard>(x => x.Id);

            AddAuditProperties(builder);
        }
    }
}