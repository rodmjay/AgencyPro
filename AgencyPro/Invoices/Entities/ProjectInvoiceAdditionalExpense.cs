#region Header

// /*
// Copyright (c) Solution Stream. All rights reserved.
// Author: Rod Johnson, Architect, Solution Stream
// */

#endregion

using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Invoices.Entities
{
    public class ProjectInvoiceAdditionalExpense : AuditableEntity<ProjectInvoiceAdditionalExpense>
    {
        public int Id { get; set; }

        public string InvoiceId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public ProjectInvoice ProjectInvoice { get; set; }
        public override void Configure(EntityTypeBuilder<ProjectInvoiceAdditionalExpense> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ProjectInvoice)
                .WithMany(x => x.AdditionalExpenses)
                .HasForeignKey(x => x.InvoiceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}