using System;

namespace AgencyPro.OrganizationPeople.Filters
{
    public class ContractorFilters
    {
        public static readonly ContractorFilters NoFilter = new ContractorFilters();
        public Guid? ProjectId { get; set; }
    }
}
