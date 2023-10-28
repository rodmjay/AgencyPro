using System;

namespace AgencyPro.OrganizationPeople.Filters
{
    public class AccountManagerFilters
    {
        public static readonly AccountManagerFilters NoFilter = new AccountManagerFilters();
        public Guid? CustomerId { get; set; }
    }
}