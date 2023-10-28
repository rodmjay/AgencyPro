using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.FinancialAccounts.Entities;
using AgencyPro.Transfers.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Transfers.Entities
{
    public class StripeTransfer : BaseEntity<StripeTransfer>, IStripeTransfer
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountReversed { get; set; }
        public string Description { get; set; }

        public string DestinationId { get; set; }
        public FinancialAccount DestinationAccount { get; set; }

        public string DestinationPaymentId { get; set; }
        public bool IsDeleted { get; set; }
        public InvoiceTransfer InvoiceTransfer { get; set; }
        public BonusTransfer BonusTransfer { get; set; }
        public DateTimeOffset Created { get; set; }

        public override void Configure(EntityTypeBuilder<StripeTransfer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.DestinationAccount)
                .WithMany(x => x.Transfers)
                .HasForeignKey(x => x.DestinationId);


            AddAuditProperties(builder);
        }
    }
}