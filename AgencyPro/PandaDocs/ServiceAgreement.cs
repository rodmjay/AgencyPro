using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PandaDocs
{
    public class ServiceAgreement : BaseEntity<ServiceAgreement>
    {
        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }

        public CustomerAccount CustomerAccount { get; set; }

        public string DocumentId { get; set; }
        public PandaDocument Document { get; set; }
        public override void Configure(EntityTypeBuilder<ServiceAgreement> builder)
        {
            builder.HasKey(x => x.DocumentId);
            builder.Property(x => x.DocumentId).IsRequired();

            builder.HasOne(x => x.CustomerAccount)
                .WithOne(x => x.ServiceAgreement)
                .HasForeignKey<ServiceAgreement>(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                });

            builder.HasOne(x => x.Document)
                .WithOne(x => x.ServiceAgreement)
                .HasForeignKey<ServiceAgreement>(x => x.DocumentId)
                .IsRequired();


            AddAuditProperties(builder);
        }
    }
    
}