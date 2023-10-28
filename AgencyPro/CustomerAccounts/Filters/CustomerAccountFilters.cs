using System;

namespace AgencyPro.CustomerAccounts.Filters
{
    public class CustomerAccountFilters
    {
        public static readonly CustomerAccountFilters NoFilter = new CustomerAccountFilters();

        public Guid? CustomerId { get; set; }
        public Guid? CustomerOrganizationId { get; set; }
        public Guid? AccountManagerId { get; set; }
        public Guid? AccountManagerOrganizationId { get; set; }
        public int? Number { get; set; }
    }
}