using System;
using AgencyPro.Common.Models;
using AgencyPro.Stories.Enums;

namespace AgencyPro.Stories.Models
{
    public class StoryFilters : CommonFilters
    {
        public static readonly StoryFilters NoFilter = new StoryFilters();

        public Guid? ProjectId { get; set; }



        public StoryFilters()
        {
            StoryStatus = new StoryStatus[] { };
        }

        public StoryStatus[] StoryStatus { get; set; }
        public Guid? AccountManagerId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? ContractorId { get; set; }
        public Guid? ContractorOrganizationId { get; set; }
        public Guid? CustomerOrganizationId { get; set; }
        public Guid? AccountManagerOrganizationId { get; set; }
    }
}