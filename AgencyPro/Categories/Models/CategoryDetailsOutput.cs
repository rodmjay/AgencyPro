using System.Collections.Generic;
using AgencyPro.Organizations.Models;

namespace AgencyPro.Categories.Models
{
    public class CategoryDetailsOutput : CategoryOutput
    {
        public List<OrganizationOutput> Organizations { get; set; }
    }
}