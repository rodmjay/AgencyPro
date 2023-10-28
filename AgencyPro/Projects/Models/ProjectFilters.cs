using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Projects.Models
{
    public class ProjectFilters : CommonFilters
    {
        public static readonly ProjectFilters NoFilter = new ProjectFilters();

        public Guid? CustomerId { get; set; }
        public Guid? CustomerOrganizationId { get; set; }
        public Guid? AccountManagerId { get; set; }
        public Guid? AccountManagerOrganizationId { get; set; }
        public Guid? ProjectManagerId { get; set; }
        public Guid? ProjectManagerOrganizationId { get; set; }
    }
}