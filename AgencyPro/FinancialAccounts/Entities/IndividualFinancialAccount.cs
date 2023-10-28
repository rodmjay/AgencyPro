using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.People.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.FinancialAccounts.Entities
{
    public class IndividualFinancialAccount : BaseEntity<IndividualFinancialAccount>
    {
        public Guid Id { get; set; }

        public string FinancialAccountId { get; set; }
       
        public FinancialAccount FinancialAccount { get; set; }
        
        public Person Person { get; set; }
        public override void Configure(EntityTypeBuilder<IndividualFinancialAccount> builder)
        {
            throw new NotImplementedException();
        }
    }
}