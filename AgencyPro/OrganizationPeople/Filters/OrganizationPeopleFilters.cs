using AgencyPro.Common.Models;

namespace AgencyPro.OrganizationPeople.Filters
{
    public class OrganizationPeopleFilters : CommonFilters
    {
        public static readonly OrganizationPeopleFilters NoFilter = new OrganizationPeopleFilters();

        public bool? ProjectManagers { get; set; }
        public bool? AccountManagers { get; set; }
        public bool? Marketers { get; set; }
        public bool? Recruiters { get; set; }
        public bool? Contractors { get; set; }
        public bool? Customers { get; set; }
    }
}