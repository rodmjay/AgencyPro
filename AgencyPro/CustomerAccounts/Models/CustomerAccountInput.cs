using System;

namespace AgencyPro.CustomerAccounts.Models
{
    public class CustomerAccountInput
    {
        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid AccountManagerOrganizationId { get; set; }

        public virtual Guid CustomerId { get; set; }
        public virtual Guid CustomerOrganizationId { get; set; }

        public bool AutoApproveTimeEntries { get; set; }

        public int? PaymentTermId { get; set; }
        
    }
}