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
            throw new NotImplementedException();
        }
    }
    
}