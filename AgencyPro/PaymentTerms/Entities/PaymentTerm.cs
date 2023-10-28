using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.CustomerAccounts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.PaymentTerms.Entities
{
    public class PaymentTerm : BaseEntity<PaymentTerm>
    {
        public string Name { get; set; }
        public int NetValue { get; set; }
        public int PaymentTermId { get; set; }

        public ICollection<CategoryPaymentTerm> CategoryPaymentTerms { get; set; }
        public ICollection<OrganizationPaymentTerm> OrganizationPaymentTerms { get; set; }

        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public override void Configure(EntityTypeBuilder<PaymentTerm> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}