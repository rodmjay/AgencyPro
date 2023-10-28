using System;

namespace AgencyPro.Contracts.Models
{

    public class ProposedContractOutput
    {
        public virtual Guid Id { get; set; }
        public virtual decimal CustomerRate { get; set; }
        public virtual decimal MaxCustomerWeekly { get; set; }
        public virtual string ContractorName { get; set; }
        public virtual string ContractorOrganizationName { get; set; }
        public virtual string ContractorImageUrl { get; set; }
        public virtual string ContractorOrganizationImageUrl { get; set; }
    }
}