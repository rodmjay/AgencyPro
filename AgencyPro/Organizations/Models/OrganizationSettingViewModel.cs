using AgencyPro.Organizations.Enums;

namespace AgencyPro.Organizations.Models
{
    public class OrganizationSettingViewModel
    {
        public SectionType SectionType { get; set; }
        public MenuType MenuType { get; set; }
        public bool IsEnabled { get; set; }
    }
}
