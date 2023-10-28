using System;

namespace AgencyPro.BillingCategories.Models
{
    public class BillingCategoryFilters
    {
        public Guid? StoryId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? ContractId { get; set; }
    }
}
