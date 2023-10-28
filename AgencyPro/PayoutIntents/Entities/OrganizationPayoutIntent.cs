using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using AgencyPro.PayoutIntents.Enums;
using AgencyPro.PayoutIntents.Interfaces;
using AgencyPro.Stripe.Entities;
using AgencyPro.Transfers.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PayoutIntents.Entities
{
    public class OrganizationPayoutIntent : AuditableEntity<OrganizationPayoutIntent>, IOrganizationPayoutIntent
    {
        public Guid Id { get; set; }

        public Organization Organization { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid AgencyOwnerId { get; set; }

        //public OrganizationCustomer AgencyOwner { get; set; }

        public string InvoiceItemId { get; set; }
        public StripeInvoiceItem InvoiceItem { get; set; }

        public decimal Amount { get; set; }
        public CommissionType Type { get; set; }

        public string Description { get; set; }


        public string InvoiceId { get; set; }
        public StripeInvoice Invoice { get; set; }


        public InvoiceTransfer InvoiceTransfer { get; set; }
        public string InvoiceTransferId { get; set; }
       


        public override void Configure(EntityTypeBuilder<OrganizationPayoutIntent> builder)
        {
            throw new NotImplementedException();
        }
    }
}