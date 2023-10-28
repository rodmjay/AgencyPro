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
            throw new System.NotImplementedException();
        }
    }
}