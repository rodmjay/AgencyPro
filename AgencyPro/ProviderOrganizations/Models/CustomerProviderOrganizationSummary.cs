using System.Collections.Generic;
using AgencyPro.Categories.Models;
using AgencyPro.Skills.Models;

namespace AgencyPro.ProviderOrganizations.Models
{
    public class CustomerProviderOrganizationSummary
    {
        public ICollection<CustomerProviderOrganizationOutput> Organizations { get; set; }

        public ICollection<SkillOutput> AvailableSkills { get; set; }
        public ICollection<CategoryOutput> AvailableCategories { get; set; }
    }
}