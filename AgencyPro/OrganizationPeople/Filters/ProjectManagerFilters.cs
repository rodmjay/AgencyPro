using System;

namespace AgencyPro.OrganizationPeople.Filters
{
    public class ProjectManagerFilters
    {
        public static readonly ProjectManagerFilters NoFilter = new ProjectManagerFilters();
        public Guid? Acc { get; set; }
    }
}