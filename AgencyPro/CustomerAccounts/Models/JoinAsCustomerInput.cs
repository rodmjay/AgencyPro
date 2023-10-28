using System;

namespace AgencyPro.CustomerAccounts.Models
{
    public class JoinAsCustomerInput
    {
        public Guid ProviderOrganizationId { get; set; }

        public string WorkOrderDescription { get; set; }
    }
}